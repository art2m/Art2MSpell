using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Art2MSpell;

namespace Art2MSpellTests
{
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Runtime.InteropServices.WindowsRuntime;
    using global::Art2MSpell.Classes;
    using global::Art2MSpell.Collections;

    [TestClass]
    public class SpellingListClassTest
    {
        /// <summary>
        /// Check word "find" for correct spelling. It should return true word is
        /// spelled correctly.
        /// </summary>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/18/2019</changed>
        [TestMethod]
        public void CheckWordSpelling_ValidWordSpelling()
        {
            var slc = new SpellingListClass();

            // Arrange
            const string Word = "find";

            // Act 
            var retVal = slc.CheckWordSpelling(Word);

            // Assert
            Assert.IsTrue(retVal, "Word is spelled correctly.");
        }

        /// <summary>
        /// Check misspelled word "find" It should return false;
        /// </summary>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/18/2019</changed>
        [TestMethod]
        public void CheckWordSpelling_InValidWordSpelling()
        {
            var slc = new SpellingListClass();

            // Arrange
            const string Word = "finnd";

            // Act
            var retVal = slc.CheckWordSpelling(Word);

            // Assert
            Assert.IsFalse(retVal, "Should pass the words are not equal Misspelled.");
        }

        [TestMethod]
        public void CheckWordSpelling_TryAddingTwoWords()
        {
            var slc = new SpellingListClass();

            // Arrange
            const string Word = "from me";

            // Act
            var retVal = slc.CheckWordSpelling(Word);

            // Assert
            Assert.IsFalse(retVal, "Should pass the words are not legit word for list.");
        }

        /// <summary>
        ///  Check Dictionary for correct spelling of misspelled word. Get count of Dictionary word collection should
        /// have suggested correction words for the misspelled word. so count should be greater then 0;
        /// </summary>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/18/2019</changed>
        [TestMethod]
        public void CheckDictionary_ValidateSuggestionsFound()
        {
            var collSugWords = new SuggestedWordsCollection();
            var slc = new SpellingListClass();

            // Arrange
            const string Word = "finnd";

            // Act
            slc.CheckDictionary(Word);
            var retVal = collSugWords.ItemsCount();

            // Assert
            Assert.AreNotEqual(retVal, 0, "retVal should be larger as it should have a list of words.");
        }

        /// <summary>
        /// Check for duplicate word all ready in the list. should assert true word is in list.
        /// </summary>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/18/2019</changed>
        [TestMethod]
        public void CheckDuplicateWord_ValidateWordAddedIsDuplicate()
        {
            var slc = new SpellingListClass();

            // Arrange
            var duplicate = new List<string> {"find", "does", "friend", "mouse", "time", "Done", "Fan"};

            const string Word = "does";
            // Act
            var retVal = slc.CheckDuplicateWord(duplicate, Word);

            // Assert
            Assert.IsTrue(retVal);
        }

        /// <summary>
        ///  Check for duplicate word all ready in the list. Should assert false word is not in the list.
        /// </summary>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/18/2019</changed>
        [TestMethod]
        public void CheckDuplicateWord_ValidateWordAddedIsNotDuplicate()
        {
            var slc = new SpellingListClass();

            // Arrange
            var duplicate = new List<string> {"find", "does", "friend", "mouse", "time", "Done", "Fan"};

            const string Word = "most";

            // Act
            var retVal = slc.CheckDuplicateWord(duplicate, Word);

            // Assert
            Assert.IsFalse(retVal);
        }

        /// <summary>
        /// Check for duplicate word all ready in the list. Check that case is ignored. word is int the list
        /// as lowercase word comparing is uppercase should still find word and return true.
        /// </summary>
        /// <created>art2m,5/18/2019</created>
        /// <changed>art2m,5/18/2019</changed>
        [TestMethod]
        public void CheckDuplicateWord_ValidateWordIsDuplicate_IgnoreCase()
        {
            // Arrange+
            var slc = new SpellingListClass();

            var duplicate = new List<string> {"find", "does", "friend", "mouse", "time", "Done", "Fan"};

            const string Word = "Does";

            // Act
            var retVal = slc.CheckDuplicateWord(duplicate, Word);

            // Assert
            Assert.IsTrue(retVal);
        }

        /// <summary>
        ///  There is space in word should return false.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        [TestMethod]
        public void CheckDuplicateWord_WordHasSpace()
        {
            // Arrange
            var slc = new SpellingListClass();

            var duplicate = new List<string> { "find", "does", "friend", "mouse", "time", "Done", "Fan" };

            const string Word = "Do es";

            // Act
            var retVal = slc.CheckDuplicateWord(duplicate, Word);

            // Assert
            Assert.IsFalse(retVal);
        }

        /// <summary>
        ///  Empty string no spaces should fail return false.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        [TestMethod]
        public void CheckDuplicateWord_EmptyString()
        {
            // Arrange
            var slc = new SpellingListClass();

            var duplicate = new List<string> { "find", "does", "friend", "mouse", "time", "Done", "Fan" };

            const string Word = "";

            // Act
            var retVal = slc.CheckDuplicateWord(duplicate, Word);

            // Assert
            Assert.IsFalse(retVal);
        }

        /// <summary>
        ///  Empty string with spaces should fail return false.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        [TestMethod]
        public void CheckDuplicateWord_EmptyStringWithSpaces()
        {
            // Arrange
            var slc = new SpellingListClass();

            var duplicate = new List<string> { "find", "does", "friend", "mouse", "time", "Done", "Fan" };

            const string Word = "   ";

            // Act
            var retVal = slc.CheckDuplicateWord(duplicate, Word);

            // Assert
            Assert.IsFalse(retVal);
        }

        [TestMethod]
        public void CheckDuplicateWord_SymbolsInWord()
        {
            // Arrange
            var slc = new SpellingListClass();

            var duplicate = new List<string> { "find", "does", "friend", "mouse", "time", "Done", "Fan" };

            const string Word = "Do&es";

            // Act
            var retVal = slc.CheckDuplicateWord(duplicate, Word);

            // Assert
            Assert.IsFalse(retVal);
        }

        /// <summary>
        ///  Check for valid header at top of spelling list file. Art2MSpell!!
        /// Should return true.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        [TestMethod]
        public void ReadHeader_ValidRead()
        {
            // Arrange
            const string DirPath = @"H:\Documents\MySpelling2.txt";

            // Act
            var retVal = SpellingListClass.ReadHeader(DirPath);

            //Assert
            Assert.IsTrue(retVal);
        }

        /// <summary>
        /// Check header read should return false. Error in the path string.
        /// Path to file not valid.
        /// </summary>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/20/2019</changed>
        [TestMethod]
        public void ReadHeader_ValidateReadReturnFalse()
        {
            // Arrange
            var srw = new SpellingReadWriteClass();

            const string DirPath = @"H:\Documents\MySpelling.txt";

            // Act
            var retVal = srw.ReadHeader(DirPath);

            //Assert
            Assert.IsFalse(retVal);
        }
    }
}
