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
            this.SpelListDisplayMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenSpellingList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToollTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRepeatWord = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbxScore = new System.Windows.Forms.GroupBox();
            this.txtTotalWords = new System.Windows.Forms.TextBox();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.txtWordsWrong = new System.Windows.Forms.TextBox();
            this.lblWordsWrong = new System.Windows.Forms.Label();
            this.txtWordsCorrect = new System.Windows.Forms.TextBox();
            this.lblWordsCorrect = new System.Windows.Forms.Label();
            this.txtWordsCount = new System.Windows.Forms.TextBox();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.btnOpenList = new System.Windows.Forms.Button();
            this.txtSpellWord = new System.Windows.Forms.TextBox();
            this.flpSpell = new System.Windows.Forms.FlowLayoutPanel();
            this.flpListButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRepeatList = new System.Windows.Forms.Button();
            this.btnMisspelled = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.lblOverall = new System.Windows.Forms.Label();
            this.txtAllScore = new System.Windows.Forms.TextBox();
            this.SpelListDisplayMenuStrip.SuspendLayout();
            this.grpbxScore.SuspendLayout();
            this.flpSpell.SuspendLayout();
            this.flpListButtons.SuspendLayout();
            this.SuspendLayout();
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
            // btnRepeatWord
            // 
            this.btnRepeatWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeatWord.Location = new System.Drawing.Point(191, 5);
            this.btnRepeatWord.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnRepeatWord.Name = "btnRepeatWord";
            this.btnRepeatWord.Size = new System.Drawing.Size(85, 32);
            this.btnRepeatWord.TabIndex = 3;
            this.btnRepeatWord.Text = "Repeat";
            this.ToollTip.SetToolTip(this.btnRepeatWord, "Select to repeat the spelling words list");
            this.btnRepeatWord.UseVisualStyleBackColor = true;
            this.btnRepeatWord.Click += new System.EventHandler(this.OnRepeatWordButtonClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(377, 5);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(85, 32);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.ToollTip.SetToolTip(this.btnQuit, "Select to quit the spelling words list.");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.OnQuitButtonClick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(5, 5);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.ToollTip.SetToolTip(this.btnStart, "Select to start the spelling words list");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnStartButtonClick);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(284, 5);
            this.btnPause.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(85, 32);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.ToollTip.SetToolTip(this.btnPause, "Select to pause the spelling words list.");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.OnPauseButtonClick);
            // 
            // btnNextWord
            // 
            this.btnNextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWord.Location = new System.Drawing.Point(98, 5);
            this.btnNextWord.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(85, 32);
            this.btnNextWord.TabIndex = 2;
            this.btnNextWord.Text = "Next";
            this.ToollTip.SetToolTip(this.btnNextWord, "Select for the next word in spelling list.");
            this.btnNextWord.UseVisualStyleBackColor = true;
            this.btnNextWord.Click += new System.EventHandler(this.OnNextWordButtonClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(668, 521);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.ToollTip.SetToolTip(this.btnClose, "Close the display spelling word form.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnCloseButtonClick);
            // 
            // grpbxScore
            // 
            this.grpbxScore.Controls.Add(this.txtAllScore);
            this.grpbxScore.Controls.Add(this.lblOverall);
            this.grpbxScore.Controls.Add(this.lblComplete);
            this.grpbxScore.Controls.Add(this.textBox2);
            this.grpbxScore.Controls.Add(this.txtScore);
            this.grpbxScore.Controls.Add(this.txtTotalWords);
            this.grpbxScore.Controls.Add(this.lblTotalWords);
            this.grpbxScore.Controls.Add(this.txtWordsWrong);
            this.grpbxScore.Controls.Add(this.lblWordsWrong);
            this.grpbxScore.Controls.Add(this.txtWordsCorrect);
            this.grpbxScore.Controls.Add(this.lblWordsCorrect);
            this.grpbxScore.Controls.Add(this.txtWordsCount);
            this.grpbxScore.Controls.Add(this.lblWordsCount);
            this.grpbxScore.Location = new System.Drawing.Point(75, 31);
            this.grpbxScore.Name = "grpbxScore";
            this.grpbxScore.Size = new System.Drawing.Size(644, 156);
            this.grpbxScore.TabIndex = 12;
            this.grpbxScore.TabStop = false;
            // 
            // txtTotalWords
            // 
            this.txtTotalWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWords.Location = new System.Drawing.Point(135, 122);
            this.txtTotalWords.Multiline = true;
            this.txtTotalWords.Name = "txtTotalWords";
            this.txtTotalWords.ReadOnly = true;
            this.txtTotalWords.Size = new System.Drawing.Size(100, 23);
            this.txtTotalWords.TabIndex = 8;
            this.txtTotalWords.Text = "0";
            this.txtTotalWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToollTip.SetToolTip(this.txtTotalWords, "Total number of words in the list.");
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWords.Location = new System.Drawing.Point(135, 87);
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Size = new System.Drawing.Size(100, 23);
            this.lblTotalWords.TabIndex = 7;
            this.lblTotalWords.Text = "Total Words";
            this.lblTotalWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWordsWrong
            // 
            this.txtWordsWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsWrong.Location = new System.Drawing.Point(134, 51);
            this.txtWordsWrong.Multiline = true;
            this.txtWordsWrong.Name = "txtWordsWrong";
            this.txtWordsWrong.ReadOnly = true;
            this.txtWordsWrong.Size = new System.Drawing.Size(100, 23);
            this.txtWordsWrong.TabIndex = 6;
            this.txtWordsWrong.Text = "0";
            this.txtWordsWrong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToollTip.SetToolTip(this.txtWordsWrong, "The number of words misspelled.");
            // 
            // lblWordsWrong
            // 
            this.lblWordsWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsWrong.Location = new System.Drawing.Point(134, 16);
            this.lblWordsWrong.Name = "lblWordsWrong";
            this.lblWordsWrong.Size = new System.Drawing.Size(100, 23);
            this.lblWordsWrong.TabIndex = 5;
            this.lblWordsWrong.Text = "Words Wrong";
            this.lblWordsWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWordsCorrect
            // 
            this.txtWordsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsCorrect.Location = new System.Drawing.Point(17, 51);
            this.txtWordsCorrect.Multiline = true;
            this.txtWordsCorrect.Name = "txtWordsCorrect";
            this.txtWordsCorrect.ReadOnly = true;
            this.txtWordsCorrect.Size = new System.Drawing.Size(100, 23);
            this.txtWordsCorrect.TabIndex = 4;
            this.txtWordsCorrect.Text = "0";
            this.txtWordsCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToollTip.SetToolTip(this.txtWordsCorrect, "The number of words correct.");
            // 
            // lblWordsCorrect
            // 
            this.lblWordsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsCorrect.Location = new System.Drawing.Point(17, 16);
            this.lblWordsCorrect.Name = "lblWordsCorrect";
            this.lblWordsCorrect.Size = new System.Drawing.Size(100, 23);
            this.lblWordsCorrect.TabIndex = 3;
            this.lblWordsCorrect.Text = "Words Correct";
            this.lblWordsCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWordsCount
            // 
            this.txtWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsCount.Location = new System.Drawing.Point(14, 122);
            this.txtWordsCount.Multiline = true;
            this.txtWordsCount.Name = "txtWordsCount";
            this.txtWordsCount.ReadOnly = true;
            this.txtWordsCount.Size = new System.Drawing.Size(100, 23);
            this.txtWordsCount.TabIndex = 2;
            this.txtWordsCount.Text = "0";
            this.txtWordsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToollTip.SetToolTip(this.txtWordsCount, "The count of words asked.");
            // 
            // lblWordsCount
            // 
            this.lblWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsCount.Location = new System.Drawing.Point(14, 87);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(100, 23);
            this.lblWordsCount.TabIndex = 1;
            this.lblWordsCount.Text = "Words Count";
            this.lblWordsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenList
            // 
            this.btnOpenList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenList.Location = new System.Drawing.Point(6, 15);
            this.btnOpenList.Margin = new System.Windows.Forms.Padding(6, 15, 3, 3);
            this.btnOpenList.Name = "btnOpenList";
            this.btnOpenList.Size = new System.Drawing.Size(140, 32);
            this.btnOpenList.TabIndex = 11;
            this.btnOpenList.Text = "Open Spelling List";
            this.btnOpenList.UseVisualStyleBackColor = true;
            this.btnOpenList.Click += new System.EventHandler(this.OnOpenSpellingListButtonClick);
            // 
            // txtSpellWord
            // 
            this.txtSpellWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpellWord.Location = new System.Drawing.Point(236, 217);
            this.txtSpellWord.Multiline = true;
            this.txtSpellWord.Name = "txtSpellWord";
            this.txtSpellWord.Size = new System.Drawing.Size(478, 34);
            this.txtSpellWord.TabIndex = 0;
            // 
            // flpSpell
            // 
            this.flpSpell.Controls.Add(this.btnStart);
            this.flpSpell.Controls.Add(this.btnNextWord);
            this.flpSpell.Controls.Add(this.btnRepeatWord);
            this.flpSpell.Controls.Add(this.btnPause);
            this.flpSpell.Controls.Add(this.btnQuit);
            this.flpSpell.Location = new System.Drawing.Point(236, 263);
            this.flpSpell.Name = "flpSpell";
            this.flpSpell.Size = new System.Drawing.Size(478, 45);
            this.flpSpell.TabIndex = 13;
            // 
            // flpListButtons
            // 
            this.flpListButtons.Controls.Add(this.btnOpenList);
            this.flpListButtons.Controls.Add(this.btnRepeatList);
            this.flpListButtons.Controls.Add(this.btnMisspelled);
            this.flpListButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListButtons.Location = new System.Drawing.Point(71, 218);
            this.flpListButtons.Name = "flpListButtons";
            this.flpListButtons.Size = new System.Drawing.Size(157, 163);
            this.flpListButtons.TabIndex = 14;
            // 
            // btnRepeatList
            // 
            this.btnRepeatList.Location = new System.Drawing.Point(6, 65);
            this.btnRepeatList.Margin = new System.Windows.Forms.Padding(6, 15, 3, 3);
            this.btnRepeatList.Name = "btnRepeatList";
            this.btnRepeatList.Size = new System.Drawing.Size(140, 32);
            this.btnRepeatList.TabIndex = 12;
            this.btnRepeatList.Text = "Repeat Word List";
            this.ToollTip.SetToolTip(this.btnRepeatList, "Repeat word list.");
            this.btnRepeatList.UseVisualStyleBackColor = true;
            // 
            // btnMisspelled
            // 
            this.btnMisspelled.Location = new System.Drawing.Point(6, 115);
            this.btnMisspelled.Margin = new System.Windows.Forms.Padding(6, 15, 3, 3);
            this.btnMisspelled.Name = "btnMisspelled";
            this.btnMisspelled.Size = new System.Drawing.Size(140, 32);
            this.btnMisspelled.TabIndex = 13;
            this.btnMisspelled.Text = "Misspelled Words";
            this.ToollTip.SetToolTip(this.btnMisspelled, "Practice misspelled words.");
            this.btnMisspelled.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(258, 87);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(100, 23);
            this.txtScore.TabIndex = 9;
            this.txtScore.Text = "100 %";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToollTip.SetToolTip(this.txtScore, "Percentage score.");
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(390, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0 Times";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToollTip.SetToolTip(this.textBox2, "The number of times list completed.");
            // 
            // lblComplete
            // 
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(390, 16);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(100, 23);
            this.lblComplete.TabIndex = 11;
            this.lblComplete.Text = "Completed";
            this.lblComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverall
            // 
            this.lblOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverall.Location = new System.Drawing.Point(521, 16);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(100, 23);
            this.lblOverall.TabIndex = 12;
            this.lblOverall.Text = "Overall";
            this.lblOverall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAllScore
            // 
            this.txtAllScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllScore.Location = new System.Drawing.Point(521, 51);
            this.txtAllScore.Multiline = true;
            this.txtAllScore.Name = "txtAllScore";
            this.txtAllScore.ReadOnly = true;
            this.txtAllScore.Size = new System.Drawing.Size(100, 23);
            this.txtAllScore.TabIndex = 13;
            this.txtAllScore.Text = "100 %";
            this.txtAllScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToollTip.SetToolTip(this.txtAllScore, "Over all score for number of times threw the list.");
            // 
            // PracticeSpellingWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.flpListButtons);
            this.Controls.Add(this.txtSpellWord);
            this.Controls.Add(this.flpSpell);
            this.Controls.Add(this.grpbxScore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.SpelListDisplayMenuStrip);
            this.MainMenuStrip = this.SpelListDisplayMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PracticeSpellingWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice Spelling words Form";
            this.ToollTip.SetToolTip(this, "Open spelling list to practice.");
            this.Load += new System.EventHandler(this.PracticeSpellingWordsForm_Load);
            this.SpelListDisplayMenuStrip.ResumeLayout(false);
            this.SpelListDisplayMenuStrip.PerformLayout();
            this.grpbxScore.ResumeLayout(false);
            this.grpbxScore.PerformLayout();
            this.flpSpell.ResumeLayout(false);
            this.flpListButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip SpelListDisplayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
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
        private System.Windows.Forms.Button btnRepeatWord;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.TextBox txtSpellWord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flpSpell;
        private System.Windows.Forms.FlowLayoutPanel flpListButtons;
        private System.Windows.Forms.Button btnRepeatList;
        private System.Windows.Forms.Button btnMisspelled;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.TextBox txtAllScore;
    }
}