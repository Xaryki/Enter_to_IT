using System;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sale1DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1DataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet1.order". При необходимости она может быть перемещена или удалена.
            //this.orderTableAdapter.Fill(this.sale1DataSet1.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet1.order". При необходимости она может быть перемещена или удалена.
            //this.orderTableAdapter.Fill(this.sale1DataSet1.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet.order);

        }

        

        private void orderBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sale1DataSet);

        }

        
        

        

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

        }

        private void orderBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sale1DataSet);

        }

        private void fillBy6ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableAdapter.FillBy6(this.sale1DataSet.order, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void key_clientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.orderTableAdapter.FillBy6(this.sale1DataSet.order, System.Convert.ToString(this.key_clientListBox.SelectedValue));
        }
    }
}
