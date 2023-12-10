
namespace Tyuiu.IbrayevAA.Sprint6.Task7.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButton_IAA = new System.Windows.Forms.Panel();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.buttonSave_IAA = new System.Windows.Forms.Button();
            this.buttonResult_IAA = new System.Windows.Forms.Button();
            this.buttonOpen_IAA = new System.Windows.Forms.Button();
            this.panelTask_IAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_IAA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelInput_IAA = new System.Windows.Forms.Panel();
            this.groupBoxInput_IAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_IAA = new System.Windows.Forms.DataGridView();
            this.panelOutput_IAA = new System.Windows.Forms.Panel();
            this.groupBoxOutput_IAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_IAA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_IAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipHelp_IAA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogOutputSave_IAA = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelButton_IAA.SuspendLayout();
            this.panelTask_IAA.SuspendLayout();
            this.groupBoxTask_IAA.SuspendLayout();
            this.panelInput_IAA.SuspendLayout();
            this.groupBoxInput_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_IAA)).BeginInit();
            this.panelOutput_IAA.SuspendLayout();
            this.groupBoxOutput_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton_IAA
            // 
            this.panelButton_IAA.Controls.Add(this.buttonInfo_IAA);
            this.panelButton_IAA.Controls.Add(this.buttonSave_IAA);
            this.panelButton_IAA.Controls.Add(this.buttonResult_IAA);
            this.panelButton_IAA.Controls.Add(this.buttonOpen_IAA);
            this.panelButton_IAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_IAA.Location = new System.Drawing.Point(0, 0);
            this.panelButton_IAA.Name = "panelButton_IAA";
            this.panelButton_IAA.Size = new System.Drawing.Size(800, 100);
            this.panelButton_IAA.TabIndex = 0;
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInfo_IAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_IAA.Image")));
            this.buttonInfo_IAA.Location = new System.Drawing.Point(704, 0);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(96, 100);
            this.buttonInfo_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonInfo_IAA, "Сведение о программе");
            this.buttonInfo_IAA.UseVisualStyleBackColor = true;
            // 
            // buttonSave_IAA
            // 
            this.buttonSave_IAA.Enabled = false;
            this.buttonSave_IAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_IAA.Image")));
            this.buttonSave_IAA.Location = new System.Drawing.Point(216, 18);
            this.buttonSave_IAA.Name = "buttonSave_IAA";
            this.buttonSave_IAA.Size = new System.Drawing.Size(96, 66);
            this.buttonSave_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonSave_IAA, "Программа сохраняет результат в файл OutPutFileTask7.csv");
            this.buttonSave_IAA.UseVisualStyleBackColor = true;
            this.buttonSave_IAA.Click += new System.EventHandler(this.buttonSave_IAA_Click);
            // 
            // buttonResult_IAA
            // 
            this.buttonResult_IAA.Enabled = false;
            this.buttonResult_IAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonResult_IAA.Image")));
            this.buttonResult_IAA.Location = new System.Drawing.Point(114, 18);
            this.buttonResult_IAA.Name = "buttonResult_IAA";
            this.buttonResult_IAA.Size = new System.Drawing.Size(96, 66);
            this.buttonResult_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonResult_IAA, " Программа изменяет во второй строке четные элементы на 44. Результат выводит в о" +
        "бъект dataGridViewOut");
            this.buttonResult_IAA.UseVisualStyleBackColor = true;
            this.buttonResult_IAA.Click += new System.EventHandler(this.buttonResult_IAA_Click);
            // 
            // buttonOpen_IAA
            // 
            this.buttonOpen_IAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_IAA.Image")));
            this.buttonOpen_IAA.Location = new System.Drawing.Point(12, 18);
            this.buttonOpen_IAA.Name = "buttonOpen_IAA";
            this.buttonOpen_IAA.Size = new System.Drawing.Size(96, 66);
            this.buttonOpen_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonOpen_IAA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_IAA.UseVisualStyleBackColor = true;
            this.buttonOpen_IAA.Click += new System.EventHandler(this.buttonOpen_IAA_Click);
            // 
            // panelTask_IAA
            // 
            this.panelTask_IAA.Controls.Add(this.groupBoxTask_IAA);
            this.panelTask_IAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_IAA.Location = new System.Drawing.Point(0, 100);
            this.panelTask_IAA.Name = "panelTask_IAA";
            this.panelTask_IAA.Size = new System.Drawing.Size(800, 100);
            this.panelTask_IAA.TabIndex = 0;
            // 
            // groupBoxTask_IAA
            // 
            this.groupBoxTask_IAA.Controls.Add(this.textBox1);
            this.groupBoxTask_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_IAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_IAA.Name = "groupBoxTask_IAA";
            this.groupBoxTask_IAA.Size = new System.Drawing.Size(800, 100);
            this.groupBoxTask_IAA.TabIndex = 0;
            this.groupBoxTask_IAA.TabStop = false;
            this.groupBoxTask_IAA.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(794, 79);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInput_IAA
            // 
            this.panelInput_IAA.Controls.Add(this.groupBoxInput_IAA);
            this.panelInput_IAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_IAA.Location = new System.Drawing.Point(0, 200);
            this.panelInput_IAA.Name = "panelInput_IAA";
            this.panelInput_IAA.Size = new System.Drawing.Size(399, 250);
            this.panelInput_IAA.TabIndex = 0;
            // 
            // groupBoxInput_IAA
            // 
            this.groupBoxInput_IAA.Controls.Add(this.dataGridViewInput_IAA);
            this.groupBoxInput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_IAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_IAA.Name = "groupBoxInput_IAA";
            this.groupBoxInput_IAA.Size = new System.Drawing.Size(399, 250);
            this.groupBoxInput_IAA.TabIndex = 0;
            this.groupBoxInput_IAA.TabStop = false;
            this.groupBoxInput_IAA.Text = "Ввод";
            // 
            // dataGridViewInput_IAA
            // 
            this.dataGridViewInput_IAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_IAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInput_IAA.Name = "dataGridViewInput_IAA";
            this.dataGridViewInput_IAA.RowHeadersWidth = 51;
            this.dataGridViewInput_IAA.RowTemplate.Height = 24;
            this.dataGridViewInput_IAA.Size = new System.Drawing.Size(393, 229);
            this.dataGridViewInput_IAA.TabIndex = 0;
            // 
            // panelOutput_IAA
            // 
            this.panelOutput_IAA.Controls.Add(this.groupBoxOutput_IAA);
            this.panelOutput_IAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOutput_IAA.Location = new System.Drawing.Point(393, 200);
            this.panelOutput_IAA.Name = "panelOutput_IAA";
            this.panelOutput_IAA.Size = new System.Drawing.Size(407, 250);
            this.panelOutput_IAA.TabIndex = 0;
            // 
            // groupBoxOutput_IAA
            // 
            this.groupBoxOutput_IAA.Controls.Add(this.splitter1);
            this.groupBoxOutput_IAA.Controls.Add(this.dataGridViewOutput_IAA);
            this.groupBoxOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_IAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_IAA.Name = "groupBoxOutput_IAA";
            this.groupBoxOutput_IAA.Size = new System.Drawing.Size(407, 250);
            this.groupBoxOutput_IAA.TabIndex = 0;
            this.groupBoxOutput_IAA.TabStop = false;
            this.groupBoxOutput_IAA.Text = "Вывод";
            // 
            // dataGridViewOutput_IAA
            // 
            this.dataGridViewOutput_IAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_IAA.ColumnHeadersVisible = false;
            this.dataGridViewOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_IAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutput_IAA.Name = "dataGridViewOutput_IAA";
            this.dataGridViewOutput_IAA.RowHeadersVisible = false;
            this.dataGridViewOutput_IAA.RowHeadersWidth = 51;
            this.dataGridViewOutput_IAA.RowTemplate.Height = 24;
            this.dataGridViewOutput_IAA.Size = new System.Drawing.Size(401, 229);
            this.dataGridViewOutput_IAA.TabIndex = 0;
            // 
            // openFileDialogTask_IAA
            // 
            this.openFileDialogTask_IAA.FileName = "openFileDialog1";
            // 
            // toolTipHelp_IAA
            // 
            this.toolTipHelp_IAA.IsBalloon = true;
            this.toolTipHelp_IAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp_IAA.ToolTipTitle = "Подсказка";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 18);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 229);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOutput_IAA);
            this.Controls.Add(this.panelInput_IAA);
            this.Controls.Add(this.panelTask_IAA);
            this.Controls.Add(this.panelButton_IAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButton_IAA.ResumeLayout(false);
            this.panelTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.PerformLayout();
            this.panelInput_IAA.ResumeLayout(false);
            this.groupBoxInput_IAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_IAA)).EndInit();
            this.panelOutput_IAA.ResumeLayout(false);
            this.groupBoxOutput_IAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_IAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_IAA;
        private System.Windows.Forms.Panel panelTask_IAA;
        private System.Windows.Forms.Panel panelInput_IAA;
        private System.Windows.Forms.Panel panelOutput_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Button buttonSave_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
        private System.Windows.Forms.Button buttonOpen_IAA;
        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInput_IAA;
        private System.Windows.Forms.DataGridView dataGridViewInput_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_IAA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_IAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_IAA;
        private System.Windows.Forms.ToolTip toolTipHelp_IAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputSave_IAA;
        private System.Windows.Forms.Splitter splitter1;
    }
}

