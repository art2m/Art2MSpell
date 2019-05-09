namespace Art2MSpell.Source
{
    partial class PracticeSpellingWordsForm
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
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SpelListDisplayMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenSpellingList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToollTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpbxScore = new System.Windows.Forms.GroupBox();
            this.txtWordsWrong = new System.Windows.Forms.TextBox();
            this.lblWordsWrong = new System.Windows.Forms.Label();
            this.txtWordsCorrect = new System.Windows.Forms.TextBox();
            this.lblWordsCorrect = new System.Windows.Forms.Label();
            this.txtWordsCount = new System.Windows.Forms.TextBox();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.btnOpenList = new System.Windows.Forms.Button();
            this.grpbxSpellingWords = new System.Windows.Forms.GroupBox();
            this.btnRepeatWord = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.txtSpellWord = new System.Windows.Forms.TextBox();
            this.txtTotalWords = new System.Windows.Forms.TextBox();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.pnlDisplay.SuspendLayout();
            this.SpelListDisplayMenuStrip.SuspendLayout();
            this.grpbxScore.SuspendLayout();
            this.grpbxSpellingWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.grpbxScore);
            this.pnlDisplay.Controls.Add(this.btnOpenList);
            this.pnlDisplay.Controls.Add(this.grpbxSpellingWords);
            this.pnlDisplay.Controls.Add(this.btnClose);
            this.pnlDisplay.Location = new System.Drawing.Point(3, 30);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(778, 529);
            this.pnlDisplay.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(661, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.ToollTip.SetToolTip(this.btnClose, "Close the display spelling word form.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnCloseButtonClick);
            // 
            // SpelListDisplayMenuStrip
            // 
            this.SpelListDisplayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.SpelListDisplayMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SpelListDisplayMenuStrip.Name = "SpelListDisplayMenuStrip";
            this.SpelListDisplayMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.SpelListDisplayMenuStrip.TabIndex = 0;
            this.SpelListDisplayMenuStrip.Text = "SpelListDisplay";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenSpellingList,
            this.toolStripSeparator1,
            this.mnuClose});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
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
            this.mnuClose.ToolTipText = "Close the display spelling word form.";
            this.mnuClose.Click += new System.EventHandler(this.OnCloseMenuItemClick);
            // 
            // grpbxScore
            // 
            this.grpbxScore.Controls.Add(this.txtTotalWords);
            this.grpbxScore.Controls.Add(this.lblTotalWords);
            this.grpbxScore.Controls.Add(this.txtWordsWrong);
            this.grpbxScore.Controls.Add(this.lblWordsWrong);
            this.grpbxScore.Controls.Add(this.txtWordsCorrect);
            this.grpbxScore.Controls.Add(this.lblWordsCorrect);
            this.grpbxScore.Controls.Add(this.txtWordsCount);
            this.grpbxScore.Controls.Add(this.lblWordsCount);
            this.grpbxScore.Location = new System.Drawing.Point(87, 16);
            this.grpbxScore.Name = "grpbxScore";
            this.grpbxScore.Size = new System.Drawing.Size(604, 124);
            this.grpbxScore.TabIndex = 8;
            this.grpbxScore.TabStop = false;
            // 
            // txtWordsWrong
            // 
            this.txtWordsWrong.Location = new System.Drawing.Point(134, 51);
            this.txtWordsWrong.Multiline = true;
            this.txtWordsWrong.Name = "txtWordsWrong";
            this.txtWordsWrong.ReadOnly = true;
            this.txtWordsWrong.Size = new System.Drawing.Size(100, 23);
            this.txtWordsWrong.TabIndex = 6;
            // 
            // lblWordsWrong
            // 
            this.lblWordsWrong.Location = new System.Drawing.Point(134, 16);
            this.lblWordsWrong.Name = "lblWordsWrong";
            this.lblWordsWrong.Size = new System.Drawing.Size(100, 23);
            this.lblWordsWrong.TabIndex = 5;
            this.lblWordsWrong.Text = "Words Wrong";
            this.lblWordsWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWordsCorrect
            // 
            this.txtWordsCorrect.Location = new System.Drawing.Point(17, 51);
            this.txtWordsCorrect.Multiline = true;
            this.txtWordsCorrect.Name = "txtWordsCorrect";
            this.txtWordsCorrect.ReadOnly = true;
            this.txtWordsCorrect.Size = new System.Drawing.Size(100, 23);
            this.txtWordsCorrect.TabIndex = 4;
            // 
            // lblWordsCorrect
            // 
            this.lblWordsCorrect.Location = new System.Drawing.Point(17, 16);
            this.lblWordsCorrect.Name = "lblWordsCorrect";
            this.lblWordsCorrect.Size = new System.Drawing.Size(100, 23);
            this.lblWordsCorrect.TabIndex = 3;
            this.lblWordsCorrect.Text = "Words Correct";
            this.lblWordsCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWordsCount
            // 
            this.txtWordsCount.Location = new System.Drawing.Point(364, 51);
            this.txtWordsCount.Multiline = true;
            this.txtWordsCount.Name = "txtWordsCount";
            this.txtWordsCount.ReadOnly = true;
            this.txtWordsCount.Size = new System.Drawing.Size(100, 23);
            this.txtWordsCount.TabIndex = 2;
            // 
            // lblWordsCount
            // 
            this.lblWordsCount.Location = new System.Drawing.Point(364, 16);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(100, 23);
            this.lblWordsCount.TabIndex = 1;
            this.lblWordsCount.Text = "Words Count";
            this.lblWordsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenList
            // 
            this.btnOpenList.Location = new System.Drawing.Point(329, 161);
            this.btnOpenList.Name = "btnOpenList";
            this.btnOpenList.Size = new System.Drawing.Size(120, 42);
            this.btnOpenList.TabIndex = 7;
            this.btnOpenList.Text = "Open Spelling List";
            this.btnOpenList.UseVisualStyleBackColor = true;
            this.btnOpenList.Click += new System.EventHandler(this.OnOpenSpellingListButtonClick);
            // 
            // grpbxSpellingWords
            // 
            this.grpbxSpellingWords.Controls.Add(this.btnRepeatWord);
            this.grpbxSpellingWords.Controls.Add(this.btnQuit);
            this.grpbxSpellingWords.Controls.Add(this.btnStart);
            this.grpbxSpellingWords.Controls.Add(this.btnPause);
            this.grpbxSpellingWords.Controls.Add(this.btnNextWord);
            this.grpbxSpellingWords.Controls.Add(this.txtSpellWord);
            this.grpbxSpellingWords.Location = new System.Drawing.Point(87, 231);
            this.grpbxSpellingWords.Name = "grpbxSpellingWords";
            this.grpbxSpellingWords.Size = new System.Drawing.Size(604, 126);
            this.grpbxSpellingWords.TabIndex = 6;
            this.grpbxSpellingWords.TabStop = false;
            this.grpbxSpellingWords.Text = "Spelling Word.";
            // 
            // btnRepeatWord
            // 
            this.btnRepeatWord.Location = new System.Drawing.Point(251, 63);
            this.btnRepeatWord.Name = "btnRepeatWord";
            this.btnRepeatWord.Size = new System.Drawing.Size(100, 32);
            this.btnRepeatWord.TabIndex = 3;
            this.btnRepeatWord.Text = "Repeat Word";
            this.ToollTip.SetToolTip(this.btnRepeatWord, "Select to repeat the spelling words list");
            this.btnRepeatWord.UseVisualStyleBackColor = true;
            this.btnRepeatWord.Click += new System.EventHandler(this.OnRepeatWordButtonClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(495, 63);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 32);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.ToollTip.SetToolTip(this.btnQuit, "Select to quit the spelling words list.");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.OnQuitButtonClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.ToollTip.SetToolTip(this.btnStart, "Select to start the spelling words list");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnStartButtonClick);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(373, 63);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 32);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.ToollTip.SetToolTip(this.btnPause, "Select to pause the spelling words list.");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.OnPauseButtonClick);
            // 
            // btnNextWord
            // 
            this.btnNextWord.Location = new System.Drawing.Point(129, 63);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(100, 32);
            this.btnNextWord.TabIndex = 2;
            this.btnNextWord.Text = "Next Word";
            this.ToollTip.SetToolTip(this.btnNextWord, "Select for the next word in spelling list.");
            this.btnNextWord.UseVisualStyleBackColor = true;
            this.btnNextWord.Click += new System.EventHandler(this.OnNextWordButtonClick);
            // 
            // txtSpellWord
            // 
            this.txtSpellWord.Location = new System.Drawing.Point(7, 18);
            this.txtSpellWord.Multiline = true;
            this.txtSpellWord.Name = "txtSpellWord";
            this.txtSpellWord.Size = new System.Drawing.Size(589, 34);
            this.txtSpellWord.TabIndex = 0;
            // 
            // txtTotalWords
            // 
            this.txtTotalWords.Location = new System.Drawing.Point(485, 51);
            this.txtTotalWords.Multiline = true;
            this.txtTotalWords.Name = "txtTotalWords";
            this.txtTotalWords.ReadOnly = true;
            this.txtTotalWords.Size = new System.Drawing.Size(100, 23);
            this.txtTotalWords.TabIndex = 8;
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.Location = new System.Drawing.Point(485, 16);
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Size = new System.Drawing.Size(100, 23);
            this.lblTotalWords.TabIndex = 7;
            this.lblTotalWords.Text = "Total Words";
            this.lblTotalWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PracticeSpellingWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.SpelListDisplayMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.SpelListDisplayMenuStrip;
            this.MaximizeBox = false;
            this.Name = "PracticeSpellingWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice Spelling words Form";
            this.Load += new System.EventHandler(this.SpellingListDisplayForm_Load);
            this.pnlDisplay.ResumeLayout(false);
            this.SpelListDisplayMenuStrip.ResumeLayout(false);
            this.SpelListDisplayMenuStrip.PerformLayout();
            this.grpbxScore.ResumeLayout(false);
            this.grpbxScore.PerformLayout();
            this.grpbxSpellingWords.ResumeLayout(false);
            this.grpbxSpellingWords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.MenuStrip SpelListDisplayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip ToollTip;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenSpellingList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox grpbxScore;
        private System.Windows.Forms.TextBox txtTotalWords;
        private System.Windows.Forms.Label lblTotalWords;
        private System.Windows.Forms.TextBox txtWordsWrong;
        private System.Windows.Forms.Label lblWordsWrong;
        private System.Windows.Forms.TextBox txtWordsCorrect;
        private System.Windows.Forms.Label lblWordsCorrect;
        private System.Windows.Forms.TextBox txtWordsCount;
        private System.Windows.Forms.Label lblWordsCount;
        private System.Windows.Forms.Button btnOpenList;
        private System.Windows.Forms.GroupBox grpbxSpellingWords;
        private System.Windows.Forms.Button btnRepeatWord;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.TextBox txtSpellWord;
    }
}