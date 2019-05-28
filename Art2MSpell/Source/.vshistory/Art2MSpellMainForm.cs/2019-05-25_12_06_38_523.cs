// Art2MSpell
// 
// Art2MSpellMainForm.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  24  2019
// 
// 05  05   2019
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
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using Classes;
    using Collections;

    /// ********************************************************************************
    /// <summary>
    ///     The main win class.
    /// </summary>
    /// ********************************************************************************
    public partial class Art2MSpellMainForm : Form
    {
        /// <summary>
        ///     The height space between group box and panel.
        /// </summary>
        private int space;

        /// ********************************************************************************
        /// <summary>
        ///     Initializes a new instance of the <see cref="Art2MSpellMainForm" /> class.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public Art2MSpellMainForm()
        {
            this.InitializeComponent();

            this.SetInitialBackgroundColors();
            this.SetInitialControlsState();
            this.GetInitialPositioningSpace();
            SetClassName();
            GetPathToAppDataDirectory();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Add new users name to theAr2mSpell User List file.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private static void AddNewUserToUserNameFile()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var unc = new UsersNameCollection();

            if (unc.ContainsItem(SpellingPropertiesClass.UserName))
            {
                MyMessages.InformationMessage = "This user all ready exists.";
                MyMessages.ShowInformationMessageBox();
            }

            unc.AddItem(SpellingPropertiesClass.UserName);

            var dirPath = SpellingPropertiesClass.AppDataDirectoryPath;
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, dirName);

            if (string.IsNullOrEmpty(dirPath))
            {
                return;
            }

            var fileName = SpellingPropertiesClass.GetArt2MSpellUserListFileName;

            var filePath = DirectoryFileOperations.CombineDirectoryPathFileNameCheckCreateFile(dirPath, fileName);

            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            SpellingReadWriteClass.WriteUserNameFile(filePath);
        }

        /// ********************************************************************************
        /// <summary>
        ///     Get spacing so when form expands can be positioned by this.
        /// </summary>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void GetInitialPositioningSpace()
        {
            var btmPos = this.grpUserControls.Top - this.grpUserControls.Height;
            this.space = btmPos - this.pnlSpellingControls.Top;
        }

        /// ********************************************************************************
        /// <summary>
        ///     Get AppData Directory path and save into Spelling Properties class.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        private static void GetPathToAppDataDirectory()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            SpellingPropertiesClass.AppDataDirectoryPath =
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (string.IsNullOrEmpty(SpellingPropertiesClass.AppDataDirectoryPath))
            {
                MyMessages.ErrorMessage = "Unable to locate the AppData directory.";

                MyMessages.ShowErrorMessageBox();
            }

            if (!Directory.Exists(SpellingPropertiesClass.AppDataDirectoryPath))
            {
                MyMessages.ErrorMessage = "Unable to locate this AppData Directory";

                MyMessages.ShowErrorMessageBox();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Add new user to the users list.
        /// </summary>
        /// <param name="sender">the source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnAddNewUserButton_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;

            using (var dlgInput = new UserCreateNew())
            {
                var dlgResult = dlgInput.ShowDialog();

                if (DialogResult.OK != dlgResult)
                {
                    return;
                }

                SpellingListClass.SpeakString("Hello " + SpellingPropertiesClass.UserName + "!");
            }

            AddNewUserToUserNameFile();

            this.SetControlsState_AfterUserSelectOrAddUser();
        }

        /// <summary>
        ///     Display the form so user can be deleted from the user list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/22/2019</changed>
        private void OnDeleteUserNameButton_Click(object sender, EventArgs e)
        {
            using (var user = new UserNameEditDeleteForm())
            {
                user.ShowDialog();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Display the form so user can edit there user name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnEditUserNameButton_Click(object sender, EventArgs e)
        {
            using (var user = new UserNameEditDeleteForm())
            {
                user.ShowDialog();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Exit the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Exit the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Call method to show practice words form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnPracticeWordsButton_Click(object sender, EventArgs e)
        {
            ShowPracticeWordsForm();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Display dialog for user to edit or delete a user from the user list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnRemoveUserNameMenuItem_Click(object sender, EventArgs e)
        {
            using (var user = new UserNameEditDeleteForm())
            {
                user.ShowDialog();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Select user so can display this users spelling lists.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnSelectUserButton_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;

            using (var dlgInput = new UserCreateNew())
            {
                var dlgResult = dlgInput.ShowDialog();

                if (DialogResult.OK != dlgResult)
                {
                    return;
                }

                SpellingListClass.SpeakString("Hello " + SpellingPropertiesClass.UserName + "!");
            }

            AddNewUserToUserNameFile();

            this.SetControlsState_AfterUserSelectOrAddUser();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Call method to show spelling list form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnSpellingListButton_Click(object sender, EventArgs e)
        {
            ShowSpellingListForm();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Call method show spelling list form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnSpellingListFormShowMenuItem_Click(object sender, EventArgs e)
        {
            ShowSpellingListForm();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Call method show practice words form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnSpellingPracticeWordsFormMenuItem_Click(object sender, EventArgs e)
        {
            ShowPracticeWordsForm();
        }

        /// ********************************************************************************
        /// <summary>
        ///     Display input box for user to enter new user name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnUserAddNewMenuItem_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;

            using (var dlgInput = new UserCreateNew())
            {
                var dlgResult = dlgInput.ShowDialog();

                if (DialogResult.OK != dlgResult)
                {
                    return;
                }

                SpellingListClass.SpeakString("Hello " + SpellingPropertiesClass.UserName + "!");
            }

            AddNewUserToUserNameFile();

            this.SetControlsState_AfterUserSelectOrAddUser();
        }

        /// <summary>
        ///     Display dialog for user to edit or delete a user from the user list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/22/2019</changed>
        private void OnUserEditUserNameMenuItem_Click(object sender, EventArgs e)
        {
            using (var user = new UserNameEditDeleteForm())
            {
                user.ShowDialog();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Display user select dialog box for user to select name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void OnUserSelectMenuItem_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;

            using (var dlgUser = new UserSelectDialogBox())
            {
                var dlgResult = dlgUser.ShowDialog();

                if (DialogResult.OK != dlgResult)
                {
                    return;
                }

                SpellingListClass.SpeakString("Hello " + SpellingPropertiesClass.UserName + "!");

                this.SetControlsState_AfterUserSelectOrAddUser();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Set class name so can be used in message boxes.
        /// </summary>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private static void SetClassName()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessages.NameOfClass = declaringType.Name;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Enable all other controls on form after user has either added new user or selected user.
        /// </summary>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void SetControlsState_AfterUserSelectOrAddUser()
        {
            this.pnlSpellingControls.Enabled = true;
            this.pnlSpellingControls.BorderStyle = BorderStyle.Fixed3D;
            this.pnlEditDeleteUser.Enabled = true;
            this.pnlEditDeleteUser.BorderStyle = BorderStyle.Fixed3D;
            this.SpellTopMenuItem.Enabled = true;
            this.mnuUserRemove.Enabled = true;
            this.mnuUserEdit.Enabled = true;
        }


        /// ********************************************************************************
        /// <summary>
        ///     Set the controls initial colors.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void SetInitialBackgroundColors()
        {
            this.BackColor = Color.Aquamarine;
            this.btnSpellingList.BackColor = Color.LightSeaGreen;
            this.btnPracticeSpellingWords.BackColor = Color.Chartreuse;
            this.ExitButton.BackColor = Color.RosyBrown;
            this.grpUserControls.BackColor = Color.Coral;
            this.pnlUserNewSelect.BackColor = Color.BurlyWood;
            this.btnAdd.BackColor = Color.DarkSeaGreen;
            this.btnSelect.BackColor = Color.LightSkyBlue;
            this.btnDelete.BackColor = Color.Red;
            this.btnEdit.BackColor = Color.LightSteelBlue;
            this.pnlSpellingControls.BackColor = Color.Blue;
        }

        /// ********************************************************************************
        /// <summary>
        ///     Set the states of controls on Initializing.
        /// </summary>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void SetInitialControlsState()
        {
            this.SpellTopMenuItem.Enabled = false;
            this.mnuUserRemove.Enabled = false;
            this.mnuUserEdit.Enabled = false;
            this.pnlEditDeleteUser.Enabled = false;
            this.pnlSpellingControls.Enabled = false;
        }

        /// ********************************************************************************
        /// <summary>
        ///     Show the practice spelling words form.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private static void ShowPracticeWordsForm()
        {
            using (var frmSpellWords = new PracticeSpellingWordsForm())
            {
                frmSpellWords.ShowDialog();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Show the spelling list form.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private static void ShowSpellingListForm()
        {
            using (var frmSpellList = new SpellingWordsListForm())
            {
                frmSpellList.ShowDialog();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Center buttons on screen.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private void SpellItMainForm_Resize(object sender, EventArgs e)
        {
            this.grpUserControls.Left = (this.ClientSize.Width - this.grpUserControls.Width) / 2;
            this.pnlSpellingControls.Left = (this.ClientSize.Width - this.pnlSpellingControls.Width) / 2;

            var half = this.grpUserControls.Height / 2;

            this.grpUserControls.Top = (this.ClientSize.Height - half) / 4;

            this.pnlSpellingControls.Top = (this.grpUserControls.Top - this.grpUserControls.Height - this.space);

            //this.pnlSpellingControls.Top = 
        }

        private void OnDeleteSpellingListMenuItem_Clcik(object sender, EventArgs e)
        {

        }
    }
}