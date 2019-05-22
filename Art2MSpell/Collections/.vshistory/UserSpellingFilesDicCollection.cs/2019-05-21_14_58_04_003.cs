// Art2MSpell
// 
// UserSpellingFilesDicCollection.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  21  2019
// 
// 05  21   2019
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

namespace Art2MSpell.Collections
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows.Forms;
    using Classes;

    /// <summary>
    ///     Holds the file paths to current users spelling lists.
    /// </summary>
    public static class UserSpellingFilesDicCollection
    {
       
        /// <summary>
        /// the 
        /// </summary>
        /// <typeparam name="string"></typeparam>
        /// <typeparam name="string"></typeparam>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/21/2019</changed>
        private static readonly Dictionary<string, string> Usl = new Dictionary<string, string>();

        /// <summary>
        ///     Get class name for messages.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/21/2019</changed>
        static UserSpellingFilesDicCollection()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessages.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        ///     Adds the item.
        /// </summary>
        /// <param name="keyItem">The key item.</param>
        /// <param name="valueItem">The value item.</param>
        public static void AddItem(string keyItem, string valueItem)
        {
            if (ContainsKey(keyItem))
            {
                return;
            }

            Usl.Add(keyItem, valueItem);
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            Usl.Clear();
        }

        /// <summary>
        ///     Check to see if the collection all ready contains the key to be
        ///     added.
        /// </summary>
        /// <param name="keyItem">Key item.</param>
        /// <returns>
        ///     <c>true</c> , if key was contained, <c>false</c> otherwise.
        /// </returns>
        public static bool ContainsKey(string keyItem)
        {
            return Usl.ContainsKey(keyItem);
        }

        /// <summary>
        ///     Items the count.
        /// </summary>
        /// <returns>
        ///     The count.
        /// </returns>
        public static int ItemCount()
        {
            return Usl.Count;
        }

        /// <summary>
        ///     Removes the key item.
        /// </summary>
        /// <param name="keyItem">Key item.</param>
        /// <returns>
        ///     <c>true</c> , if key item was removed, <c>false</c> otherwise.
        /// </returns>
        public static bool RemoveKeyItem(string keyItem)
        {
            return ContainsKey(keyItem) && Usl.Remove(keyItem);
        }

        /// <summary>
        ///     Returns the item value at the key.
        /// </summary>
        /// <param name="keyItem">Key item.</param>
        /// <returns>
        ///     The item value at key.
        /// </returns>
        public static string ReturnItemValueAtKey(string keyItem)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;

            if (!ContainsKey(keyItem))
            {
//                const string msg = "This genre directory name could not be found in the list.";
//                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return string.Empty;
            }

            Usl.TryGetValue(keyItem, out var keyValue);
            return keyValue;
        }
    }
}