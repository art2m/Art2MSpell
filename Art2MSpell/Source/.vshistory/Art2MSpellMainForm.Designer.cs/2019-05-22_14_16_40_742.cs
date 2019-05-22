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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.spellItToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.btnPracticeSpellingWords = new System.Windows.Forms.Button();
            this.btnSpellingList = new System.Windows.Forms.Button();
            this.pnlSpellingControls = new System.Windows.Forms.Panel();
            this.panelUserNewSelect = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainMenuMenuStrip.SuspendLayout();
            this.pnlSpellingControls.SuspendLayout();
            this.panelUserNewSelect.SuspendLayout();
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
            this.mnuFileExit.Click += new System.EventHandler(this.OnExitMenuItem_Click);
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
            this.mnuUserSelect,
            this.toolStripSeparator1,
            this.mnuUserEdit,
            this.mnuUserRemove});
            this.UserTopMenuItem.Name = "UserTopMenuItem";
            this.UserTopMenuItem.Size = new System.Drawing.Size(42, 20);
            this.UserTopMenuItem.Text = "User";
            // 
            // mnuUserAddNew
            // 
            this.mnuUserAddNew.Name = "mnuUserAddNew";
            this.mnuUserAddNew.Size = new System.Drawing.Size(155, 22);
            this.mnuUserAddNew.Text = "Add New User";
            this.mnuUserAddNew.Click += new System.EventHandler(this.OnUserAddNewMenuItem_Click);
            // 
            // mnuUserSelect
            // 
            this.mnuUserSelect.Name = "mnuUserSelect";
            this.mnuUserSelect.Size = new System.Drawing.Size(155, 22);
            this.mnuUserSelect.Text = "Select User ";
            this.mnuUserSelect.Click += new System.EventHandler(this.OnUserSelectMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // mnuUserEdit
            // 
            this.mnuUserEdit.Name = "mnuUserEdit";
            this.mnuUserEdit.Size = new System.Drawing.Size(155, 22);
            this.mnuUserEdit.Text = "Edit User Name";
            this.mnuUserEdit.Click += new System.EventHandler(this.OnOnUserEditUserNameMenuItem_Click);
            // 
            // mnuUserRemove
            // 
            this.mnuUserRemove.Name = "mnuUserRemove";
            this.mnuUserRemove.Size = new System.Drawing.Size(155, 22);
            this.mnuUserRemove.Text = "Remove User";
            this.mnuUserRemove.Click += new System.EventHandler(this.OnRemoveUserNameMenuItem_Click);
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
            this.ExitButton.Click += new System.EventHandler(this.OnExitButton_Click);
            // 
            // btnPracticeSpellingWords
            // 
            this.btnPracticeSpellingWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPracticeSpellingWords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPracticeSpellingWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticeSpellingWords.Location = new System.Drawing.Point(75, 21);
            this.btnPracticeSpellingWords.Name = "btnPracticeSpellingWords";
            this.btnPracticeSpellingWords.Size = new System.Drawing.Size(160, 44);
            this.btnPracticeSpellingWords.TabIndex = 5;
            this.btnPracticeSpellingWords.Text = "Practice Spelling Words";
            this.spellItToolTip.SetToolTip(this.btnPracticeSpellingWords, "Display spelling words to spell.");
            this.btnPracticeSpellingWords.UseVisualStyleBackColor = true;
            this.btnPracticeSpellingWords.Click += new System.EventHandler(this.OnPracticeWordsButton_Click);
            // 
            // btnSpellingList
            // 
            this.btnSpellingList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpellingList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpellingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpellingList.Location = new System.Drawing.Point(286, 21);
            this.btnSpellingList.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSpellingList.Name = "btnSpellingList";
            this.btnSpellingList.Size = new System.Drawing.Size(160, 44);
            this.btnSpellingList.TabIndex = 6;
            this.btnSpellingList.Text = "Spelling List";
            this.spellItToolTip.SetToolTip(this.btnSpellingList, "Create, edit, or delete a spelling list.");
            this.btnSpellingList.UseVisualStyleBackColor = true;
            this.btnSpellingList.Click += new System.EventHandler(this.OnSpellingListButton_Click);
            // 
            // pnlSpellingControls
            // 
            this.pnlSpellingControls.Controls.Add(this.btnPracticeSpellingWords);
            this.pnlSpellingControls.Controls.Add(this.btnSpellingList);
            this.pnlSpellingControls.Location = new System.Drawing.Point(132, 332);
            this.pnlSpellingControls.Name = "pnlSpellingControls";
            this.pnlSpellingControls.Size = new System.Drawing.Size(521, 89);
            this.pnlSpellingControls.TabIndex = 7;
            // 
            // panelUserNewSelect
            // 
            this.panelUserNewSelect.Controls.Add(this.button1);
            this.panelUserNewSelect.Controls.Add(this.btnAdd);
            this.panelUserNewSelect.Location = new System.Drawing.Point(132, 197);
            this.panelUserNewSelect.Name = "panelUserNewSelect";
            this.panelUserNewSelect.Size = new System.Drawing.Size(521, 89);
            this.panelUserNewSelect.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(70, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New User";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(286, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Art2MSpellMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelUserNewSelect);
            this.Controls.Add(this.pnlSpellingControls);
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
            this.pnlSpellingControls.ResumeLayout(false);
            this.panelUserNewSelect.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnPracticeSpellingWords;
        private System.Windows.Forms.Button btnSpellingList;
        private System.Windows.Forms.ToolStripMenuItem UserTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUserAddNew;
        private System.Windows.Forms.ToolStripMenuItem mnuUserSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuPracticeForm;
        private System.Windows.Forms.ToolStripMenuItem mnuUserEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUserRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlSpellingControls;
        private System.Windows.Forms.Panel panelUserNewSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
    }
}

