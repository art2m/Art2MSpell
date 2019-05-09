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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDisplaySpellingWords = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.btnSpellingList = new System.Windows.Forms.Button();
            this.spellItToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenuMenuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
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
            this.mnuNewSpellList.Size = new System.Drawing.Size(198, 22);
            this.mnuNewSpellList.Text = "Spelling List";
            this.mnuNewSpellList.ToolTipText = "Create, edit, or delete a spenning list.";
            this.mnuNewSpellList.Click += new System.EventHandler(this.SpellListMenuItem_Click);
            // 
            // mnuDisplaySpellingWords
            // 
            this.mnuDisplaySpellingWords.Name = "mnuDisplaySpellingWords";
            this.mnuDisplaySpellingWords.Size = new System.Drawing.Size(198, 22);
            this.mnuDisplaySpellingWords.Text = "Practice Spelling Words";
            this.mnuDisplaySpellingWords.ToolTipText = "Display spelling words to spell.";
            this.mnuDisplaySpellingWords.Click += new System.EventHandler(this.DisplaySpellingWordsMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnDisplaySpellingWords);
            this.pnlMain.Controls.Add(this.ExitButton);
            this.pnlMain.Controls.Add(this.btnSpellingList);
            this.pnlMain.Location = new System.Drawing.Point(5, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(774, 534);
            this.pnlMain.TabIndex = 1;
            // 
            // btnDisplaySpellingWords
            // 
            this.btnDisplaySpellingWords.Location = new System.Drawing.Point(209, 245);
            this.btnDisplaySpellingWords.Name = "btnDisplaySpellingWords";
            this.btnDisplaySpellingWords.Size = new System.Drawing.Size(140, 44);
            this.btnDisplaySpellingWords.TabIndex = 0;
            this.btnDisplaySpellingWords.Text = "Practice Spelling Words";
            this.spellItToolTip.SetToolTip(this.btnDisplaySpellingWords, "Display spelling words to spell.");
            this.btnDisplaySpellingWords.UseVisualStyleBackColor = true;
            this.btnDisplaySpellingWords.Click += new System.EventHandler(this.DisplaySpellingWordsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(657, 490);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 32);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.spellItToolTip.SetToolTip(this.ExitButton, "Exit the  spelling program.");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // btnSpellingList
            // 
            this.btnSpellingList.Location = new System.Drawing.Point(426, 245);
            this.btnSpellingList.Name = "btnSpellingList";
            this.btnSpellingList.Size = new System.Drawing.Size(140, 44);
            this.btnSpellingList.TabIndex = 1;
            this.btnSpellingList.Text = "Spelling List";
            this.spellItToolTip.SetToolTip(this.btnSpellingList, "Create, edit, or delete a spelling list.");
            this.btnSpellingList.UseVisualStyleBackColor = true;
            this.btnSpellingList.Click += new System.EventHandler(this.SpellingListButton_Click);
            // 
            // SpellItMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.MainMenuMenuStrip);
            this.MainMenuStrip = this.MainMenuMenuStrip;
            this.MaximizeBox = false;
            this.Name = "SpellItMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spelling  Program";
            this.MainMenuMenuStrip.ResumeLayout(false);
            this.MainMenuMenuStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuNewSpellList;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSpellingList;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolTip spellItToolTip;
        private System.Windows.Forms.Button btnDisplaySpellingWords;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplaySpellingWords;
    }
}

