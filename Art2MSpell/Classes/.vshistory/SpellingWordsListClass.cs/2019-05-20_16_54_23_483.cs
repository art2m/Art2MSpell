// Art2MSpell
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

    public static class SpellingWordsListClass
    {
        /// <summary>
        ///     Save spelling list file in the users name directory.
        /// </summary>
        /// <returns>Path where the users spelling list is to be saved.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        private static string CreateUserSpellingListFileName()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessages.NameOfClass = declaringType.Name;
            }

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

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
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!SpellingReadWriteClass.WriteToFile(filePath))
            {
                return false;
            }

            const string MsgSuccess = "Your spelling list has been created successfully.";
            MyMessages.ShowInformationMessage(MsgSuccess, MyMessages.NameOfMethod);
            return true;
        }
    }
}