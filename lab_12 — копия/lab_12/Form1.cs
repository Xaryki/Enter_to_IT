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
            f2.MdiParent = this;
            f2.Show();

        }

        private void вводПокупателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form3();
            f2.MdiParent = this;
            f2.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form4();
            f2.MdiParent = this;
            f2.Show();
        }

        private void компанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form5();
            f2.MdiParent = this;
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

        private void мозаикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void поГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void поВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void каскадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void заказыНаЗаданнуюДатуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form9();
            f2.Show();
        }

        private void заказыВИнтервалеДатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form10();
            f2.Show();
        }

        private void заказыПокупателяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form11();
            f2.Show();
        }

        private void заказыТовараToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form12();
            f2.Show();
        }

        private void десятьСамыхДорогихТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form13();
            f2.Show();
        }

        private void десятьСамыхПродаваемыхТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form14();
            f2.Show();
        }

        private void общаяСуммаЗаказовКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form15();
            f2.Show();
        }

        private void добавлениеТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form16();
            f2.Show();
        }

        private void добавлениеПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form17();
            f2.Show();
        }
    }
}
