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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void регистрацияТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void вводПокупателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form3();
            f2.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form4();
            f2.Show();
        }

        private void компанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form5();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void заказыПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form6();
            f2.Show();
        }

        private void заказыТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form7();
            f2.Show();
        }

        private void заказыНаЗаданнуюДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form8();
            f2.Show();
        }
    }
}
