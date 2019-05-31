// Art2MSpell
// 
// SpellingWordsListForm.ButtonClickEvents.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  17  2019
// 
//      2019
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
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using Classes;

    /// <summary>
    /// Button click events.
    /// </summary>
    public partial class SpellingWordsListForm
    {
        /// <summary>Handles the Click event of the AddNewWordButton control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonAddNewWord_Click(object sender, EventArgs e)
        {
            this.SetButtonsEnabledState_AddNewButtonClicked();
            this.ChangeControlsBackgroundColors();
            this.SetTabOrderAddWordToList();
            this.cboWord.Focus();
        }

        /// <summary>
        ///     Handles the Click event of the AddToListButton control. Adds a new spelling word to the new spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonAddWordToList_Click(object sender, EventArgs e)
        {
            var addWord = this.cboWord.Text.Trim();

            if (!ValidationClass.ValidateSpellingWord(addWord))
            {
                this.SetButtonsEnabledState_AddToListButtonClicked();
                this.ChangeControlsBackgroundColors();

                return;
            }

            if (!this.AddWordToListBox(addWord))
            {
                return;
            }

            this.SetButtonsEnabledState_AddToListButtonClicked();
            this.ChangeControlsBackgroundColors();
            this.SetTabOrderAddWordToList();
            this.SetTabOrderAddNewWordButton();
        }

        /// <summary>
        ///     Handles the Click event of the ClearButton control. Clears the word text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonCancelOperation_Click(object sender, EventArgs e)
        {
            if (SpellingPropertiesClass.EditingSpellingList)
            {
                this.lstWords.Items.Add(SpellingPropertiesClass.SpellingWordTextBoxValue);
            }

            this.cboWord.Text = string.Empty;

            SpellingPropertiesClass.EditingSpellingList = false;

            SpellingPropertiesClass.SpellingWordTextBoxValue = string.Empty;

            this.SetButtonsEnabledState_CancelOperationButtonClicked();

            this.ChangeControlsBackgroundColors();

            this.SetTabOrderCancelOperationButton();
        }

        /// <summary>
        ///     Handles the Click event of the ClearListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonClearList_Click(object sender, EventArgs e)
        {
            this.lstWords.Items.Clear();
            this.cboWord.Text = string.Empty;
            SpellingPropertiesClass.SpellingListIsDirty = true;
            this.SetButtonsEnabledState_ClearListButtonClicked();
            this.ChangeControlsBackgroundColors();
        }

        /// <summary>Handles the Click event of the CloseButton control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonClose_Click(object sender, EventArgs e)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            if (SpellingPropertiesClass.SpellingListIsDirty)
            {
                const string Msg =
                    "You have an unsaved spelling words list! Do you wish to save the list before exiting. ";
                var dlgResult = MyMessagesClass.ShowQuestionMessage(Msg, MyMessagesClass.NameOfMethod);
                if (dlgResult == DialogResult.Yes)
                {
                    return;
                }
            }

            this.Close();
        }

        /// <summary>
        ///     Create new spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void OnButtonCreateNewList_Click(object sender, EventArgs e)
        {
            this.CreateNewSpellingList();
        }

        /// <summary>
        ///     Handles the Click event of the button DeleteList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonDeleteList_Click(object sender, EventArgs e)
        {
            var className = this.GetType().Name;
            var methodName = MethodBase.GetCurrentMethod().Name;

            try
            {
                File.Delete(SpellingPropertiesClass.SpellingListPath);
                this.SetDeletePropertyStates();
                SpellingPropertiesClass.CreatingNewSpellingList = false;
            }
            catch (DirectoryNotFoundException ex)
            {
                var msg = ex.ToString();
                MyMessagesClass.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (NotSupportedException ex)
            {
                var msg = ex.ToString();
                MyMessagesClass.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (PathTooLongException ex)
            {
                var msg = ex.ToString();
                MyMessagesClass.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (UnauthorizedAccessException ex)
            {
                var msg = ex.ToString();
                MyMessagesClass.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (ArgumentException ex)
            {
                var msg = ex.ToString();
                MyMessagesClass.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (IOException ex)
            {
                var msg = ex.ToString();
                MyMessagesClass.ShowErrorMessageBox(msg, className, methodName);
            }
        }

        /// <summary>
        ///     Handles the Click event of the DeleteSelectedWordButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonDeleteWord_Click(object sender, EventArgs e)
        {
            this.lstWords.Items.RemoveAt(SpellingPropertiesClass.SelectedWordIndex);
            this.cboWord.Text = string.Empty;
            this.SetButtonsEnabledState_DeleteSelectedWordButtonClicked();
            this.ChangeControlsBackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the EditItemButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonEditWord_Click(object sender, EventArgs e)
        {
            this.cboWord.Focus();
            SpellingPropertiesClass.EditingSpellingList = true;
            SpellingPropertiesClass.SpellingWordTextBoxValue = this.cboWord.Text.Trim();
            this.lstWords.Items.RemoveAt(SpellingPropertiesClass.SelectedWordIndex);
            this.SetButtonsEnabledState_EditItemButtonClicked();
            this.ChangeControlsBackgroundColors();
        }

        /// <summary>Handles the Click event of the SelectSpellingListButton control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonOpenList_Click(object sender, EventArgs e)
        {
            this.OpenSpellingList();
        }

        /// <summary>
        ///     Handles the Click event of the SaveListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonSaveList_Click(object sender, EventArgs e)
        {
            if (this.lstWords.Items.Count < 1)
            {
                return;
            }

            using (var saveDlg = new SaveFileDialog())
            {
                saveDlg.ShowDialog();
                SpellingPropertiesClass.SpellingListPath = saveDlg.FileName;
            }

            this.SaveSpellingWordsToSpellingList();
            SpellingPropertiesClass.CreatingNewSpellingList = false;
        }
    }
}