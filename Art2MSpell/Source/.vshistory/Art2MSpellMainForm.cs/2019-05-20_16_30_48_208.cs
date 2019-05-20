// Art2MSpell
// 
// Art2MSpellMainForm.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  20  2019
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
    using System.Windows.Forms;
    using Classes;

    /// <summary>
    ///     The main win class.
    /// </summary>
    public partial class Art2MSpellMainForm : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Art2MSpellMainForm" /> class.
        /// </summary>
        public Art2MSpellMainForm()
        {
            this.InitializeComponent();

            this.SetControlsState(false);
            this.SetInitialBackgroundColors();
        }

        /// <summary>
        ///     Add new users name to theAr2mSpell User List file.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private static void AddNewUserToUserNameFile()
        {
            SpellingReadWriteClass.WriteUserNameFile();
        }

        /// <summary>
        ///     Exit the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     Exit the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     Call method show spelling list form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void OnSpellingListFormShowMenuItem_Click(object sender, EventArgs e)
        {
            ShowSpellingListForm();
        }

        /// <summary>
        ///     Call method show practice words form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void OnSpellingPracticeWordsFormMenuItem_Click(object sender, EventArgs e)
        {
            ShowPracticeWordsForm();
        }

        /// <summary>
        ///     Call method to show practice words form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void PracticeWordsButton_Click(object sender, EventArgs e)
        {
            ShowPracticeWordsForm();
        }

        /// <summary>
        ///     Set the affected controls to enabled or disabled.
        /// </summary>
        /// <param name="val"></param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void SetControlsState(bool val)
        {
            this.flpButtons.Enabled = val;
            this.SpellTopMenuItem.Enabled = val;
        }

        /// <summary>
        ///     Set the controls initial colors.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void SetInitialBackgroundColors()
        {
            this.BackColor = Color.Aquamarine;
            this.btnSpellingList.BackColor = Color.LightSeaGreen;
            this.btnPracticeSpellingWords.BackColor = Color.Chartreuse;
            this.ExitButton.BackColor = Color.RosyBrown;
        }

        /// <summary>
        ///     Show the practice spelling words form.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private static void ShowPracticeWordsForm()
        {
            using (var frmSpellWords = new PracticeSpellingWordsForm())
            {
                frmSpellWords.ShowDialog();
            }
        }

        /// <summary>
        ///     Show the spelling list form.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private static void ShowSpellingListForm()
        {
            using (var frmSpellList = new SpellingWordsListForm())
            {
                frmSpellList.ShowDialog();
            }
        }

        /// <summary>
        ///     Call method to show spelling list form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void SpellingListButton_Click(object sender, EventArgs e)
        {
            ShowSpellingListForm();
        }

        /// <summary>
        ///     Center buttons on screen.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void SpellItMainForm_Resize(object sender, EventArgs e)
        {
            this.flpButtons.Left = (this.ClientSize.Width - this.flpButtons.Width) / 2;
            this.flpButtons.Top = (this.ClientSize.Height - this.flpButtons.Height) / 2;
        }

        /// <summary>
        ///     Display input box for user to enter new user name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void UserAddNewMenuItem_Click(object sender, EventArgs e)
        {
            SpellingPropertiesClass.UserName = string.Empty;

            using (var dlgInput = new CreateNewUser())
            {
                var dlgResult = dlgInput.ShowDialog();

                if (DialogResult.OK != dlgResult)
                {
                    return;
                }

                SpellingListClass.SpeakString("Hello " + SpellingPropertiesClass.UserName + "!");
            }

            AddNewUserToUserNameFile();

            this.SetControlsState(true);
        }

        /// <summary>
        ///     Display user select dialog box for user to select name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void UserSelectMenuItem_Click(object sender, EventArgs e)
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

                this.SetControlsState(true);
            }
        }
    }
}