//---------------------------------------------------------------------------------------------------------------
// Spell-It
//
// SpellItForm.cs
//
// File:     Spell-It.sln
// Author:   art2m_000]
// Company:
// Date:     8/25/2018
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//----------------------------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Art2MSpell.Source
{
    /// <summary>
    /// The main win class.
    /// </summary>
    public partial class SpellItMainForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SpellItMainForm"/> class.
        /// </summary>
        public SpellItMainForm()
        {
            this.InitializeComponent();
            this.InitializeControls();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// Handles the Click event of the DisplaySpellingWordsButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DisplaySpellingWordsButton_Click(object sender, EventArgs e)
        {
            using (var frmPractice = new PracticeSpellingWordsForm())
            {
                frmPractice.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of the newSpellList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DisplaySpellingWordsMenuItem_Click(object sender, EventArgs e)

        {
            using (var frmSpellWords = new PracticeSpellingWordsForm())
            {
                frmSpellWords.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of the CloseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the CloseMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeControls()
        {
            this.pnlMain.BackColor = Color.Aquamarine;

            this.btnSpellingList.BackColor = Color.LightSeaGreen;
            this.btnDisplaySpellingWords.BackColor = Color.Chartreuse;

            this.ExitButton.BackColor = Color.RosyBrown;
        }

        /// <summary>
        /// Handles the Click event of the NewSpellListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SpellingListButton_Click(object sender, EventArgs e)
        {
            using (var frmSpellList = new SpellingWordsListForm())
            {
                frmSpellList.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of the SpellListMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SpellListMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmSpellList = new SpellingWordsListForm())
            {
                frmSpellList.ShowDialog();
            }
        }

        #endregion Private Methods
    }
}