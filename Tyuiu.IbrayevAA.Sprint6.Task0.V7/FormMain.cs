using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IbrayevAA.Sprint6.Task0.V7.Lib;

namespace Tyuiu.IbrayevAA.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult_IAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_IAA.Text)));
        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТБ-23-2 Ибраев Абай Аскарович", "Сообщение");
        }
    }
}
