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

        [Browsable(true)]
        [Category("Value and bounds")]    
        public int Value { get; set; } = 1;

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
            LettersOnly,
            LettersAndDigits,
            Special,
        }

        private bool IsValidKeyChar(char c)
        {
            if (c == (char)Keys.Delete || c == (char)Keys.Back ||
                c == (char)Keys.Enter  || c == (char)Keys.Tab)
                return true;

            if (c == (char)Keys.Space)
                return AllowSpace ? true : false;

            switch (UsedFilter)
            {
                case Filter.DigitsOnly:
                    return (c >= 48 && c <= 57);

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

        private int GetIntValue()
        {
            try {return Convert.ToInt32(this.Text);}
            catch (Exception){return 0;}
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

        protected override void OnTextChanged(EventArgs e)
        {
            if (UsedFilter == Filter.DigitsOnly)
            {
                Value = GetIntValue();

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

            base.OnTextChanged(e);
        }


        protected override void OnValidated(EventArgs e)
        {
            string validString = "";

            foreach (char c in this.Text)
            {
                if (IsValidKeyChar(c))
                    validString += c;
            }
            if (!this.Text.Equals(validString))
            {
                System.Media.SystemSounds.Beep.Play();
                this.Text = validString;
            }

            base.OnValidated(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (UsedFilter == Filter.DigitsOnly)
            {
                this.Text = Funcs.Clamp(Funcs.ToInt(this.Text) + (Wheel_StepValue * Funcs.Force(Funcs.ToInt(e.Delta))),
                                        MinimumValue, MaximumValue).ToString();

                this.Select(this.Text.Length, 0);
            }

            base.OnMouseWheel(e);
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
