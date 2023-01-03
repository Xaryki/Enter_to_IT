using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{Команда.key_client } = '" + comboBox1.SelectedValue + "'";
            crystalReportViewer1.RefreshReport();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dataSet11);

        }
    }
}
