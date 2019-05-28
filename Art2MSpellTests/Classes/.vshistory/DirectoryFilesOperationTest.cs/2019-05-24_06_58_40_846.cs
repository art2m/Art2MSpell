using Art2MSpell.Classes;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Art2MSpell.Classes.Tests
{
    using System.IO;
    using System.Reflection;

    [TestClass()]
    public class DirectoryFilesOperationTest
    {
        /// ********************************************************************************
        /// <summary>
        /// Check that the users spelling list directory all ready exists else
        /// create it. Should all ways be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod()]
        public void CreateUserSpellingListDirectory_TestDirectoryExistsOrIsCreated()
        {
            // Assign
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;
            SpellingPropertiesClass.UserName = "Beep";

            // Act
            var dirArt2MSpell = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, dirName);

            var userDir = Path.Combine(dirArt2MSpell, SpellingPropertiesClass.UserName);

            if (!Directory.Exists(userDir))
            {
                Directory.CreateDirectory(userDir);
            }

            // Assert
            Assert.IsTrue(Directory.Exists(userDir));
        }

        /// ********************************************************************************
        /// <summary>
        /// Check if directory all ready exists if not create it. Calls Create user
        /// Spelling  list directory. Should always be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod()]
        public void CheckDirectoryExistsCreateDirectory_TestDirectoryExistsOrIsCreated()
        {
            // Assign
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            // Act
          
            Directory.CreateDirectory(dirPath);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        /// ********************************************************************************
        /// <summary>
        /// Combine directory path and directory name. Check to see that they exist.
        /// Should always be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod()]
        public void CombineStringsMakeDirectoryPath_TestCombineTwoDirectories()
     
        {
            // Assign
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act
            dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, dirName);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        /// ********************************************************************************
        /// <summary>
        /// Combine three directories check if they exist. Should always be true.
        /// </summary>
        /// <created>art2m,5/24/2019</created>
        /// <changed>art2m,5/24/2019</changed>
        /// ********************************************************************************
        [TestMethod()]
        public void CombineStringsMakeDirectoryPath_TestCombineThreeDirectories()
        {
            // Assign
            const string DirPath1 = @"C:\Users\art2m_000";

            var dirPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act
            var dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(
                DirPath1, dirPath2, dirName);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        [TestMethod()]
        public void CombineStringsMakeDirectoryPathTest_CombineFourDirectories()
        {
            const string DirPath1 = @"C:\";

            const string DirPath2 = @"Users\art2m_000";

            var dirPath3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act
            var dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(
                DirPath1, DirPath2, dirPath3, dirName);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        [TestMethod]
        public void CombineDirectoryPathFileNameCheckCreateFile_TestCheckFileExistsOrCreateFile()
        {
            // Assign
            var dirPath1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act

            var dirPath
            var filePath = Path.Combine(dirPath, fileName);

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }

            return !File.Exists(filePath) ? string.Empty : filePath;
        }
       
    }
}