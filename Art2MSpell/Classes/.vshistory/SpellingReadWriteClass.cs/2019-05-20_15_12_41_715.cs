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
    using System.Text;
    using Classes;
    using Collections;
    public class SpellingReadWriteClass
    {
        /// <summary>
        ///     Reads the spelling list from the file the user has opened.
        /// </summary>
        /// <param name="filePath">The file path to the spelling list user wishes to open.</param>
        /// <returns>True if the spelling list words are added to collection else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public  bool ReadFile(string filePath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            var swc = new SpellingWordsCollection();
            var clsValid = new Validation();

            try
            {
                swc.ClearCollection();

                var cnt = 0;
                StreamReader fileRead;
                using (fileRead = new StreamReader(filePath))
                {
                    string word;
                    while ((word = fileRead.ReadLine()) != null)
                    {
                        if (SpellingPropertiesClass.Art2MSpellSpellingList && (cnt == 0))
                        {
                            cnt = 1;
                            continue;
                        }

                        // check for valid spell list by checking words are all letters and not empty.
                        if (!clsValid.ValidateSpellingWord(word))
                        {
                            return false;
                        }

                        swc.AddItem(word);
                    }
                }

                return true;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Invalid file path. " + filePath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Read error has occurred. " + filePath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Validate real spelling list by reading header from file should be Art2MmSpell!!
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>True if valid spelling list else false.</returns>
        /// <created>art2m,5/12/2019</created>
        /// <changed>art2m,5/12/2019</changed>
        public  bool ReadHeader(string filePath)
        {
            var clsValid = new Validation();

            try
            {
                using (var fileRead = new StreamReader(filePath))
                {
                    var word = fileRead.ReadLine();

                    return clsValid.ValidateThisIsArt2MSpellSpellingList(word);
                }
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
                MyMessages.ErrorMessage = "Read error has occurred. " + filePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass,
                    MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Writes spelling words to file.
        /// </summary>
        /// <param name="filePath">The file path to write the spelling words to.</param>
        /// <returns>True if spelling words written to file else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/10/2019</changed>
        public  bool WriteToFile(string filePath)
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
        /// <returns></returns>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/17/2019</changed>
        public  bool WriteUserNameFile()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var op = new DirectoryFileOperations();

            /*if (!string.IsNullOrEmpty(op.CheckDirectoryPathExistsCreate()))
            {
               
            };


            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();

                using (TextWriter tw = new StreamWriter(filePath))
                {
                    tw.WriteLine(SpellingPropertiesClass.UserName);
                }
            }
            else if (File.Exists(filePath))
            {
                using (TextWriter tw = new StreamWriter(filePath))
                {
                    tw.WriteLine(SpellingPropertiesClass.UserName);
                }
            }*/

            return true;
        }

       

        public  bool ReadUserNameFile()
        {

            return true;
        }



    }
}