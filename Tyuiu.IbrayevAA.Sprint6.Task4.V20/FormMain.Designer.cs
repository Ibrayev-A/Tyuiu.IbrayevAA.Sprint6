
namespace Tyuiu.IbrayevAA.Sprint6.Task4.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxInput_IAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_IAA = new System.Windows.Forms.GroupBox();
            this.textBoxStartValue_IAA = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_IAA = new System.Windows.Forms.TextBox();
            this.labelVarStartValue_IAA = new System.Windows.Forms.Label();
            this.labelStopValue_IAA = new System.Windows.Forms.Label();
            this.buttonResult_IAA = new System.Windows.Forms.Button();
            this.buttonSave_IAA = new System.Windows.Forms.Button();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.panelTop_IAA = new System.Windows.Forms.Panel();
            this.panelLeft_IAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_IAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_IAA = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxResult_IAA = new System.Windows.Forms.TextBox();
            this.chartOutput_IAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterPanel_IAA = new System.Windows.Forms.Splitter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInput_IAA.SuspendLayout();
            this.groupBoxOutput_IAA.SuspendLayout();
            this.panelTop_IAA.SuspendLayout();
            this.panelLeft_IAA.SuspendLayout();
            this.groupBoxTask_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_IAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInput_IAA
            // 
            this.groupBoxInput_IAA.Controls.Add(this.labelStopValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.labelVarStartValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.textBoxStopValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.textBoxStartValue_IAA);
            this.groupBoxInput_IAA.Location = new System.Drawing.Point(524, 7);
            this.groupBoxInput_IAA.Name = "groupBoxInput_IAA";
            this.groupBoxInput_IAA.Size = new System.Drawing.Size(250, 131);
            this.groupBoxInput_IAA.TabIndex = 0;
            this.groupBoxInput_IAA.TabStop = false;
            this.groupBoxInput_IAA.Text = "Ввод данных";
            // 
            // groupBoxOutput_IAA
            // 
            this.groupBoxOutput_IAA.Controls.Add(this.panelLeft_IAA);
            this.groupBoxOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_IAA.Location = new System.Drawing.Point(0, 143);
            this.groupBoxOutput_IAA.Name = "groupBoxOutput_IAA";
            this.groupBoxOutput_IAA.Size = new System.Drawing.Size(1125, 358);
            this.groupBoxOutput_IAA.TabIndex = 0;
            this.groupBoxOutput_IAA.TabStop = false;
            this.groupBoxOutput_IAA.Text = "Вывод";
            // 
            // textBoxStartValue_IAA
            // 
            this.textBoxStartValue_IAA.Location = new System.Drawing.Point(6, 71);
            this.textBoxStartValue_IAA.Name = "textBoxStartValue_IAA";
            this.textBoxStartValue_IAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartValue_IAA.TabIndex = 0;
            this.textBoxStartValue_IAA.Text = "-5";
            // 
            // textBoxStopValue_IAA
            // 
            this.textBoxStopValue_IAA.Location = new System.Drawing.Point(132, 71);
            this.textBoxStopValue_IAA.Name = "textBoxStopValue_IAA";
            this.textBoxStopValue_IAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopValue_IAA.TabIndex = 0;
            this.textBoxStopValue_IAA.Text = "5";
            // 
            // labelVarStartValue_IAA
            // 
            this.labelVarStartValue_IAA.AutoSize = true;
            this.labelVarStartValue_IAA.Location = new System.Drawing.Point(6, 47);
            this.labelVarStartValue_IAA.Name = "labelVarStartValue_IAA";
            this.labelVarStartValue_IAA.Size = new System.Drawing.Size(87, 17);
            this.labelVarStartValue_IAA.TabIndex = 1;
            this.labelVarStartValue_IAA.Text = "Старт шага:";
            // 
            // labelStopValue_IAA
            // 
            this.labelStopValue_IAA.AutoSize = true;
            this.labelStopValue_IAA.Location = new System.Drawing.Point(129, 47);
            this.labelStopValue_IAA.Name = "labelStopValue_IAA";
            this.labelStopValue_IAA.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_IAA.TabIndex = 1;
            this.labelStopValue_IAA.Text = "Конец шага:";
            // 
            // buttonResult_IAA
            // 
            this.buttonResult_IAA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonResult_IAA.Location = new System.Drawing.Point(780, 44);
            this.buttonResult_IAA.Name = "buttonResult_IAA";
            this.buttonResult_IAA.Size = new System.Drawing.Size(107, 79);
            this.buttonResult_IAA.TabIndex = 1;
            this.buttonResult_IAA.Text = "Выполнить";
            this.buttonResult_IAA.UseVisualStyleBackColor = false;
            this.buttonResult_IAA.Click += new System.EventHandler(this.buttonResult_IAA_Click);
            // 
            // buttonSave_IAA
            // 
            this.buttonSave_IAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave_IAA.Location = new System.Drawing.Point(893, 44);
            this.buttonSave_IAA.Name = "buttonSave_IAA";
            this.buttonSave_IAA.Size = new System.Drawing.Size(107, 79);
            this.buttonSave_IAA.TabIndex = 1;
            this.buttonSave_IAA.Text = "Сохранить";
            this.buttonSave_IAA.UseVisualStyleBackColor = false;
            this.buttonSave_IAA.Click += new System.EventHandler(this.buttonSave_IAA_Click);
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInfo_IAA.Location = new System.Drawing.Point(1006, 44);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(107, 79);
            this.buttonInfo_IAA.TabIndex = 1;
            this.buttonInfo_IAA.Text = "Справка";
            this.buttonInfo_IAA.UseVisualStyleBackColor = false;
            this.buttonInfo_IAA.Click += new System.EventHandler(this.buttonInfo_IAA_Click);
            // 
            // panelTop_IAA
            // 
            this.panelTop_IAA.Controls.Add(this.groupBoxTask_IAA);
            this.panelTop_IAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_IAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_IAA.Name = "panelTop_IAA";
            this.panelTop_IAA.Size = new System.Drawing.Size(1125, 143);
            this.panelTop_IAA.TabIndex = 2;
            // 
            // panelLeft_IAA
            // 
            this.panelLeft_IAA.Controls.Add(this.splitterPanel_IAA);
            this.panelLeft_IAA.Controls.Add(this.chartOutput_IAA);
            this.panelLeft_IAA.Controls.Add(this.textBoxResult_IAA);
            this.panelLeft_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft_IAA.Location = new System.Drawing.Point(3, 18);
            this.panelLeft_IAA.Name = "panelLeft_IAA";
            this.panelLeft_IAA.Size = new System.Drawing.Size(1119, 337);
            this.panelLeft_IAA.TabIndex = 2;
            // 
            // groupBoxTask_IAA
            // 
            this.groupBoxTask_IAA.Controls.Add(this.pictureBoxTask_IAA);
            this.groupBoxTask_IAA.Controls.Add(this.textBox1);
            this.groupBoxTask_IAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_IAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_IAA.Name = "groupBoxTask_IAA";
            this.groupBoxTask_IAA.Size = new System.Drawing.Size(506, 143);
            this.groupBoxTask_IAA.TabIndex = 1;
            this.groupBoxTask_IAA.TabStop = false;
            this.groupBoxTask_IAA.Text = "Условие";
            // 
            // pictureBoxTask_IAA
            // 
            this.pictureBoxTask_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTask_IAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_IAA.Image")));
            this.pictureBoxTask_IAA.Location = new System.Drawing.Point(3, 60);
            this.pictureBoxTask_IAA.Name = "pictureBoxTask_IAA";
            this.pictureBoxTask_IAA.Size = new System.Drawing.Size(500, 80);
            this.pictureBoxTask_IAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTask_IAA.TabIndex = 1;
            this.pictureBoxTask_IAA.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(500, 42);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "\r\n\r\n";
            // 
            // textBoxResult_IAA
            // 
            this.textBoxResult_IAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxResult_IAA.Location = new System.Drawing.Point(0, 0);
            this.textBoxResult_IAA.Multiline = true;
            this.textBoxResult_IAA.Name = "textBoxResult_IAA";
            this.textBoxResult_IAA.Size = new System.Drawing.Size(184, 337);
            this.textBoxResult_IAA.TabIndex = 2;
            // 
            // chartOutput_IAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOutput_IAA.ChartAreas.Add(chartArea2);
            this.chartOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartOutput_IAA.Legends.Add(legend2);
            this.chartOutput_IAA.Location = new System.Drawing.Point(184, 0);
            this.chartOutput_IAA.Name = "chartOutput_IAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartOutput_IAA.Series.Add(series2);
            this.chartOutput_IAA.Size = new System.Drawing.Size(935, 337);
            this.chartOutput_IAA.TabIndex = 3;
            this.chartOutput_IAA.Text = "chart1";
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "Title1";
            title2.Text = "График функции";
            this.chartOutput_IAA.Titles.Add(title2);
            // 
            // splitterPanel_IAA
            // 
            this.splitterPanel_IAA.Location = new System.Drawing.Point(184, 0);
            this.splitterPanel_IAA.Name = "splitterPanel_IAA";
            this.splitterPanel_IAA.Size = new System.Drawing.Size(3, 337);
            this.splitterPanel_IAA.TabIndex = 4;
            this.splitterPanel_IAA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 501);
            this.Controls.Add(this.buttonInfo_IAA);
            this.Controls.Add(this.buttonSave_IAA);
            this.Controls.Add(this.buttonResult_IAA);
            this.Controls.Add(this.groupBoxOutput_IAA);
            this.Controls.Add(this.groupBoxInput_IAA);
            this.Controls.Add(this.panelTop_IAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxInput_IAA.ResumeLayout(false);
            this.groupBoxInput_IAA.PerformLayout();
            this.groupBoxOutput_IAA.ResumeLayout(false);
            this.panelTop_IAA.ResumeLayout(false);
            this.panelLeft_IAA.ResumeLayout(false);
            this.panelLeft_IAA.PerformLayout();
            this.groupBoxTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_IAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_IAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxInput_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_IAA;
        private System.Windows.Forms.Label labelStopValue_IAA;
        private System.Windows.Forms.Label labelVarStartValue_IAA;
        private System.Windows.Forms.TextBox textBoxStopValue_IAA;
        private System.Windows.Forms.TextBox textBoxStartValue_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
        private System.Windows.Forms.Button buttonSave_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Panel panelTop_IAA;
        private System.Windows.Forms.Panel panelLeft_IAA;
        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.PictureBox pictureBoxTask_IAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput_IAA;
        private System.Windows.Forms.TextBox textBoxResult_IAA;
        private System.Windows.Forms.Splitter splitterPanel_IAA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

