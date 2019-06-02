using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public partial class StringEditor : Form
    {
        public StringEditor(string title = "")
        {
            InitializeComponent();

            if (title != String.Empty)
                this.Text = title;

        }

        private void info_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

        }

        private void info_Load(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;

        }
    }
}
