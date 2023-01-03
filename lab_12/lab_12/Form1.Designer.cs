namespace lab_12
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
            this.вводДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводПокупателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыПокупателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыНаЗаданнуюДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вводДанныхToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вводДанныхToolStripMenuItem
            // 
            this.вводДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияТовараToolStripMenuItem,
            this.вводПокупателейToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.компанииToolStripMenuItem});
            this.вводДанныхToolStripMenuItem.Name = "вводДанныхToolStripMenuItem";
            this.вводДанныхToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.вводДанныхToolStripMenuItem.Text = "Ввод данных";
            // 
            // регистрацияТовараToolStripMenuItem
            // 
            this.регистрацияТовараToolStripMenuItem.Name = "регистрацияТовараToolStripMenuItem";
            this.регистрацияТовараToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.регистрацияТовараToolStripMenuItem.Text = "Регистрация товара";
            this.регистрацияТовараToolStripMenuItem.Click += new System.EventHandler(this.регистрацияТовараToolStripMenuItem_Click);
            // 
            // вводПокупателейToolStripMenuItem
            // 
            this.вводПокупателейToolStripMenuItem.Name = "вводПокупателейToolStripMenuItem";
            this.вводПокупателейToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.вводПокупателейToolStripMenuItem.Text = "Ввод покупателей";
            this.вводПокупателейToolStripMenuItem.Click += new System.EventHandler(this.вводПокупателейToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // компанииToolStripMenuItem
            // 
            this.компанииToolStripMenuItem.Name = "компанииToolStripMenuItem";
            this.компанииToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.компанииToolStripMenuItem.Text = "Компании";
            this.компанииToolStripMenuItem.Click += new System.EventHandler(this.компанииToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыПокупателяToolStripMenuItem,
            this.заказыТовараToolStripMenuItem,
            this.заказыНаЗаданнуюДатуToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // заказыПокупателяToolStripMenuItem
            // 
            this.заказыПокупателяToolStripMenuItem.Name = "заказыПокупателяToolStripMenuItem";
            this.заказыПокупателяToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.заказыПокупателяToolStripMenuItem.Text = "Заказы покупателя";
            this.заказыПокупателяToolStripMenuItem.Click += new System.EventHandler(this.заказыПокупателяToolStripMenuItem_Click);
            // 
            // заказыТовараToolStripMenuItem
            // 
            this.заказыТовараToolStripMenuItem.Name = "заказыТовараToolStripMenuItem";
            this.заказыТовараToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.заказыТовараToolStripMenuItem.Text = "Заказы товара";
            this.заказыТовараToolStripMenuItem.Click += new System.EventHandler(this.заказыТовараToolStripMenuItem_Click);
            // 
            // заказыНаЗаданнуюДатуToolStripMenuItem
            // 
            this.заказыНаЗаданнуюДатуToolStripMenuItem.Name = "заказыНаЗаданнуюДатуToolStripMenuItem";
            this.заказыНаЗаданнуюДатуToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.заказыНаЗаданнуюДатуToolStripMenuItem.Text = "Заказы на заданную дату";
            this.заказыНаЗаданнуюДатуToolStripMenuItem.Click += new System.EventHandler(this.заказыНаЗаданнуюДатуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вводДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводПокупателейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыПокупателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыНаЗаданнуюДатуToolStripMenuItem;
    }
}

