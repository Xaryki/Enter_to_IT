using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3sql
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            dataSet41.Clear();
            sqlDataAdapter1.Fill(dataSet41.firm);
            sqlDataAdapter2.Fill(dataSet41.client);
            sqlDataAdapter3.Fill(dataSet41.order);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
