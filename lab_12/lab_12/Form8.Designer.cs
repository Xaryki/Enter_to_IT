namespace lab_12
{
    partial class Form8
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
            System.Windows.Forms.Label key_clientLabel;
            System.Windows.Forms.Label key_productLabel;
            System.Windows.Forms.Label date_orderLabel;
            System.Windows.Forms.Label quantity_orderLabel;
            System.Windows.Forms.Label date_saleLabel;
            System.Windows.Forms.Label quantity_saleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.orderTableAdapter = new lab_12.Sale1DataSetTableAdapters.orderTableAdapter();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.key_clientTextBox = new System.Windows.Forms.TextBox();
            this.key_productTextBox = new System.Windows.Forms.TextBox();
            this.date_orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantity_orderTextBox = new System.Windows.Forms.TextBox();
            this.date_saleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantity_saleTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale1DataSet = new lab_12.Sale1DataSet();
            this.tableAdapterManager = new lab_12.Sale1DataSetTableAdapters.TableAdapterManager();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.param3ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param3ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            key_clientLabel = new System.Windows.Forms.Label();
            key_productLabel = new System.Windows.Forms.Label();
            date_orderLabel = new System.Windows.Forms.Label();
            quantity_orderLabel = new System.Windows.Forms.Label();
            date_saleLabel = new System.Windows.Forms.Label();
            quantity_saleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // key_clientLabel
            // 
            key_clientLabel.AutoSize = true;
            key_clientLabel.Location = new System.Drawing.Point(32, 68);
            key_clientLabel.Name = "key_clientLabel";
            key_clientLabel.Size = new System.Drawing.Size(55, 13);
            key_clientLabel.TabIndex = 1;
            key_clientLabel.Text = "key client:";
            // 
            // key_productLabel
            // 
            key_productLabel.AutoSize = true;
            key_productLabel.Location = new System.Drawing.Point(30, 104);
            key_productLabel.Name = "key_productLabel";
            key_productLabel.Size = new System.Drawing.Size(66, 13);
            key_productLabel.TabIndex = 3;
            key_productLabel.Text = "key product:";
            // 
            // date_orderLabel
            // 
            date_orderLabel.AutoSize = true;
            date_orderLabel.Location = new System.Drawing.Point(28, 138);
            date_orderLabel.Name = "date_orderLabel";
            date_orderLabel.Size = new System.Drawing.Size(58, 13);
            date_orderLabel.TabIndex = 5;
            date_orderLabel.Text = "date order:";
            // 
            // quantity_orderLabel
            // 
            quantity_orderLabel.AutoSize = true;
            quantity_orderLabel.Location = new System.Drawing.Point(27, 167);
            quantity_orderLabel.Name = "quantity_orderLabel";
            quantity_orderLabel.Size = new System.Drawing.Size(74, 13);
            quantity_orderLabel.TabIndex = 7;
            quantity_orderLabel.Text = "quantity order:";
            // 
            // date_saleLabel
            // 
            date_saleLabel.AutoSize = true;
            date_saleLabel.Location = new System.Drawing.Point(27, 195);
            date_saleLabel.Name = "date_saleLabel";
            date_saleLabel.Size = new System.Drawing.Size(53, 13);
            date_saleLabel.TabIndex = 9;
            date_saleLabel.Text = "date sale:";
            // 
            // quantity_saleLabel
            // 
            quantity_saleLabel.AutoSize = true;
            quantity_saleLabel.Location = new System.Drawing.Point(24, 226);
            quantity_saleLabel.Name = "quantity_saleLabel";
            quantity_saleLabel.Size = new System.Drawing.Size(69, 13);
            quantity_saleLabel.TabIndex = 11;
            quantity_saleLabel.Text = "quantity sale:";
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // key_clientTextBox
            // 
            this.key_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "key_client", true));
            this.key_clientTextBox.Location = new System.Drawing.Point(93, 65);
            this.key_clientTextBox.Name = "key_clientTextBox";
            this.key_clientTextBox.Size = new System.Drawing.Size(100, 20);
            this.key_clientTextBox.TabIndex = 2;
            // 
            // key_productTextBox
            // 
            this.key_productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "key_product", true));
            this.key_productTextBox.Location = new System.Drawing.Point(102, 101);
            this.key_productTextBox.Name = "key_productTextBox";
            this.key_productTextBox.Size = new System.Drawing.Size(100, 20);
            this.key_productTextBox.TabIndex = 4;
            // 
            // date_orderDateTimePicker
            // 
            this.date_orderDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "date_order", true));
            this.date_orderDateTimePicker.Location = new System.Drawing.Point(92, 134);
            this.date_orderDateTimePicker.Name = "date_orderDateTimePicker";
            this.date_orderDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_orderDateTimePicker.TabIndex = 6;
            // 
            // quantity_orderTextBox
            // 
            this.quantity_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "quantity_order", true));
            this.quantity_orderTextBox.Location = new System.Drawing.Point(107, 164);
            this.quantity_orderTextBox.Name = "quantity_orderTextBox";
            this.quantity_orderTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantity_orderTextBox.TabIndex = 8;
            // 
            // date_saleDateTimePicker
            // 
            this.date_saleDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "date_sale", true));
            this.date_saleDateTimePicker.Location = new System.Drawing.Point(86, 191);
            this.date_saleDateTimePicker.Name = "date_saleDateTimePicker";
            this.date_saleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_saleDateTimePicker.TabIndex = 10;
            // 
            // quantity_saleTextBox
            // 
            this.quantity_saleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "quantity_sale", true));
            this.quantity_saleTextBox.Location = new System.Drawing.Point(99, 223);
            this.quantity_saleTextBox.Name = "quantity_saleTextBox";
            this.quantity_saleTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantity_saleTextBox.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(368, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.sale1DataSet;
            // 
            // sale1DataSet
            // 
            this.sale1DataSet.DataSetName = "Sale1DataSet";
            this.sale1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.firmTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab_12.Sale1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param3ToolStripLabel,
            this.param3ToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillBy1ToolStrip.TabIndex = 14;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // param3ToolStripLabel
            // 
            this.param3ToolStripLabel.Name = "param3ToolStripLabel";
            this.param3ToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.param3ToolStripLabel.Text = "Param3:";
            // 
            // param3ToolStripTextBox
            // 
            this.param3ToolStripTextBox.Name = "param3ToolStripTextBox";
            this.param3ToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 19);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(quantity_saleLabel);
            this.Controls.Add(this.quantity_saleTextBox);
            this.Controls.Add(date_saleLabel);
            this.Controls.Add(this.date_saleDateTimePicker);
            this.Controls.Add(quantity_orderLabel);
            this.Controls.Add(this.quantity_orderTextBox);
            this.Controls.Add(date_orderLabel);
            this.Controls.Add(this.date_orderDateTimePicker);
            this.Controls.Add(key_productLabel);
            this.Controls.Add(this.key_productTextBox);
            this.Controls.Add(key_clientLabel);
            this.Controls.Add(this.key_clientTextBox);
            this.Controls.Add(this.orderBindingNavigator);
            this.Name = "Form8";
            this.Text = "Заказы на заданную дату";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sale1DataSet sale1DataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Sale1DataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private Sale1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox key_clientTextBox;
        private System.Windows.Forms.TextBox key_productTextBox;
        private System.Windows.Forms.DateTimePicker date_orderDateTimePicker;
        private System.Windows.Forms.TextBox quantity_orderTextBox;
        private System.Windows.Forms.DateTimePicker date_saleDateTimePicker;
        private System.Windows.Forms.TextBox quantity_saleTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel param3ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param3ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}