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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataSet1001.Clear();
            sqlDataAdapter1.Fill(dataSet1001.client);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlDataAdapter2.SelectCommand.Parameters[0].Value = dataSet1001.client[comboBox1.SelectedIndex].key_client;
            dataSet10021.Clear();
            sqlDataAdapter2.Fill(dataSet10021.order);

        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }
    }
}
