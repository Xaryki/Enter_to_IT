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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = dateTimePicker1.Text;
            switch (comboBox1.Text)
            {
                case "до":
                    {
                        crystalReportViewer1.SelectionFormula = "{Команда.date_order} < CDate('" + $"{dateTimePicker1.Value}')";
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
                case "после":
                    {
                        crystalReportViewer1.SelectionFormula = "{Команда.date_order} > CDate('" + $"{dateTimePicker1.Value}')";
                        crystalReportViewer1.RefreshReport();
                        break;
                    }

            }
        }
    }
}
