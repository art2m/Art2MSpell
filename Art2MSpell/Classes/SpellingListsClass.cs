// Art2MSpell
// 
// SpellingListsClass.cs
// 
// art2m
// 
// art2m@live.com
// 
// 05  09  2019
// 
// 05  05   2019
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Speech.Synthesis;
using Art2MSpell.Collections;
using NHunspell;

namespace Art2MSpell.Classes

{
    /// <summary>
    ///     Spelling list class reads and writes spelling list to file. Retrieves path to spelling lists.
    /// </summary>
    public static class SpellingListsClass
    {
        private static readonly SpeechSynthesizer Ss = new SpeechSynthesizer();

        #region Public Methods

        /// <summary>
        ///     Check to see if the word is already in the list box.
        /// </summary>
        /// <param name="word">The word to check for.</param>
        /// <returns>True if word is all ready in the list else false.</returns>
        public static bool CheckForDuplicateWordInList(string word)
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessages.NameOfClass = declaringType.Name;
            }

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            for (var index = 0; index < PossibleWordsListCollection.ItemsCount(); index++)
            {
                var spell = PossibleWordsListCollection.GetItemAt(index);
                var same = string.Compare(word, spell, StringComparison.CurrentCultureIgnoreCase);

                if (same != 0)
                {
                    continue;
                }

                MyMessages.InformationMessage = "This word is all ready in the list of spelling words. " + word;
                MyMessages.ShowInformationMessageBox(MyMessages.InformationMessage, MyMessages.NameOfClass,
                    MyMessages.NameOfMethod);

                return true;
            }

            return false;
        }

        /// <summary>
        ///     Check the spelling word.
        /// </summary>
        /// <param name="word">The word to be checked for correct spelling.</param>
        /// <returns></returns>
        public static bool CheckUserEnteredSpellingWord(string word)
        {
            using (var hunspell = new Hunspell("en_us.aff", "en_us.dic"))
            {
                if (!hunspell.Spell(word))
                {
                    CheckForSuggestionsMissSpelledWord(word);
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        ///     Gets possible correct spelling for misspelled word.
        /// </summary>
        /// <param name="word">Misspelled word.</param>
        /// <returns>list with suggestions.</returns>
        public static void CheckForSuggestionsMissSpelledWord(string word)
        {
            List<string> suggestions;

            using (var hunspell = new Hunspell("en_us.aff", "en_us.dic"))
            {
                suggestions = hunspell.Suggest(word);
            }

            foreach (var item in suggestions)
            {
                SuggestedWordsCollection.AddItem(item);
            }
        }

        /// <summary>
        ///     Reads the spelling words to collection.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>True if words read in and added to collection else false.</returns>
        public static bool ReadSpellingWordsToCollection(string filePath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            SpellingWordsCollection.ClearCollection();

            try
            {
                if (!File.Exists(filePath))
                {
                    return false;
                }

                StreamReader fileRead;
                using (fileRead = new StreamReader(filePath))
                {
                    string word;
                    while ((word = fileRead.ReadLine()) != null)
                    {
                        if (!SpellingPropertiesClass.FirstWordIsArt2MSpellHeader &&
                            Validation.ValidateThisIsArt2MSpellSpellingList(word))
                            // If is Art2mSpell!! then continue do not add to collection. This is a UDo_Spell
                            // spelling list.
                        {
                            SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = true;
                            continue;
                        }

                        // check for valid spell list by checking words are all letters and not empty.
                        if (!Validation.ValidateIsSpellingList(word))
                        {
                            return false;
                        }

                        SpellingWordsCollection.AddItem(word);
                    }
                }

                return true;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Invalid file path. " + filePath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);

                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Read error has occurred. " + filePath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);

                return false;
            }
        }

        /// <summary>
        ///     Writes the spelling words from collection to file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>True if words wrote from collection to file else false.</returns>
        public static bool WriteSpellingWordsFromCollectionToFile(string filePath)
        {
            try
            {
                StreamWriter fileWrite;
                using (fileWrite = new StreamWriter(filePath, false))
                {
                    var cnt = SpellingWordsCollection.ItemsCount();

                    fileWrite.WriteLine(SpellingPropertiesClass.GetArt2MSpellHeader);

                    for (var i = 0; i < cnt; i++)
                    {
                        var word = SpellingWordsCollection.GetItemAt(i);
                        fileWrite.WriteLine(word);
                    }
                }

                return true;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Invalid file path. " + filePath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);

                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Write error has occurred. " + filePath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);

                return false;
            }
        }

        /// <summary>
        ///     Speak string passed into method.
        /// </summary>
        /// <param name="word">The string to speak</param>
        public static void SpeakString(string word)
        {
            Ss.Speak(word);
        }

        #endregion Public Methods
    }
}