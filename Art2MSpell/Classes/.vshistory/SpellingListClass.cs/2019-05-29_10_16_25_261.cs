// Art2MSpell
// 
// SpellingListClass.cs
// 
// art2m
// 
// art2m@live.com
// 
// 05  14  2019
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

namespace Art2MSpell.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Speech.Synthesis;
    using System.Windows.Forms;
    using Collections;
    using JetBrains.Annotations;
    using NHunspell;

    /// <summary>
    ///     Spelling list class reads and writes spelling list to file. Retrieves path to spelling lists.
    /// </summary>
    public static class SpellingListClass
    {
        private static readonly MisspelledWordsCollection mwc;

        static SpellingListClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }

            mwc = new MisspelledWordsCollection();
        }

        /// <summary>Declare speech synthesizer object.</summary>
        private static readonly SpeechSynthesizer Ss = new SpeechSynthesizer();

        /// <summary>
        ///     Gets list of words from dictionary for the misspelled word.
        /// </summary>
        /// <param name="word">Misspelled word.</param>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static void CheckDictionary(string word)
        {
            var sugWords = new SuggestedWordsCollection();

            List<string> suggestions;

            using (var hunspell = new Hunspell("en_us.aff", "en_us.dic"))
            {
                suggestions = hunspell.Suggest(word);
            }

            foreach (var item in suggestions)
            {
                sugWords.AddItem(item);
            }
        }

        /// <summary>
        ///     Check to see if the word is already in the list box.
        /// </summary>
        /// <param name="duplicate">The items from the list box.</param>
        /// ///
        /// <param name="addWord">The word to check for.</param>
        /// <returns>True if word is all ready in the list else false.</returns>
        /// <created>,5/10/2019</created>
        /// <changed>,5/10/2019</changed>
        public static bool CheckDuplicateWord(List<string> duplicate, string addWord)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!LoopThrewWordsList(duplicate, addWord))
            {
                return false;
            }

            MyMessagesClass.InformationMessage = "The word entered is all ready in the list of spelling words. ";
            MyMessagesClass.ShowInformationMessageBox();

            return true;
        }

        /// <summary>
        ///     Check spelling word for the correct spelling.
        ///     If incorrect spelling the get a list of possible correct spelling.
        /// </summary>
        /// <param name="word">The word to check spelling on.</param>
        /// <returns>True if word is spelled correctly else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool CheckWordSpelling(string word)
        {
            using (var hunspell = new Hunspell("en_us.aff", "en_us.dic"))
            {
                if (hunspell.Spell(word))
                {
                    return true;
                }

                 mwc.AddItem(word);

                MyMessagesClass.InformationMessage = string.Concat("This word is not spelled correctly:  ", word);
                MyMessagesClass.ShowInformationMessageBox();

                CheckDictionary(word);

                return false;
            }
        }

        /// <summary>
        /// Show the user a list of saved spelling lists they can use to choose
        /// what spelling list to open.
        /// </summary>
        /// <created>art2m,5/16/2019</created>
        /// <changed>art2m,5/16/2019</changed>
        public static void GetListOfSpellingListFiles()
        {
            // TODO: Get list of spelling files the user has.
        }

        /// <summary>
        ///     Read header from file validate is real spelling file.
        /// </summary>
        /// <returns>True if valid spelling file else false.</returns>
        /// <returns>True if valid spelling file else false.</returns>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        public static bool ReadHeader(string filePath)
        {
            if (!SpellingReadWriteClass.ReadHeader(filePath))
            {
                SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = false;
                SpellingPropertiesClass.Art2MSpellSpellingList = false;
                return false;
            }

            SpellingPropertiesClass.FirstWordIsArt2MSpellHeader = true;
            SpellingPropertiesClass.Art2MSpellSpellingList = true;
            return true;
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
        ///     Compare the words in the list with new word to add.
        /// </summary>
        /// ///
        /// <param name="listWord">The word from the list box to be compared with new word.</param>
        /// <param name="addWord">The word to be evaluated.</param>
        /// <returns>True if word to be added matches the word from the list else false.</returns>
        /// <created>art2m,5/13/2019</created>
        /// <changed>art2m,5/13/2019</changed>
        private static bool CompareWordListToNewWord(string listWord, string addWord)
        {
            var same = string.Compare(listWord, addWord, StringComparison.CurrentCultureIgnoreCase);

            return same == 0;
        }

        /// <summary>
        ///     Loop threw the words from the list box. Call method to check for duplicate words.
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
    }
}