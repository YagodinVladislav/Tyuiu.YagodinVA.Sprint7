using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project.V15.Lib;

namespace Project.V
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;
        int selectedCol;

        private void aboutProgramToolStripMenuItem_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные:\r* О клиентах магазина(ФИО, номер счёта, адрес проживания, номер телефона)\r* О заказах клиентов(Номер заказа, дата исполнения, стоимость заказа, название товара, цена, количество)", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_SSV_Click(object sender, EventArgs e)
        {
            openFileDialogTable_SSV.ShowDialog();
            openFilePath = openFileDialogTable_SSV.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTableOrders_SSV.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTableOrders_SSV.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
        }

        private void buttonDownload_SSV_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_SSV.FileName = "DataBase.csv";
            saveFileDialogTable_SSV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_SSV.ShowDialog();

            string path = saveFileDialogTable_SSV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTableOrders_SSV.RowCount;
            int columns = dataGridViewTableOrders_SSV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTableOrders_SSV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAdd_SSV_Click(object sender, EventArgs e)
        {
            dataGridViewTableOrders_SSV.Rows.Add();
        }

        private void buttonInfo_SSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemExit_SSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = dataGridViewTableOrders_SSV.SelectedRows.Count;
            int removeCount = 0;
            for (int i = 0; i < selectedRowsCount; i++, removeCount++)
            {
                dataGridViewTableOrders_SSV.Rows.RemoveAt(dataGridViewTableOrders_SSV.SelectedRows[i - removeCount].Index);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCol = comboBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string row = "";
            int selectRowIndex = -1;
            for (int i = 0; i < dataGridViewTableOrders_SSV.Rows.Count; i++)
            {
                row += dataGridViewTableOrders_SSV.Rows[i].Cells[selectedCol].Value;
                if (row.Contains(textBox1.Text))
                {
                    dataGridViewTableOrders_SSV.Rows[selectRowIndex].Cells[selectedCol].Selected = true;
                    break;
                }
                row = "";
            }
        }

        private void dataGridViewTable_SSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewTableOrders_SSV.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTableOrders_SSV.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}
