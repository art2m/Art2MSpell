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
    using System.Reflection;
    using System.Speech.Synthesis;
    using Collections;
    using NHunspell;

    /// <summary>
    ///     Spelling list class reads and writes spelling list to file. Retrieves path to spelling lists.
    /// </summary>
    public static class SpellingListsClass
    {
        /// <summary>Declare speech synthesizer object.</summary>
        private static readonly SpeechSynthesizer Ss = new SpeechSynthesizer();

        /// <summary>
        ///     Check to see if the word is already in the list box.
        /// </summary>
        /// <param name="word">The word to check for.</param>
        /// <returns>True if word is all ready in the list else false.</returns>
        /// <created>,5/10/2019</created>
        /// <changed>,5/10/2019</changed>
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
                MyMessages.ShowInformationMessageBox(
                    MyMessages.InformationMessage,
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod);
                return true;
            }

            return false;
        }

        /// <summary>
        ///     Gets list of possible correct spelling for misspelled word.
        /// </summary>
        /// <param name="word">Misspelled word.</param>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
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
        ///     Check spelling word for the correct spelling.
        ///     If incorrect spelling the get a list of possible correct spelling.
        /// </summary>
        /// <param name="word">The word to check spelling on.</param>
        /// <returns>True if word is spelled correctly else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
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
        ///     Reads the spelling list from the file the user has opened.
        /// </summary>
        /// <param name="filePath">The file path to the spelling list user wishes to open.</param>
        /// <returns>True if the spelling list words are added to collection else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
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
                        Debug.WriteLine(SpellingPropertiesClass.GetArt2MSpellHeader);
                        if (!SpellingPropertiesClass.FirstWordIsArt2MSpellHeader)
                        {
                            if (Validation.ValidateThisIsArt2MSpellSpellingList(word))
                            {
                                SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = true;
                                continue;
                            }
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
        ///     Writes spelling list user entered from the collection to the file.
        /// </summary>
        /// <param name="filePath">The file path to write the spelling words to.</param>
        /// <returns>True if spelling words written to file else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool WriteSpellingWordsFromCollectionToFile(string filePath)
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