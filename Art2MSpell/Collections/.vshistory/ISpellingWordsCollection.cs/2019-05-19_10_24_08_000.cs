// Art2MSpell
// 
// ISpellingWordsCollection.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 05  19  2019
// 
//      2019
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
    public interface ISpellingWordsCollection
    {
        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="word">Add new word to the collection.</param>
        void AddItem(string word);

        /// <summary>
        /// Clears the collection.
        /// </summary>
        void ClearCollection();

        /// <summary>
        /// Determines whether the specified word contains item.
        /// </summary>
        /// <param name="word">Check if the word is contained in the collection.</param>
        /// <returns><c>true</c> if the specified word contains item; otherwise, <c>false</c>.</returns>
        bool ContainsItem(string word);

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <returns>All items.</returns>
        string[] GetAllItems();

        /// <summary>
        /// Gets the item at.
        /// </summary>
        /// <param name="index">The items index.</param>
        /// <returns>The item.</returns>
        string GetItemAt(int index);

        /// <summary>
        /// Gets the index of the item.
        /// </summary>
        /// <param name="word">The word to find index for.</param>
        /// <returns>Return the index of the item.</returns>
        int GetItemIndex(string word);

        /// <summary>
        /// Items the count.
        /// </summary>
        /// <returns>The items count.</returns>
        int ItemsCount();

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="word">The word to be removed.</param>
        /// <returns>true if word removed else false.</returns>
        bool RemoveItem(string word);

        /// <summary>
        /// Removes the item at.
        /// </summary>
        /// <param name="index">The index to be removed.</param>
        /// <returns>true if item is no longer in collection else false.</returns>
        bool RemoveItemAt(int index);

        /// <summary>
        /// Sorts the collection.
        /// </summary>
        void SortCollection();
    }
}