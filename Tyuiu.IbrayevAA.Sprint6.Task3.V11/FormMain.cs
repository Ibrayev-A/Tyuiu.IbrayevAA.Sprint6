using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IbrayevAA.Sprint6.Task3.V11.Lib;

namespace Tyuiu.IbrayevAA.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mrtx = new int[5, 5] { { 27, -15, 14, 2, 27 },
                                      { -8, 14, -10, 33, 0 },
                                      { 1, 7, -11, -11, 23 },
                                      { -13, -20, 15, -16, 34 },
                                      { -3, 1, -1, 5, 1 } };
        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            int rows = mrtx.GetUpperBound(0) + 1;
            int columns = mrtx.Length / rows;

            int[] array = new int[rows];

            dataGridViewResult_IAA.ColumnCount = columns;
            dataGridViewResult_IAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_IAA.Columns[i].Width = 25;
            }
            int[,] res = ds.Calculate(mrtx);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_IAA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mrtx.GetUpperBound(0) + 1;
            int columns = mrtx.Length / rows;

            int[] array = new int[rows];

            dataGridViewTask_IAA.ColumnCount = columns;
            dataGridViewTask_IAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask_IAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask_IAA.Rows[i].Cells[j].Value = Convert.ToString(mrtx[i, j]);
                }
            }
        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТБ-23-2 Ибраев Абай Аскарович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
