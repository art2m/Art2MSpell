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
            this.SuspendLayout();
            // 
            // pnlListBoxes
            // 
            this.pnlListBoxes.Location = new System.Drawing.Point(11, 12);
            this.pnlListBoxes.Name = "pnlListBoxes";
            this.pnlListBoxes.Size = new System.Drawing.Size(779, 473);
            this.pnlListBoxes.TabIndex = 0;
            // 
            // DeleteSpellingListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.pnlListBoxes);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DeleteSpellingListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Spelling Lists";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListBoxes;
    }
}