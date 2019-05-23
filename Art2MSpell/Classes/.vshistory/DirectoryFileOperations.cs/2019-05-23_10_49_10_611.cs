// Art2MSpell
// 
// DirectoryFileOperations.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  18  2019
// 
// 05  18   2019
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
    using System.CodeDom;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;

    /// <summary>
    /// Class that contains code to create directories and files.
    /// </summary>
    public static class DirectoryFileOperations
    {
        /// ********************************************************************************
        /// <summary>
        /// Constructor used to set class name for use with message boxes.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        static DirectoryFileOperations()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessages.NameOfClass = declaringType.Name;
            }
        }

        /// ********************************************************************************
        /// <summary>
        /// Check if directory path to Art2m spell directory exits. If not then create it
        /// and verify its existence. used to hold all files related to Art2MSpell.
        /// </summary>
        /// <returns>Directory path if successful else returns empty string.</returns>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CheckExistsCreateArt2MSpellPathDirectory()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

                dirPath = Path.Combine(dirPath, dirName);

                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                return !Directory.Exists(dirPath) ? string.Empty : dirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered Error when combining directory paths or creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have necessary security rating to perform this operation.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The directory path is to long.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate the directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "Not supported for this platform.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
        }

        /// ********************************************************************************
        /// <summary>
        /// Need to save new users name to User file list name. So can be used to identify users
        /// spelling list. check file exists if not create.
        /// </summary>
        /// <param name="dirPath"></param>
        /// <returns>File path if successful else return empty string.</returns>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CreatePathToUserFile(string dirPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                var fileName = SpellingPropertiesClass.GetArt2MSpellUserListFileName;

                var filePath = Path.Combine(dirPath, fileName);

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Dispose();
                }

                return !File.Exists(filePath) ? string.Empty : filePath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered Error when combining directory paths or creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have necessary security rating to perform this operation.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The directory path is to long.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate the directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "Not supported for this platform.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
        }

        /// ********************************************************************************
        /// <summary>
        /// Create user sub directory in Art2MSpell directory. This will hold all of
        /// this users spelling lists.
        /// </summary>
        /// <param name="dirPath">The path to the users directory.</param>
        /// <returns>True if user directory created else false.</returns>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool CreateUserSpellingListDirectory(string dirPath)
        {
            var dirName = SpellingPropertiesClass.UserName;

            try
            {
                dirPath = Path.Combine(dirPath, dirName);

                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                return Directory.Exists(dirPath);
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered Error when combining directory paths or creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have necessary security rating to perform this operation.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The directory path is to long.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate the directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "Not supported for this platform.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return false;
            }


        }

        /// ********************************************************************************
        /// <summary>
        /// Creates directories if they do not exist in supplied path; 
        /// </summary>
        /// <param name="dirPath">The path to create directories from.</param>
        /// <returns>Directory path if they exist or were created else returns empty string.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CheckDirectoryExistsCreateDirectory(string dirPath)
        {
            try
            {
                if (Directory.Exists(dirPath))
                {
                    return dirPath;
                }

                Directory.CreateDirectory(dirPath);


                return dirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered Error when combining directory paths or creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have necessary security rating to perform this operation.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The directory path is to long.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate the directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "Not supported for this platform.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while creating directory.";

                MyMessages.ShowErrorMessageBox();

                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///  Combine two strings to get complete path to directory First Directory must
        /// all ready exist.  Check to see if directory path exists if so return path string. else
        /// create new directory.
        /// </summary>
        /// <param name="first">Directory name or path.</param>
        /// <param name="second">Directory name, path or file name.</param>
        /// <returns>Path string to directories else empty string.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CombineStringsMakeDirectoryPath(string first, string second)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var makePath = Path.Combine(first, second);

                var dirPath = CheckDirectoryExistsCreateDirectory(makePath);

                return dirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "One or both of the path strings is null.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Possible invalid characters in path string.";

                Debug.WriteLine(ex.ToString());
                
                MyMessages.ShowErrorMessageBox();

                return string.Empty;
            }
        }

        /// ********************************************************************************
        /// <summary>
        /// Combine three strings to get complete path to directory First Directory must
        /// all ready exist.  Check to see if directory path exists if so return path string.
        /// else create new directory and return path string.
        /// </summary>
        /// <param name="first">Directory Name or path.</param>
        /// <param name="second">Directory name or Path.</param>
        /// <param name="third">Directory name or path.</param>
        /// <returns>Path string to directories else empty string.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CombineStringsMakePath(string first, string second, string third)
        {
            try
            {
                var makePath = Path.Combine(first, second);
                makePath = Path.Combine(makePath, third);

                var dirPath = CheckDirectoryExistsCreateDirectory(makePath);

                return dirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "One or both of the path strings is null.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Possible invalid characters in path string.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return string.Empty;
            }
        }

        /// ********************************************************************************
        /// <summary>
        /// Combine four strings to get complete path to directory First Directory must
        /// all ready exist.  Check to see if directory path exists if so return path string.
        /// else create new directory and return path string.
        /// </summary>
        /// <param name="first">Directory name or path.</param>
        /// <param name="second">Directory name or path.</param>
        /// <param name="third">Directory name or path.</param>
        /// <param name="fourth">Directory name or path.</param>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CombineStringsMakePath(string first, string second, string third, string fourth)
        {
            try
            {
                var makePath = Path.Combine(first, second);
                makePath = Path.Combine(makePath, third);
                makePath = Path.Combine(makePath, fourth);

                var dirPath = CheckDirectoryExistsCreateDirectory(makePath);

                return dirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "One or both of the path strings is null.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Possible invalid characters in path string.";

                Debug.WriteLine(ex.ToString());

                MyMessages.ShowErrorMessageBox();

                return string.Empty;
            }
        }

    }
}