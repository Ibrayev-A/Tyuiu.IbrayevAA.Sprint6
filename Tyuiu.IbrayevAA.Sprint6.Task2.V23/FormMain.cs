using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IbrayevAA.Sprint6.Task2.V23.Lib;

namespace Tyuiu.IbrayevAA.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_IAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_IAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartOutput_IAA.Titles.Add("График функции ");
                    
                this.chartOutput_IAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOutput_IAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOutput_IAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartOutput_IAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТБ-23-2 Ибраев Абай Аскарович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_IAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_IAA.BackColor = Color.Blue;
        }

        private void buttonResult_IAA_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_IAA.BackColor = Color.Red;
        }

        private void buttonResult_IAA_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_IAA.BackColor = Color.Green;
        }
    }
}
