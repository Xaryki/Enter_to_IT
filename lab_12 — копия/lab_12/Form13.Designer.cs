namespace lab_12
{
    partial class Form13
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
            this.sale1DataSet3 = new lab_12.Sale1DataSet3();
            this.tenMoreExpensiveProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenMoreExpensiveProductsTableAdapter = new lab_12.Sale1DataSet3TableAdapters.TenMoreExpensiveProductsTableAdapter();
            this.tableAdapterManager = new lab_12.Sale1DataSet3TableAdapters.TableAdapterManager();
            this.tenMoreExpensiveProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMoreExpensiveProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMoreExpensiveProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sale1DataSet3
            // 
            this.sale1DataSet3.DataSetName = "Sale1DataSet3";
            this.sale1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenMoreExpensiveProductsBindingSource
            // 
            this.tenMoreExpensiveProductsBindingSource.DataMember = "TenMoreExpensiveProducts";
            this.tenMoreExpensiveProductsBindingSource.DataSource = this.sale1DataSet3;
            // 
            // tenMoreExpensiveProductsTableAdapter
            // 
            this.tenMoreExpensiveProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = lab_12.Sale1DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tenMoreExpensiveProductsDataGridView
            // 
            this.tenMoreExpensiveProductsDataGridView.AutoGenerateColumns = false;
            this.tenMoreExpensiveProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tenMoreExpensiveProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tenMoreExpensiveProductsDataGridView.DataSource = this.tenMoreExpensiveProductsBindingSource;
            this.tenMoreExpensiveProductsDataGridView.Location = new System.Drawing.Point(12, 74);
            this.tenMoreExpensiveProductsDataGridView.Name = "tenMoreExpensiveProductsDataGridView";
            this.tenMoreExpensiveProductsDataGridView.RowHeadersWidth = 51;
            this.tenMoreExpensiveProductsDataGridView.RowTemplate.Height = 24;
            this.tenMoreExpensiveProductsDataGridView.Size = new System.Drawing.Size(379, 426);
            this.tenMoreExpensiveProductsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Наименование товара";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование товара";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.tenMoreExpensiveProductsDataGridView);
            this.Name = "Form13";
            this.Text = "Десять самых дорогих товаров";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMoreExpensiveProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMoreExpensiveProductsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sale1DataSet3 sale1DataSet3;
        private System.Windows.Forms.BindingSource tenMoreExpensiveProductsBindingSource;
        private Sale1DataSet3TableAdapters.TenMoreExpensiveProductsTableAdapter tenMoreExpensiveProductsTableAdapter;
        private Sale1DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tenMoreExpensiveProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}