using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DocMaker
{
    public class CustomTextBox : TextBox
    {
        [Browsable(true)]
        [Category("Input Filter")]
        public bool AllowSpace { get; set; } = true;

        [Browsable(true)]
        [Category("Input Filter")]
        public Filter UsedFilter { get; set; } = Filter.LettersAndDigits;

        /*
        [Browsable(true)]
        [Category("Value and bounds")]    
        public int Value { get; set; } = 1;
        */
        private float Value { get; set; }

        [Browsable(true)]
        [Category("Value and bounds")]    
        public bool IgnoreClampig { get; set; } = false;
        
        [Browsable(true)]
        [Category("Value and bounds")]    
        public bool AllowDecimal { get; set; } = false;
        
        [Browsable(true)]
        [Category("Value and bounds")]    
        public int MinimumValue { get; set; } = 1;

        [Browsable(true)]
        [Category("Value and bounds")]
        public int MaximumValue { get; set; } = 10000;

        [Browsable(true)]
        [Category("Value and bounds")]
        public int Wheel_StepValue { get; set; } = 5;

        public enum Filter
        {
            DigitsOnly,
            DigitList,
            LettersOnly,
            LettersAndDigits,
            Special,
        }

        private Keys keyCapture;

        private bool IsValidKeyChar(char c)
        {
            /*
            if (keyCapture == Keys.Delete || keyCapture == Keys.Back ||
                keyCapture == Keys.Enter  || keyCapture == Keys.Tab)
                return true;

            if (keyCapture == Keys.Space)
                return AllowSpace ? true : false;
            */

            switch (UsedFilter)
            {
                case Filter.DigitsOnly:
                    return ((c >= 48 && c <= 57) || c == '-' || (c == '.' && AllowDecimal));

                case Filter.DigitList:
                    return ((c >= 48 && c <= 57) || c == ' ' || (c == '.' && AllowDecimal));

                case Filter.LettersOnly:
                    return ((c >= 65 && c <= 90) || (c >= 97 && c <= 122));

                case Filter.LettersAndDigits:
                    return ((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || (c >= 48 && c <= 57));

                case Filter.Special:
                    return ((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || (c >= 48 && c <= 57)) ||
                               c == '_' || c == '$' || c == '#';
            }

            return false;
        }
 
        private void ParseValue()
        {
            float buffer;

            if (Text.Equals("-"))
            {
                Value = 0;
                return;
            }

            try {buffer = (float)Convert.ToDouble(this.Text);}
            catch (Exception){
                this.Text = previousRightText;
                return;
            }

            Value = buffer;
        }

        /*
        protected override void OnKeyDown(KeyEventArgs e)
        {
            keyCapture = e.KeyCode;
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!IsValidKeyChar(e.KeyChar))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
        */

        private string lastSafeText;

        protected override void OnTextChanged(EventArgs e)
        {
            /*
            if (UsedFilter == Filter.DigitsOnly)
            {
                ParseValue();

                if(!IgnoreClampig)
                {
                    if (Value < MinimumValue)
                    {
                        Value = MinimumValue;
                        System.Media.SystemSounds.Beep.Play();

                        this.Text = Value.ToString();
                        this.Select(this.Text.Length, 0);
                    }

                    if (Value > MaximumValue)
                    {
                        Value = MaximumValue;
                        System.Media.SystemSounds.Beep.Play();

                        this.Text = Value.ToString();
                        this.Select(this.Text.Length, 0);
                    }
                }
            }
            */

            foreach(char c in Text)
            {           
                if(!IsValidKeyChar(c))
                {
                    Text = lastSafeText;
                    System.Media.SystemSounds.Beep.Play();
                    break;
                }
            }

            lastSafeText = Text;
            base.OnTextChanged(e);
        }

        private string previousRightText;

        protected override void OnValidated(EventArgs e)
        {
            /*
            string validString = "";
            keyCapture = Keys.None;

            foreach (char c in this.Text)
            {
                if (IsValidKeyChar(c))
                    validString += c;
            }

            if (!this.Text.Equals(validString))
            {
                System.Media.SystemSounds.Beep.Play();
                this.Text = previousRightText;
            }
            

            previousRightText = this.Text;
            */
            base.OnValidated(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (UsedFilter == Filter.DigitsOnly)
            {
                int newValue = Funcs.ToInt(this.Text) + (Wheel_StepValue * Funcs.Force(Funcs.ToInt(e.Delta)));

                if(!IgnoreClampig)
                    this.Text = Funcs.Clamp(newValue, MinimumValue, MaximumValue).ToString();

                this.Select(this.Text.Length, 0);
            }

            base.OnMouseWheel(e);
        }

        public int IntValue()
        {
            return (int)Value;
        }

        public float FloatValue()
        {
            return Value;
        }


        /*
        protected override void OnMouseHover(EventArgs e)
        {
            this.Focus();
            this.Select(0, 0);

            base.OnMouseHover(e);
        }
        */
    }
}
