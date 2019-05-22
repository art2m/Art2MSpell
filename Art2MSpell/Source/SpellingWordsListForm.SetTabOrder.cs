// Art2MSpell
// 
// SpellingWordsListForm.SetTabOrder.cs
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
    /// <summary>
    /// Set tab order when buttons are selected.
    /// </summary>
    public partial class SpellingWordsListForm
    {
        /// <summary>
        ///     Set tab order when user selects Add New Word Button.
        /// </summary>
        private void SetTabOrderAddNewWordButton()
        {
            this.flpBottomPanel.Focus();
            this.btnAddWordToList.TabIndex = 0;
            this.btnCancelOperation.TabIndex = 1;
            this.btnSaveList.TabIndex = 2;
            this.btnClose.TabIndex = 3;
        }

        /// <summary>
        /// Set tab order when user selects add word to list.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void SetTabOrderAddWordToList()
        {
            this.flpBottomPanel.Focus();
            this.btnAddNewWord.TabIndex = 0;
            this.btnCancelOperation.TabIndex = 1;
            this.btnSaveList.TabIndex = 2;
            this.btnClose.TabIndex = 3;
        }

        /// <summary>
        /// Sets the tab order cancel operation button.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void SetTabOrderCancelOperationButton()
        {
            this.flpBottomPanel.Focus();
            this.btnAddNewWord.TabIndex = 0;
            this.btnSaveList.TabIndex = 1;
            this.btnClose.TabIndex = 2;
        }

        /// <summary>
        /// Set tab order on form load.
        /// </summary>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        private void SetTabOrderFormLoad()
        {
            this.flpLeftPanel.Focus();
            this.btnCreateNewList.TabIndex = 0;
            this.btnOpenist.TabIndex = 1;
            this.btnClose.TabIndex = 2;
        }
    }
}