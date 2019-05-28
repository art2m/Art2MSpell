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
        /// The name of directory to hold all files dealing with Art2mSpell.
        /// Except for Spelling list files.
        /// </summary>
        private const string Art2MSpellDirectoryName = "Art2MSpell";

        /// <summary>
        ///     The get spell it header so that we know spelling list is
        ///     used by Spell-It program.
        /// </summary>
        private const string Art2MSpellHeader = "Art2MSpell!!";

        private const string Art2MSpellUserListFileName = "Ar2mSpellUserList";

        /// <summary>Gets or sets a value indicating whether
        /// [Spelling list is a spell it spelling list].
        /// </summary>
        /// <value><c>true</c> if [spell it spelling list];
        /// otherwise, <c>false</c>.</value>
        public static bool Art2MSpellSpellingList { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether [creating new spelling list].
        /// </summary>
        /// <value><c>true</c> if [creating new spelling list]; otherwise, <c>false</c>.</value>
        public static bool CreatingNewSpellingList { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether [delete spelling list].
        /// </summary>
        /// <value><c>true</c> if [delete spelling list]; otherwise, <c>false</c>.</value>
        public static bool DeleteSpellingList { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether [editing spelling list].
        /// </summary>
        /// <value><c>true</c> if [editing spelling list]; otherwise, <c>false</c>.</value>
        public static bool EditingSpellingList { get; set; } = false;

        /// <summary>
        ///  Gets or sets a value indicating whether [first word is Art2MSpell header].
        /// </summary>
        public static bool FirstWordIsArt2MSpellHeader { get; set; } = false;

        /// <summary>
        /// Get the name of the top level directory Art2MSpell;
        /// </summary>
        public static string GetArt2MSpellDirectoryName => Art2MSpellDirectoryName;

        /// <summary>
        ///     returns the header for all spelling list used in Spell-It program.
        /// </summary>
        /// <value>
        ///     The get spell it header.
        /// </value>
        public static string GetArt2MSpellHeader => Art2MSpellHeader;

        /// <summary>
        /// Get The name of the user name list file.
        /// </summary>
        public static string GetArt2MSpellUserListFileName => Art2MSpellUserListFileName;

        /// <summary>Gets or sets a value indicating whether [opened spelling list].</summary>
        /// <value>
        ///   <c>true</c> if [opened spelling list]; otherwise, <c>false</c>.</value>
        public static bool OpenedSpellingList { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether [saving spelling list].
        /// </summary>
        /// <value><c>true</c> if [saving spelling list]; otherwise, <c>false</c>.</value>
        public static bool SavingSpellingList { get; set; } = false;

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

        /// <summary>
        /// Holds the name of the current user.
        /// </summary>
        public static string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Holds the name of the file that holds paths to all of the users spelling lists.
        /// </summary>
        public static string SpellingListPathsFileName { get; set; } = string.Empty;

        public static string AppDataDirectoryPath { get; set; } = string.Empty;

        public static string UserNameFilePath { get; set; } = string.Empty;
    }
}