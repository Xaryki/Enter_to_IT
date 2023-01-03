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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataSet41.Clear();
            sqlDataAdapter1.Fill(dataSet41.firm);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            //firmBindingSource.EndEdit();
            //sqlDataAdapter1.Update(dataSet41.firm);
            try
            {
                firmBindingSource.EndEdit();
                sqlDataAdapter1.Update(dataSet41.firm);
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                dataSet41.Clear();
                sqlDataAdapter1.Fill(dataSet41.firm);
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Предпринята попытка вставить уже имеющееся предприятие", "Ошибка", MessageBoxButtons.OK);
                dataSet41.Clear();
                sqlDataAdapter1.Fill(dataSet41.firm);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    dataSet41.Clear();
                    sqlDataAdapter1.Fill(dataSet41.firm);
                }
            }


        }
    }
}
