﻿//---------------------------------------------------------------------------------------------------------------
// Art2MSpell
//
// SuggestedWordsCollection.cs
//
// File:     Art2MSpell.sln
//
// Author:   art2m_000]
// Email     art2m@live.com
// Company:
// Date:     5/8/2019
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
    /// Holds suggested words for a misspelled word.
    /// </summary>
    public class SuggestedWordsCollection : ISpellingWordsCollection
    {
        /// <summary>
        /// Contains collection of words to possibly become a spelling list.
        /// </summary>
        private static readonly List<string> WordsList = new List<string>();

        /// <summary>
        ///  Adds the specified word to the collection.
        /// </summary>
        /// <param name="word">The word to be added to the collection.</param>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public void AddItem(string word)
        {
            if (this.ContainsItem(word))
            {
                return;
            }

            WordsList.Add(word);
        }

        /// <summary>
        /// clear the collection of all items.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public void ClearCollection()
        {
            WordsList.Clear();
        }

        /// <summary>
        /// Checks the word specified to see if it is contained in the collection.
        /// </summary>
        /// <param name="word">The word to check the collection for.</param>
        /// <returns>true if the word is in the collection else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public bool ContainsItem(string word) => WordsList.Contains(word);


        /// <summary>
        /// Get all items contained in the collection.
        /// </summary>
        /// <returns>Array of all words in collection.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public string[] GetAllItems()
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
        /// Get item at the specified index.
        /// </summary>
        /// <return>The word at this index.</return>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public string GetItemAt(int index) => WordsList[index];

        /// <summary>
        ///  Get the index of this  item.
        /// </summary>
        /// <param name="word">The item to get the index of.</param>
        /// <returns>the index or else -1.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public int GetItemIndex(string word) => WordsList.IndexOf(word);

        /// <summary>
        ///Get the count of items contained in the collection.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public int ItemsCount() => WordsList.Count;

        /// <summary>
        /// Remove the specified word.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>true if removed else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public bool RemoveItem(string word) => WordsList.Remove(word);

        /// <summary>
        /// Remove the item at selected index.
        /// </summary>
        /// <param name="index">The index of the item to be removed.</param>
        /// <returns>True if item is removed else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = this.GetItemAt(index);

            WordsList.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !this.ContainsItem(item);

            // Item still in collection remove failed.
        }

        /// <summary>
        /// Sort the collection.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public void SortCollection()
        {
            WordsList.Sort();
        }
    }
}