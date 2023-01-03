using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet2.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1DataSet2.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet2.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet2.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet2.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1DataSet2.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1DataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet1.OrderPerClient". При необходимости она может быть перемещена или удалена.
            this.orderPerClientTableAdapter.Fill(this.sale1DataSet1.OrderPerClient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.client". При необходимости она может быть перемещена или удалена.
            //this.clientTableAdapter.Fill(this.sale1DataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet1.OrderPerClient". При необходимости она может быть перемещена или удалена.
            this.orderPerClientTableAdapter.Fill(this.sale1DataSet1.OrderPerClient);

        }

        

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //this.orderPerClientTableAdapter.Test(this.sale1DataSet1.OrderPerClient, System.Convert.ToString(comboBox1.SelectedValue));
        }

        
        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.FillBy1(this.sale1DataSet.client);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void key_clientComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.orderPerClientTableAdapter.Test(this.sale1DataSet1.OrderPerClient, System.Convert.ToString(comboBox1.SelectedValue));
        }
    }
}
