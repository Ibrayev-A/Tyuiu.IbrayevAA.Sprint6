using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IbrayevAA.Sprint6.Task1.V13.Lib;

namespace Tyuiu.IbrayevAA.Sprint6.Task1.V13
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxOutput_IAA.Text = "";
                textBoxOutput_IAA.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxOutput_IAA.AppendText("|      X     |    f(x)    |" + Environment.NewLine);
                textBoxOutput_IAA.AppendText("+------------+------------+" + Environment.NewLine);

                for (int i = 0; i<=len-1; i++)
                {
                    strLine = String.Format("|   {0,5:d}    |  {1,6:f2}    | ", startStep, valueArray[i]);
                    textBoxOutput_IAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxOutput_IAA.AppendText("+------------+------------+" + Environment.NewLine);

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
    }
}
