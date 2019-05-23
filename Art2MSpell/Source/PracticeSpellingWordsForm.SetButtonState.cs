// Art2MSpell
// 
// PracticeSpellingWordsForm.SetButtonState.cs
// 
// art2m
// 
// art2m@live.com
// 
// 05  09  2019
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
    /// <summary>Contains button state methods.</summary>
    public partial class PracticeSpellingWordsForm
    {
        /// <summary>
        ///     Sets the state of the close button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetCloseButtonState(bool stateVal)
        {
            this.btnClose.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the next word button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetNextWordButtonState(bool stateVal)
        {
            this.btnNextWord.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the open spelling list button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetOpenSpellingListButtonState(bool stateVal)
        {
            this.btnOpenList.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the open spelling list menu item.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetOpenSpellingListMenuItemState(bool stateVal)
        {
            this.mnuOpenSpellingList.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the pause button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetPauseButtonState(bool stateVal)
        {
            this.btnPause.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the quit button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetQuitButtonState(bool stateVal)
        {
            this.btnQuit.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the repeat word button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetRepeatWordButtonState(bool stateVal)
        {
            this.btnRepeatWord.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the score group box.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetScoreGroupBoxState(bool stateVal)
        {
            this.grpbxScore.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the start state of the button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetStartButtonState(bool stateVal)
        {
            this.btnStart.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the button enabled state open spelling list button clicked.
        /// </summary>
        private void SetButtonEnabledState_OpenSpellingListButtonClicked()
        {
            const bool StateVal = true;

            this.SetNextWordButtonState(!StateVal);
            this.SetOpenSpellingListButtonState(!StateVal);
            this.SetOpenSpellingListMenuItemState(!StateVal);
            this.SetPauseButtonState(!StateVal);
            this.SetQuitButtonState(!StateVal);
            this.SetRepeatWordButtonState(!StateVal);
            this.SetScoreGroupBoxState(StateVal);
            this.SetStartButtonState(StateVal);
        }

        /// <summary>
        ///     Sets the button enabled state start button clicked.
        /// </summary>
        private void SetButtonEnabledState_StartButtonClicked()
        {
            const bool StateVal = true;

            this.SetNextWordButtonState(StateVal);
            this.SetOpenSpellingListButtonState(!StateVal);
            this.SetOpenSpellingListMenuItemState(!StateVal);
            this.SetPauseButtonState(StateVal);
            this.SetQuitButtonState(StateVal);
            this.SetRepeatWordButtonState(StateVal);
            this.SetScoreGroupBoxState(StateVal);
            this.SetStartButtonState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state next word button clicked.
        /// </summary>
        private void SetButtonsEnabledState_NextWordButtonClicked()
        {
            const bool StateVal = true;

            this.SetNextWordButtonState(!StateVal);
            this.SetOpenSpellingListButtonState(!StateVal);
            this.SetOpenSpellingListMenuItemState(!StateVal);
            this.SetPauseButtonState(!StateVal);
            this.SetQuitButtonState(!StateVal);
            this.SetRepeatWordButtonState(!StateVal);
            this.SetStartButtonState(StateVal);

            this.SetScoreGroupBoxState(StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state pause button clicked.
        /// </summary>
        private void SetButtonsEnabledState_PauseButtonClicked()
        {
            const bool StateVal = true;

            if (this.paused)
            {
                this.SetNextWordButtonState(!StateVal);
                this.SetOpenSpellingListButtonState(!StateVal);
                this.SetOpenSpellingListMenuItemState(!StateVal);
                this.SetPauseButtonState(StateVal);
                this.SetQuitButtonState(!StateVal);
                this.SetRepeatWordButtonState(!StateVal);
            }
            else
            {
                this.SetNextWordButtonState(StateVal);
                this.SetOpenSpellingListButtonState(!StateVal);
                this.SetOpenSpellingListMenuItemState(!StateVal);
                this.SetPauseButtonState(StateVal);
                this.SetQuitButtonState(StateVal);
                this.SetRepeatWordButtonState(StateVal);
            }

            this.SetQuitButtonState(!StateVal);
            this.SetScoreGroupBoxState(!StateVal);
            this.SetStartButtonState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state quit button clicked.
        /// </summary>
        private void SetButtonsEnabledState_QuitButtonClicked()
        {
            const bool StateVal = true;

            this.SetNextWordButtonState(!StateVal);
            this.SetOpenSpellingListButtonState(!StateVal);
            this.SetOpenSpellingListMenuItemState(!StateVal);
            this.SetOpenSpellingListMenuItemState(StateVal);
            this.SetQuitButtonState(!StateVal);
            this.SetRepeatWordButtonState(!StateVal);
            this.SetScoreGroupBoxState(!StateVal);
            this.SetStartButtonState(!StateVal);
        }

        /// <summary>
        ///     Sets the menu enabled state open spelling menu item clicked.
        /// </summary>
        private void SetMenuEnabledState_OpenSpellingMenuItemClicked()
        {
            const bool StateVal = true;

            this.SetNextWordButtonState(!StateVal);
            this.SetOpenSpellingListButtonState(!StateVal);
            this.SetOpenSpellingListMenuItemState(!StateVal);
            this.SetQuitButtonState(!StateVal);
            this.SetRepeatWordButtonState(!StateVal);
            this.SetStartButtonState(!StateVal);
        }

        /// <summary>
        ///     Sets the state of the paused.
        /// </summary>
        private void SetPausedState()
        {
            // _paused = _paused ? !_paused : true;
            if (!this.paused)
            {
                this.paused = true;
            }
            else
            {
                this.paused = false;

                this.OnRepeatWordButtonClick(null, null);
            }
        }
    }
}