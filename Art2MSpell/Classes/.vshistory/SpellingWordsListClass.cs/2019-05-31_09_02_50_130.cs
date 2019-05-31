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
        ///     Save the path to where user saved spelling list to.
        ///     Used to give user a selection of spelling lists to open.
        /// </summary>
        /// <param name="words"></param>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static void SaveSpellingListPath(string words)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var dirPath = SpellingPropertiesClass.CurrentUserSpellingListDirectory;

            DialogResult retVal;
            const string Caption = "Name spelling list.";
            const string Prompt = "You must enter a name for this spelling list. It can be name and date.";
            var value = string.Empty;

            using (var dlgInput = new InputDialog())
            {
                retVal = dlgInput.GetFileName(Caption, Prompt, ref value);
            }

            if (DialogResult.OK == retVal)
            {
                if (string.IsNullOrEmpty(value))
                {
                    MyMessagesClass.WarningMessage = "You need to name this file in order to save it.";
                    MyMessagesClass.ShowWarningMessageBox();
                    return;
                }

                var filePath = DirectoryFileOperationsClass.CombineDirectoryPathFileNameCheckCreateFile(
                    dirPath,
                    value);
                    
                WriteWordsToFile(filePath);
            }
            else
            {
                MyMessagesClass.WarningMessage = "You need to name this file in order to save it.";
                MyMessagesClass.ShowWarningMessageBox();
            }
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