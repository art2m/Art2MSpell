﻿// Art2MSpell
// 
// SpellingWordsListForm.AddWordsToListBox.cs
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
    using System.Collections.Generic;
    using System.Linq;
    using Classes;
    using Collections;

    /// <summary>
    /// List box operations.
    /// </summary>
    public partial class SpellingWordsListForm
    {
        /// <summary>
        ///     Add spelling words list from file to the list box.
        /// </summary>
        /// <param name="words"></param>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private void AddWordsToListBox(IReadOnlyCollection<string> words)
        {
            var word = cboWord.Text.Trim();

            if (string.IsNullOrEmpty(word))
            {
                SetButtonsEnabledState_AddToListButtonClicked();
                ChangeControlsBackgroundColors();

                return;
            }

            // Do not add word to list box if it all ready contains the word.
            if (CheckListBoxForWord(word))
            {
                SetAddingWordProperties();
                return;
            }

            // Validate word user is adding has correct spelling.
            if (!CheckWordSpelling(word)) return;

            // say word to validate to user word is being added to the list box.
            SpellingListClass.SpeakString(word);

            SetAddingWordProperties();

            SetButtonsEnabledState_AddToListButtonClicked();
            ChangeControlsBackgroundColors();
            SetTabOrderAddWordToList();
            SetTabOrderAddNewWordButton();
        }

        /// <summary>
        ///     add the word to spelling list box. add word user entered in combo box
        /// to the list box. 
        /// </summary>
        /// <param name="word">The word to be added.</param>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        private void AddWordToListBox()
        {
            var word = this.cboWord.Text.Trim();

            if (string.IsNullOrEmpty(word))
            {
                this.SetButtonsEnabledState_AddToListButtonClicked();
                this.ChangeControlsBackgroundColors();

                return;
            }

            // Do not add word to list box if it all ready contains the word.
            if (this.CheckListBoxForWord(word))
            {
                this.SetAddingWordProperties();
                return;
            }

            // Validate word user is adding has correct spelling.
            if (!this.CheckWordSpelling(word))
            {
                return;
            }

            // say word to validate to user word is being added to the list box.
            SpellingListClass.SpeakString(word);

            this.SetAddingWordProperties();

            this.SetButtonsEnabledState_AddToListButtonClicked();
            this.ChangeControlsBackgroundColors();
            this.SetTabOrderAddWordToList();
            this.SetTabOrderAddNewWordButton();
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
            // List<string> list = this.lstWords.Items.OfType<string>().ToList();

            if (this.lstWords.Items.Contains(word))
            {
                return true;
            }

            this.cboWord.Text = string.Empty;
            this.cboWord.Focus();
            return false;
        }

        /// <summary>
        ///     Fills the ListBox with words list.
        /// </summary>
        private void FillListBoxWithWordsList()
        {
            var swc = new SpellingWordsCollection();

            if (swc.ItemsCount() < 1)
            {
                return;
            }

            this.AddWordsToListBox();
        }
    }
}