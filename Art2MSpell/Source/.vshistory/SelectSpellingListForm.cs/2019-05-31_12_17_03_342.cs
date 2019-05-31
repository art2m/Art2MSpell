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

        private void GetAllSpellingListPaths()
        {
            var dirPath = SpellingPropertiesClass.CurrentUserSpellingListDirectory;

            var filePaths = Directory.GetFiles(dirPath);

            this.lstSpell.DataSource = filePaths;
        }

        private void LstSpell_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void OnButtonCancel_Click(object sender, EventArgs e)
        {

        }

        public string GetSpellingListPath(ref string value)
        {
            return string.Empty;
        }
    }
}
