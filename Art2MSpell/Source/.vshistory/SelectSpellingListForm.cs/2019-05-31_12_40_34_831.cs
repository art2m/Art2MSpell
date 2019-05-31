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
    using System.IO;
    using Classes;

    public partial class SelectSpellingListForm : Form
    {
        private string spellName = string.Empty;
        public SelectSpellingListForm()
        {
            this.InitializeComponent();

            this.GetAllSpellingListPaths();
        }

        /// ********************************************************************************
        /// <summary>
        /// Get all of this users spelling files from the users directory.
        /// Fill list box with 
        /// </summary>
        /// <created>art2m,5/31/2019</created>
        /// <changed>art2m,5/31/2019</changed>
        /// ********************************************************************************
        private void GetAllSpellingListPaths()
        {
            var dirPath = SpellingPropertiesClass.CurrentUserSpellingListDirectory;

            var filePaths = Directory.GetFiles(dirPath);
            
            this.lstSpell.DataSource = filePaths;
        }

        private void LstSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spellName = this.lstSpell.SelectedItem.ToString();
        }

        private void OnButtonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.spellName))
            {
                MyMessagesClass.InformationMessage = "You need to select a spelling list else cancel.";
                MyMessagesClass.ShowInformationMessageBox();
              
            
        }

        private void OnButtonCancel_Click(object sender, EventArgs e)
        {
            this.spellName = string.Empty;
        }

        public DialogResult GetSpellingListPath(ref string value)
        {
            var dialogResult = this.ShowDialog();

            value = string.Copy(this.spellN);
            return dialogResult;
           
        }
    }
}
