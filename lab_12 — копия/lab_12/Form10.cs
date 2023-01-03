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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
                dateTimePicker2.Visible = true;
            else dateTimePicker2.Visible = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dataView1.RowFilter = $"[Дата продажи]<'{Convert.ToString(dateTimePicker1.Value).Substring(0, 10)}'";
                        sqlDataAdapter1.Fill(dataSet11.OrderPerDate);
                        break;
                    }
                case 1:
                    {
                        dataView1.RowFilter = $"[Дата продажи]>'{Convert.ToString(dateTimePicker1.Value).Substring(0, 10)}' AND " +
                            $"[Дата продажи]<'{Convert.ToString(dateTimePicker2.Value).Substring(0, 10)}'";
                        sqlDataAdapter1.Fill(dataSet11.OrderPerDate);
                        break;
                    }
                case 2:
                    {
                        dataView1.RowFilter = $"[Дата продажи]>'{Convert.ToString(dateTimePicker1.Value).Substring(0, 10)}'";
                        sqlDataAdapter1.Fill(dataSet11.OrderPerDate);
                        break;
                    }
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dataView1.RowFilter = $"[Дата продажи]>'{Convert.ToString(dateTimePicker1.Value).Substring(0, 10)}' AND " +
                            $"[Дата продажи]<'{Convert.ToString(dateTimePicker2.Value).Substring(0, 10)}'";
            sqlDataAdapter1.Fill(dataSet11.OrderPerDate);

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
