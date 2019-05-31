// Art2MSpell
// 
// SpellingReadWriteClass.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  28  2019
// 
// 05  17   2019
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
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Security;
    using Collections;

    /// ********************************************************************************
    /// <summary>
    ///     used to read write spelling list user list and read header from spelling list files.
    /// </summary>
    /// ********************************************************************************
    public static class SpellingReadWriteClass
    {
        /// ********************************************************************************
        /// <summary>
        ///     Declare object to Spelling Words Collection.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private static readonly SpellingWordsCollection Swc = new SpellingWordsCollection();

        /// ********************************************************************************
        /// <summary>
        ///     Collection containing all of the paths to this users spelling list files.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private static readonly UserSpellingFilePathsCollection usp = new UserSpellingFilePathsCollection();

        /// ********************************************************************************
        /// <summary>
        ///     Used to get class name. For user with error messages.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        static SpellingReadWriteClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     OverWrite file using the User Collection after a user has been removed from
        ///     the list.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        /// <created>art2m,5/28/2019</created>
        /// <changed>art2m,5/28/2019</changed>
        /// ********************************************************************************
        private static bool OverWriteUserNameFile(string filePath)
        {
            try
            {
                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                using (var writer = new StreamWriter(filePath, false))
                {
                    for (var index = 0; index < UsersNameCollection.ItemsCount(); index++)
                    {
                        writer.WriteLine(UsersNameCollection.GetItemAt(index));
                    }
                }

                return true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Validate real spelling list by reading header from file should be Art2MmSpell!!
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>True if valid spelling list else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool ReadHeader(string filePath)
        {
            try
            {
                using (var fileRead = new StreamReader(filePath))
                {
                    var word = fileRead.ReadLine();

                    return ValidationClass.ValidateThisIsArt2MSpellSpellingList(word);
                }
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Reads the spelling list from the file the user has opened.
        /// </summary>
        /// <param name="filePath">The file path to the spelling list user wishes to open.</param>
        /// <returns>True if the spelling list words are added to collection else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static List<string> ReadSpellingListFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            List<string> words;

            var spell = Array.Empty<string>();

            try
            {
                using (var fileRead = new StreamReader(filePath))
                {
                    spell = fileRead.ReadToEnd().Split(',');
                }

                words = new List<string>(spell);
                return words;
            }
            catch (OutOfMemoryException ex)
            {
                MyMessagesClass.ErrorMessage = "Not enough memory to continue. Try closing other windows.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return words = new List<string>(Array.Empty<string>());
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return words = new List<string>(Array.Empty<string>());
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return words = new List<string>(Array.Empty<string>());
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return words = new List<string>(Array.Empty<string>());
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return words = new List<string>(Array.Empty<string>());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return words = new List<string>(Array.Empty<string>());
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Read user name file into collection.
        ///     so user can log in with there name. This
        ///     is used to keep each users spelling list together so they can choose
        ///     an all ready saved spelling list to practice.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool ReadUserNameFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string user;
                    while ((user = reader.ReadLine()) != null)
                    {
                        UsersNameCollection.AddItem(user.Trim());
                    }
                }

                return true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Reads file that contains all of the paths To users spelling List file.
        /// </summary>
        /// <returns>True if file read is successful.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool ReadUsersSpellingListPathsFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return false;
                }

                using (var reader = new StreamReader(filePath))
                {
                    string user;
                    while ((user = reader.ReadLine()) != null)
                    {
                        UsersNameCollection.AddItem(user.Trim());
                    }
                }

                return true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Validate word then if valid place into the collection.
        /// </summary>
        /// <param name="word"></param>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        private static void ValidateWordFromSpellingListAddToCollection(string word)
        {
            // check for valid spell list by checking words are all letters and not empty.
            if (!ValidationClass.ValidateSpellingWord(word))
            {
                return;
            }

            Swc.AddItem(word);
        }

        /// ********************************************************************************
        /// <summary>
        ///     Write spelling words list to file.
        /// </summary>
        /// <param name="filePath">Path to write file to.</param>
        /// <param name="words"></param>
        /// <returns>True if file is written else false.</returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool WriteSpellingWordsToFile(string filePath, IEnumerable<string> words)
        {
            var wordsCsv = string.Join(",", words.ToArray());
            try
            {
                File.WriteAllText(filePath, wordsCsv);
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     If adding new user  then write there name to the Art2MSpell user names file.
        /// </summary>
        /// <returns>True if write successful else false.</returns>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool WriteUserNameFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                // Append line to the file.
                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(SpellingPropertiesClass.UserName);
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Writes file that contains all of the paths to users spelling list file.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool WriteUsersSpellingListPathsFile()
        {
            return true;
        }
    }
}