﻿// Art2MSpell
// 
// PracticeSpellingWordsForm.cs
// 
// art2m
// 
// art2m@live.com
// 
// 05  09  2019
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
    using System.Speech.Synthesis;
    using System.Text;
    using System.Windows.Forms;
    using Classes;
    using Collections;

    /// <summary>Displays form for creating and editing spelling lists.</summary>
    public partial class PracticeSpellingWordsForm : Form
    {
        /// <summary>
        ///     The number of words spelled correctly.
        /// </summary>
        private int correct;

        /// <summary>
        ///     Current index of the spelling words collection.
        /// </summary>
        private int index;

        /// <summary>
        ///     The paused
        /// </summary>
        private bool paused;

        /// <summary>
        ///     The number of words spelled incorrectly.
        /// </summary>
        private int wrong;

        /// <summary>Initializes a new instance of the <see cref="PracticeSpellingWordsForm" /> class.</summary>
        public PracticeSpellingWordsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>Gets the spelling words from spelling list.</summary>
        /// <returns>True if spelling list files is read into the collection else false,</returns>
        private static bool GetSpellingWordsFromSpellingList()
        {
            return SpellingListsClass.ReadSpellingWordsToCollection(SpellingPropertiesClass.SpellingListPath);
        }

        /// <summary>
        ///     Says the spelling word.
        /// </summary>
        /// <param name="word">The word to be asked for spelling.</param>
        private static void SaySpellingWord(string word)
        {
            using (var synth = new SpeechSynthesizer())
            {
                synth.Speak(word);
            }
        }

        /// <summary>
        ///     Sets the color of the buttons background.
        /// </summary>
        private void ChangeControls_BackgroundColors()
        {
            this.SetCloseButton_BackgroundColor();

            if (this.pnlDisplay != null)
            {
                this.SetDisplayPanel_BackgroundColor();
            }

            this.SetNextWordButton_BackgroundColor();
            this.SetOpenSpellingListButton_BackgroundColor();
            this.SetPauseButton_BackgroundColor();
            this.SetQuitButton_BackgroundColor();
            this.SetRepeatWordButton_BackgroundColor();
            this.SetScoreGroupBox_BackgroundColor();
            this.SetSpellingWordsGroupBox_BackgroundColor();
            this.SetSpellingWordsGroupBox_BackgroundColor();
            this.SetStartButton_BackgroundColor();
        }

        /// <summary>
        ///     Checks the word spelling.
        /// </summary>
        private void CheckWordSpelling()
        {
            var word = this.txtSpellWord.Text.Trim();

            var sb = new StringBuilder();

            if (SpellingListsClass.CheckUserEnteredSpellingWord(word))
            {
                this.correct++;

                sb.Append("Your spelling of the word ");
                sb.Append(word);
                sb.AppendLine(" is correct.");
            }
            else
            {
                this.wrong++;

                sb.Append("Your spelling of the word ");
                sb.Append(word);
                sb.AppendLine(" is wrong.");
            }

            this.ShowWordsScore();

            SaySpellingWord(sb.ToString());
        }

        /// <summary>
        ///     Handles the Click event of the CloseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     Handles the Click event of the CloseMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     Handles the Click event of the Next Word Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnNextWordButtonClick(object sender, EventArgs e)
        {
            this.txtSpellWord.Focus();

            if (string.IsNullOrEmpty(this.txtSpellWord.Text.Trim()))
            {
                this.OnRepeatWordButtonClick(null, null);
                return;
            }

            this.CheckWordSpelling();

            this.txtSpellWord.Text = string.Empty;
            this.ChangeControls_BackgroundColors();
            this.ShowWordsScore();

            this.index++;

            if (this.index == SpellingWordsCollection.ItemsCount())
            {
                return;
            }

            var word = SpellingWordsCollection.GetItemAt(this.index);

            SaySpellingWord(word);

            this.txtSpellWord.Text = string.Empty;

            // btnNextWord.Enabled = true;
        }

        /// <summary>
        ///     Handles the Click event of the OpenSpellingListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnOpenSpellingListButtonClick(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.ShowDialog();

                SpellingPropertiesClass.SpellingListPath = openDlg.FileName;

                if (!GetSpellingWordsFromSpellingList())
                {
                    return;
                }
            }

            this.SetButtonEnabledState_OpenSpellingListButtonClicked();

            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the OpenSpellingListMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnOpenSpellingListMenuItemClick(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.ShowDialog();

                SpellingPropertiesClass.SpellingListPath = openDlg.FileName;

                if (!GetSpellingWordsFromSpellingList())
                {
                    return;
                }
            }

            this.SetButtonEnabledState_OpenSpellingListButtonClicked();

            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the PauseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnPauseButtonClick(object sender, EventArgs e)
        {
            this.SetPausedState();

            this.SetButtonsEnabledState_PauseButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the QuitButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnQuitButtonClick(object sender, EventArgs e)
        {
            SpellingWordsCollection.ClearCollection();
            this.index = 0;
            SpellingPropertiesClass.OpeningSpellingList = false;
            SpellingPropertiesClass.SpellingListPath = string.Empty;
            this.SetButtonsEnabledState_QuitButtonClicked();
            this.ChangeControls_BackgroundColors();
        }

        /// <summary>
        ///     Handles the Click event of the Repeat Word Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnRepeatWordButtonClick(object sender, EventArgs e)
        {
            this.txtSpellWord.Focus();

            this.index--;

            var word = SpellingWordsCollection.GetItemAt(this.index);
            SaySpellingWord(word);

            this.txtSpellWord.Focus();

            this.txtSpellWord.Text = string.Empty;

            this.index++;
        }

        /// <summary>
        ///     Handles the Click event of the StartButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnStartButtonClick(object sender, EventArgs e)
        {
            this.index = 0;
            this.correct = 0;
            this.wrong = 0;

            this.txtSpellWord.Focus();

            this.SetButtonEnabledState_StartButtonClicked();
            this.ChangeControls_BackgroundColors();

            var word = SpellingWordsCollection.GetItemAt(this.index);
            SaySpellingWord(word);
        }

        /// <summary>
        ///     Sets the state of the Buttons when form is loading.
        /// </summary>
        private void SetControlsEnabledState_FormLoadEvent()
        {
            const bool StateVal = true;

            this.SetCloseButtonState(StateVal);
            this.SetSpellingWordGroupBoxState(!StateVal);
            this.SetOpenSpellingListButtonState(StateVal);
            this.SetNextWordButtonState(!StateVal);
            this.SetRepeatWordButtonState(!StateVal);
            this.SetScoreGroupBoxState(!StateVal);
        }

        /// <summary>
        ///     Shows the number of words spelled correctly and the number spelled incorrectly.
        /// </summary>
        private void ShowWordsScore()
        {
            this.txtWordsCount.Text = FormattableString.Invariant($"{this.index}");

            this.txtWordsCorrect.Text = FormattableString.Invariant($"{this.correct}");

            this.txtWordsWrong.Text = FormattableString.Invariant($"{this.wrong}");
        }

        /// <summary>
        ///     Handles the Load event of the SpellingListDisplayForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SpellingListDisplayForm_Load(object sender, EventArgs e)
        {
            this.index = 0;

            SpellingPropertiesClass.SpellingListPath = string.Empty;
            SpellingPropertiesClass.OpeningSpellingList = false;

            this.SetControlsEnabledState_FormLoadEvent();

            this.ChangeControls_BackgroundColors();

            SpellingPropertiesClass.SpellingListPath = string.Empty;
        }
    }
}