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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataView1.RowFilter = "[Дата продажи]=" + "'" + System.Convert.ToString(dateTimePicker1.Value).Substring(0, 10) + "'";
            sqlDataAdapter1.Fill(dataSet111.OrderPerDate);

        }
    }
}
