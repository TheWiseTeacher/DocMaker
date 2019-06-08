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

        public enum Filter
        {
            DigitsOnly,
            LettersOnly,
            LettersAndDigits,
            Special,
        }

        private bool IsValidKeyChar(char c)
        {
            if (c == (char)Keys.Delete || c == (char)Keys.Back)
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

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!IsValidKeyChar(e.KeyChar))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }

            base.OnKeyPress(e);
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



    }
}
