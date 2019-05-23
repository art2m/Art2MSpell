﻿using Art2MSpell.Classes;
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
            const string DirName = "Art2MSpell";
            const string UserName = "Beep";

            // Act
            var dirArt2MSpell = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, DirName);

            var userDir = Path.Combine(dirArt2MSpell, UserName);

            if (!Directory.Exists(userDir))
            {
                Directory.CreateDirectory(userDir);
            }

            // Assert
            Assert.IsTrue(Directory.Exists(userDir));
        }

        [TestMethod]
        public void CreateUserSpellingListDirectoryTest_InValidDirectoryName()
        {
            // Assign
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            const string DirName = "Art2MSpell";
            const string UserName = "Beep^**$%@#=+";

            // Act
            var dirArt2MSpell = DirectoryFileOperations.CombineStringsMakeDirectoryPath(dirPath, DirName);

            var userDir = Path.Combine(dirArt2MSpell, UserName);

            if (!Directory.Exists(userDir))
            {
                Directory.CreateDirectory(userDir);
            }

            // Assert
            Assert.IsFalse(Directory.Exists(userDir));
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

