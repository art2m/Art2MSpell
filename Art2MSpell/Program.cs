using System;
using System.Windows.Forms;
using Art2MSpell.Source;

namespace Art2MSpell
{
    internal static class Program
    {
        #region Private Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Art2MSpellMainForm());
        }

        #endregion Private Methods
    }
}