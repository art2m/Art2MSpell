namespace Art2MSpell.Source
{
    partial class SpellItMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.spellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewSpellList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplaySpellingWords = new System.Windows.Forms.ToolStripMenuItem();
            this.spellItToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.btnPracticeSpellingWords = new System.Windows.Forms.Button();
            this.btnSpellingList = new System.Windows.Forms.Button();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.MainMenuMenuStrip.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuMenuStrip
            // 
            this.MainMenuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.spellToolStripMenuItem});
            this.MainMenuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuMenuStrip.Name = "MainMenuMenuStrip";
            this.MainMenuMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MainMenuMenuStrip.TabIndex = 0;
            this.MainMenuMenuStrip.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.ToolTipText = "Exit the  spelling program.";
            this.mnuExit.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // spellToolStripMenuItem
            // 
            this.spellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewSpellList,
            this.mnuDisplaySpellingWords});
            this.spellToolStripMenuItem.Name = "spellToolStripMenuItem";
            this.spellToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spellToolStripMenuItem.Text = "Spell";
            // 
            // mnuNewSpellList
            // 
            this.mnuNewSpellList.Name = "mnuNewSpellList";
            this.mnuNewSpellList.Size = new System.Drawing.Size(137, 22);
            this.mnuNewSpellList.Text = "Spelling List";
            this.mnuNewSpellList.ToolTipText = "Create, edit, or delete a spenning list.";
            this.mnuNewSpellList.Click += new System.EventHandler(this.SpellListMenuItem_Click);
            // 
            // mnuDisplaySpellingWords
            // 
            this.mnuDisplaySpellingWords.Name = "mnuDisplaySpellingWords";
            this.mnuDisplaySpellingWords.Size = new System.Drawing.Size(137, 22);
            this.mnuDisplaySpellingWords.Text = "Practice";
            this.mnuDisplaySpellingWords.ToolTipText = "Display spelling words to spell.";
            this.mnuDisplaySpellingWords.Click += new System.EventHandler(this.PracticeWordsMenuItem_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(664, 517);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 32);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.spellItToolTip.SetToolTip(this.ExitButton, "Exit the  spelling program.");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // btnPracticeSpellingWords
            // 
            this.btnPracticeSpellingWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPracticeSpellingWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticeSpellingWords.Location = new System.Drawing.Point(13, 6);
            this.btnPracticeSpellingWords.Name = "btnPracticeSpellingWords";
            this.btnPracticeSpellingWords.Size = new System.Drawing.Size(160, 44);
            this.btnPracticeSpellingWords.TabIndex = 5;
            this.btnPracticeSpellingWords.Text = "Practice Spelling Words";
            this.spellItToolTip.SetToolTip(this.btnPracticeSpellingWords, "Display spelling words to spell.");
            this.btnPracticeSpellingWords.UseVisualStyleBackColor = true;
            this.btnPracticeSpellingWords.Click += new System.EventHandler(this.PracticeWordsButton_Click);
            // 
            // btnSpellingList
            // 
            this.btnSpellingList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpellingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpellingList.Location = new System.Drawing.Point(276, 9);
            this.btnSpellingList.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSpellingList.Name = "btnSpellingList";
            this.btnSpellingList.Size = new System.Drawing.Size(160, 44);
            this.btnSpellingList.TabIndex = 6;
            this.btnSpellingList.Text = "Spelling List";
            this.spellItToolTip.SetToolTip(this.btnSpellingList, "Create, edit, or delete a spelling list.");
            this.btnSpellingList.UseVisualStyleBackColor = true;
            this.btnSpellingList.Click += new System.EventHandler(this.SpellingListButton_Click);
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnPracticeSpellingWords);
            this.flpButtons.Controls.Add(this.btnSpellingList);
            this.flpButtons.Location = new System.Drawing.Point(139, 251);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.flpButtons.Size = new System.Drawing.Size(457, 58);
            this.flpButtons.TabIndex = 6;
            // 
            // SpellItMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainMenuMenuStrip);
            this.MainMenuStrip = this.MainMenuMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SpellItMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spelling  Program";
            this.Resize += new System.EventHandler(this.SpellItMainForm_Resize);
            this.MainMenuMenuStrip.ResumeLayout(false);
            this.MainMenuMenuStrip.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuNewSpellList;
        private System.Windows.Forms.ToolTip spellItToolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplaySpellingWords;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnPracticeSpellingWords;
        private System.Windows.Forms.Button btnSpellingList;
    }
}

