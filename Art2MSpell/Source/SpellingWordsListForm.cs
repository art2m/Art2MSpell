// Art2MSpell
//
// SpellingWordsListForm.cs
//
// art2m
//
// art2m@live.com
//
// 05  08  2019
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

    /// <summary>
    /// Show spelling list form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SpellingWordsListForm : Form
    {
        #region Public Constructors

        /// <summary>Initializes a new instance of the <see cref="SpellingWordsListForm"/> class.</summary>
        public SpellingWordsListForm()
        {
            this.InitializeComponent();
        }

        #endregion Public Constructors

        #region Controls Click Event

        /// <summary>
        ///     If the file exists delete spelling list click.
        /// </summary>
        private void IfNotFileExists_DeleteSpellingListClick()
        {
            if (File.Exists(SpellingPropertiesClass.SpellingListPath))
            {
                return;
            }

            const string Msg = "There is no file to delete at this location. ";
            MyMessages.InformationMessage = string.Concat(Msg, SpellingPropertiesClass.SpellingListPath);
            MyMessages.ShowInformationMessage(MyMessages.InformationMessage, SpellingPropertiesClass.SpellingListPath);
            this.SetDeletePropertyStates();
        }

        /// <summary>
        ///     Ifs the spelling file does not exist after delete spelling list click.
        /// </summary>
        private void IfSpellingFileDoesNotExist_AfterDeleteSpellingListClick()
        {
            if (!File.Exists(SpellingPropertiesClass.SpellingListPath))
            {
                const string MsgInfo = "The file was deleted successfully.";
                MyMessages.ShowInformationMessage(MsgInfo, MyMessages.NameOfMethod);
                this.SetDeletePropertyStates();
            }
        }

        /// <summary>Ifs the spelling file exists after delete spelling list click.</summary>
        private void IfSpellingFileExists_AfterDeleteSpellingListClick()
        {
            if (File.Exists(SpellingPropertiesClass.SpellingListPath))
            {
                const string MsgError = "Unable to delete the spelling word file at this location. ";
                MyMessages.ErrorMessage = string.Concat(MsgError, SpellingPropertiesClass.SpellingListPath);
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }
        }

        /// <summary>Handles the Click event of the AddNewWordButton control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnAddNewWordButtonClick(object sender, EventArgs e)
        {
            this.SetButtonsEnabledState_AddNewButtonClicked();
            this.ChangeControls_BackgroundColors();
            this.cboWord.Focus();
            this.SetTabOrderAddNewWordButton();
        }

        /// <summary>
        ///     Handles the Click event of the AddToListButton control. Adds a new spelling word to the new spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnAddWordToListButtonClick(object sender, EventArgs e)
        {
            var word = this.cboWord.Text.Trim();

            if (!Validation.ValidateSpellingWord(word))
            {
                return;
            }

            this.AddWordToTheSpellingListBox(word);
            this.SetTabOrderAddNewWordButton();
        }

        /// <summary>
        ///     Handles the Click event of the ClearButton control. Clears the word text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCancelOperationButtonClick(object sender, EventArgs e)
        {
            if (SpellingPropertiesClass.EditingSpellingList)
            {
                this.lstWordsList.Items.Add(SpellingPropertiesClass.SpellingWordTextBoxValue);
            }

            this.cboWord.Text = string.Empty;
            SpellingPropertiesClass.EditingSpellingList = false;
            SpellingPropertiesClass.SpellingWordTextBoxValue = string.Empty;
            this.SetButtonsEnabledState_CancelOperationButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the ClearListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnClearSpellingListButtonClick(object sender, EventArgs e)
        {
            this.lstWordsList.Items.Clear();
            this.cboWord.Text = string.Empty;
            SpellingPropertiesClass.SpellingListIsDirty = true;
            this.SetButtonsEnabledState_ClearListButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>Handles the Click event of the CloseButton control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            if (SpellingPropertiesClass.SpellingListIsDirty)
            {
                const string Msg =
                    "You have an unsaved spelling words list! Do you wish to save the list before exiting. ";
                var dlgResult = MyMessages.ShowQuestionMessage(Msg, MyMessages.NameOfMethod);
                if (dlgResult == DialogResult.Yes)
                {
                    return;
                }
            }

            this.Close();
        }

        /// <summary>
        ///     Handles the Click event of the Close control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     Handles the Click event of the CreateNewListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCreateNewListButtonClick(object sender, EventArgs e)
        {
            SpellingPropertiesClass.CreatingNewSpellingList = true;
            this.SetButtonsEnabledState_CreateNewListButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the button DeleteList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnDeleteSpellingListClick(object sender, EventArgs e)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            this.IfNotFileExists_DeleteSpellingListClick();
            File.Delete(SpellingPropertiesClass.SpellingListPath);
            this.IfSpellingFileExists_AfterDeleteSpellingListClick();
            this.IfSpellingFileDoesNotExist_AfterDeleteSpellingListClick();
        }

        /// <summary>
        ///     Handles the Click event of the DeleteSelectedWordButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnDeleteWordButtonClick(object sender, EventArgs e)
        {
            this.lstWordsList.Items.RemoveAt(SpellingPropertiesClass.SelectedWordIndex);
            this.cboWord.Text = string.Empty;
            this.SetButtonsEnabledState_DeleteSelectedWordButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the EditItemButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnEditWordButtonClick(object sender, EventArgs e)
        {
            this.cboWord.Focus();
            SpellingPropertiesClass.EditingSpellingList = true;
            SpellingPropertiesClass.SpellingWordTextBoxValue = this.cboWord.Text.Trim();
            this.lstWordsList.Items.RemoveAt(SpellingPropertiesClass.SelectedWordIndex);
            this.SetButtonsEnabledState_EditItemButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the OpenSpellingListMenuItem control. Opens the file menu for user to select a
        ///     spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnOpenSpellingListMenuItemClick(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.ShowDialog();
                SpellingPropertiesClass.SpellingListPath = openDlg.FileName;
                if (!this.DisplaySpellingWords())
                {
                    return;
                }

                this.lstWordsList.Enabled = true;
                this.SetButtonsEnabledState_OpenSpellingListButtonStateClicked();
                this.ChangeControls_BackgroundColors();
            }
        }

        /// <summary>
        ///     Handles the Click event of the SaveListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnSaveSpellingListButtonClick(object sender, EventArgs e)
        {
            if (this.lstWordsList.Items.Count < 1)
            {
                return;
            }

            using (var saveDlg = new SaveFileDialog())
            {
                saveDlg.ShowDialog();
                SpellingPropertiesClass.SpellingListPath = saveDlg.FileName;
            }

            this.SaveSpellingWordsToSpellingList();
        }

        /// <summary>Handles the Click event of the SelectSpellingListButton control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnSelectSpellingListButtonClick(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.ShowDialog();
                SpellingPropertiesClass.SpellingListPath = openDlg.FileName;
                if (!this.DisplaySpellingWords())
                {
                    return;
                }

                this.SetButtonsEnabledState_OpenSpellingListButtonStateClicked();
                this.ChangeControls_BackgroundColors();
            }
        }

        /// <summary>
        ///     Set tab order when user selects Add New Word Button.
        /// </summary>
        private void SetTabOrderAddNewWordButton()
        {
            this.btnAddWordToList.TabIndex = 0;
            this.btnCancelOperation.TabIndex = 1;
            this.btnSaveList.TabIndex = 2;
            this.btnClose.TabIndex = 3;
        }

        /// <summary>
        ///     Set tab order when user selects Add Word To List Button.
        /// </summary>
        private void SetTabOrderAddToListButton()
        {
            this.btnAddNewWord.TabIndex = 0;
            this.btnSaveList.TabIndex = 1;
            this.btnClose.TabIndex = 2;
        }

        /// <summary>Sets the tab order cancel operation button.</summary>
        private void SetTabOrderCancelOperationButton()
        {
            this.btnAddNewWord.TabIndex = 0;
            this.btnSaveList.TabIndex = 1;
            this.btnClose.TabIndex = 2;
        }
        #endregion Controls Click Event

        #region Private Methods

        /// <summary>
        ///     Create spelling list file.
        /// </summary>
        /// <param name="filePath">The path string to where the new spelling list file should be saved.</param>
        /// <returns>True if file created else false.</returns>
        private static bool WriteSpellingWordsToFile(string filePath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            if (!SpellingListsClass.WriteSpellingWordsFromCollectionToFile(filePath))
            {
                return false;
            }

            const string MsgSuccess = "Your spelling list has been created successfully.";

            MyMessages.ShowInformationMessage(MsgSuccess, MyMessages.NameOfMethod);
            return true;
        }

        /// <summary>
        ///     Add suggested words to combo box.
        /// </summary>
        private void AddSuggestionsForMisspelledWords()
        {
            for (var index = 0; index < SuggestedWordsCollection.ItemsCount(); index++)
            {
                this.cboWord.Items.Add(SuggestedWordsCollection.GetItemAt(index));
            }

            this.cboWord.DroppedDown = true;
        }

        /// <summary>
        ///     Adds the word to the spelling ListBox.
        /// </summary>
        /// <param name="word">The word to add to spelling list.</param>
        private void AddWordToTheSpellingListBox(string word)
        {
            if (this.CheckWordIsInListBox(word))
            {
                return;
            }

            if (!this.CheckWordSpelling(word))
            {
                this.cboWord.Text = string.Empty;
                return;
            }

            this.lstWordsList.Items.Add(word);

            SpellingListsClass.SpeakString(word);
            this.SetAddingWordProperties();
        }

        /// <summary>
        ///     Sets the color of the buttons background.
        /// </summary>
        private void ChangeControls_BackgroundColors()
        {
            this.SetAddNewItemButton_BackgroundColor();
            this.SetAddToListButton_BackgroundColor();
            this.SetCancelOperationButton_BackgroundColor();
            this.SetClearListButton_BackgroundColor();
            this.SetCloseButton_BackgroundColor();
            this.SetCreateNewListButton_BackgroundColor();
            this.SetDeleteListButton_BackgroundColor();
            this.SetDeleteSelectedWord_BackgroundColor();
            this.SetEditItemButton_BackgroundColor();
            this.SetSaveListButton_BackgroundColor();
            this.SetSelectSpellingListButton_BackgroundColor();
            this.SetWordsListBox_BackgroundColor();
            this.SetWordTextBox_BackgroundColor();
        }

        /// <summary>
        ///     Check word to see if it is all ready contained in the list box.
        /// </summary>
        /// <param name="word">The string to be checked.</param>
        /// <returns>True if it is contained in the list box else false.</returns>
        private bool CheckWordIsInListBox(string word)
        {
            PossibleWordsListCollection.ClearCollection();
            foreach (var item in this.lstWordsList.Items)
            {
                PossibleWordsListCollection.AddItem(item.ToString());
            }

            if (!SpellingListsClass.CheckForDuplicateWordInList(word))
            {
                return false;
            }

            this.cboWord.Text = string.Empty;
            this.cboWord.Focus();
            return true;
        }

        /// <summary>
        ///     check the spelling word user has either entered for new spelling list
        ///     or to check practice spelling word user has spelled.
        /// </summary>
        /// <param name="word">The word to be checked for spelling.</param>
        /// <returns>True if spelled correctly else false.</returns>
        private bool CheckWordSpelling(string word)
        {
            if (SpellingListsClass.CheckUserEnteredSpellingWord(word))
            {
                return true;
            }

            var msg = string.Concat("This word is not spelled correctly:  ", word);
            const string Caption = "Spelling Incorrect.";
            MessageBox.Show(msg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.AddSuggestionsForMisspelledWords();
            return false;
        }

        /// <summary>Displays the spelling words.</summary>
        /// <returns>True if spelling words added to list box else false.</returns>
        private bool DisplaySpellingWords()
        {
            if (!SpellingListsClass.ReadSpellingWordsToCollection(SpellingPropertiesClass.SpellingListPath))
            {
                return false;
            }

            this.FillListBoxWithWordsList();
            return true;
        }

        /// <summary>
        ///     Fills the collection with spelling words.
        /// </summary>
        /// <returns>true if items added to collection else false.</returns>
        private bool FillCollectionWithSpellingWords()
        {
            foreach (var listItem in this.lstWordsList.Items)
            {
                SpellingWordsCollection.AddItem(listItem.ToString().Trim());
            }

            return this.lstWordsList.Items.Count >= 1;
        }

        /// <summary>
        ///     Fills the ListBox with list words from collection.
        /// </summary>
        private void FillListBoxWithListWordsFromCollection()
        {
            for (var index = 0; index < SpellingWordsCollection.ItemsCount(); index++)
            {
                this.lstWordsList.Items.Add(SpellingWordsCollection.GetItemAt(index));
            }
        }

        /// <summary>
        ///     Fills the ListBox with words list.
        /// </summary>
        private void FillListBoxWithWordsList()
        {
            if (SpellingWordsCollection.ItemsCount() < 1)
            {
                return;
            }

            this.FillListBoxWithListWordsFromCollection();
        }

        /// <summary>
        ///     Saves the spelling words to spelling list.
        /// </summary>
        private void SaveSpellingWordsToSpellingList()
        {
            SpellingWordsCollection.ClearCollection();
            if (!this.FillCollectionWithSpellingWords())
            {
                return;
            }

            if (!WriteSpellingWordsToFile(SpellingPropertiesClass.SpellingListPath))
            {
                return;
            }

            this.SetSaveOperationProperties();
        }

        /// <summary>
        ///     Sets the adding word properties.
        /// </summary>
        private void SetAddingWordProperties()
        {
            this.cboWord.Text = string.Empty;
            SpellingPropertiesClass.EditingSpellingList = false;
            SpellingPropertiesClass.SpellingWordTextBoxValue = string.Empty;
            SpellingPropertiesClass.SpellingListIsDirty = true;
            this.SetButtonsEnabledState_AddToListButtonClicked();
            this.ChangeControls_BackgroundColors();
            this.cboWord.Focus();
        }

        /// <summary>
        ///     Sets the delete property states.
        /// </summary>
        private void SetDeletePropertyStates()
        {
            SpellingPropertiesClass.EditingSpellingList = false;
            SpellingPropertiesClass.CreatingNewSpellingList = false;
            SpellingPropertiesClass.DeleteSpellingList = false;
            SpellingPropertiesClass.OpeningSpellingList = false;
            SpellingPropertiesClass.SavingSpellingList = false;
            SpellingPropertiesClass.SpellingListIsDirty = false;
            SpellingPropertiesClass.SpellingListPath = string.Empty;
            SpellingPropertiesClass.SpellingWordTextBoxValue = string.Empty;
            SpellingPropertiesClass.SpellingListPath = string.Empty;
            this.cboWord.Text = string.Empty;
            this.lstWordsList.Items.Clear();
            this.SetButtonsEnabledState_DeleteSpellingListButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Sets the save operation properties.
        /// </summary>
        private void SetSaveOperationProperties()
        {
            SpellingPropertiesClass.SpellingListIsDirty = false;
            SpellingPropertiesClass.EditingSpellingList = false;
            SpellingPropertiesClass.OpeningSpellingList = false;
            SpellingPropertiesClass.CreatingNewSpellingList = false;
            SpellingPropertiesClass.DeleteSpellingList = false;
            SpellingPropertiesClass.SavingSpellingList = false;
            SpellingPropertiesClass.SpellingListPath = string.Empty;
            SpellingPropertiesClass.SpellingWordTextBoxValue = string.Empty;
            this.lstWordsList.Items.Clear();
            this.cboWord.Text = string.Empty;
            this.lstWordsList.Enabled = true;
            this.SetButtonsEnabledState_SaveSpellingListButtonStateClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Load event of the SpellingWordsList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void SpellingWordsList_Load(object sender, EventArgs e)
        {
            this.pnlMain.BackColor = Color.PaleGoldenrod;
            this.pnlWordList.BackColor = Color.SandyBrown;
            this.pnlWord.BackColor = Color.BurlyWood;
            this.SetButtonsEnabledState_FormLoadEvent();
            this.ChangeControls_BackgroundColors();
            SpellingPropertiesClass.SpellingListPath = string.Empty;
        }

        /// <summary>
        ///     Handles the SelectedIndexChanged event of the WordsList control. Gets the item selected and places it in the
        ///     words text box for editing. Gets the item index so edit changes can be made in the words list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void WordsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstWordsList.SelectedItem == null)
            {
                return;
            }

            this.cboWord.Text = this.lstWordsList.SelectedItem.ToString();
            SpellingPropertiesClass.SelectedWordIndex = this.lstWordsList.SelectedIndex;
            this.SetButtonsEnabledState_WordsListSelectedIndexChanges();
            this.ChangeControls_BackgroundColors();
        }
        #endregion Private Methods
    }
}