namespace Art2MSpell.Source
{
    partial class SelectSpellingListForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lstSpell = new System.Windows.Forms.ListBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Gold;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(16, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(752, 34);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Select spelling words file to use.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSpell
            // 
            this.lstSpell.FormattingEnabled = true;
            this.lstSpell.Location = new System.Drawing.Point(16, 63);
            this.lstSpell.Name = "lstSpell";
            this.lstSpell.Size = new System.Drawing.Size(752, 394);
            this.lstSpell.TabIndex = 1;
            // 
            // flpButtons
            // 
            this.flpButtons.Location = new System.Drawing.Point(16, 480);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(752, 66);
            this.flpButtons.TabIndex = 2;
            // 
            // SelectSpellingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.lstSpell);
            this.Controls.Add(this.lblInfo);
            this.Name = "SelectSpellingListForm";
            this.Text = "SelectSpellingListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstSpell;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
    }
}