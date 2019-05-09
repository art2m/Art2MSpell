﻿// Art2MSpell
//
// SpellingWordsListForm.SetBackgroundColor.cs
//
// art2m
//
// art2m@live.com
//
// 05  08  2019
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

using System.Drawing;

namespace Art2MSpell.Source
{
    /// <summary>Create new spelling list. Edit existing spelling list.</summary>
    public partial class SpellingWordsListForm
    {
        /// <summary>Sets the color of the buttons when add new item button is clicked.</summary>
        private void SetAddNewItemButtonClickedBackgroundColor()
        {
            this.SetAddNewItemButton_BackgroundColor();
            this.SetAddToListButton_BackgroundColor();
            this.SetCancelOperationButton_BackgroundColor();
            this.SetClearListButton_BackgroundColor();
            this.SetClearListButton_BackgroundColor();
            this.SetDeleteSelectedWord_BackgroundColor();
            this.SetEditItemButton_BackgroundColor();
            this.SetSaveListButton_BackgroundColor();
            this.SetWordsTextBoxState(false);
            this.SetWordTextBox_BackgroundColor();
        }

        /// <summary>
        ///     Sets the background color for the add button based on button state.
        /// </summary>
        private void SetAddNewItemButton_BackgroundColor()
        {
            if (this.btnAddNewWord.Enabled)
            {
                this.btnAddNewWord.BackColor = Color.MediumAquamarine;
                return;
            }

            this.btnAddNewWord.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the add to list button background.
        /// </summary>
        private void SetAddToListButton_BackgroundColor()
        {
            if (this.btnAddWordToList.Enabled)
            {
                this.btnAddWordToList.BackColor = Color.LimeGreen;
                return;
            }

            this.btnAddWordToList.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the background color for the clear button based on button state.
        /// </summary>
        private void SetCancelOperationButton_BackgroundColor()
        {
            if (this.btnCancelOperation.Enabled)
            {
                this.btnCancelOperation.BackColor = Color.Cyan;
                return;
            }

            this.btnCancelOperation.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the state of the clear list button background color.
        /// </summary>
        private void SetClearListButton_BackgroundColor()
        {
            if (this.btnClearist.Enabled)
            {
                this.btnClearist.BackColor = Color.Cyan;
                return;
            }

            this.btnClearist.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the background color for the close button based on button state.
        /// </summary>
        private void SetCloseButton_BackgroundColor()
        {
            if (this.btnClose.Enabled)
            {
                this.btnClose.BackColor = Color.RosyBrown;
                return;
            }

            this.btnClose.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the background color for the create new list button based on button state.
        /// </summary>
        private void SetCreateNewListButton_BackgroundColor()
        {
            if (this.btnCreateNewList.Enabled)
            {
                this.btnCreateNewList.BackColor = Color.Gold;
                return;
            }

            this.btnCreateNewList.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the background color for the delete list button based on button state.
        /// </summary>
        private void SetDeleteListButton_BackgroundColor()
        {
            if (this.btnDeleteList.Enabled)
            {
                this.btnDeleteList.BackColor = Color.OrangeRed;
                return;
            }

            this.btnDeleteList.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the background color for the delete selected word button based on button state.
        /// </summary>
        private void SetDeleteSelectedWord_BackgroundColor()
        {
            if (this.btnDeleteWord.Enabled)
            {
                this.btnDeleteWord.BackColor = Color.OrangeRed;
                return;
            }

            this.btnDeleteWord.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the color of the edit item button background.
        /// </summary>
        private void SetEditItemButton_BackgroundColor()
        {
            if (this.btnEditWord.Enabled)
            {
                this.btnEditWord.BackColor = Color.Coral;
                return;
            }

            this.btnEditWord.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the state of the save list button background color for.
        /// </summary>
        private void SetSaveListButton_BackgroundColor()
        {
            if (this.btnSaveList.Enabled)
            {
                this.btnSaveList.BackColor = Color.LimeGreen;
                return;
            }

            this.btnSaveList.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the background color for the select spelling list button based on the state.
        /// </summary>
        private void SetSelectSpellingListButton_BackgroundColor()
        {
            if (this.btnOpenist.Enabled)
            {
                this.btnOpenist.BackColor = Color.Aqua;
                return;
            }

            this.btnOpenist.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the state of the words ListBox background color.
        /// </summary>
        private void SetWordsListBox_BackgroundColor()
        {
            if (this.lstWordsList.Enabled)
            {
                this.lstWordsList.BackColor = Color.LightYellow;
                return;
            }

            this.lstWordsList.BackColor = Color.SlateGray;
        }

        /// <summary>
        ///     Sets the state of the word text box background color.
        /// </summary>
        private void SetWordTextBox_BackgroundColor()
        {
            if (this.cboWord.Enabled)
            {
                this.cboWord.BackColor = Color.LightYellow;
                return;
            }

            this.cboWord.BackColor = Color.SlateGray;
        }
    }
}