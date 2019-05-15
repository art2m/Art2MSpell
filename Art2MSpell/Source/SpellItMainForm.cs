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
        /// <summary>
        /// Initializes a new instance of the <see cref="SpellItMainForm"/> class.
        /// </summary>
        public SpellItMainForm()
        {
            this.InitializeComponent();
            this.InitializeControls();
        }

        /// <summary>
        /// Show the practice form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void PracticeWordsButton_Click(object sender, EventArgs e)
        {
            using (var frmPractice = new PracticeSpellingWordsForm())
            {
                frmPractice.ShowDialog();
            }
        }

        /// <summary>
        /// Show the practice form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void PracticeWordsMenuItem_Click(object sender, EventArgs e)

        {
            using (var frmSpellWords = new PracticeSpellingWordsForm())
            {
                frmSpellWords.ShowDialog();
            }
        }

        /// <summary>
        /// Exit the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  Exit the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeControls()
        {
            this.BackColor = Color.Aquamarine;

            this.btnSpellingList.BackColor = Color.LightSeaGreen;
            this.btnPracticeSpellingWords.BackColor = Color.Chartreuse;

            this.ExitButton.BackColor = Color.RosyBrown;
        }

        /// <summary>
        ///  Show the spelling list form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void SpellingListButton_Click(object sender, EventArgs e)
        {
            using (var frmSpellList = new SpellingWordsListForm())
            {
                frmSpellList.ShowDialog();
            }
        }

        /// <summary>
        ///  show the spelling list form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void SpellListMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmSpellList = new SpellingWordsListForm())
            {
                frmSpellList.ShowDialog();
            }
        }

        /// <summary>
        /// Center buttons on screen.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the data.</param>
        /// <created>art2m,5/14/2019</created>
        /// <changed>art2m,5/14/2019</changed>
        private void SpellItMainForm_Resize(object sender, EventArgs e)
        {
            this.flpButtons.Left = (this.ClientSize.Width - this.flpButtons.Width) / 2;
            this.flpButtons.Top = (this.ClientSize.Height - this.flpButtons.Height) / 2;
        }
    }
}