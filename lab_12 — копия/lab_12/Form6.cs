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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sale1DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1DataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet.order);

        }

        private void key_clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.orderTableAdapter.ЗаказыПокупателя(this.sale1DataSet.order, System.Convert.ToString(this.key_clientComboBox.SelectedValue));
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

        }
    }
}
