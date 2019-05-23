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
        public void CreateUserSpellingListDirectoryTest()
        {
            // Assign
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dirName = SpellingPropertiesClass.GetArt2MSpellDirectoryName;

            var dirArt2MSpell = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, dirName);

            dirName = SpellingPropertiesClass.UserName;
            
            dirPath = Path.Combine(dirPath, dirName);

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            return Directory.Exists(dirPath);

            // Act

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void CheckDirectoryExistsCreateDirectoryTest()
        {
            Assert.Fail();
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

