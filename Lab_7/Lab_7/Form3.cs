using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataSet501.Clear();
            sqlDataAdapter1.Fill(dataSet501.product);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlDataAdapter2.SelectCommand.Parameters[0].Value = dataSet501.product[comboBox1.SelectedIndex].key_product;
            dataSet511.Clear();
            sqlDataAdapter2.Fill(dataSet511.order);
        }
    }
}
