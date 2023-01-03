namespace lab_12
{
    partial class Form14
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
            this.sale1DataSet4 = new lab_12.Sale1DataSet4();
            this.tenMorePopularProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenMorePopularProductsTableAdapter = new lab_12.Sale1DataSet4TableAdapters.TenMorePopularProductsTableAdapter();
            this.tableAdapterManager = new lab_12.Sale1DataSet4TableAdapters.TableAdapterManager();
            this.tenMorePopularProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMorePopularProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMorePopularProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sale1DataSet4
            // 
            this.sale1DataSet4.DataSetName = "Sale1DataSet4";
            this.sale1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenMorePopularProductsBindingSource
            // 
            this.tenMorePopularProductsBindingSource.DataMember = "TenMorePopularProducts";
            this.tenMorePopularProductsBindingSource.DataSource = this.sale1DataSet4;
            // 
            // tenMorePopularProductsTableAdapter
            // 
            this.tenMorePopularProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = lab_12.Sale1DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tenMorePopularProductsDataGridView
            // 
            this.tenMorePopularProductsDataGridView.AutoGenerateColumns = false;
            this.tenMorePopularProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tenMorePopularProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tenMorePopularProductsDataGridView.DataSource = this.tenMorePopularProductsBindingSource;
            this.tenMorePopularProductsDataGridView.Location = new System.Drawing.Point(12, 44);
            this.tenMorePopularProductsDataGridView.Name = "tenMorePopularProductsDataGridView";
            this.tenMorePopularProductsDataGridView.RowHeadersWidth = 51;
            this.tenMorePopularProductsDataGridView.RowTemplate.Height = 24;
            this.tenMorePopularProductsDataGridView.Size = new System.Drawing.Size(356, 394);
            this.tenMorePopularProductsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Column1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tenMorePopularProductsDataGridView);
            this.Name = "Form14";
            this.Text = "Десять самых продаваемых товаров";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMorePopularProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMorePopularProductsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sale1DataSet4 sale1DataSet4;
        private System.Windows.Forms.BindingSource tenMorePopularProductsBindingSource;
        private Sale1DataSet4TableAdapters.TenMorePopularProductsTableAdapter tenMorePopularProductsTableAdapter;
        private Sale1DataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tenMorePopularProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}