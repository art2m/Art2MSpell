// Art2MSpell
// 
// PracticeSpellingWordsForm.BackgroundColor.cs
// 
// art2m
// 
// art2m@live.com
// 
// 05  13  2019
// 
// 05  09   2019
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
    using System.Drawing;

    public partial class PracticeSpellingWordsForm
    {
        /// <summary>
        ///     Sets the background color for the close button based on button state.
        /// </summary>
        private void SetCloseButton_BackgroundColor()
        {
            this.btnClose.BackColor = this.btnClose.Enabled ? Color.RosyBrown : Color.SlateGray;
        }


        /// <summary>
        ///     Sets the color of the next word button background.
        /// </summary>
        private void SetNextWordButton_BackgroundColor()
        {
            this.btnNextWord.BackColor = this.btnNextWord.Enabled ? Color.SkyBlue : Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the open spelling list button background.
        /// </summary>
        private void SetOpenSpellingListButton_BackgroundColor()
        {
            this.btnOpenList.BackColor = this.btnOpenList.Enabled ? Color.Aqua : Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the pause button background.
        /// </summary>
        private void SetPauseButton_BackgroundColor()
        {
            this.btnPause.BackColor = this.btnPause.Enabled ? Color.SkyBlue : Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the quit button background.
        /// </summary>
        private void SetQuitButton_BackgroundColor()
        {
            this.btnQuit.BackColor = this.btnQuit.Enabled ? Color.SkyBlue : Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the repeat word button background.
        /// </summary>
        private void SetRepeatWordButton_BackgroundColor()
        {
            this.btnRepeatWord.BackColor = this.btnRepeatWord.Enabled ? Color.SkyBlue : Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the score group box background.
        /// </summary>
        private void SetScoreGroupBox_BackgroundColor()
        {
            this.grpbxScore.BackColor = this.grpbxScore.Enabled ? Color.SteelBlue : Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the spelling words group box.
        /// </summary>
        private void SetSpellingWordsGroupBox_BackgroundColor()
        {
            this.grpbxSpellingWords.BackColor = this.grpbxSpellingWords.Enabled ? Color.Gold : Color.SlateGray;
        }

        /// <summary>
        ///     Sets the start color of the button background.
        /// </summary>
        private void SetStartButton_BackgroundColor()
        {
            this.btnStart.BackColor = this.btnStart.Enabled ? Color.SkyBlue : Color.SlateGray;
        }
    }
}