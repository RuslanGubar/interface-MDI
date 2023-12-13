namespace лаба_8_часть_2
{
    partial class formMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiView,
            this.tsmiOrder});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.MdiWindowListItem = this.tsmiView;
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(800, 24);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "файл";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(180, 22);
            this.tsmiNew.Text = "создать";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpen.Text = "открыть";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(74, 20);
            this.tsmiView.Text = "просмотр";
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascade,
            this.tsmiHorizontal,
            this.tsmiVertical});
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(90, 20);
            this.tsmiOrder.Text = "упорядочить";
            this.tsmiOrder.Click += new System.EventHandler(this.tsmiOrder_Click);
            // 
            // tsmiCascade
            // 
            this.tsmiCascade.Name = "tsmiCascade";
            this.tsmiCascade.Size = new System.Drawing.Size(180, 22);
            this.tsmiCascade.Text = "каскадом";
            this.tsmiCascade.Click += new System.EventHandler(this.tsmiCascade_Click);
            // 
            // tsmiHorizontal
            // 
            this.tsmiHorizontal.Name = "tsmiHorizontal";
            this.tsmiHorizontal.Size = new System.Drawing.Size(180, 22);
            this.tsmiHorizontal.Text = "по горизонтали";
            this.tsmiHorizontal.Click += new System.EventHandler(this.tsmiHorizontal_Click);
            // 
            // tsmiVertical
            // 
            this.tsmiVertical.Name = "tsmiVertical";
            this.tsmiVertical.Size = new System.Drawing.Size(180, 22);
            this.tsmiVertical.Text = "по вертикали";
            this.tsmiVertical.Click += new System.EventHandler(this.tsmiVertical_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "formMain";
            this.Text = "Form1";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascade;
        private System.Windows.Forms.ToolStripMenuItem tsmiHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiVertical;
    }
}

