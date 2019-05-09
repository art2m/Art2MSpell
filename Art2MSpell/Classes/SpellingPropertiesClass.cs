//---------------------------------------------------------------------------------------------------------------
// Spell-It
//
// SpellingPropertiesClass.cs
//
// File:     Spell-It.sln
// Author:   art2m_000]
// Company:
// Date:     9/1/2018
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//----------------------------------------------------------------------------------------------------------------

namespace Art2MSpell.Classes
{
    /// <summary>
    /// Holds properties for spelling program.
    /// </summary>
    public static class SpellingPropertiesClass
    {
        /// <summary>
        ///     The get spell it header so that we know spelling list is
        ///     used by Spell-It program.
        /// </summary>
        private const string art2MSpellHeader = "Art2MSpell!!";

        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether [Spelling list is a spell it spelling list].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [spell it spelling list]; otherwise, <c>false</c>.
        /// </value>
        public static bool Art2MSpellSpellingList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [creating new spelling list].
        /// </summary>
        /// <value><c>true</c> if [creating new spelling list]; otherwise, <c>false</c>.</value>
        public static bool CreatingNewSpellingList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [delete spelling list].
        /// </summary>
        /// <value><c>true</c> if [delete spelling list]; otherwise, <c>false</c>.</value>
        public static bool DeleteSpellingList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [editing spelling list].
        /// </summary>
        /// <value><c>true</c> if [editing spelling list]; otherwise, <c>false</c>.</value>
        public static bool EditingSpellingList { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether [first word is Art2MSpell header].
        /// </summary>
        public static bool FirstWordIsArt2MSpellHeader { get; set; }

        /// <summary>
        ///     returns the header for all spelling list used in Spell-It program.
        /// </summary>
        /// <value>
        ///     The get spell it header.
        /// </value>
        public static string GetArt2MSpellHeader => art2MSpellHeader;

        /// <summary>
        /// Gets or sets a value indicating whether [opening spelling list].
        /// </summary>
        /// <value><c>true</c> if [opening spelling list]; otherwise, <c>false</c>.</value>
        public static bool OpeningSpellingList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [saving spelling list].
        /// </summary>
        /// <value><c>true</c> if [saving spelling list]; otherwise, <c>false</c>.</value>
        public static bool SavingSpellingList { get; set; }

        /// <summary>
        /// Gets or sets the index of the selected word.
        /// </summary>
        /// <value>The index of the selected word.</value>
        public static int SelectedWordIndex { get; set; } = -1;

        /// <summary>
        /// Gets or sets a value indicating whether [spelling list is dirty].
        /// </summary>
        /// <value><c>true</c> if [spelling list is dirty]; otherwise, <c>false</c>.</value>
        public static bool SpellingListIsDirty { get; set; }

        /// <summary>
        /// Gets or sets the spelling list path.
        /// </summary>
        /// <value>The spelling list path.</value>
        public static string SpellingListPath { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the spelling word text box value.
        /// </summary>
        /// <value>The spelling word text box value.</value>
        public static string SpellingWordTextBoxValue { get; set; } = string.Empty;

        #endregion Public Properties
    }
}