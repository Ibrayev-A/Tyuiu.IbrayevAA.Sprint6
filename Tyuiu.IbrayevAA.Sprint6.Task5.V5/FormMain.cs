using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IbrayevAA.Sprint6.Task5.V5.Lib;
using System.IO;

namespace Tyuiu.IbrayevAA.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\Quyzt\Source\Repos\Tyuiu.IbrayevAA.Sprint6\Tyuiu.IbrayevAA.Sprint6.Task5.V5\bin\Sprint6Task4\InPutFileTask5V5.txt";

        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_IAA.ColumnCount = 2;
            dataGridViewOutput_IAA.Columns[0].Width = 20;
            dataGridViewOutput_IAA.Columns[1].Width = 50;

            this.chartOutput_IAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartOutput_IAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartOutput_IAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutput_IAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartOutput_IAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_IAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТБ-23-2 Ибраев Абай Аскарович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
