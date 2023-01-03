using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog1.Filter.IndexOf("Word") > 0)
            {
                CrystalReport11.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, saveFileDialog1.FileName);
            }
            if (saveFileDialog1.Filter.IndexOf("Excel") > 0)
            {
                CrystalReport11.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, saveFileDialog1.FileName);
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "документ Word|*.doc";
            saveFileDialog1.ShowDialog();

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "документ Excel|*.xls";
            saveFileDialog1.ShowDialog();

        }
    }
}
