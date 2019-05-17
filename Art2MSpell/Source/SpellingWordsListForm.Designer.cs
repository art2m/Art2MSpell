namespace Art2MSpell.Source
{
    partial class SpellingWordsListForm
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
            this.MnuNewSpellListMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.SpellTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpellNewSpellingList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpellOpenSpellingList = new System.Windows.Forms.ToolStripMenuItem();
            this.UserTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spelListToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpenist = new System.Windows.Forms.Button();
            this.btnClearist = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnAddNewWord = new System.Windows.Forms.Button();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnAddWordToList = new System.Windows.Forms.Button();
            this.btnCreateNewList = new System.Windows.Forms.Button();
            this.SpellingListOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SpellingListSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.flpLeftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.flpBottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cboWord = new System.Windows.Forms.ComboBox();
            this.MnuNewSpellListMenuStrip.SuspendLayout();
            this.flpLeftPanel.SuspendLayout();
            this.flpBottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuNewSpellListMenuStrip
            // 
            this.MnuNewSpellListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTopMenuItem,
            this.SpellTopMenuItem,
            this.UserTopMenuItem});
            this.MnuNewSpellListMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuNewSpellListMenuStrip.Name = "MnuNewSpellListMenuStrip";
            this.MnuNewSpellListMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MnuNewSpellListMenuStrip.TabIndex = 0;
            this.MnuNewSpellListMenuStrip.Text = "mnuNewSpellList";
            // 
            // FileTopMenuItem
            // 
            this.FileTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuClose});
            this.FileTopMenuItem.Name = "FileTopMenuItem";
            this.FileTopMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileTopMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(103, 22);
            this.mnuClose.Text = "Close";
            // 
            // SpellTopMenuItem
            // 
            this.SpellTopMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpellNewSpellingList,
            this.mnuSpellOpenSpellingList});
            this.SpellTopMenuItem.Name = "SpellTopMenuItem";
            this.SpellTopMenuItem.Size = new System.Drawing.Size(44, 20);
            this.SpellTopMenuItem.Text = "Spell";
            // 
            // mnuSpellNewSpellingList
            // 
            this.mnuSpellNewSpellingList.Name = "mnuSpellNewSpellingList";
            this.mnuSpellNewSpellingList.Size = new System.Drawing.Size(169, 22);
            // 
            // mnuSpellOpenSpellingList
            // 
            this.mnuSpellOpenSpellingList.Name = "mnuSpellOpenSpellingList";
            this.mnuSpellOpenSpellingList.Size = new System.Drawing.Size(169, 22);
            this.mnuSpellOpenSpellingList.Text = "Open Spelling List";
            this.mnuSpellOpenSpellingList.Click += new System.EventHandler(this.OnMenuSpellOpenSpellingList_Click);
            // 
            // UserTopMenuItem
            // 
            this.UserTopMenuItem.Name = "UserTopMenuItem";
            this.UserTopMenuItem.Size = new System.Drawing.Size(42, 20);
            this.UserTopMenuItem.Text = "User";
            // 
            // btnOpenist
            // 
            this.btnOpenist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenist.Location = new System.Drawing.Point(4, 115);
            this.btnOpenist.Margin = new System.Windows.Forms.Padding(4, 40, 3, 3);
            this.btnOpenist.Name = "btnOpenist";
            this.btnOpenist.Size = new System.Drawing.Size(172, 32);
            this.btnOpenist.TabIndex = 1;
            this.btnOpenist.Text = "Open Spelling List";
            this.spelListToolTip.SetToolTip(this.btnOpenist, "Open spelling list to edit or delete.");
            this.btnOpenist.UseVisualStyleBackColor = true;
            this.btnOpenist.Click += new System.EventHandler(this.OnButtonOpenList_Click);
            // 
            // btnClearist
            // 
            this.btnClearist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearist.Location = new System.Drawing.Point(4, 190);
            this.btnClearist.Margin = new System.Windows.Forms.Padding(4, 40, 3, 3);
            this.btnClearist.Name = "btnClearist";
            this.btnClearist.Size = new System.Drawing.Size(172, 32);
            this.btnClearist.TabIndex = 2;
            this.btnClearist.Text = "Clear Spelling List";
            this.spelListToolTip.SetToolTip(this.btnClearist, "Select to clear the spelling list currently displayed.");
            this.btnClearist.UseVisualStyleBackColor = true;
            this.btnClearist.Click += new System.EventHandler(this.OnButtonClearList_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveList.Location = new System.Drawing.Point(4, 340);
            this.btnSaveList.Margin = new System.Windows.Forms.Padding(4, 40, 0, 0);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(172, 32);
            this.btnSaveList.TabIndex = 4;
            this.btnSaveList.Text = "Save Spelling List";
            this.spelListToolTip.SetToolTip(this.btnSaveList, "Select to save the new spelling list.");
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.OnButtonSaveList_Click);
            // 
            // lstWords
            // 
            this.lstWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 16;
            this.lstWords.Location = new System.Drawing.Point(219, 31);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(388, 500);
            this.lstWords.TabIndex = 2;
            this.spelListToolTip.SetToolTip(this.lstWords, "Spelling words list. Select word to edit or delete the spelling list.");
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewWord.Location = new System.Drawing.Point(20, 6);
            this.btnAddNewWord.Margin = new System.Windows.Forms.Padding(15, 6, 3, 3);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(120, 32);
            this.btnAddNewWord.TabIndex = 0;
            this.btnAddNewWord.Text = "Add New Word";
            this.spelListToolTip.SetToolTip(this.btnAddNewWord, "Select  to add a new word.");
            this.btnAddNewWord.UseVisualStyleBackColor = true;
            this.btnAddNewWord.Click += new System.EventHandler(this.OnButtonAddNewWord_Click);
            // 
            // btnEditWord
            // 
            this.btnEditWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWord.Location = new System.Drawing.Point(158, 6);
            this.btnEditWord.Margin = new System.Windows.Forms.Padding(15, 6, 3, 3);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(120, 32);
            this.btnEditWord.TabIndex = 1;
            this.btnEditWord.Text = "Edit Word";
            this.spelListToolTip.SetToolTip(this.btnEditWord, "Select to edit currently displayed word.");
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.OnButtonEditWord_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWord.Location = new System.Drawing.Point(296, 6);
            this.btnDeleteWord.Margin = new System.Windows.Forms.Padding(15, 6, 3, 3);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(120, 32);
            this.btnDeleteWord.TabIndex = 2;
            this.btnDeleteWord.Text = "Delete Word";
            this.spelListToolTip.SetToolTip(this.btnDeleteWord, "Select to delete the selected word from the spelling list.");
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.OnButtonDeleteWord_Click);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOperation.Location = new System.Drawing.Point(434, 6);
            this.btnCancelOperation.Margin = new System.Windows.Forms.Padding(15, 6, 3, 3);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(120, 32);
            this.btnCancelOperation.TabIndex = 3;
            this.btnCancelOperation.Text = "Cancel Operation";
            this.spelListToolTip.SetToolTip(this.btnCancelOperation, "Select to cancel the current operation.");
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.OnButtonCancelOperation_Click);
            // 
            // btnAddWordToList
            // 
            this.btnAddWordToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddWordToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWordToList.Location = new System.Drawing.Point(572, 6);
            this.btnAddWordToList.Margin = new System.Windows.Forms.Padding(15, 6, 3, 3);
            this.btnAddWordToList.Name = "btnAddWordToList";
            this.btnAddWordToList.Size = new System.Drawing.Size(124, 32);
            this.btnAddWordToList.TabIndex = 4;
            this.btnAddWordToList.Text = "Add Word To List";
            this.spelListToolTip.SetToolTip(this.btnAddWordToList, "Select to add currently displayed word to the spelling list.");
            this.btnAddWordToList.UseVisualStyleBackColor = true;
            this.btnAddWordToList.Click += new System.EventHandler(this.OnButtonAddWordToList_Click);
            // 
            // btnCreateNewList
            // 
            this.btnCreateNewList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewList.Location = new System.Drawing.Point(4, 40);
            this.btnCreateNewList.Margin = new System.Windows.Forms.Padding(4, 40, 3, 3);
            this.btnCreateNewList.Name = "btnCreateNewList";
            this.btnCreateNewList.Size = new System.Drawing.Size(172, 32);
            this.btnCreateNewList.TabIndex = 0;
            this.btnCreateNewList.Text = "Create New LIst";
            this.btnCreateNewList.Click += new System.EventHandler(this.OnButtonCreateNewSpellingList_Click);
            // 
            // SpellingListOpenFileDialog
            // 
            this.SpellingListOpenFileDialog.DefaultExt = "txt";
            this.SpellingListOpenFileDialog.FileName = "openSpellingListDialog";
            this.SpellingListOpenFileDialog.Filter = "text files (*.text)|*.text";
            this.SpellingListOpenFileDialog.InitialDirectory = "Documents";
            this.SpellingListOpenFileDialog.Title = "Select Spelling List";
            // 
            // SpellingListSaveFileDialog
            // 
            this.SpellingListSaveFileDialog.CheckFileExists = true;
            this.SpellingListSaveFileDialog.FileName = "SaveSpellingListDialog";
            this.SpellingListSaveFileDialog.Filter = "text files (*.text)|*.text";
            this.SpellingListSaveFileDialog.InitialDirectory = "Documents";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(682, 640);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnButtonClose_Click);
            // 
            // flpLeftPanel
            // 
            this.flpLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpLeftPanel.Controls.Add(this.btnCreateNewList);
            this.flpLeftPanel.Controls.Add(this.btnOpenist);
            this.flpLeftPanel.Controls.Add(this.btnClearist);
            this.flpLeftPanel.Controls.Add(this.btnDeleteList);
            this.flpLeftPanel.Controls.Add(this.btnSaveList);
            this.flpLeftPanel.Location = new System.Drawing.Point(33, 45);
            this.flpLeftPanel.Name = "flpLeftPanel";
            this.flpLeftPanel.Size = new System.Drawing.Size(180, 458);
            this.flpLeftPanel.TabIndex = 1;
            this.flpLeftPanel.TabStop = true;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteList.Location = new System.Drawing.Point(4, 265);
            this.btnDeleteList.Margin = new System.Windows.Forms.Padding(4, 40, 3, 3);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(172, 32);
            this.btnDeleteList.TabIndex = 3;
            this.btnDeleteList.Text = "Delete Spelling List";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.OnButtonDeleteList_Click);
            // 
            // flpBottomPanel
            // 
            this.flpBottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBottomPanel.Controls.Add(this.btnAddNewWord);
            this.flpBottomPanel.Controls.Add(this.btnEditWord);
            this.flpBottomPanel.Controls.Add(this.btnDeleteWord);
            this.flpBottomPanel.Controls.Add(this.btnCancelOperation);
            this.flpBottomPanel.Controls.Add(this.btnAddWordToList);
            this.flpBottomPanel.Location = new System.Drawing.Point(29, 574);
            this.flpBottomPanel.Name = "flpBottomPanel";
            this.flpBottomPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flpBottomPanel.Size = new System.Drawing.Size(743, 49);
            this.flpBottomPanel.TabIndex = 4;
            this.flpBottomPanel.TabStop = true;
            // 
            // cboWord
            // 
            this.cboWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWord.FormattingEnabled = true;
            this.cboWord.Location = new System.Drawing.Point(219, 539);
            this.cboWord.Margin = new System.Windows.Forms.Padding(185, 15, 3, 3);
            this.cboWord.MaxLength = 400;
            this.cboWord.Name = "cboWord";
            this.cboWord.Size = new System.Drawing.Size(391, 28);
            this.cboWord.TabIndex = 3;
            // 
            // SpellingWordsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 684);
            this.Controls.Add(this.flpLeftPanel);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.flpBottomPanel);
            this.Controls.Add(this.cboWord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.MnuNewSpellListMenuStrip);
            this.MainMenuStrip = this.MnuNewSpellListMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SpellingWordsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a New Spelling List or Modify Existing Spelling List.";
            this.Resize += new System.EventHandler(this.SpellingWordsListForm_Resize);
            this.MnuNewSpellListMenuStrip.ResumeLayout(false);
            this.MnuNewSpellListMenuStrip.PerformLayout();
            this.flpLeftPanel.ResumeLayout(false);
            this.flpBottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuNewSpellListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolTip spelListToolTip;
        private System.Windows.Forms.OpenFileDialog SpellingListOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SpellingListSaveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flpLeftPanel;
        private System.Windows.Forms.Button btnCreateNewList;
        private System.Windows.Forms.Button btnOpenist;
        private System.Windows.Forms.Button btnClearist;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.FlowLayoutPanel flpBottomPanel;
        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnAddWordToList;
        private System.Windows.Forms.ComboBox cboWord;
        private System.Windows.Forms.ToolStripMenuItem SpellTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSpellOpenSpellingList;
        private System.Windows.Forms.ToolStripMenuItem mnuSpellNewSpellingList;
        private System.Windows.Forms.ToolStripMenuItem UserTopMenuItem;
    }
}