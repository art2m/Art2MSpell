﻿// Art2MSpell
// 
// UserSelectListForm.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  22  2019
// 
// 05  17   2019
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
    using Collections;

    /// ********************************************************************************
    /// <summary>
    /// select user name so then can connect current user to spelling lists.
    /// </summary>
    /// ********************************************************************************
    public partial class UserSelectListForm : Form
    {
        /// ********************************************************************************
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public UserSelectListForm()
        {
            this.InitializeComponent();
            this.SetInitialBackgroundColors();
            this.lstUsers.Focus();
            this.ReadUserFileFillListBox();
        }

        /// ********************************************************************************
        /// <summary>
        /// Place all the user names from the collection into the list box.
        /// User can then select there name and get all of there spelling list.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void FillListBoxWithUserNames()
        {
           
            for (var index = 0; index < UsersNameCollection.ItemsCount(); index++)
            {
                this.lstUsers.Items.Add(UsersNameCollection.GetItemAt(index));
            }
        }

        /// ********************************************************************************
        /// <summary>
        /// cancel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnButtonCancel_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;
        }

        /// ********************************************************************************
        /// <summary>
        /// File user name property with selected user name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnButtonOk_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = this.txtName.Text;
        }

        /// <summary>
        ///  Get The name of the user from the list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        private void OnListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtName.Text = this.lstUsers.Text;
        }

        /// ********************************************************************************
        /// <summary>
        /// Read users names list from file.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void ReadUserFileFillListBox()
        {
            var dirPath = SpellingPropertiesClass.AppDataDirectoryPath;
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            dirPath = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirPath, dirName);

            if (string.IsNullOrEmpty(dirPath))
            {
                return;
            }

            var fileName = SpellingPropertiesClass.GetArt2MSpellUserListFileName;

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathFileNameCheckCreateFile(dirPath, fileName);

            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            if (!SpellingReadWriteClass.ReadUsersSpellingListPathsFile(filePath))
            {
                return;

            }

            this.FillListBoxWithUserNames();

            // TODO: Not finding the data for the user name!
        }


        /// ********************************************************************************
        /// <summary>
        /// Set the control colors
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void SetInitialBackgroundColors()
        {
            this.BackColor = Color.SaddleBrown;
            this.btnCancel.BackColor = Color.Red;
            this.btnOk.BackColor = Color.LawnGreen;
            this.lblUserName.BackColor = Color.Goldenrod;
        }
    }
}