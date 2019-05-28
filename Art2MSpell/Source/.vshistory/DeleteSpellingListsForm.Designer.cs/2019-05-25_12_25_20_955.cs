namespace Art2MSpell.Source
{
    partial class DeleteSpellingListsForm
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
            this.pnlListBoxes = new System.Windows.Forms.Panel();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.lstSpellFiles = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlListBoxes.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListBoxes
            // 
            this.pnlListBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListBoxes.Controls.Add(this.lstWords);
            this.pnlListBoxes.Controls.Add(this.lstSpellFiles);
            this.pnlListBoxes.Location = new System.Drawing.Point(11, 12);
            this.pnlListBoxes.Name = "pnlListBoxes";
            this.pnlListBoxes.Size = new System.Drawing.Size(750, 396);
            this.pnlListBoxes.TabIndex = 0;
            // 
            // lstWords
            // 
            this.lstWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWords.FormattingEnabled = true;
            this.lstWords.Location = new System.Drawing.Point(9, 197);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(734, 186);
            this.lstWords.TabIndex = 4;
            // 
            // lstSpellFiles
            // 
            this.lstSpellFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSpellFiles.FormattingEnabled = true;
            this.lstSpellFiles.Location = new System.Drawing.Point(8, 11);
            this.lstSpellFiles.Name = "lstSpellFiles";
            this.lstSpellFiles.Size = new System.Drawing.Size(734, 173);
            this.lstSpellFiles.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(698, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.button1);
            this.pnlButtons.Location = new System.Drawing.Point(118, 426);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(564, 72);
            this.pnlButtons.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteSpellingListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlListBoxes);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DeleteSpellingListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Spelling Lists";
            this.pnlListBoxes.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListBoxes;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.ListBox lstSpellFiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button button1;
    }
}