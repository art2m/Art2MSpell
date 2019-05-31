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

    public partial class InputDialog : Form
    {
        private string fileName = string.Empty;

        public InputDialog()
        {
            this.InitializeComponent();
        }

        private void OnButtonOk_Click(object sender, EventArgs e)
        {
            this.fileName = this.txtName.Text.Trim();

            if (string.IsNullOrEmpty(this.fileName))
            {
                this.fileName = string.Empty;
            }
        }

        private void OnButtonCancel_Click(object sender, EventArgs e)
        {
            this.fileName = string.Empty;
        }

        public DialogResult GetFileName(string caption, string prompt, ref string value)
        {
            this.Text = caption;
            this.lblPrompt.Text = prompt;
            var dialogResult = this.ShowDialog();
            value = string.Copy(this.fileName);
            return dialogResult;
        }
    }
}