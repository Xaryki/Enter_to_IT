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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }


        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);
            }
            catch (System.Data.NoNullAllowedException)
            {
                this.Show();
                MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                this.productTableAdapter.Fill(this.sale1DataSet.product);
            }
            catch (System.Data.ConstraintException)
            {
                this.Show();
                MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                this.productTableAdapter.Fill(this.sale1DataSet.product);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    this.Show();
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    this.productTableAdapter.Fill(this.sale1DataSet.product);
                }
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.sale1DataSet.product);

        }

        private void productDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.productBindingSource.EndEdit();
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

        private void productBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            productDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            productDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            productDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            productDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            productDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            productDataGridView.ReadOnly = false;
            try
            {
              //  
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Предпринята попытка вставить уже имеющееся предприятие", "Ошибка", MessageBoxButtons.OK);
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sale1DataSet);

            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    this.productBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.sale1DataSet);

                }
            }

        }
    }
}
