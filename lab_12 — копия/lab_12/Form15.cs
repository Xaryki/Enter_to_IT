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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1Client.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1Client.client);

        }

        private void key_clientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            System.Data.SqlClient.SqlDataReader sr;
            sqlCommand1.Parameters[0].Value = key_clientListBox.SelectedValue;
            sr = sqlCommand1.ExecuteReader();
            while (sr.Read())
            {
                textBox1.Text = System.Convert.ToString(sr[2]);
                textBox2.Text = System.Convert.ToString(sr[3]);
            }
            sqlConnection1.Close();

        }
    }
}
