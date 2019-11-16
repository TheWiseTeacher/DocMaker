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
    public partial class LanguageManager : Form
    {
        private void LoadLanguages()
        {
            languagesTable.Rows.Clear();
            for (int i = 0; i < Languages.UsedLanguages.Count; i++)
            {
                languagesTable.Rows.Add(i, Languages.UsedLanguages[i]);
            }
        }


        public LanguageManager()
        {
            InitializeComponent();
            LoadLanguages();
        }

        private void LanguageManager_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_add_lang_Click(object sender, EventArgs e)
        {
            StringEditor stringEditor = new StringEditor("Insert a language code :");

            if(stringEditor.ShowDialog() == DialogResult.OK)
            {
                foreach(string l in Languages.UsedLanguages)
                {
                    if(l == stringEditor.textBox.Text)
                    {
                        Funcs.Information("You can't add a language twice!");
                        return;
                    }
                }
            }

            Languages.UsedLanguages.Add(stringEditor.textBox.Text);
            Objects.AddLanguage(stringEditor.textBox.Text);
            LoadLanguages();
        }

        private void Btn_remove_lang_Click(object sender, EventArgs e)
        {
            if (languagesTable.SelectedCells.Count > 0)
            {
                int langID = Funcs.ToInt(languagesTable[grid_id.Index, languagesTable.SelectedCells[0].RowIndex].Value);

                if (langID == 0)
                {
                    Funcs.Information("You can't delete the default entry, it is the default text value used when no languages are avaible.");
                    return;
                }

                if (Funcs.Question("Are you sure you want to delete this language code ?\nNote that all label objects will lose this language code text value !  ") == DialogResult.Yes)
                {
                    Objects.RemoveLanguage(Languages.UsedLanguages[langID]);
                    Languages.UsedLanguages.Remove(Languages.UsedLanguages[langID]);
                    LoadLanguages();
                }
            }
        }
    }
}
