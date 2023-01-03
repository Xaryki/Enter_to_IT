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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text) 
            {
                case "больше":
                    {
                        crystalReportViewer1.SelectionFormula = "{@Сумма заказа } > " + Convert.ToSingle(textBox1.Text);
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
                case "меньше":
                    {
                        crystalReportViewer1.SelectionFormula = "{@Сумма заказа } < " + Convert.ToSingle(textBox1.Text);
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
                case "равно":
                    {
                        crystalReportViewer1.SelectionFormula = "{@Сумма заказа } = " + Convert.ToSingle(textBox1.Text);
                        crystalReportViewer1.RefreshReport();
                       
                    }
                    break;
                    
            }  
        }
    }
}
