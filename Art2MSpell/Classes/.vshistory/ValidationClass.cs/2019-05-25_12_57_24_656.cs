// //-----------------------------------------------------------------------------------------------------------------------------------
// <copyright file="None">
// 
// Company copyright tag.
// 
//  </copyright>
// 
// Art2MSpell
// 
// Validation.cs
// 
// art2m
// 
// art2m@live.com
// 
// 05  10  2019
// 
// 05  08   2019
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
// //-----------------------------------------------------------------------------------------------------------------------------------

namespace Art2MSpell.Classes
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Reflection;
    using JetBrains.Annotations;

    /// <summary>
    ///     Validates data.
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// Set class name for use with messages.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/22/2019</changed>
        static Validation()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        ///     Check spelling word has no white space which could indicate two words only one word is allowed.
        ///     Only letters allowed in the spelling word.
        /// </summary>
        /// <param name="value">Word to check spelling.</param>
        /// <returns>true if no empty space and has letters only.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool ValidateSpellingWord([NotNull] string value)
        {
            Contract.Requires(value != null);

            if (!ValidateStringValueNotEmptyNotWhiteSpace(value))
            {
                return false;
            }

            if (!ValidateStringOneWord(value))
            {
                return false;
            }

            return ValidateSpellingWordHasLettersOnly(value);
        }

        /// <summary>
        ///     Check that there are only letters in the spelling word.
        /// </summary>
        /// <param name="value">The spelling word to be checked.</param>
        /// <returns>True if only letters in the spelling word else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool ValidateSpellingWordHasLettersOnly([NotNull] string value)
        {
            Contract.Requires(!string.IsNullOrEmpty(value));

            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                foreach (var letter in value)
                {
                    if (char.IsLetter(letter))
                    {
                        continue;
                    }

                    MyMessagesClass.ErrorMessage = "Invalid character in string:  " + letter;
                    throw new NotSupportedException();
                }

                return true;
            }
            catch (NotSupportedException e)
            {
                Debug.WriteLine(e.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// <summary>
        ///     Check for space in value this will means either space in word that does not belong or
        ///     two words instead of one spelling word.
        /// </summary>
        /// <param name="value">The spelling word to validate.</param>
        /// <returns>True if no space is found else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool ValidateStringOneWord(string value)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            MyMessagesClass.ErrorMessage =
                "Check to see if space in word or if two words are entered. Spaces and double words are not " +
                "allowed. correct this then add the word again. ";
            try
            {
                var index = value.IndexOf(' ');

                if (index > -1)
                {
                    throw new NotSupportedException();
                }

                return true;
            }
            catch (NotSupportedException e)
            {
                Debug.WriteLine(e.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// <summary>
        ///     If empty not valid spelling word
        /// </summary>
        /// <param name="value">The spelling word to be checked.</param>
        /// <returns>True if not empty else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool ValidateStringValueNotEmptyNotWhiteSpace([NotNull] string value)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            value = value.Trim();

            try
            {
                MyMessagesClass.ErrorMessage = "The value is not valid. ";
                if (string.IsNullOrEmpty(value))
                {
                    throw new NotSupportedException();
                }

                if (value.Length == 0)
                {
                    throw new NotSupportedException();
                }

                return true;
            }
            catch (NotSupportedException e)
            {
                Debug.WriteLine(e.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// <summary>
        ///     Validates that this is a valid spelling list file.
        /// </summary>
        /// <param name="word"> first word in the spelling list file.</param>
        /// <returns>true if valid spelling list file else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool ValidateThisIsArt2MSpellSpellingList([NotNull] string word)
        {
            Contract.Requires(!string.IsNullOrEmpty(word));

            if (!ValidateStringValueNotEmptyNotWhiteSpace(word))
            {
                return false;
            }

            var valid = string.Compare(
                SpellingPropertiesClass.GetArt2MSpellHeader,
                word,
                StringComparison.CurrentCultureIgnoreCase);
            return valid == 0;
        }
    }
}