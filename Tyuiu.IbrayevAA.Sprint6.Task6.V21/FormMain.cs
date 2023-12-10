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
using Tyuiu.IbrayevAA.Sprint6.Task6.V21.Lib;

namespace Tyuiu.IbrayevAA.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string openFilePath;

        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            string str = "g";
            textBoxOutput_IAA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonOpenFile_IAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IAA.ShowDialog();
            openFilePath = openFileDialogTask_IAA.FileName;
            textBoxInput_IAA.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_IAA.Text = groupBoxOutput_IAA.Text + " " + openFileDialogTask_IAA.FileName;
            buttonOpenFile_IAA.Enabled = true;
        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            FormAbout fromAbout = new FormAbout();
            fromAbout.ShowDialog();
        }
    }
}
