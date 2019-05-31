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
            var pos = this.lstSpell.SelectedIndex;
        }

        private void OnButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void OnButtonCancel_Click(object sender, EventArgs e)
        {

        }

        public dlg GetSpellingListPath(ref string value)
        {
            return string.Empty;
        }
    }
}
