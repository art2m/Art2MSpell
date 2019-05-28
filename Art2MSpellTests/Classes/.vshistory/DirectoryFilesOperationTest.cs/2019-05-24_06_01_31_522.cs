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
        public void CreateUserSpellingListDirectoryTest_ValidTest()
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
        public void CheckDirectoryExistsCreateDirectoryTest()
        {
            // Assign
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            // Act
          
            Directory.CreateDirectory(dirPath);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        [TestMethod()]
        public void CombineStringsMakeDirectoryPathTest()
     
        {
            // Assign
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            // Act
            dirPath = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, dirName);

            // Assert
            Assert.IsTrue(Directory.Exists(dirPath));
        }

        [TestMethod()]
        public void CombineStringsMakeDirectoryPathTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CombineStringsMakeDirectoryPathTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CombineDirectoryPathFileNameCheckCreateFileTest()
        {
            Assert.Fail();
        }
    }
}