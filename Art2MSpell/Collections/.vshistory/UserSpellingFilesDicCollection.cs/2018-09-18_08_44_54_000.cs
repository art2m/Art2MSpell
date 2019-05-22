// **********************************************************************************************
// MusicManagerWindows
//
// SongFileDictionary.cs
//
// art2m
//
// art2m@live.com
//
// 18  09  2018
//
// 13  09  2017
//
// This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// **********************************************************************************************

namespace MusicManagerWindows.Collections
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    ///     Key value song Name value is song path.
    /// </summary>
    public static class SongFileDictionary
    {
        /// <summary>
        ///     The class name
        /// </summary>
        private static readonly string ClassName = MethodBase.GetCurrentMethod().DeclaringType?.Name;

        /// <summary>
        ///     The genre directory list.
        /// </summary>
        private static readonly Dictionary<string, string> SongsList = new Dictionary<string, string>();

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

            SongsList.Add(keyItem, valueItem);
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            SongsList.Clear();
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
            return SongsList.ContainsKey(keyItem);
        }

        /// <summary>
        ///     Items the count.
        /// </summary>
        /// <returns>
        ///     The count.
        /// </returns>
        public static int ItemCount()
        {
            return SongsList.Count;
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
            return ContainsKey(keyItem) && SongsList.Remove(keyItem);
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
            var caption = methodName + " - " + ClassName;

            if (!ContainsKey(keyItem))
            {
                const string msg = "This genre directory name could not be found in the list.";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return string.Empty;
            }

            SongsList.TryGetValue(keyItem, out var keyValue);
            return keyValue;
        }
    }
}