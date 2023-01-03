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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sale1DataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sale1DataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sale1DataSet.order);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.orderTableAdapter.FillBy1(this.sale1DataSet.order, monthCalendar1.SelectionStart);
        }

        

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableAdapter.FillBy1(this.sale1DataSet.order, ((System.DateTime)(System.Convert.ChangeType(param3ToolStripTextBox.Text, typeof(System.DateTime)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
