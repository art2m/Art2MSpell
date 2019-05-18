// Art2MSpell
// 
// SpellingWordsListForm.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  15  2019
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
        /// <summary>Holds the initial with of the form.</summary>
        private readonly int formWidth;

        /// <summary>Holds items from list box so they can be checked against word to be added for duplicate.</summary>
        private List<string> duplicate;

        /// <summary>Initializes a new instance of the <see cref="SpellingWordsListForm" /> class.</summary>
        public SpellingWordsListForm()
        {
            this.InitializeComponent();
            this.BackColor = Color.PaleGoldenrod;
            this.SetButtonsEnabledState_FormLoadEvent();
            this.ChangeControlsBackgroundColors();
            SpellingPropertiesClass.SpellingListPath = string.Empty;
            this.SetTabOrderFormLoad();
            this.formWidth = this.Width;

            // TODO: Add Save And Get spelling list paths!
            // TODO: Add collection for words spelled wrong. So they can respell wrong!
            // TODO: Add menu items for opening, creating new spelling list., user saved spelling lists.
        }

        /// <summary>
        ///     Read header from file validate is real spelling file.
        /// </summary>
        /// <returns>True if valid spelling file else false.</returns>
        /// <returns>True if valid spelling file else false.</returns>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private static bool ReadHeader()
        {
            if (!SpellingReadWriteClass.ReadHeader(SpellingPropertiesClass.SpellingListPath))
            {
                SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = false;
                SpellingPropertiesClass.Art2MSpellSpellingList = false;
                return false;
            }

            SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = true;
            SpellingPropertiesClass.Art2MSpellSpellingList = true;
            return true;
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
            if (!SpellingReadWriteClass.WriteToFile(filePath))
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
            this.cboWord.Items.Clear();
            for (var index = 0; index < DictionaryWordscollection.ItemsCount(); index++)
            {
                this.cboWord.Items.Add(DictionaryWordscollection.GetItemAt(index));
            }

            DictionaryWordscollection.ClearCollection();
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
        ///     Check the spelling word user has entered.
        /// </summary>
        /// <param name="word">The word to be checked for spelling.</param>
        /// <returns>True if word is correct else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private bool CheckWordSpelling(string word)
        {
            if (SpellingListClass.CheckWordSpelling(word))
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
        /// Create new spelling list for entering a new list of spelling words.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void CreateNewSpellingList()
        {
            SpellingPropertiesClass.CreatingNewSpellingList = true;
            SpellingPropertiesClass.OpenedSpellingList = false;
            this.lstWords.Items.Clear();
            this.SetButtonsEnabledState_CreateNewListButtonClicked();
            this.ChangeControlsBackgroundColors();
            this.SetTabOrderAddNewWordButton();
        }

        private void GetUserName()
        {
            // TODO: Get the user name so it can preface users saved spelling list.
            // TODO:  Make user sign in screen so I know who's  spelling list to show.
            // TODO: Save list of users name so user can select name on sign in or add new user.
        }

        /// <summary>
        ///     Get spelling words from file and place into collection for editing.
        /// </summary>
        /// <returns>true if words added to the collection else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private bool GetWordsFromFile()
        {
            if (!ReadHeader())
            {
                return false;
            }

            if (!SpellingReadWriteClass.ReadFile(SpellingPropertiesClass.SpellingListPath))
            {
                return false;
            }

            this.FillListBoxWithWordsList();
            return true;
        }

        /// <summary>
        /// Call method create new spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void MenuSpellNewSpellingList_Click(object sender, EventArgs e)
        {
            this.CreateNewSpellingList();
        }

        /// <summary>
        /// Call method to create new spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void OnButtonCreateNewSpellingList_Click(object sender, EventArgs e)
        {
            this.CreateNewSpellingList();
        }

        /// <summary>
        ///     Opens user selected spelling list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing event data.</param>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void OnMenuSpellOpenSpellingList_Click(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.ShowDialog();
                SpellingPropertiesClass.SpellingListPath = openDlg.FileName;
                SpellingPropertiesClass.OpenedSpellingList = true;
                SpellingPropertiesClass.CreatingNewSpellingList = false;
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
        /// Open spelling list so user can edit the list or delete the list.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void OpenSpellingList()
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.ShowDialog();

                SpellingPropertiesClass.SpellingListPath = openDlg.FileName;
                SpellingPropertiesClass.OpenedSpellingList = true;
                SpellingPropertiesClass.CreatingNewSpellingList = false;

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
        ///     Resize controls for form size change.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/15/2019</created>
        /// <changed>art2m,5/15/2019</changed>
        private void SpellingWordsListForm_Resize(object sender, EventArgs e)
        {
            this.lstWords.Left = (this.ClientSize.Width - this.lstWords.Width) / 2;
            this.flpBottomPanel.Top = this.cboWord.Top + 32;
            var pos = this.flpLeftPanel.Height + this.cboWord.Height + this.flpBottomPanel.Height;
            this.flpLeftPanel.Top = (this.ClientSize.Height - pos) / 2;
            this.flpBottomPanel.Left = (this.ClientSize.Width - this.flpBottomPanel.Width) / 2;
            pos = this.lstWords.Left - this.flpLeftPanel.Width;
            this.flpLeftPanel.Left = pos - 10;
            this.cboWord.Left = this.lstWords.Left;
        }
    }
}