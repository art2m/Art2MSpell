// Art2MSpellTests
// 
// DirectoryFilesOperationTest.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  24  2019
// 
// 05  23   2019
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

namespace Art2MSpell.Classes.Tests
{
    using System;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DirectoryFilesOperationTest
    {
        /// ********************************************************************************
        /// <summary>
        ///     Check if directory all ready exists if not create it. Calls Create user
        ///     Spelling  list directory. Should always be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CheckDirectoryExistsCreateDirectory_TestDirectoryExistsOrIsCreated()
        {
            // Assign
            var dirPath1 = SpellingPropertiesClass.AppDataDirectoryPath;
            // Act
            var dirPath = DirectoryFileOperations.CheckDirectoryExistsCreateDirectory(dirPath1);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        /// ********************************************************************************
        /// <summary>
        ///     Check file exists if not create it. should all ways be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CombineDirectoryPathFileNameCheckCreateFile_TestCheckFileExistsOrCreateFile()
        {
            // Assign
            var dirPath1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            const string FileName = "Ar2mSpellUserList";

            // Act
            var dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath1, dirName);
            var filePath = Path.Combine(dirPath, FileName);

            filePath = DirectoryFileOperations.CombineDirectoryPathFileNameCheckCreateFile(dirPath, filePath);

            // Assert
            Assert.IsTrue(File.Exists(filePath));
        }

        /// ********************************************************************************
        /// <summary>
        ///     Combine three directories check if they exist. Should always be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CombineStringsMakeDirectoryPath_TestCombineThreeDirectories()
        {
            // Assign
            const string DirPath1 = @"C:\Users\art2m_000";

            SpellingPropertiesClass.AppDataDirectoryPath =
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirPath2 = SpellingPropertiesClass.AppDataDirectoryPath;

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act
            var dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(
                DirPath1, dirPath2, dirName);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        /// ********************************************************************************
        /// <summary>
        ///     Combine directory path and directory name. Check to see that they exist.
        ///     Should always be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CombineStringsMakeDirectoryPath_TestCombineTwoDirectories()

        {
            // Assign
            SpellingPropertiesClass.AppDataDirectoryPath =
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirPath = SpellingPropertiesClass.AppDataDirectoryPath;

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act
            dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, dirName);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        [TestMethod]
        public void CombineStringsMakeDirectoryPathTest_CombineFourDirectories()
        {
            const string DirPath1 = @"C:\";

            const string DirPath2 = @"Users\art2m_000";

            SpellingPropertiesClass.AppDataDirectoryPath = 
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirPath3 = SpellingPropertiesClass.AppDataDirectoryPath;

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act
            var dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(
                DirPath1, DirPath2, dirPath3, dirName);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        /// ********************************************************************************
        /// <summary>
        ///     Check Directory path throws argument exception. All ways asserts false.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CreateUserSpellingListDirectory_TestArgumentDirectoryNotFoundException()
        {
            // Assign
            var dirPath = string.Empty;

            var dirName = string.Empty;

            SpellingPropertiesClass.UserName = string.Empty;

            // Act
            var retVal = DirectoryFileOperations.CreateUserSpellingListDirectory(dirPath);

            // Assert
            Assert.IsFalse(retVal);
        }

        /// ********************************************************************************
        /// <summary>
        ///     Check Argument null exception is thrown. Should all ways assert false.;
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CreateUserSpellingListDirectory_TestArgumentNullException()
        {
            // Assign
            string dirPath = null;

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            SpellingPropertiesClass.UserName = "Beep";

            // Act
            var retVal = DirectoryFileOperations.CreateUserSpellingListDirectory(dirPath);

            // Assert
            Assert.IsFalse(retVal);
        }

        /// ********************************************************************************
        /// <summary>
        ///     Check argument path to long exception is thrown. Should all ways assert false.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CreateUserSpellingListDirectory_TestArgumentPathToLongException()
        {
            // Assign
            const string DirPath = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                                   "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            ;
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;
            SpellingPropertiesClass.UserName = "Beep";

            // Act
            var retVal = DirectoryFileOperations.CreateUserSpellingListDirectory(DirPath);

            // Assert
            Assert.IsFalse(retVal);
        }

        /// ********************************************************************************
        /// <summary>
        ///     Check that the users spelling list directory all ready exists else
        ///     create it. Should all ways assert true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod]
        public void CreateUserSpellingListDirectory_TestDirectoryExistsOrIsCreated()
        {
            // Assign
            SpellingPropertiesClass.AppDataDirectoryPath =
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            SpellingPropertiesClass.UserName = "Beep";

            // Act

            var retVal = DirectoryFileOperations.CreateUserSpellingListDirectory(
                SpellingPropertiesClass.AppDataDirectoryPath);

            // Assert
            Assert.IsTrue(retVal);
        }
    }
}