﻿//---------------------------------------------------------------------------------------------------------------
// Art2MSpell
// 
// SpellingWordsCollection.cs
//
// File:     Art2MSpell.sln
//
// Author:   art2m_000]
// Email     art2m@live.com   
// Company:  
// Date:     5/9/2019
//
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//----------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Art2MSpell.Collections
{
    /// <summary>
    /// Spelling Words Collection Holds words from current spelling list.
    /// </summary>
    public static class SpellingWordsCollection

    {
        #region Fields

        /// <summary>
        /// Contains collection of words from a spelling list.
        /// </summary>
        private static readonly List<string> WordsList = new List<string>();

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="word">Add new word to the collection.</param>
        public static void AddItem(string word)
        {
            WordsList.Add(word);
        }

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            WordsList.Clear();
        }

        /// <summary>
        /// Determines whether the specified word contains item.
        /// </summary>
        /// <param name="word">Check if the word is contained in the collection.</param>
        /// <returns><c>true</c> if the specified word contains item; otherwise, <c>false</c>.</returns>
        public static bool ContainsItem(string word) => WordsList.Contains(word);

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <returns>All items.</returns>
        public static string[] GetAllItems()
        {
            var count = WordsList.Count;

            // No genre Folders Found
            if ((count - 1) < 1)
            {
                return System.Array.Empty<string>();
            }

            var origPath = new string[count];

            for (var i = 0; i < count; i++)
            {
                origPath[i] = WordsList[i];
            }

            // All OK.
            return origPath;
        }

        /// <summary>
        /// Gets the item at.
        /// </summary>
        /// <param name="index">The items index.</param>
        /// <returns>The item.</returns>
        public static string GetItemAt(int index) => WordsList[index];

        /// <summary>
        /// Gets the index of the item.
        /// </summary>
        /// <param name="word">The word to find index for.</param>
        /// <returns>Return the index of the item.</returns>
        public static int GetItemIndex(string word) => WordsList.IndexOf(word);

        /// <summary>
        /// Items the count.
        /// </summary>
        /// <returns>The items count.</returns>
        public static int ItemsCount() => WordsList.Count;

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="word">The word to be removed.</param>
        /// <returns>true if word removed else false.</returns>
        public static bool RemoveItem(string word) => WordsList.Remove(word);

        /// <summary>
        /// Removes the item at.
        /// </summary>
        /// <param name="index">The index to be removed.</param>
        /// <returns>true if item is no longer in collection else false.</returns>
        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            WordsList.RemoveAt(index);

            // Check to see if item is no longer in collection
            if (!ContainsItem(item))
            {
                return true;
            }

            // Item still in collection remove failed.
            return false;
        }

        /// <summary>
        /// Sorts the collection.
        /// </summary>
        public static void SortCollection()
        {
            WordsList.Sort();
        }

        #endregion Public Methods
    }
}