using Art2MSpell.Classes;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Art2MSpell.Classes.Tests
{
    using System.IO;

    [TestClass()]
    public class DirectoryFilesOperationTest
    {
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

        [TestMethod()]
        public void CheckDirectoryExistsCreateDirectoryTest()
        {
            // Assign
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            // Act
          
            Directory.CreateDirectory(dirPath);

            // Assert
            Assert.AreEqual(dirPath, Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData));
        }

        [TestMethod()]
        public void CombineStringsMakeDirectoryPathTest()
        {
            Assert.Fail();
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