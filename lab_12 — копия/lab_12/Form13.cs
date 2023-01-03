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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet3.TenMoreExpensiveProducts". При необходимости она может быть перемещена или удалена.
            this.tenMoreExpensiveProductsTableAdapter.Fill(this.sale1DataSet3.TenMoreExpensiveProducts);

        }
    }
}
