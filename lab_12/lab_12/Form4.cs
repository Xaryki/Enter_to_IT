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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sss;
            this.Hide();
            e.Cancel = true;
            sss = MessageBox.Show("Сохранить сделанные изменения в таблице товары?", "Внимание!", MessageBoxButtons.OKCancel);
            if (sss == DialogResult.OK)
            {
                try
                {
                    this.Validate();
                    this.orderBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.sale1DataSet);
                }
                catch (System.Data.NoNullAllowedException)
                {
                    this.Show();
                    MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                    this.orderTableAdapter.Fill(this.sale1DataSet.order);
                }
                catch (System.Data.ConstraintException)
                {
                    this.Show();
                    MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                    this.orderTableAdapter.Fill(this.sale1DataSet.order);
                }
                catch (System.Data.SqlClient.SqlException s1)
                {
                    if (s1.ErrorCode == -2146232060)
                    {
                        this.Show();
                        MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                        this.orderTableAdapter.Fill(this.sale1DataSet.order);
                    }
                }
            }
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.orderBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);
            }
            catch (System.Data.NoNullAllowedException)
            {
                this.Show();
                MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                this.orderTableAdapter.Fill(this.sale1DataSet.order);
            }
            catch (System.Data.ConstraintException)
            {
                this.Show();
                MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                this.orderTableAdapter.Fill(this.sale1DataSet.order);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    this.Show();
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    this.orderTableAdapter.Fill(this.sale1DataSet.order);
                }
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1DataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet.order);

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox)
                {
                    ctl.Enabled = true;
                }
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void orderDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.orderBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                //sale1DataSet.Clear();


            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Предпринята попытка вставить уже имеющееся предприятие", "Ошибка", MessageBoxButtons.OK);

            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);

                }
            }
        }
    }
}
