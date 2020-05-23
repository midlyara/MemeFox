namespace MemeFox
{
    partial class SingleForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сГЕНЕРИТЬПИКЧУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гЕНМОДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иНФОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.сОХРАНИТЬToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оДИНОЧНЫЙToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кОМИКСНЫЙToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дЕМОТИВАТОРToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сГЕНЕРИТЬПИКЧУToolStripMenuItem,
            this.сОХРАНИТЬToolStripMenuItem,
            this.гЕНМОДToolStripMenuItem,
            this.иНФОToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сГЕНЕРИТЬПИКЧУToolStripMenuItem
            // 
            this.сГЕНЕРИТЬПИКЧУToolStripMenuItem.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сГЕНЕРИТЬПИКЧУToolStripMenuItem.Name = "сГЕНЕРИТЬПИКЧУToolStripMenuItem";
            this.сГЕНЕРИТЬПИКЧУToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сГЕНЕРИТЬПИКЧУToolStripMenuItem.Text = "СГЕНЕРИТЬ ПИКЧУ";
            this.сГЕНЕРИТЬПИКЧУToolStripMenuItem.Click += new System.EventHandler(this.сГЕНЕРИТЬПИКЧУToolStripMenuItem_Click);
            // 
            // гЕНМОДToolStripMenuItem
            // 
            this.гЕНМОДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оДИНОЧНЫЙToolStripMenuItem,
            this.кОМИКСНЫЙToolStripMenuItem,
            this.дЕМОТИВАТОРToolStripMenuItem});
            this.гЕНМОДToolStripMenuItem.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.гЕНМОДToolStripMenuItem.Name = "гЕНМОДToolStripMenuItem";
            this.гЕНМОДToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.гЕНМОДToolStripMenuItem.Text = "ГЕНМОД";
            // 
            // иНФОToolStripMenuItem
            // 
            this.иНФОToolStripMenuItem.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.иНФОToolStripMenuItem.Name = "иНФОToolStripMenuItem";
            this.иНФОToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.иНФОToolStripMenuItem.Text = "ИНФО";
            this.иНФОToolStripMenuItem.Click += new System.EventHandler(this.иНФОToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 236);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // сОХРАНИТЬToolStripMenuItem
            // 
            this.сОХРАНИТЬToolStripMenuItem.Font = new System.Drawing.Font("Roboto Light", 11.25F);
            this.сОХРАНИТЬToolStripMenuItem.Name = "сОХРАНИТЬToolStripMenuItem";
            this.сОХРАНИТЬToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.сОХРАНИТЬToolStripMenuItem.Text = "СОХРАНИТЬ";
            this.сОХРАНИТЬToolStripMenuItem.Click += new System.EventHandler(this.сОХРАНИТЬToolStripMenuItem_Click);
            // 
            // оДИНОЧНЫЙToolStripMenuItem
            // 
            this.оДИНОЧНЫЙToolStripMenuItem.Checked = true;
            this.оДИНОЧНЫЙToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.оДИНОЧНЫЙToolStripMenuItem.Enabled = false;
            this.оДИНОЧНЫЙToolStripMenuItem.Name = "оДИНОЧНЫЙToolStripMenuItem";
            this.оДИНОЧНЫЙToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.оДИНОЧНЫЙToolStripMenuItem.Text = "ОДИНОЧНЫЙ";
            // 
            // кОМИКСНЫЙToolStripMenuItem
            // 
            this.кОМИКСНЫЙToolStripMenuItem.Name = "кОМИКСНЫЙToolStripMenuItem";
            this.кОМИКСНЫЙToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.кОМИКСНЫЙToolStripMenuItem.Text = "КОМИКСНЫЙ";
            this.кОМИКСНЫЙToolStripMenuItem.Click += new System.EventHandler(this.кОМИКСНЫЙToolStripMenuItem_Click);
            // 
            // дЕМОТИВАТОРToolStripMenuItem
            // 
            this.дЕМОТИВАТОРToolStripMenuItem.Name = "дЕМОТИВАТОРToolStripMenuItem";
            this.дЕМОТИВАТОРToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.дЕМОТИВАТОРToolStripMenuItem.Text = "ДЕМОТИВАТОР";
            // 
            // SingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(425, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(441, 321);
            this.MinimumSize = new System.Drawing.Size(441, 321);
            this.Name = "SingleForm";
            this.Text = "MemeFox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сГЕНЕРИТЬПИКЧУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гЕНМОДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иНФОToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem сОХРАНИТЬToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оДИНОЧНЫЙToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кОМИКСНЫЙToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дЕМОТИВАТОРToolStripMenuItem;
    }
}

