using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IbrayevAA.Sprint6.Task7.V14.Lib;
using System.IO;

namespace Tyuiu.IbrayevAA.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_IAA.Filter = "Значения разделённые запятыми(*.cvs)|*.cvs|Все файлы(*.*)|*.*";
            saveFileDialogOutputSave_IAA.Filter = "Значения разделённые запятыми(*.cvs)|*.cvs|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { 'r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            int[,] matrix = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutput_IAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_IAA.Enabled = true;
        }

        private void buttonOpen_IAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IAA.ShowDialog();
            openFilePath = openFileDialogTask_IAA.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_IAA.RowCount = rows;
            dataGridViewInput_IAA.ColumnCount = colums;
            dataGridViewOutput_IAA.RowCount = rows;
            dataGridViewOutput_IAA.ColumnCount = colums;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput_IAA.Columns[i].Width = 25;
                dataGridViewOutput_IAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInput_IAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonResult_IAA.Enabled = true;
        }

        private void buttonSave_IAA_Click(object sender, EventArgs e)
        {
            saveFileDialogOutputSave_IAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogOutputSave_IAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogOutputSave_IAA.ShowDialog();

            string path = saveFileDialogOutputSave_IAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
                File.Delete(path);

            int rows = dataGridViewOutput_IAA.RowCount;
            int columns = dataGridViewOutput_IAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str += dataGridViewOutput_IAA.Rows[i].Cells[j].Value + ";";
                    else
                        str += dataGridViewOutput_IAA.Rows[i].Cells[j].Value;

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
