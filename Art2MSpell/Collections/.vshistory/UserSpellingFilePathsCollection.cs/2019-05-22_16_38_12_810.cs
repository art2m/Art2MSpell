using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art2MSpell.Collections
{
    public class UserSpellingFilePathsCollection : ISpellingWordsCollection
    {
        /// <summary>
        ///     Contains collection of words to possibly become a spelling list.
        /// </summary>
        private static readonly List<string> SpellList = new List<string>();

        /// <summary>
        ///     Adds the specified word to the collection.
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

            SpellList.Add(word);
        }

        /// <summary>
        ///     clear the collection of all items.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public void ClearCollection()
        {
            SpellList.Clear();
        }

        /// <summary>
        ///     Checks the word specified to see if it is contained in the collection.
        /// </summary>
        /// <param name="word">The word to check the collection for.</param>
        /// <returns>true if the word is in the collection else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public bool ContainsItem(string word)
        {
            return SpellList.Contains(word);
        }

        /// <summary>
        ///     Get all items contained in the collection.
        /// </summary>
        /// <returns>Array of all words in collection.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public string[] GetAllItems()
        {
            var count = SpellList.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var origPath = new string[count];

            for (var i = 0; i < count; i++)
            {
                origPath[i] = SpellList[i];
            }

            // All OK.
            return origPath;
        }

        /// <summary>
        ///     Get item at the specified index.
        /// </summary>
        /// <return>The word at this index.</return>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public string GetItemAt(int index)
        {
            return SpellList[index];
        }

        /// <summary>
        ///     Get the index of this  item.
        /// </summary>
        /// <param name="word">The item to get the index of.</param>
        /// <returns>the index or else -1.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public int GetItemIndex(string word)
        {
            return SpellList.IndexOf(word);
        }

        /// <summary>
        ///     Get the count of items contained in the collection.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public int ItemsCount()
        {
            return SpellList.Count;
        }

        /// <summary>
        ///     Remove the specified word.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>true if removed else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public bool RemoveItem(string word)
        {
            return SpellList.Remove(word);
        }

        /// <summary>
        ///     Remove the item at selected index.
        /// </summary>
        /// <param name="index">The index of the item to be removed.</param>
        /// <returns>True if item is removed else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = this.GetItemAt(index);

            SpellList.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !this.ContainsItem(item);
        }

        /// <summary>
        ///     Sort the collection.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public void SortCollection()
        {
            SpellList.Sort();
        }
    }
}
