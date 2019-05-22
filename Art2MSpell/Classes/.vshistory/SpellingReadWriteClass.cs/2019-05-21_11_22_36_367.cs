// Art2MSpell
// 
// SpellingReadWriteClass.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  17  2019
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
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Text;
    using Classes;
    using Collections;

    /// <summary>
    /// used to read write spelling list user list and read header from spelling list files.
    /// </summary>
    public static class SpellingReadWriteClass
    {
        /// <summary>
        ///  Declare object to Spelling Words Collection.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/21/2019</changed>
        private static readonly SpellingWordsCollection Swc = new SpellingWordsCollection();

        /// <summary>
        ///  Collection containing the user names.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/21/2019</changed>
        private static readonly UsersNameCollection unc = new UsersNameCollection();
        

        /// <summary>
        /// Used to get class name. For user with error messages.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/21/2019</changed>
        static SpellingReadWriteClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessages.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        ///     Reads the spelling list from the file the user has opened.
        /// </summary>
        /// <param name="filePath">The file path to the spelling list user wishes to open.</param>
        /// <returns>True if the spelling list words are added to collection else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public static bool ReadSpellingListFile(string filePath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var swc = new SpellingWordsCollection();

            try
            {
                swc.ClearCollection();

                using (var fileRead = new StreamReader(filePath))
                {
                    string word;
                    while ((word = fileRead.ReadLine()) != null)
                    {
                        ValidateWordFromSpellingListAddToCollection(word);
                    }
                }

                return true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return false;
            }
        }

        /// <summary>
        ///  Validate word then if valid place into the collection.
        /// </summary>
        /// <param name="word"></param>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/21/2019</changed>
        private static void ValidateWordFromSpellingListAddToCollection(string word)
        {
            // check for valid spell list by checking words are all letters and not empty.
            if (!Validation.ValidateSpellingWord(word))
            {
                return;
            }

            Swc.AddItem(word);
        }


        /// <summary>
        ///     Validate real spelling list by reading header from file should be Art2MmSpell!!
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>True if valid spelling list else false.</returns>
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
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return false;
            }
        }

        
        /// <summary>
        /// Write spelling words list to file.
        /// </summary>
        /// <param name="filePath">Path to write file to.</param>
        /// <returns>True if file is written else false.</returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        public static bool WriteSpellingWordsToFile(string filePath)
        {
            var swc = new SpellingWordsCollection();

            try
            {
                StreamWriter fileWrite;
                using (fileWrite = new StreamWriter(filePath, false))
                {
                    var cnt = swc.ItemsCount();

                    fileWrite.WriteLine(SpellingPropertiesClass.GetArt2MSpellHeader);

                    Debug.WriteLine(SpellingPropertiesClass.GetArt2MSpellHeader);

                    for (var i = 0; i < cnt; i++)
                    {
                        var word = swc.GetItemAt(i);
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

        /// <summary>
        /// If adding new user  then write there name to the Art2MSpell user names file.
        /// </summary>
        /// <returns>True if write successful else false.</returns>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        public static bool WriteUserNameFile()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var dirPath = DirectoryFileOperations.CheckDirectoryPathExistsCreate();

            var filePath = DirectoryFileOperations.CreatePathToUserFile(dirPath);

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
                MyMessages.ErrorMessage = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate the directory.";

                   Debug.WriteLine(ex.ToString());

                   MyMessages.ShowErrorMessageBox();

                   return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return false;
            }
            catch (SecurityException ex)
            {
                MyMessages.ErrorMessage = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return false;
            }
        }

       

        /// <summary>
        /// Read user name file into collection.
        /// so user can log in with there name. This
        /// is used to keep each users spelling list together so they can choose
        /// an all ready saved spelling list to practice.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        public static bool ReadUserNameFile()
        {
            // TODO: Add error handling to this method.

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var dirPath = DirectoryFileOperations.CheckDirectoryPathExistsCreate();
            var filePath = DirectoryFileOperations.CreatePathToUserFile(dirPath);

            

            using (var reader = new StreamReader(filePath))
            {
                string user;
                while ((user = reader.ReadLine()) != null)
                {
                    userColl.AddItem(user.Trim());
                }
            }

            return true;
        }



    }
}