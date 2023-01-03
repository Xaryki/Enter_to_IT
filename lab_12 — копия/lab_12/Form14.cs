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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet4.TenMorePopularProducts". При необходимости она может быть перемещена или удалена.
            this.tenMorePopularProductsTableAdapter.Fill(this.sale1DataSet4.TenMorePopularProducts);

        }
    }
}
