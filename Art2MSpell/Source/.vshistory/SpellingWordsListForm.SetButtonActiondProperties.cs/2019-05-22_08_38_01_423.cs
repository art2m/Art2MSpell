// Art2MSpell
// 
// SpellingWordsListForm.SetButtonActiondProperties.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  22  2019
// 
// 05  17   2019
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
    #region

    using Classes;

    #endregion

    /// <summary>
    /// Set properties for controls based on what button is selected.
    /// </summary>
    public partial class SpellingWordsListForm
    {
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
            SpellingPropertiesClass.OpenedSpellingList = false;
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
            SpellingPropertiesClass.OpenedSpellingList = false;
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
    }
}