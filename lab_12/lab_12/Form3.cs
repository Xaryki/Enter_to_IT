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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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
                    this.clientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.sale1DataSet);
                }
                catch (System.Data.NoNullAllowedException)
                {
                    this.Show();
                    MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                    this.clientTableAdapter.Fill(this.sale1DataSet.client);
                }
                catch (System.Data.ConstraintException)
                {
                    this.Show();
                    MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                    this.clientTableAdapter.Fill(this.sale1DataSet.client);
                }
                catch (System.Data.SqlClient.SqlException s1)
                {
                    if (s1.ErrorCode == -2146232060)
                    {
                        this.Show();
                        MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                        this.clientTableAdapter.Fill(this.sale1DataSet.client);
                    }
                }
            }
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);
            }
            catch (System.Data.NoNullAllowedException)
            {
                this.Show();
                MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                this.clientTableAdapter.Fill(this.sale1DataSet.client);
            }
            catch (System.Data.ConstraintException)
            {
                this.Show();
                MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                this.clientTableAdapter.Fill(this.sale1DataSet.client);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    this.Show();
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    this.clientTableAdapter.Fill(this.sale1DataSet.client);
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sale1DataSet.client);

        }

        private void clientDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.clientBindingSource.EndEdit();
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
    }
}
