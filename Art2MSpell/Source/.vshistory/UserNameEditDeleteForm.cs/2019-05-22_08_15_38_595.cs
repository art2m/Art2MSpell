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

    public partial class UserNameEditDeleteDlg : Form
    {
        public UserNameEditDeleteDlg()
        {
            this.InitializeComponent();

            this.SetInitialBackgroundColors();

            this.CurrentUsersName();

            // TODO: Have to write all users spelling file paths out to a file saved as user name.
        }

        private void CurrentUsersName()
        {
            this.txtName.Text = SpellingPropertiesClass.UserName;
            this.txtName.Enabled = false;
        }

        /// <summary>
        /// Set the control colors
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void SetInitialBackgroundColors()
        {
            this.BackColor = Color.SaddleBrown;
            this.btnClose.BackColor = Color.Bisque;
            this.btnEdit.BackColor = Color.LawnGreen;
            this.btnDelete.BackColor = Color.Red;
            this.lblInfo.BackColor = Color.Goldenrod;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.txtName.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
