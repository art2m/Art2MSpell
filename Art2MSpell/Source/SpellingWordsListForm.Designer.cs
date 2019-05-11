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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenSpellingList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlWordList = new System.Windows.Forms.Panel();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnOpenist = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.btnCreateNewList = new System.Windows.Forms.Button();
            this.btnClearist = new System.Windows.Forms.Button();
            this.lstWordsList = new System.Windows.Forms.ListBox();
            this.pnlWord = new System.Windows.Forms.Panel();
            this.cboWord = new System.Windows.Forms.ComboBox();
            this.btnAddWordToList = new System.Windows.Forms.Button();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnAddNewWord = new System.Windows.Forms.Button();
            this.spelListToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SpellingListOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SpellingListSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MnuNewSpellListMenuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlWordList.SuspendLayout();
            this.pnlWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuNewSpellListMenuStrip
            // 
            this.MnuNewSpellListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MnuNewSpellListMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuNewSpellListMenuStrip.Name = "MnuNewSpellListMenuStrip";
            this.MnuNewSpellListMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MnuNewSpellListMenuStrip.TabIndex = 0;
            this.MnuNewSpellListMenuStrip.Text = "mnuNewSpellList";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenSpellingList,
            this.toolStripSeparator1,
            this.mnuClose});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // mnuOpenSpellingList
            // 
            this.mnuOpenSpellingList.Name = "mnuOpenSpellingList";
            this.mnuOpenSpellingList.Size = new System.Drawing.Size(169, 22);
            this.mnuOpenSpellingList.Text = "Open Spelling List";
            this.mnuOpenSpellingList.Click += new System.EventHandler(this.OnOpenSpellingListMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(169, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.OnCloseMenuItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(661, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnCloseButtonClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlWordList);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.pnlWord);
            this.pnlMain.Location = new System.Drawing.Point(5, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(774, 534);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlWordList
            // 
            this.pnlWordList.Controls.Add(this.btnDeleteList);
            this.pnlWordList.Controls.Add(this.btnOpenist);
            this.pnlWordList.Controls.Add(this.btnSaveList);
            this.pnlWordList.Controls.Add(this.btnCreateNewList);
            this.pnlWordList.Controls.Add(this.btnClearist);
            this.pnlWordList.Controls.Add(this.lstWordsList);
            this.pnlWordList.Location = new System.Drawing.Point(62, 17);
            this.pnlWordList.Name = "pnlWordList";
            this.pnlWordList.Size = new System.Drawing.Size(650, 331);
            this.pnlWordList.TabIndex = 0;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(502, 213);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(141, 33);
            this.btnDeleteList.TabIndex = 4;
            this.btnDeleteList.Text = "Delete Spelling List";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.OnDeleteSpellingListClick);
            // 
            // btnOpenist
            // 
            this.btnOpenist.Location = new System.Drawing.Point(502, 79);
            this.btnOpenist.Name = "btnOpenist";
            this.btnOpenist.Size = new System.Drawing.Size(141, 33);
            this.btnOpenist.TabIndex = 2;
            this.btnOpenist.Text = "Open Spelling List";
            this.spelListToolTip.SetToolTip(this.btnOpenist, "Open spelling list to edit or delete.");
            this.btnOpenist.UseVisualStyleBackColor = true;
            this.btnOpenist.Click += new System.EventHandler(this.OnSelectSpellingListButtonClick);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(502, 280);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(141, 33);
            this.btnSaveList.TabIndex = 5;
            this.btnSaveList.Text = "Save Spelling List";
            this.spelListToolTip.SetToolTip(this.btnSaveList, "Select to save the new spelling list.");
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.OnSaveSpellingListButtonClick);
            // 
            // btnCreateNewList
            // 
            this.btnCreateNewList.Location = new System.Drawing.Point(502, 12);
            this.btnCreateNewList.Name = "btnCreateNewList";
            this.btnCreateNewList.Size = new System.Drawing.Size(141, 33);
            this.btnCreateNewList.TabIndex = 1;
            this.btnCreateNewList.Text = "Create New Spelling List";
            this.spelListToolTip.SetToolTip(this.btnCreateNewList, "Select to create a new spelling list.");
            this.btnCreateNewList.UseVisualStyleBackColor = true;
            this.btnCreateNewList.Click += new System.EventHandler(this.OnCreateNewListButtonClick);
            // 
            // btnClearist
            // 
            this.btnClearist.Location = new System.Drawing.Point(502, 146);
            this.btnClearist.Name = "btnClearist";
            this.btnClearist.Size = new System.Drawing.Size(141, 33);
            this.btnClearist.TabIndex = 3;
            this.btnClearist.Text = "Clear Spelling List";
            this.spelListToolTip.SetToolTip(this.btnClearist, "Select to clear the spelling list currently displayed.");
            this.btnClearist.UseVisualStyleBackColor = true;
            this.btnClearist.Click += new System.EventHandler(this.OnClearSpellingListButtonClick);
            // 
            // lstWordsList
            // 
            this.lstWordsList.FormattingEnabled = true;
            this.lstWordsList.Location = new System.Drawing.Point(12, 12);
            this.lstWordsList.Name = "lstWordsList";
            this.lstWordsList.Size = new System.Drawing.Size(485, 303);
            this.lstWordsList.TabIndex = 0;
            this.spelListToolTip.SetToolTip(this.lstWordsList, "Spelling words list. Select word to edit or delete the spelling list.");
            this.lstWordsList.SelectedIndexChanged += new System.EventHandler(this.WordsList_SelectedIndexChanged);
            // 
            // pnlWord
            // 
            this.pnlWord.Controls.Add(this.cboWord);
            this.pnlWord.Controls.Add(this.btnAddWordToList);
            this.pnlWord.Controls.Add(this.btnCancelOperation);
            this.pnlWord.Controls.Add(this.btnEditWord);
            this.pnlWord.Controls.Add(this.btnDeleteWord);
            this.pnlWord.Controls.Add(this.btnAddNewWord);
            this.pnlWord.Location = new System.Drawing.Point(98, 366);
            this.pnlWord.Name = "pnlWord";
            this.pnlWord.Size = new System.Drawing.Size(579, 99);
            this.pnlWord.TabIndex = 1;
            // 
            // cboWord
            // 
            this.cboWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWord.FormattingEnabled = true;
            this.cboWord.Location = new System.Drawing.Point(13, 12);
            this.cboWord.Name = "cboWord";
            this.cboWord.Size = new System.Drawing.Size(535, 28);
            this.cboWord.TabIndex = 0;
            // 
            // btnAddWordToList
            // 
            this.btnAddWordToList.Location = new System.Drawing.Point(461, 51);
            this.btnAddWordToList.Name = "btnAddWordToList";
            this.btnAddWordToList.Size = new System.Drawing.Size(100, 32);
            this.btnAddWordToList.TabIndex = 5;
            this.btnAddWordToList.Text = "Add Word To List";
            this.spelListToolTip.SetToolTip(this.btnAddWordToList, "Select to add currently displayed word to the spelling list.");
            this.btnAddWordToList.UseVisualStyleBackColor = true;
            this.btnAddWordToList.Click += new System.EventHandler(this.OnAddWordToListButtonClick);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(349, 51);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(100, 32);
            this.btnCancelOperation.TabIndex = 4;
            this.btnCancelOperation.Text = "Cancel Operation";
            this.spelListToolTip.SetToolTip(this.btnCancelOperation, "Select to cancel the current operation.");
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.OnCancelOperationButtonClick);
            // 
            // btnEditWord
            // 
            this.btnEditWord.Location = new System.Drawing.Point(125, 51);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(100, 32);
            this.btnEditWord.TabIndex = 2;
            this.btnEditWord.Text = "Edit Word";
            this.spelListToolTip.SetToolTip(this.btnEditWord, "Select to edit currently displayed word.");
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.OnEditWordButtonClick);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(237, 51);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteWord.TabIndex = 3;
            this.btnDeleteWord.Text = "Delete Word";
            this.spelListToolTip.SetToolTip(this.btnDeleteWord, "Select to delete the selected word from the spelling list.");
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.OnDeleteWordButtonClick);
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.Location = new System.Drawing.Point(13, 51);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(100, 32);
            this.btnAddNewWord.TabIndex = 1;
            this.btnAddNewWord.Text = "Add New Word";
            this.spelListToolTip.SetToolTip(this.btnAddNewWord, "Select  to add a new word.");
            this.btnAddNewWord.UseVisualStyleBackColor = true;
            this.btnAddNewWord.Click += new System.EventHandler(this.OnAddNewWordButtonClick);
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
            // SpellingWordsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.MnuNewSpellListMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MnuNewSpellListMenuStrip;
            this.MaximizeBox = false;
            this.Name = "SpellingWordsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a New Spelling List or Modify Existing Spelling List.";
            this.Load += new System.EventHandler(this.SpellingWordsList_Load);
            this.MnuNewSpellListMenuStrip.ResumeLayout(false);
            this.MnuNewSpellListMenuStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlWordList.ResumeLayout(false);
            this.pnlWord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuNewSpellListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlWordList;
        private System.Windows.Forms.Button btnClearist;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.ListBox lstWordsList;
        private System.Windows.Forms.Panel pnlWord;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.ToolStripMenuItem SpellingListsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectSpellingListMenuItem;
        private System.Windows.Forms.Button btnCreateNewList;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.Button btnAddWordToList;
        private System.Windows.Forms.ToolTip spelListToolTip;
        private System.Windows.Forms.Button btnOpenist;
        private System.Windows.Forms.OpenFileDialog SpellingListOpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenSpellingList;
        private System.Windows.Forms.SaveFileDialog SpellingListSaveFileDialog;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cboWord;
    }
}