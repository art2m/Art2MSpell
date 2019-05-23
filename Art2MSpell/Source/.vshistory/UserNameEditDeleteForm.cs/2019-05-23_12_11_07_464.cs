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
    using System.Reflection;
    using System.Windows.Forms;
    using Classes;
    using Collections;


    /// <summary>
    ///  Edit a user or delete user from user file list.
    /// </summary>
    public partial class UserNameEditDeleteForm : Form
    { 
        /// ********************************************************************************
        /// <summary>
        /// Collection that holds the paths to use
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private readonly UserSpellingFilePathsCollection uspc = new UserSpellingFilePathsCollection();

        private readonly UsersNameCollection usnc = new UsersNameCollection();

        public UserNameEditDeleteForm()
        {
            this.InitializeComponent();

            this.SetInitialBackgroundColors();

            this.CurrentUsersName();

            this.DisplayUsersSpellingList();
           
        }

       
         /// <summary>
         /// Display all of the users spelling list in the list box.
         /// </summary>
         /// <created>art2m,5/22/2019</created>
         /// <changed>art2m,5/22/2019</changed>
         private void DisplayUsersSpellingList()
         {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, dirName);

            if (string.IsNullOrEmpty(dirPath))
            {
                return;
            }

            var fileName = SpellingPropertiesClass.SpellingListPathsFileName;

            var filePath = DirectoryFileOperations.CombineDirectoryPathFileNameCheckCreateFile(dirPath, fileName);

            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            var retVal = SpellingReadWriteClass.ReadUsersSpellingListPathsFile(filePath);

            if (!retVal)
            {
                return;
            }

            this.FillListBoxWithPathsToUsersSpellingListFiles();
         }

         /// ********************************************************************************
         /// <summary>
         /// Fill list box with spelling paths to users spelling list files.
         /// </summary>
         /// <created>art2m,5/23/2019</created>
         /// <changed>art2m,5/23/2019</changed>
         /// ********************************************************************************
         private void FillListBoxWithPathsToUsersSpellingListFiles()
         {
             for (var index = 0; index < this.uspc.ItemsCount(); index++)
             {
                 this.lstFilePaths.Items.Add(this.uspc.GetItemAt(index));
             }
         }

         private void OnCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnDeleteUserButton_Click(object sender, EventArgs e)
        {
            var userName = SpellingPropertiesClass.UserName;
            this.usnc.
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