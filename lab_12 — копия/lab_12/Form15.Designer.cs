namespace lab_12
{
    partial class Form15
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
            this.dataSet2 = new lab_12.DataSet2();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale1Client = new lab_12.Sale1Client();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new lab_12.Sale1ClientTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new lab_12.Sale1ClientTableAdapters.TableAdapterManager();
            this.key_clientListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            key_clientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // key_clientLabel
            // 
            key_clientLabel.AutoSize = true;
            key_clientLabel.Location = new System.Drawing.Point(113, 110);
            key_clientLabel.Name = "key_clientLabel";
            key_clientLabel.Size = new System.Drawing.Size(196, 16);
            key_clientLabel.TabIndex = 0;
            key_clientLabel.Text = "Выберите клиента из списка";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dataSet2;
            // 
            // sale1Client
            // 
            this.sale1Client.DataSetName = "Sale1Client";
            this.sale1Client.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.sale1Client;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab_12.Sale1ClientTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // key_clientListBox
            // 
            this.key_clientListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource1, "key_client", true));
            this.key_clientListBox.DataSource = this.sale1Client;
            this.key_clientListBox.DisplayMember = "client.key_client";
            this.key_clientListBox.FormattingEnabled = true;
            this.key_clientListBox.ItemHeight = 16;
            this.key_clientListBox.Location = new System.Drawing.Point(116, 154);
            this.key_clientListBox.Name = "key_clientListBox";
            this.key_clientListBox.Size = new System.Drawing.Size(193, 180);
            this.key_clientListBox.TabIndex = 1;
            this.key_clientListBox.ValueMember = "client.key_client";
            this.key_clientListBox.SelectedIndexChanged += new System.EventHandler(this.key_clientListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Общее число заказов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "на сумму";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 22);
            this.textBox2.TabIndex = 5;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-LBHF0MP\\SQLEXPRESS;Initial Catalog=Sale1;Integrated Security=" +
    "True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SumOfOrderPerClient";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("P1", System.Data.SqlDbType.NChar)});
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(key_clientLabel);
            this.Controls.Add(this.key_clientListBox);
            this.Name = "Form15";
            this.Text = "Общая сумма заказов клиента";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Sale1Client sale1Client;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private Sale1ClientTableAdapters.clientTableAdapter clientTableAdapter;
        private Sale1ClientTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox key_clientListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}