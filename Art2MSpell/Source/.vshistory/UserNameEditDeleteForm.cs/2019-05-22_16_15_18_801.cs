// Art2MSpell
// 
// UserNameEditDeleteForm.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  22  2019
// 
// 05  21   2019
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Art2MSpell.Source
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Classes;


    public partial class UserNameEditDeleteForm : Form
    {
        public UserNameEditDeleteForm()
        {
            this.InitializeComponent();

            this.SetInitialBackgroundColors();

            this.CurrentUsersName();

            // TODO: Have to write all users spelling file paths out to a file saved as user name.
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Allow user to edit name;
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/22/2019</changed>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.txtName.Enabled = true;
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
            this.btnEdit.BackColor = Color.LightSteelBlue;
            this.btnDelete.BackColor = Color.Red;
            this.lblInfo.BackColor = Color.Goldenrod;
            this.btnUpdate.BackColor = Color.LawnGreen;
        }

        
    }
}