using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art2MSpell.Source
{
    using Classes;

    public partial class dlgInput : Form
    {
        private string fileName = string.Empty;

        public dlgInput()
        {
            InitializeComponent();
        }

        private void OnButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void OnButtonCancel_Click(object sender, EventArgs e)
        {

        }

        public DialogResult GetFileName(string caption, string prompt, ref string value)
        {
            SpellingPropertiesClass.UserSpellListName = string.Empty;
            this.Text = caption;
            this.lblPrompt.Text = prompt;
            var dialogResult = ShowDialog();
            SpellingPropertiesClass.UserSpellListName = fileName;
            return dialogResult;
        }
    }
}
