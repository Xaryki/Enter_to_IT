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
            dataSet21.Clear();
            sqlDataAdapter1.Fill(dataSet21.client);
            sqlDataAdapter2.Fill(dataSet21.order);

        }
    }
}
