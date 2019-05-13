// Art2MSpell
// 
// SpellingWordsListForm.cs
// 
// art2m
// 
// art2m@live.com
// 
// 05  13  2019
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
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using Classes;
    using Collections;

    /// <summary>
    ///     Show spelling list form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SpellingWordsListForm : Form
    {
        /// <summary>Holds items from list box so they can be checked against word to be added for duplicate.</summary>
        private List<string> duplicate;

        /// <summary>Holds the initial with of the form.</summary>
        private int formWidth;

        /// <summary>Initializes a new instance of the <see cref="SpellingWordsListForm" /> class.</summary>
        public SpellingWordsListForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        ///     write spelling words from collection to file.
        /// </summary>
        /// <param name="filePath">The path to the spelling list file.</param>
        /// <returns>true if spelling list is written to file else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private static bool WriteWordsToFile(string filePath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            if (!SpellingList.WriteToFile(filePath))
            {
                return false;
            }

            const string MsgSuccess = "Your spelling list has been created successfully.";

            MyMessages.ShowInformationMessage(MsgSuccess, MyMessages.NameOfMethod);
            return true;
        }

        /// <summary>
        ///     Add suggested words for misspelled words to the combo box.
        /// </summary>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private void AddSuggestions()
        {
            for (var index = 0; index < DictionaryWordscollection.ItemsCount(); index++)
            {
                this.cboWord.Items.Add(DictionaryWordscollection.GetItemAt(index));
            }

            this.cboWord.DroppedDown = true;
        }

        /// <summary>
        ///     Add spelling word to the collection for saving to file.
        /// </summary>
        /// <returns>True if word is added to the collection else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private bool AddWordsToCollection()
        {
            foreach (var listItem in this.lstWords.Items)
            {
                SpellingWordsCollection.AddItem(listItem.ToString().Trim());
            }

            return this.lstWords.Items.Count >= 1;
        }

        /// <summary>
        ///     Add words to list box for editing of deleting.
        /// </summary>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private void AddWordsToListBox()
        {
            for (var index = 0; index < SpellingWordsCollection.ItemsCount(); index++)
            {
                this.lstWords.Items.Add(SpellingWordsCollection.GetItemAt(index));
            }
        }

        /// <summary>
        ///     add the word to spelling list box
        /// </summary>
        /// <param name="word">The word to be added.</param>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private void AddWordToListBox(string word)
        {
            if (this.CheckListBoxForWord(word))
            {
                return;
            }

            // If true found duplicate word.
            if (this.CheckWordSpelling(word))
            {
                this.cboWord.Text = string.Empty;
                return;
            }

            this.lstWords.Items.Add(word);

            SpellingList.SpeakString(word);
            this.SetAddingWordProperties();
        }

        /// <summary>
        ///     Sets button background color.
        /// </summary>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private void ChangeControlsBackgroundColors()
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
        ///     Check to see if the word is all ready contained in the list box.
        /// </summary>
        /// <param name="word">The word to be added to the list box.</param>
        /// <returns>True if no duplicate word found in the list box else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private bool CheckListBoxForWord(string word)
        {
            this.duplicate = new List<string>();
            foreach (var item in this.lstWords.Items)
            {
                this.duplicate.Add(item.ToString());
            }

            if (!SpellingList.CheckDuplicateWord(this.duplicate, word))
            {
                return false;
            }

            this.cboWord.Text = string.Empty;
            this.cboWord.Focus();
            return true;
        }

        /// <summary>
        ///     Check the spelling word user has entered.
        /// </summary>
        /// <param name="word">The word to be checked for spelling.</param>
        /// <returns>True if word is correct else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private bool CheckWordSpelling(string word)
        {
            if (SpellingList.CheckWord(word))
            {
                return true;
            }

            var msg = string.Concat("This word is not spelled correctly:  ", word);
            const string Caption = "Spelling Incorrect.";
            MessageBox.Show(msg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.AddSuggestions();
            return false;
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
                 this.AddWordsToListBox();
        }

        /// <summary>
        ///     Get spelling words from file and place into collection for editing.
        /// </summary>
        /// <returns>true if words added to the collection else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private bool GetWordsFromFile()
        {
            if (!SpellingList.ReadHeader(SpellingPropertiesClass.SpellingListPath))
            {
                SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = false;
                SpellingPropertiesClass.Art2MSpellSpellingList = false;
                return false;
            }

            SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = true;
            SpellingPropertiesClass.Art2MSpellSpellingList = true;

            if (!SpellingList.ReadFile(SpellingPropertiesClass.SpellingListPath))
            {
                return false;
            }

            this.FillListBoxWithWordsList();
            return true;
        }

        /// <summary>Handles the Click event of the AddNewWordButton control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonAddNewWord(object sender, EventArgs e)
        {
            this.SetButtonsEnabledState_AddNewButtonClicked();
            this.ChangeControlsBackgroundColors();
            this.cboWord.Focus();
            this.SetTabOrderAddNewWordButton();
        }

        /// <summary>
        ///     Handles the Click event of the AddToListButton control. Adds a new spelling word to the new spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonAddWordToList(object sender, EventArgs e)
        {
            var addWord = this.cboWord.Text.Trim();

            if (!Validation.ValidateSpellingWord(addWord))
            {
                return;
            }

            this.AddWordToListBox(addWord);
            this.SetTabOrderAddNewWordButton();
        }

        /// <summary>
        ///     Handles the Click event of the ClearButton control. Clears the word text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonCancelOperation(object sender, EventArgs e)
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
        private void OnButtonClearSpellingList(object sender, EventArgs e)
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
        private void OnButtonClose(object sender, EventArgs e)
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
        ///     Handles the Click event of the CreateNewListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonCreateNewList(object sender, EventArgs e)
        {
            SpellingPropertiesClass.CreatingNewSpellingList = true;
            this.lstWords.Items.Clear();
            this.SetButtonsEnabledState_CreateNewListButtonClicked();
            this.ChangeControlsBackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the button DeleteList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonDeleteSpellingList(object sender, EventArgs e)
        {
            var className = this.GetType().Name;
            var methodName = MethodBase.GetCurrentMethod().Name;

            try
            {
                File.Delete(SpellingPropertiesClass.SpellingListPath);
                this.SetDeletePropertyStates();
            }
            catch (DirectoryNotFoundException ex)
            {
                var msg = ex.ToString();
                MyMessages.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (NotSupportedException ex)
            {
                var msg = ex.ToString();
                MyMessages.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (PathTooLongException ex)
            {
                var msg = ex.ToString();
                MyMessages.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (UnauthorizedAccessException ex)
            {
                var msg = ex.ToString();
                MyMessages.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (ArgumentException ex)
            {
                var msg = ex.ToString();
                MyMessages.ShowErrorMessageBox(msg, className, methodName);
            }
            catch (IOException ex)
            {
                var msg = ex.ToString();
                MyMessages.ShowErrorMessageBox(msg, className, methodName);
            }
        }

        /// <summary>
        ///     Handles the Click event of the DeleteSelectedWordButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonDeleteWord(object sender, EventArgs e)
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
        private void OnButtonEditWord(object sender, EventArgs e)
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
        private void OnButtonOpenSpellingList(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.ShowDialog();

                SpellingPropertiesClass.SpellingListPath = openDlg.FileName;

                this.lstWords.Items.Clear();

                if (!this.GetWordsFromFile())
                {
                    return;
                }

                this.SetButtonsEnabledState_OpenSpellingListButtonStateClicked();
                this.ChangeControlsBackgroundColors();
            }
        }

        /// <summary>
        ///     Handles the Click event of the SaveListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnButtonSaveSpellingList(object sender, EventArgs e)
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
        }

        /// <summary>
        ///     Handles the SelectedIndexChanged event of the WordsList control. Gets the item selected and places it in the
        ///     words text box for editing. Gets the item index so edit changes can be made in the words list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnWordsListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstWords.SelectedItem == null)
            {
                return;
            }

            this.cboWord.Text = this.lstWords.SelectedItem.ToString();
            SpellingPropertiesClass.SelectedWordIndex = this.lstWords.SelectedIndex;
            this.SetButtonsEnabledState_WordsListSelectedIndexChanges();
            this.ChangeControlsBackgroundColors();
        }

        /// <summary>
        ///     Saves the spelling words to spelling list.
        /// </summary>
        private void SaveSpellingWordsToSpellingList()
        {
            SpellingWordsCollection.ClearCollection();
            if (!this.AddWordsToCollection())
            {
                return;
            }

            if (!WriteWordsToFile(SpellingPropertiesClass.SpellingListPath))
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
            this.ChangeControlsBackgroundColors();
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
            this.lstWords.Items.Clear();
            this.SetButtonsEnabledState_DeleteSpellingListButtonClicked();
            this.ChangeControlsBackgroundColors();
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
            this.lstWords.Items.Clear();
            this.cboWord.Text = string.Empty;
            this.lstWords.Enabled = true;
            this.SetButtonsEnabledState_SaveSpellingListButtonStateClicked();
            this.ChangeControlsBackgroundColors();
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

        /// <summary>Sets the tab order cancel operation button.</summary>
        private void SetTabOrderCancelOperationButton()
        {
            this.btnAddNewWord.TabIndex = 0;
            this.btnSaveList.TabIndex = 1;
            this.btnClose.TabIndex = 2;
        }

        /// <summary>
        ///     Handles the Load event of the SpellingWordsList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void SpellingWordsList_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
            this.pnlWordList.BackColor = Color.SandyBrown;
            this.pnlWord.BackColor = Color.BurlyWood;
            this.SetButtonsEnabledState_FormLoadEvent();
            this.ChangeControlsBackgroundColors();
            SpellingPropertiesClass.SpellingListPath = string.Empty;

            this.formWidth = this.Width;
        }

        /// <summary>
        ///     Repositions the panel Words
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private void SpellingWordsListForm_Resize(object sender, EventArgs e)
        {
            // Initial placement of panel word at minimum form size.
            if (this.Width == this.formWidth)
            {
                this.pnlWord.Left = this.pnlWordList.Left;
                return;
            }

            // When form size is increased center panel word on panel word list.
            var width = this.pnlWordList.Width / 2;

            var left = width - this.pnlWord.Width / 2;

            this.pnlWord.Left = left;
        }
    }
}