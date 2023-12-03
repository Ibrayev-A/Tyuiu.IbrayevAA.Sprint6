
namespace Tyuiu.IbrayevAA.Sprint6.Task2.V23
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
            this.groupBoxTask_IAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_IAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_IAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IAA = new System.Windows.Forms.TextBox();
            this.pictureBoxTask_IAA = new System.Windows.Forms.PictureBox();
            this.textBoxStartValue_IAA = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_IAA = new System.Windows.Forms.TextBox();
            this.labelStartValue_IAA = new System.Windows.Forms.Label();
            this.labelStopValue_IAA = new System.Windows.Forms.Label();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.buttonResult_IAA = new System.Windows.Forms.Button();
            this.dataGridViewOutput_IAA = new System.Windows.Forms.DataGridView();
            this.chartOutput_IAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_IAA.SuspendLayout();
            this.groupBoxInput_IAA.SuspendLayout();
            this.groupBoxOutput_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_IAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_IAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_IAA
            // 
            this.groupBoxTask_IAA.Controls.Add(this.pictureBoxTask_IAA);
            this.groupBoxTask_IAA.Controls.Add(this.textBoxTask_IAA);
            this.groupBoxTask_IAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_IAA.Name = "groupBoxTask_IAA";
            this.groupBoxTask_IAA.Size = new System.Drawing.Size(484, 281);
            this.groupBoxTask_IAA.TabIndex = 0;
            this.groupBoxTask_IAA.TabStop = false;
            this.groupBoxTask_IAA.Text = "Условие";
            // 
            // groupBoxInput_IAA
            // 
            this.groupBoxInput_IAA.Controls.Add(this.labelStopValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.labelStartValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.textBoxStopValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.textBoxStartValue_IAA);
            this.groupBoxInput_IAA.Location = new System.Drawing.Point(12, 299);
            this.groupBoxInput_IAA.Name = "groupBoxInput_IAA";
            this.groupBoxInput_IAA.Size = new System.Drawing.Size(259, 79);
            this.groupBoxInput_IAA.TabIndex = 0;
            this.groupBoxInput_IAA.TabStop = false;
            this.groupBoxInput_IAA.Text = "Ввод данных";
            // 
            // groupBoxOutput_IAA
            // 
            this.groupBoxOutput_IAA.Controls.Add(this.chartOutput_IAA);
            this.groupBoxOutput_IAA.Controls.Add(this.dataGridViewOutput_IAA);
            this.groupBoxOutput_IAA.Location = new System.Drawing.Point(502, 12);
            this.groupBoxOutput_IAA.Name = "groupBoxOutput_IAA";
            this.groupBoxOutput_IAA.Size = new System.Drawing.Size(657, 366);
            this.groupBoxOutput_IAA.TabIndex = 0;
            this.groupBoxOutput_IAA.TabStop = false;
            this.groupBoxOutput_IAA.Text = "Вывод данных";
            // 
            // textBoxTask_IAA
            // 
            this.textBoxTask_IAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_IAA.Multiline = true;
            this.textBoxTask_IAA.Name = "textBoxTask_IAA";
            this.textBoxTask_IAA.ReadOnly = true;
            this.textBoxTask_IAA.Size = new System.Drawing.Size(471, 50);
            this.textBoxTask_IAA.TabIndex = 0;
            this.textBoxTask_IAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "\r\n";
            // 
            // pictureBoxTask_IAA
            // 
            this.pictureBoxTask_IAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_IAA.Image")));
            this.pictureBoxTask_IAA.Location = new System.Drawing.Point(7, 78);
            this.pictureBoxTask_IAA.Name = "pictureBoxTask_IAA";
            this.pictureBoxTask_IAA.Size = new System.Drawing.Size(319, 99);
            this.pictureBoxTask_IAA.TabIndex = 1;
            this.pictureBoxTask_IAA.TabStop = false;
            // 
            // textBoxStartValue_IAA
            // 
            this.textBoxStartValue_IAA.Location = new System.Drawing.Point(7, 51);
            this.textBoxStartValue_IAA.Name = "textBoxStartValue_IAA";
            this.textBoxStartValue_IAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartValue_IAA.TabIndex = 0;
            this.textBoxStartValue_IAA.Text = "-5";
            // 
            // textBoxStopValue_IAA
            // 
            this.textBoxStopValue_IAA.Location = new System.Drawing.Point(129, 51);
            this.textBoxStopValue_IAA.Name = "textBoxStopValue_IAA";
            this.textBoxStopValue_IAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopValue_IAA.TabIndex = 0;
            this.textBoxStopValue_IAA.Tag = "";
            this.textBoxStopValue_IAA.Text = "5";
            // 
            // labelStartValue_IAA
            // 
            this.labelStartValue_IAA.AutoSize = true;
            this.labelStartValue_IAA.Location = new System.Drawing.Point(7, 28);
            this.labelStartValue_IAA.Name = "labelStartValue_IAA";
            this.labelStartValue_IAA.Size = new System.Drawing.Size(87, 17);
            this.labelStartValue_IAA.TabIndex = 1;
            this.labelStartValue_IAA.Text = "Старт шага:";
            // 
            // labelStopValue_IAA
            // 
            this.labelStopValue_IAA.AutoSize = true;
            this.labelStopValue_IAA.Location = new System.Drawing.Point(126, 28);
            this.labelStopValue_IAA.Name = "labelStopValue_IAA";
            this.labelStopValue_IAA.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_IAA.TabIndex = 1;
            this.labelStopValue_IAA.Text = "Конец шага:";
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_IAA.Location = new System.Drawing.Point(277, 305);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(105, 73);
            this.buttonInfo_IAA.TabIndex = 1;
            this.buttonInfo_IAA.Text = "Справка";
            this.buttonInfo_IAA.UseVisualStyleBackColor = false;
            this.buttonInfo_IAA.Click += new System.EventHandler(this.buttonInfo_IAA_Click);
            // 
            // buttonResult_IAA
            // 
            this.buttonResult_IAA.BackColor = System.Drawing.Color.Green;
            this.buttonResult_IAA.Location = new System.Drawing.Point(382, 305);
            this.buttonResult_IAA.Name = "buttonResult_IAA";
            this.buttonResult_IAA.Size = new System.Drawing.Size(108, 73);
            this.buttonResult_IAA.TabIndex = 1;
            this.buttonResult_IAA.Text = "Выполнить";
            this.buttonResult_IAA.UseVisualStyleBackColor = false;
            this.buttonResult_IAA.Click += new System.EventHandler(this.buttonResult_IAA_Click);
            this.buttonResult_IAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_IAA_MouseDown);
            this.buttonResult_IAA.MouseEnter += new System.EventHandler(this.buttonResult_IAA_MouseEnter);
            this.buttonResult_IAA.MouseLeave += new System.EventHandler(this.buttonResult_IAA_MouseLeave);
            // 
            // dataGridViewOutput_IAA
            // 
            this.dataGridViewOutput_IAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_IAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewOutput_IAA.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewOutput_IAA.Name = "dataGridViewOutput_IAA";
            this.dataGridViewOutput_IAA.RowHeadersVisible = false;
            this.dataGridViewOutput_IAA.RowTemplate.Height = 24;
            this.dataGridViewOutput_IAA.Size = new System.Drawing.Size(134, 342);
            this.dataGridViewOutput_IAA.TabIndex = 0;
            // 
            // chartOutput_IAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOutput_IAA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOutput_IAA.Legends.Add(legend2);
            this.chartOutput_IAA.Location = new System.Drawing.Point(147, 22);
            this.chartOutput_IAA.Name = "chartOutput_IAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartOutput_IAA.Series.Add(series2);
            this.chartOutput_IAA.Size = new System.Drawing.Size(504, 344);
            this.chartOutput_IAA.TabIndex = 1;
            this.chartOutput_IAA.Text = "chart1";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 400);
            this.Controls.Add(this.buttonResult_IAA);
            this.Controls.Add(this.buttonInfo_IAA);
            this.Controls.Add(this.groupBoxInput_IAA);
            this.Controls.Add(this.groupBoxOutput_IAA);
            this.Controls.Add(this.groupBoxTask_IAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Ибраев А. А.";
            this.groupBoxTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.PerformLayout();
            this.groupBoxInput_IAA.ResumeLayout(false);
            this.groupBoxInput_IAA.PerformLayout();
            this.groupBoxOutput_IAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_IAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_IAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_IAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.GroupBox groupBoxInput_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_IAA;
        private System.Windows.Forms.TextBox textBoxTask_IAA;
        private System.Windows.Forms.PictureBox pictureBoxTask_IAA;
        private System.Windows.Forms.Label labelStopValue_IAA;
        private System.Windows.Forms.Label labelStartValue_IAA;
        private System.Windows.Forms.TextBox textBoxStopValue_IAA;
        private System.Windows.Forms.TextBox textBoxStartValue_IAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput_IAA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

