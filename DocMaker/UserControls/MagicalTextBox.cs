using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DocMaker
{
    public class MagicalTextBox : TextBox
    {
        public enum Filter
        {
            Digits,
            DigitList,

            LettersOnly,
            LettersAndDigits,

            Special,
        }

        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public Filter UsedFilter { get; set; } = Filter.LettersAndDigits;

        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public bool AllowNegative { get; set; } = false;

        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public bool AllowDecimal { get; set; } = false;

        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public bool AllowSpaces { get; set; } = true;

        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public bool IgnoreClamping { get; set; } = true;

        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public float Minimum { get; set; } = float.MinValue;

        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public float Maximum { get; set; } = float.MaxValue;
        
        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public bool AllowWheel { get; set; } = true;
        
        [Browsable(true)]
        [Category("Magical TextBox Parameters")]
        public float WheelStepValue { get; set; } = 1.0f;

        private KeyEventArgs keyCapture;
        private string lastGoodText;
        private bool ignoreNextCheck = false;

        private bool IsValidCharacter(char c, int position, string exText = null, string exSelectedText = "")
        {
            Keys kc = keyCapture.KeyCode;

            if (kc == Keys.Delete || kc == Keys.Back || kc == Keys.Enter || kc == Keys.Tab)
                return true;

            if(keyCapture.Control)
                return true;

            if (exText == null)
            {
                exText = Text;
                exSelectedText = SelectedText;
            }

            switch (UsedFilter)
            {
                case Filter.Digits:
                    return (char.IsDigit(c) || (c == '-' && position == 0 && AllowNegative) ||
                           (c == '.' && AllowDecimal && position != 0 && (!exText.Contains(".") || exSelectedText.Contains("."))));

                case Filter.DigitList:

                    // SP : Sub-string starting point
                    int sp = exText.LastIndexOf(' ', position == 0 ? 0 : position - 1) + 1;
                    if (sp == -1) sp = 0;

                    // SL : Sub-string length
                    int cl = exText.IndexOf(' ', sp);
                    if (cl == -1) cl = exText.Length;
                    cl -= sp;

                    return (char.IsDigit(c) || c == ' ' || (c == '-' && (position-sp) == 0 && AllowNegative) ||
                           (c == '.' && AllowDecimal && (position - sp) != 0 && (!exText.Substring(sp, cl).Contains(".") || exSelectedText.Contains(".")) ));

                case Filter.LettersOnly:
                    return (char.IsLetter(c) || (c == ' ' && AllowSpaces));

                case Filter.LettersAndDigits:
                    return (char.IsLetterOrDigit(c) || (c == ' ' && AllowSpaces));

                case Filter.Special:
                    break;

                default:
                    break;
            }


            return false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            keyCapture = e;
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if(!IsValidCharacter(e.KeyChar, SelectionStart))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;             
            }

            base.OnKeyPress(e);
        }

        private void SetCursorTo(int position)
        {
            SelectionStart = position < Text.Length ? position : Text.Length;
        }

        private void IgnoreChanges(string text = null)
        {
            System.Media.SystemSounds.Beep.Play();

            ignoreNextCheck = true;
            int cursorPosition = SelectionStart;

            Text = text == null? lastGoodText : text;
            SetCursorTo(cursorPosition);
        }

        private float ParseFloatValue(string text)
        {
            try { return Convert.ToSingle(text); }
            catch (Exception) { return 0; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if(ignoreNextCheck)
            {
                ignoreNextCheck = false;
                return;
            }

            // After we validated or the key press the text will be changed,
            // so we need to recheck it in case their is some misbehavior

            keyCapture = new KeyEventArgs(Keys.None);
            string checkedString = string.Empty;
            
            for (int i = 0; i < Text.Length; i++)
            {
                if (IsValidCharacter(Text[i], i, checkedString))
                    checkedString += Text[i];
                else
                {
                    IgnoreChanges();
                    return;
                }
            }

            // Text is good but let's check if it is clamped

            if(!IgnoreClamping)
            {
                if(UsedFilter == Filter.Digits)
                {
                    float f = ParseFloatValue(Text);

                    if (f < Minimum)
                        IgnoreChanges(Minimum.ToString());

                    if (f > Maximum)
                        IgnoreChanges(Maximum.ToString());
                }
                else if(UsedFilter == Filter.DigitList)
                {
                    string[] fl = Text.Split(' ');
                    bool badInput = false;

                    for (int i = 0; i < fl.Length; i++)
                    {
                        if (fl[i] == string.Empty)
                        {
                            // Return and ignore everything if a string is empty since it will value 0 
                            // and it will be corrected by minimum if it's bigger than 0 Sooo...
                            //
                            return;
                        }

                        float f = ParseFloatValue(fl[i]);

                        if (f < Minimum)
                        {
                            fl[i] = Minimum.ToString();
                            badInput = true;
                        }

                        if (f > Maximum)
                        {
                            fl[i] = Maximum.ToString();
                            badInput = true;
                        }
                    }

                    if(badInput)
                        IgnoreChanges(string.Join(" ", fl));
                }
            }

            // If text is good remember it :D
            lastGoodText = Text;
            base.OnTextChanged(e);

            OnSafeTextChange?.Invoke(this, lastGoodText);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (AllowWheel && UsedFilter == Filter.Digits)
            {
                float newValue = ParseFloatValue(lastGoodText) + (WheelStepValue * Funcs.Force(Funcs.ToInt(e.Delta)));

                if (!IgnoreClamping)
                    this.Text = (newValue < Minimum ? Minimum : (newValue > Maximum ? Maximum : newValue)).ToString();

                this.Select(this.Text.Length, 0);
            }

            base.OnMouseWheel(e);
        }

        public float GetFloatValue()
        {
            return ParseFloatValue(lastGoodText);
        }
        
        public float[] GetFloatList()
        {
            return Array.ConvertAll(lastGoodText.Split(' '), s => ParseFloatValue(s));
        }

        public int GetIntValue()
        {
            return (int)ParseFloatValue(lastGoodText);
        }

        public int[] GetIntList()
        {
            return Array.ConvertAll(lastGoodText.Split(' '), s => (int)ParseFloatValue(s));
        }

        public delegate void SafeTextChange(object sender, string safeValue);
        public event SafeTextChange OnSafeTextChange;
    }
}
