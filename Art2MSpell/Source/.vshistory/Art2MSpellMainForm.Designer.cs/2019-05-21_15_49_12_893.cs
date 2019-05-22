namespace Art2MSpell.Source
{
    partial class Art2MSpellMainForm
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
            this.FileTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SpellTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpellingForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPracticeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.UserTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.spellItToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.btnPracticeSpellingWords = new System.Windows.Forms.Button();
            this.btnSpellingList = new System.Windows.Forms.Button();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.mnuUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuMenuStrip.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuMenuStrip
            // 
            this.MainMenuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTopMenuItem,
            this.SpellTopMenuItem,
            this.UserTopMenuItem});
            this.MainMenuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuMenuStrip.Name = "MainMenuMenuStrip";
            this.MainMenuMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MainMenuMenuStrip.TabIndex = 0;
            this.MainMenuMenuStrip.Text = "MainMenu";
            // 
            // FileTopMenuItem
            // 
            this.FileTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.FileTopMenuItem.Name = "FileTopMenuItem";
            this.FileTopMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileTopMenuItem.Text = "File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(92, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.ToolTipText = "Exit the  spelling program.";
            this.mnuFileExit.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // SpellTopMenuItem
            // 
            this.SpellTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpellingForm,
            this.mnuPracticeForm});
            this.SpellTopMenuItem.Name = "SpellTopMenuItem";
            this.SpellTopMenuItem.Size = new System.Drawing.Size(44, 20);
            this.SpellTopMenuItem.Text = "Spell";
            // 
            // mnuSpellingForm
            // 
            this.mnuSpellingForm.Name = "mnuSpellingForm";
            this.mnuSpellingForm.Size = new System.Drawing.Size(261, 22);
            this.mnuSpellingForm.Text = "Show Spelling List Form";
            this.mnuSpellingForm.ToolTipText = "Create, edit, or delete a spenning list.";
            this.mnuSpellingForm.Click += new System.EventHandler(this.OnSpellingListFormShowMenuItem_Click);
            // 
            // mnuPracticeForm
            // 
            this.mnuPracticeForm.Name = "mnuPracticeForm";
            this.mnuPracticeForm.Size = new System.Drawing.Size(261, 22);
            this.mnuPracticeForm.Text = "Show Practice Spelling Words Form";
            this.mnuPracticeForm.Click += new System.EventHandler(this.OnSpellingPracticeWordsFormMenuItem_Click);
            // 
            // UserTopMenuItem
            // 
            this.UserTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserAddNew,
            this.mnuUserEdit,
            this.mnuUserRemove,
            this.mnuUserSelect});
            this.UserTopMenuItem.Name = "UserTopMenuItem";
            this.UserTopMenuItem.Size = new System.Drawing.Size(42, 20);
            this.UserTopMenuItem.Text = "User";
            // 
            // mnuUserAddNew
            // 
            this.mnuUserAddNew.Name = "mnuUserAddNew";
            this.mnuUserAddNew.Size = new System.Drawing.Size(180, 22);
            this.mnuUserAddNew.Text = "Add New User";
            this.mnuUserAddNew.Click += new System.EventHandler(this.UserAddNewMenuItem_Click);
            // 
            // mnuUserSelect
            // 
            this.mnuUserSelect.Name = "mnuUserSelect";
            this.mnuUserSelect.Size = new System.Drawing.Size(180, 22);
            this.mnuUserSelect.Text = "Select User";
            this.mnuUserSelect.Click += new System.EventHandler(this.UserSelectMenuItem_Click);
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
            this.btnPracticeSpellingWords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btnSpellingList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // mnuUserEdit
            // 
            this.mnuUserEdit.Name = "mnuUserEdit";
            this.mnuUserEdit.Size = new System.Drawing.Size(180, 22);
            this.mnuUserEdit.Text = "Edit User Name";
            this.mnuUserEdit.Click += new System.EventHandler(this.OnMenu);
            // 
            // mnuUserRemove
            // 
            this.mnuUserRemove.Name = "mnuUserRemove";
            this.mnuUserRemove.Size = new System.Drawing.Size(180, 22);
            this.mnuUserRemove.Text = "Remove User";
            this.mnuUserRemove.Click += new System.EventHandler(this.OnMenuRemoveUserName_Click);
            // 
            // Art2MSpellMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainMenuMenuStrip);
            this.MainMenuStrip = this.MainMenuMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Art2MSpellMainForm";
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
        private System.Windows.Forms.ToolStripMenuItem FileTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpellTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSpellingForm;
        private System.Windows.Forms.ToolTip spellItToolTip;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnPracticeSpellingWords;
        private System.Windows.Forms.Button btnSpellingList;
        private System.Windows.Forms.ToolStripMenuItem UserTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUserAddNew;
        private System.Windows.Forms.ToolStripMenuItem mnuUserSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuPracticeForm;
        private System.Windows.Forms.ToolStripMenuItem mnuUserEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUserRemove;
    }
}

