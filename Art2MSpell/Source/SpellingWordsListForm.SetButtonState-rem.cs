// Art2MSpell
//
// SpellingWordsListForm.SetButtonState.cs
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

namespace Art2MSpell.Source
{
    using Classes;

    /// <summary>This class is for setting button states.</summary>
    public partial class SpellingWordsListForm
    {
        #region Set Buttons Enabled State When Button Is Selected

        /// <summary>
        ///     Sets the buttons enabled state when the add to list butt0n is Selected.
        /// </summary>
        private void SetButtonsEnabledState_AddToListButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetDeleteButtonEnableState_AddToListButtonClicked();
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveButtonState_AddToListButtonClicked();
            this.SetSelectSpellingListButtonState(!StateVal);
            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state when the cancel operation button is selected.
        /// </summary>
        private void SetButtonsEnabledState_CancelOperationButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(!StateVal);

            this.SetDeleteListButtonState_CancelOperationButtonClicked();

            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);

            this.SetSaveListEnabledButtonState_CancelOperationButtonClick();

            this.SetSelectSpellingListButtonState(!StateVal);

            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state when the clear list button is selected.
        /// </summary>
        private void SetButtonsEnabledState_ClearListButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonState(!StateVal);
            this.SetSelectSpellingListButtonState(!StateVal);

            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state when the create new list button is selected.
        /// </summary>
        private void SetButtonsEnabledState_CreateNewListButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonState(!StateVal);
            this.SetSelectSpellingListButtonState(!StateVal);

            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state when the delete selected word button is selected.
        /// </summary>
        private void SetButtonsEnabledState_DeleteSelectedWordButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonEnabledState_DeleteSelectedWordButtonClicked();
            this.SetSelectSpellingListButtonState(!StateVal);
            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state when the delete spelling list button is selected.
        /// </summary>
        private void SetButtonsEnabledState_DeleteSpellingListButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(!StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.OnDeleteSpellingListButtonClickedSetSaveListButtonEnabledState();
            this.SetSelectSpellingListButtonState(StateVal);
            this.SetWordsListBoxState(!StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state when the edit item button is selected.
        /// </summary>
        private void SetButtonsEnabledState_EditItemButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(!StateVal);
            this.SetAddToListButtonState(StateVal);
            this.SetCancelOperationButtonState(StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonState(!StateVal);
            this.SetSelectSpellingListButtonState(!StateVal);
            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(StateVal);
        }

        /// <summary>
        ///     Sets the state of the Buttons when form is loading.
        /// </summary>
        private void SetButtonsEnabledState_FormLoadEvent()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(!StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCloseButtonState(StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetCreateNewListButtonState(StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonState(!StateVal);
            this.SetSelectSpellingListButtonState(StateVal);
            this.SetWordsListBoxState(!StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state When the open spelling list button is selected.
        /// </summary>
        private void SetButtonsEnabledState_OpenSpellingListButtonStateClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonState(!StateVal);
            this.SetSelectSpellingListButtonState(StateVal);
            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state When saving spelling list button is selected.
        /// </summary>
        private void SetButtonsEnabledState_SaveSpellingListButtonStateClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(!StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCloseButtonState(StateVal);
            this.SetCreateNewListButtonState(StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonState(!StateVal);
            this.SetSelectSpellingListButtonState(StateVal);
            this.SetWordsListBoxState(!StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the buttons enabled state when selected index changed.
        /// </summary>
        private void SetButtonsEnabledState_WordsListSelectedIndexChanges()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(!StateVal);
            this.SetAddToListButtonState(!StateVal);
            this.SetCancelOperationButtonState(!StateVal);
            this.SetClearListButtonState_WordsListSelectedIndexChanged();
            this.SetCloseButtonState(StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetDeleteSelectedWordButtonState(StateVal);
            this.SetDeleteSpellingListButtonEnabledState_WordsListSelectedIndexChanges();
            this.SetEditItemButtonState(StateVal);
            this.SetSaveListButtonState(!StateVal);
            this.SetWordsListBoxState(!StateVal);
            this.SetWordsTextBoxState(!StateVal);
        }

        /// <summary>
        ///     Sets the clear list button state when the words list selected index changes.
        /// </summary>
        private void SetClearListButtonState_WordsListSelectedIndexChanged()
        {
            if (SpellingPropertiesClass.SpellingListIsDirty)
            {
                this.SetClearListButtonState(false);
                return;
            }

            this.SetClearListButtonState(true);
        }

        /// <summary>
        ///     Sets the create new spelling list button enabled state when cancel operation button clicked.
        /// </summary>
        private void SetButtonEnabledStat_CancelButtonClicked()
        {
            if (SpellingPropertiesClass.CreatingNewSpellingList)
            {
                this.SetDeleteSpellingListButtonState(false);
            }
        }

        /// <summary>
        ///     Sets the buttons enabled state when add new item button is selected.
        /// </summary>
        private void SetButtonsEnabledState_AddNewButtonClicked()
        {
            const bool StateVal = true;

            this.SetAddNewItemButtonState(!StateVal);
            this.SetAddToListButtonState(StateVal);
            this.SetCancelOperationButtonState(StateVal);
            this.SetClearListButtonState(!StateVal);
            this.SetCreateNewListButtonState(!StateVal);
            this.SetDeleteSelectedWordButtonState(!StateVal);
            this.SetDeleteSpellingListButtonState(!StateVal);
            this.SetEditItemButtonState(!StateVal);
            this.SetSaveListButtonEnabledState_AddNewButtonClicked();
            this.SetSelectSpellingListButtonState(!StateVal);
            this.SetWordsListBoxState(StateVal);
            this.SetWordsTextBoxState(StateVal);
        }

        /// <summary>
        ///     Sets the delete button enable state when the add to list button is selected.
        /// </summary>
        private void SetDeleteButtonEnableState_AddToListButtonClicked()
        {
            if (SpellingPropertiesClass.SpellingListIsDirty)
            {
                this.SetDeleteSpellingListButtonState(true);
                return;
            }

            this.SetDeleteSpellingListButtonState(false);
        }

        /// <summary>
        ///     Sets the delete list button state when cancel operation button is selected.
        /// </summary>
        private void SetDeleteListButtonState_CancelOperationButtonClicked()
        {
            this.SetDeleteSpellingListButtonEnabledState_CancelOperationButtonClicked();

            this.SetButtonEnabledStat_CancelButtonClicked();

            this.SetDeleteSpellingListButtonState(true);
        }

        /// <summary>
        ///     Sets the delete spelling list button enabled state when cancel operation button is selected.
        /// </summary>
        private void SetDeleteSpellingListButtonEnabledState_CancelOperationButtonClicked()
        {
            if (SpellingPropertiesClass.SpellingListIsDirty)
            {
                this.SetDeleteSpellingListButtonState(false);
            }
        }

        /// <summary>
        ///     Sets the delete spelling list button enabled state when the words list selected index changes.
        /// </summary>
        private void SetDeleteSpellingListButtonEnabledState_WordsListSelectedIndexChanges()
        {
            if (SpellingPropertiesClass.SpellingListIsDirty)
            {
                this.SetDeleteSpellingListButtonState(false);
                return;
            }

            this.SetDeleteSpellingListButtonState(true);
        }

        /// <summary>
        ///     Sets the save button state when add to list button is selected.
        /// </summary>
        private void SetSaveButtonState_AddToListButtonClicked()
        {
            if (this.lstWords.Items.Count > 0)
            {
                this.SetSaveListButtonState(true);
                return;
            }

            this.SetSaveListButtonState(false);
        }

        /// <summary>
        ///     Sets the save list button state add new button clicked.
        /// </summary>
        private void SetSaveListButtonEnabledState_AddNewButtonClicked()
        {
            if (SpellingPropertiesClass.SpellingListIsDirty)
            {
                this.SetSaveListButtonState(true);
                return;
            }

            this.SetSaveListButtonState(false);
        }

        /// <summary>
        ///     Sets the save list button enabled state when delete selected word button selected.
        /// </summary>
        private void SetSaveListButtonEnabledState_DeleteSelectedWordButtonClicked()
        {
            if (this.lstWords.Items.Count > 0)
            {
                this.SetSaveListButtonState(true);
                return;
            }

            this.SetSaveListButtonState(false);
        }

        /// <summary>
        ///     Sets the save list button enabled state when delete spelling list button selected.
        /// </summary>
        private void OnDeleteSpellingListButtonClickedSetSaveListButtonEnabledState()
        {
            if (this.lstWords.Items.Count > 0)
            {
                this.SetSaveListButtonState(true);
                return;
            }

            this.SetSaveListButtonState(false);
        }

        /// <summary>
        ///     Sets the save list enabled button state when cancel operation button selected.
        /// </summary>
        private void SetSaveListEnabledButtonState_CancelOperationButtonClick()
        {
            if (this.lstWords.Items.Count > 0 && SpellingPropertiesClass.SpellingListIsDirty)
            {
                this.SetSaveListButtonState(true);
                return;
            }

            this.SetSaveListButtonState(false);
        }

        #endregion Set Buttons Enabled State When Button Is Selected

        #region Set Enabled State Of Each Individual Control

        /// <summary>
        ///     Sets the state of the add new item button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetAddNewItemButtonState(bool stateVal)
        {
            this.btnAddNewWord.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the add to list button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetAddToListButtonState(bool stateVal)
        {
            this.btnAddWordToList.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the clear item button click.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetCancelOperationButtonState(bool stateVal)
        {
            this.btnCancelOperation.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the clear list button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetClearListButtonState(bool stateVal)
        {
            this.btnClearist.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the close button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetCloseButtonState(bool stateVal)
        {
            this.btnClose.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the create new list button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetCreateNewListButtonState(bool stateVal)
        {
            this.btnCreateNewList.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the delete selected word button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetDeleteSelectedWordButtonState(bool stateVal)
        {
            this.btnDeleteWord.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the delete spelling list button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetDeleteSpellingListButtonState(bool stateVal)
        {
            this.btnDeleteList.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the edit button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetEditItemButtonState(bool stateVal)
        {
            this.btnEditWord.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the save list button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetSaveListButtonState(bool stateVal)
        {
            this.btnSaveList.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the select spelling list button.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetSelectSpellingListButtonState(bool stateVal)
        {
            this.btnOpenist.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the words ListBox.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [value].</param>
        private void SetWordsListBoxState(bool stateVal)
        {
            this.lstWords.Enabled = stateVal;
        }

        /// <summary>
        ///     Sets the state of the words text box.
        /// </summary>
        /// <param name="stateVal">if set to <c>true</c> [state value].</param>
        private void SetWordsTextBoxState(bool stateVal)
        {
            this.cboWord.Enabled = stateVal;
        }

        #endregion Set Enabled State Of Each Individual Control
    }
}