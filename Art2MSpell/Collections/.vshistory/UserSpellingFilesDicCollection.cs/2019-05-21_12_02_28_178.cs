

namespace Art2MSpell.Collections
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    ///     Key value song Name value is song path.
    /// </summary>
    public static class UserSpellingFilesDicCollection
    {
        /// <summary>
        ///     The class name
        /// </summary>
        private static readonly string ClassName = MethodBase.GetCurrentMethod().DeclaringType?.Name;

        /// <summary>
        ///     The genre directory list.
        /// </summary>
        private static readonly Dictionary<string, string> Usl = new Dictionary<string, string>();

        static UserSpellingFilesDicCollection()
        {

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
            var caption = methodName + " - " + ClassName;

            if (!ContainsKey(keyItem))
            {
                const string msg = "This genre directory name could not be found in the list.";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return string.Empty;
            }

            Usl.TryGetValue(keyItem, out var keyValue);
            return keyValue;
        }
    }
}