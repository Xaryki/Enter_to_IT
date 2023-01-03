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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void заказыПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void заказыТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }
    }
}
