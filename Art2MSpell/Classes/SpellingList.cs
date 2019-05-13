// //-----------------------------------------------------------------------------------------------------------------------------------
// <copyright file="None">
//
// Company copyright tag.
//
//  </copyright>
//
// Art2MSpell
//
// SpellingListsClass.cs
//
// art2m
//
// art2m@live.com
//
// 05  10  2019
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
// //-----------------------------------------------------------------------------------------------------------------------------------

namespace Art2MSpell.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Speech.Synthesis;
    using Collections;
    using NHunspell;

    /// <summary>
    ///     Spelling list class reads and writes spelling list to file. Retrieves path to spelling lists.
    /// </summary>
    public static class SpellingList
    {
        /// <summary>Declare speech synthesizer object.</summary>
        private static readonly SpeechSynthesizer Ss = new SpeechSynthesizer();

        /// <summary>
        ///     Check to see if the word is already in the list box.
        /// </summary>
        /// <param name="duplicate">The items from the list box.</param>
        /// /// <param name="addWord">The word to check for.</param>
        /// <returns>True if word is all ready in the list else false.</returns>
        /// <created>,5/10/2019</created>
        /// <changed>,5/10/2019</changed>
        public static bool CheckDuplicateWord(List<string> duplicate, string addWord)
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessages.NameOfClass = declaringType.Name;
            }

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!LoopThrewWordsList(duplicate, addWord))
            {
                return false;
            }

            MyMessages.InformationMessage = "The word entered is all ready in the list of spelling words. ";
                MyMessages.ShowInformationMessageBox(
                    MyMessages.InformationMessage,
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod);

                return true;
        }

        /// <summary>
        ///  Loop threw the words from the list box. Call method to check for duplicate words.
        /// </summary>
        /// <param name="duplicate">The list of words contained in the list box.</param>
        /// <param name="addWord">The word being added by user.</param>
        /// <returns>True if duplicate word found in lest box else false.</returns>
        /// <created>art2m,5/13/2019</created>
        /// <changed>art2m,5/13/2019</changed>
        private static bool LoopThrewWordsList(IReadOnlyCollection<string> duplicate, string addWord)
        {
            for (var index = 0; index < duplicate.Count; index++)
            {
                // If false not duplicate.
                if (!CompareWordListToNewWord(duplicate.ElementAt(index), addWord))
                {
                    continue;
                }

                // true  duplicate word.
                return true;
            }

            return false;
        }

        /// <summary>
        /// Compare the words in the list with new word to add.
        /// </summary>
        /// /// <param name="listWord">The word from the list box to be compared with new word.</param>
        /// <param name="addWord">The word to be evaluated.</param>
        /// <returns>True if word to be added matches the word from the list else false.</returns>
        /// <created>art2m,5/13/2019</created>
        /// <changed>art2m,5/13/2019</changed>
        private static bool CompareWordListToNewWord(string listWord, string addWord)
        {
            var same = string.Compare(listWord, addWord, StringComparison.CurrentCultureIgnoreCase);

            if (same != 0)
            {
                return false;
            }

            return true;

        }

        /// <summary>
        ///     Gets list of words from dictionary for the misspelled word.
        /// </summary>
        /// <param name="word">Misspelled word.</param>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static void CheckDictionary(string word)
        {
            List<string> suggestions;
            using (var hunspell = new Hunspell("en_us.aff", "en_us.dic"))
            {
                suggestions = hunspell.Suggest(word);
            }

            foreach (var item in suggestions)
            {
                DictionaryWordscollection.AddItem(item);
            }
        }

        /// <summary>
        ///     Check spelling word for the correct spelling.
        ///     If incorrect spelling the get a list of possible correct spelling.
        /// </summary>
        /// <param name="word">The word to check spelling on.</param>
        /// <returns>True if word is spelled correctly else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool CheckWord(string word)
        {
            using (var hunspell = new Hunspell("en_us.aff", "en_us.dic"))
            {
                if (!hunspell.Spell(word))
                {
                    CheckDictionary(word);
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        ///  Validate real spelling list by reading header from file should be Art2MmSpell!!
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        public static bool ReadHeader(string filePath)
        {
            try
            {
                using (var fileRead = new StreamReader(filePath))
                {
                    var word = fileRead.ReadLine();

                    return Validation.ValidateThisIsArt2MSpellSpellingList(word);
                }
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Invalid file path. " + filePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Read error has occurred. " + filePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Reads the spelling list from the file the user has opened.
        /// </summary>
        /// <param name="filePath">The file path to the spelling list user wishes to open.</param>
        /// <returns>True if the spelling list words are added to collection else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool ReadFile(string filePath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            SpellingWordsCollection.ClearCollection();
            try
            {
                var cnt = 0;
                StreamReader fileRead;
                using (fileRead = new StreamReader(filePath))
                {
                    string word;
                    while ((word = fileRead.ReadLine()) != null)
                    {
                        if (SpellingPropertiesClass.Art2MSpellSpellingList && cnt == 0)
                        {
                            cnt = 1;
                            continue;
                        }
                        // check for valid spell list by checking words are all letters and not empty.
                        if (!Validation.ValidateSpellingWord(word))
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
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Read error has occurred. " + filePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Say the string passed into it.
        /// </summary>
        /// <param name="word">The word or can be string.</param>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static void SpeakString(string word)
        {
            Ss.Speak(word);
        }

        /// <summary>
        ///     Writes spelling words to file.
        /// </summary>
        /// <param name="filePath">The file path to write the spelling words to.</param>
        /// <returns>True if spelling words written to file else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool WriteToFile(string filePath)
        {
            try
            {
                StreamWriter fileWrite;
                using (fileWrite = new StreamWriter(filePath, false))
                {
                    var cnt = SpellingWordsCollection.ItemsCount();
                    fileWrite.WriteLine(SpellingPropertiesClass.GetArt2MSpellHeader);
                    Debug.WriteLine(SpellingPropertiesClass.GetArt2MSpellHeader);
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
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Write error has occurred. " + filePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
        }
    }
}