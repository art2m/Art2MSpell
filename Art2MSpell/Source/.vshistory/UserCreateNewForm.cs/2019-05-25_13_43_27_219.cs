// Art2MSpell
// 
// UserCreateNewForm.cs
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
    using System.Reflection;
    using System.Windows.Forms;
    using Classes;

    /// <summary>
    /// Dialog for adding a new user to the user file.
    /// </summary>
    public partial class UserCreateNewForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateNewForm"/> class.
        /// </summary>
        public UserCreateNewForm()
        {
            this.InitializeComponent();

            this.SetInitialBackgroundColors();

            this.txtUserName.Focus();

            SetClassName();
        }

        /// <summary>
        /// Set class name so can be used in message boxes.
        /// </summary>
        private static void SetClassName()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        /// if user cancels then set the user name property to string empty.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnButtonCancel_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;
        }

        /// <summary>
        /// if user enters text save it to user name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnButtonOk_Click(object sender, EventArgs e)
        {
            var name = this.txtUserName.Text.Trim();

            if (string.IsNullOrEmpty(name) || name.Length < 1)
            {
                SpellingPropertiesClass.UserName = string.Empty;
                return;
            }

            SpellingPropertiesClass.UserName = name;

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

            SpellingReadWriteClass.WriteUserNameFile(filePath);
        }

     

        /// <summary>
        /// Set the control colors
        /// </summary>
        private void SetInitialBackgroundColors()
        {
            this.BackColor = Color.SaddleBrown;
            this.btnCancel.BackColor = Color.Red;
            this.btnOk.BackColor = Color.LawnGreen;
            this.lblUserName.BackColor = Color.Goldenrod;
        }
    }
}