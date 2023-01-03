namespace Lab_10
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыПокупатселяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЗаказовПокупателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЗаказовПоОбъемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЗаказовПоДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыПокупатселяToolStripMenuItem,
            this.продажиТоваровToolStripMenuItem,
            this.выборЗаказовПокупателяToolStripMenuItem,
            this.выборЗаказовПоОбъемуToolStripMenuItem,
            this.выборЗаказовПоДатеToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // заказыПокупатселяToolStripMenuItem
            // 
            this.заказыПокупатселяToolStripMenuItem.Name = "заказыПокупатселяToolStripMenuItem";
            this.заказыПокупатселяToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.заказыПокупатселяToolStripMenuItem.Text = "Заказы покупатселя";
            this.заказыПокупатселяToolStripMenuItem.Click += new System.EventHandler(this.заказыПокупатселяToolStripMenuItem_Click);
            // 
            // продажиТоваровToolStripMenuItem
            // 
            this.продажиТоваровToolStripMenuItem.Name = "продажиТоваровToolStripMenuItem";
            this.продажиТоваровToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.продажиТоваровToolStripMenuItem.Text = "Продажи товаров";
            this.продажиТоваровToolStripMenuItem.Click += new System.EventHandler(this.продажиТоваровToolStripMenuItem_Click);
            // 
            // выборЗаказовПокупателяToolStripMenuItem
            // 
            this.выборЗаказовПокупателяToolStripMenuItem.Name = "выборЗаказовПокупателяToolStripMenuItem";
            this.выборЗаказовПокупателяToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.выборЗаказовПокупателяToolStripMenuItem.Text = "Выбор заказов покупателя";
            this.выборЗаказовПокупателяToolStripMenuItem.Click += new System.EventHandler(this.выборЗаказовПокупателяToolStripMenuItem_Click);
            // 
            // выборЗаказовПоОбъемуToolStripMenuItem
            // 
            this.выборЗаказовПоОбъемуToolStripMenuItem.Name = "выборЗаказовПоОбъемуToolStripMenuItem";
            this.выборЗаказовПоОбъемуToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.выборЗаказовПоОбъемуToolStripMenuItem.Text = "Выбор заказов по объему";
            this.выборЗаказовПоОбъемуToolStripMenuItem.Click += new System.EventHandler(this.выборЗаказовПоОбъемуToolStripMenuItem_Click);
            // 
            // выборЗаказовПоДатеToolStripMenuItem
            // 
            this.выборЗаказовПоДатеToolStripMenuItem.Name = "выборЗаказовПоДатеToolStripMenuItem";
            this.выборЗаказовПоДатеToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.выборЗаказовПоДатеToolStripMenuItem.Text = "Выбор заказов по дате.";
            this.выборЗаказовПоДатеToolStripMenuItem.Click += new System.EventHandler(this.выборЗаказовПоДатеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Продажи";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыПокупатселяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЗаказовПокупателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЗаказовПоОбъемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЗаказовПоДатеToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

