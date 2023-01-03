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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
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
                    this.firmBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.sale1DataSet);
                }
                catch (System.Data.NoNullAllowedException)
                {
                    this.Show();
                    MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                    this.firmTableAdapter.Fill(this.sale1DataSet.firm);
                }
                catch (System.Data.ConstraintException)
                {
                    this.Show();
                    MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                    this.firmTableAdapter.Fill(this.sale1DataSet.firm);
                }
                catch (System.Data.SqlClient.SqlException s1)
                {
                    if (s1.ErrorCode == -2146232060)
                    {
                        this.Show();
                        MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                        this.firmTableAdapter.Fill(this.sale1DataSet.firm);
                    }
                }
            }
        }

        private void firmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.firmBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);
            }
            catch (System.Data.NoNullAllowedException)
            {
                this.Show();
                MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                this.firmTableAdapter.Fill(this.sale1DataSet.firm);
            }
            catch (System.Data.ConstraintException)
            {
                this.Show();
                MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                this.firmTableAdapter.Fill(this.sale1DataSet.firm);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    this.Show();
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    this.firmTableAdapter.Fill(this.sale1DataSet.firm);
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.firm". При необходимости она может быть перемещена или удалена.
            this.firmTableAdapter.Fill(this.sale1DataSet.firm);

        }

        private void firmDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.firmBindingSource.EndEdit();
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
            firmDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            firmDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            firmDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            firmDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            firmDataGridView.ReadOnly = false;
            try
            {
                //  
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                this.firmBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Предпринята попытка вставить уже имеющееся предприятие", "Ошибка", MessageBoxButtons.OK);
                this.firmBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);

            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    this.firmBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.sale1DataSet);

                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            firmDataGridView.ReadOnly = true;
        }
    }
}
