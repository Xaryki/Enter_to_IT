namespace laba3sql
{
    partial class Form1
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
            this.связанныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиИЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыИЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компанииПокупателиИЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.связанныеДанныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // связанныеДанныеToolStripMenuItem
            // 
            this.связанныеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупателиИЗаказыToolStripMenuItem,
            this.товарыИЗаказыToolStripMenuItem,
            this.компанииПокупателиИЗаказыToolStripMenuItem});
            this.связанныеДанныеToolStripMenuItem.Name = "связанныеДанныеToolStripMenuItem";
            this.связанныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.связанныеДанныеToolStripMenuItem.Text = "Связанные данные";
            // 
            // покупателиИЗаказыToolStripMenuItem
            // 
            this.покупателиИЗаказыToolStripMenuItem.Name = "покупателиИЗаказыToolStripMenuItem";
            this.покупателиИЗаказыToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.покупателиИЗаказыToolStripMenuItem.Text = "Покупатели и заказы";
            this.покупателиИЗаказыToolStripMenuItem.Click += new System.EventHandler(this.покупателиИЗаказыToolStripMenuItem_Click);
            // 
            // товарыИЗаказыToolStripMenuItem
            // 
            this.товарыИЗаказыToolStripMenuItem.Name = "товарыИЗаказыToolStripMenuItem";
            this.товарыИЗаказыToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.товарыИЗаказыToolStripMenuItem.Text = "Товары и Заказы";
            this.товарыИЗаказыToolStripMenuItem.Click += new System.EventHandler(this.товарыИЗаказыToolStripMenuItem_Click);
            // 
            // компанииПокупателиИЗаказыToolStripMenuItem
            // 
            this.компанииПокупателиИЗаказыToolStripMenuItem.Name = "компанииПокупателиИЗаказыToolStripMenuItem";
            this.компанииПокупателиИЗаказыToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.компанииПокупателиИЗаказыToolStripMenuItem.Text = "Компании, покупатели и заказы";
            this.компанииПокупателиИЗаказыToolStripMenuItem.Click += new System.EventHandler(this.компанииПокупателиИЗаказыToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Продажи";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem связанныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиИЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыИЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компанииПокупателиИЗаказыToolStripMenuItem;
    }
}

