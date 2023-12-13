namespace лаба_8_часть_2
{
    partial class noteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(noteForm));
            this.tsNoteForm = new System.Windows.Forms.ToolStrip();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbFont = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tsNoteForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsNoteForm
            // 
            this.tsNoteForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbDelete,
            this.tsbFont});
            this.tsNoteForm.Location = new System.Drawing.Point(0, 0);
            this.tsNoteForm.Name = "tsNoteForm";
            this.tsNoteForm.Size = new System.Drawing.Size(351, 25);
            this.tsNoteForm.TabIndex = 0;
            this.tsNoteForm.Text = "toolStrip1";
            // 
            // rtbNote
            // 
            this.rtbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNote.Location = new System.Drawing.Point(0, 25);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(351, 206);
            this.rtbNote.TabIndex = 1;
            this.rtbNote.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Простой текст |*.txt| Rich Text Format |*.rtf";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Сохранить";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Удалить";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbFont
            // 
            this.tsbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbFont.Image")));
            this.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFont.Name = "tsbFont";
            this.tsbFont.Size = new System.Drawing.Size(23, 22);
            this.tsbFont.Text = "Изменить шрифт";
            this.tsbFont.Click += new System.EventHandler(this.tsbFont_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.txt";
            this.saveFileDialog1.Filter = " Простой текст |*.txt| Rich Text Format |*.rtf";
            // 
            // noteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 231);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.tsNoteForm);
            this.Name = "noteForm";
            this.Text = "noteForm";
            this.Load += new System.EventHandler(this.noteForm_Load);
            this.tsNoteForm.ResumeLayout(false);
            this.tsNoteForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsNoteForm;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbFont;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}