﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void заказыПокупатселяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void продажиТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f3 = new Form3();
            f3.Show();
        }

        private void выборЗаказовПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f4 = new Form4();
            f4.Show();
        }

        private void выборЗаказовПоОбъемуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f5 = new Form5();
            f5.Show();
        }

        private void выборЗаказовПоДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f6 = new Form6();
            f6.Show();
        }
    }
}
