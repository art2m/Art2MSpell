﻿// Art2MSpell
// 
// SpellingWordsListClass.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  20  2019
// 
// 05  19   2019
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
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using Source;

    public static class SpellingWordsListClass
    {
        /// <summary>
        /// Get class name for use with message boxes.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/22/2019</changed>
        static SpellingWordsListClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        ///     Save spelling list file in the users name directory.
        /// </summary>
        /// <returns>Path where the users spelling list is to be saved.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        private static string CreateUserSpellingListFileName()
        {
            // TODO: add code to display input box get file name.
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var user = SpellingPropertiesClass.UserName;

            return Path.Combine(user, SpellingPropertiesClass.SpellingListPath);
        }

        /// <summary>
        ///     Save the path to where user saved spelling list to.
        ///     Used to give user a selection of spelling lists to open.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static void SaveSpellingListPath()
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var dirPath = SpellingPropertiesClass.CurrentUserSpellingListDirectory;

            DialogResult retVal;

            const string caption = "Name spelling list.";
            const string prompt = "You must enter a name for this spelling list. It can be name and date.";

            var value = string.Empty;

            using (var dlgInput = new InputDialog())
            {
                retVal = dlgInput.GetFileName(caption, prompt, ref value);
            }

            var dirPath = SpellingPropertiesClass.CurrentUserSpellingListDirectory;
            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathFileNameCheckCreateFile(dirPath, value)
            var filePath = CreateUserSpellingListFileName();

            WriteWordsToFile(filePath);
        }

        /// <summary>
        ///     Loop threw the misspelled words so user can respell those they got wrong.
        /// </summary>
        /// <created>art2m,5/16/2019</created>
        /// <changed>art2m,5/16/2019</changed>
        public static void SpellMisspelledWords()
        {
            // TODO: Spell each word in the misspelled words. 
        }

        /// <summary>
        ///     write spelling words from collection to file.
        /// </summary>
        /// <param name="filePath">The path to the spelling list file.</param>
        /// <returns>true if spelling list is written to file else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        public static bool WriteWordsToFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!SpellingReadWriteClass.WriteSpellingWordsToFile(filePath))
            {
                return false;
            }

            const string MsgSuccess = "Your spelling list has been created successfully.";
            MyMessagesClass.ShowInformationMessage(MsgSuccess, MyMessagesClass.NameOfMethod);
            return true;
        }
    }
}