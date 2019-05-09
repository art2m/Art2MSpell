using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using JetBrains.Annotations;

namespace Art2MSpell.Classes
{
    /// <summary>
    ///     Validates data.
    /// </summary>
    public static class Validation
    {
        #region Private Fields

        /// <summary>
        ///     The first string in the spelling list. Means if exists that the spelling list is a Spell-It list.
        /// </summary>
        private const string spelling = "Art2mSpell!!";

        #endregion Private Fields

        #region Public Methods

        /// <summary>
        ///     Validates is spelling list bu checking that there is only
        ///     one <paramref name="word" /> on each line of the text file.
        /// </summary>
        /// <param name="word">
        ///     The value.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />. true if only one word per line else false.
        /// </returns>
        public static bool ValidateIsSpellingList([NotNull] string word)
        {
            Contract.Requires(!string.IsNullOrEmpty(word));

            if (word == null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            if (!ValidateStringValueNotEmptyNotWhiteSpace(word))
            {
                return false;
            }

            return ValidateSpellingWord(word);
        }

        /// <summary>
        ///     Checks the spelling <paramref name="word" /> for letters only.
        /// </summary>
        /// <param name="word">
        ///     The value.
        /// </param>
        /// <returns>
        ///     true if letters only else false.
        /// </returns>
        public static bool ValidateSpellingWordHasLettersOnly([NotNull] string word)
        {
            Contract.Requires(!string.IsNullOrEmpty(word));

            var caption = MethodBase.GetCurrentMethod().Name;

            foreach (var letter in word)
            {
                var msg = "Invalid character in value:  " + letter;

                if (char.IsLetter(letter))
                {
                    continue;
                }

                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        /// <summary>
        ///     Validates the string <paramref name="value" /> is not empty and not white space.
        /// </summary>
        /// <param name="value">
        ///     The value.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />. true if string is not empty. found else false.
        /// </returns>
        public static bool ValidateStringValueNotEmptyNotWhiteSpace([NotNull] string value)
        {
            value = value.Trim();

            return value.Length != 0;
        }

        /// <summary>
        ///     Validates it is spelling list.
        /// </summary>
        /// <param name="word">The <paramref name="word" />.</param>
        /// <returns>true if spelling list else false</returns>
        /// <exception cref="ArgumentNullException">If word is null</exception>
        public static bool ValidateThisIsArt2MSpellSpellingList([NotNull] string word)
        {
            Contract.Requires(!string.IsNullOrEmpty(word));

            if (word == null)
            {
                const string Msg = "The file path can not be null";
                throw new ArgumentNullException(nameof(word), Msg);
            }

            if (!ValidateStringValueNotEmptyNotWhiteSpace(word))
            {
                return false;
            }

            SpellingPropertiesClass.Art2MSpellSpellingList = word.Equals(spelling);

            return SpellingPropertiesClass.Art2MSpellSpellingList;
        }

        /// <summary>
        ///     Checks for invalid characters file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns><see langword="true" /> if invalid characters found else false.</returns>
        private static bool CheckForInvalidCharactersFilePath([NotNull] string filePath)
        {
            Contract.Requires(filePath != null);

            var invalidPathChars = Path.GetInvalidPathChars();

            foreach (var invalid in invalidPathChars)
            {
                var index = filePath.IndexOf(invalid);

                if (index <= 0)
                {
                    continue;
                }

                // invalid char found.
                var caption = MethodBase.GetCurrentMethod().Name;
                var msg = "You have an invalid character in your file path. This must be fixed prior to saving.  "
                          + invalid;
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        /// <summary>
        ///     Validates the spelling <paramref name="word" />.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns> true if valid else false.;</returns>
        private static bool ValidateSpellingWord([NotNull] string word)
        {
            Contract.Requires(word != null);

            var caption = MethodBase.GetCurrentMethod().Name;

            if (word.IndexOf(' ') > 0)
            {
                const string Msg = "Invalid spelling list more then one value on each line.";
                MessageBox.Show(Msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateSpellingWordHasLettersOnly(word))
            {
                const string Msg = "Invalid spelling list only letters are allowed in the word to be spelled.";
                MessageBox.Show(Msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion Public Methods
    }
}
