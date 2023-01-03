using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataSet51.Clear();
            sqlDataAdapter1.Fill(dataSet51.client);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[dataSet51, "client"].EndCurrentEdit();
                this.BindingContext[dataSet51, "client"].AddNew();
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие и Кредит не может содержать  значение Null", "Ошибка", MessageBoxButtons.OK);
                dataSet51.Clear();
                sqlDataAdapter1.Fill(dataSet51.client);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Поле Предприятие и Кредит не может содержать  значение Null", "Ошибка", MessageBoxButtons.OK);
                dataSet51.Clear();
                sqlDataAdapter1.Fill(dataSet51.client);
            }


        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[dataSet51, "client"].Count > 0)
            {
                this.BindingContext[dataSet51, "client"].RemoveAt(this.BindingContext[dataSet51, "client"].Position);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.BindingContext[dataSet51, "client"].EndCurrentEdit();
            //sqlDataAdapter1.Update(dataSet51.client);
            try
            {
                this.BindingContext[dataSet51, "client"].EndCurrentEdit();
                sqlDataAdapter1.Update(dataSet51.client);
            }
            catch (System.Data.SqlClient.SqlException s3)
            {
                if (s3.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Редактирование записей невозможно. В таблице Заказы именются связанные записи, код клиента должен быть уникальным", "Ошибка", MessageBoxButtons.OK);
                    dataSet51.Clear();
                    sqlDataAdapter1.Fill(dataSet51.client);
                }
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие и Кредит не может содержать  значение Null", "Ошибка", MessageBoxButtons.OK);
                dataSet51.Clear();
                sqlDataAdapter1.Fill(dataSet51.client);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet51, "client"].CancelCurrentEdit();
        }
    }
}
