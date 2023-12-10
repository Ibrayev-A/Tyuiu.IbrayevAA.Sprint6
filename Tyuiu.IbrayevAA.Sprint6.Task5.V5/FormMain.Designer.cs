
namespace Tyuiu.IbrayevAA.Sprint6.Task5.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_IAA = new System.Windows.Forms.Panel();
            this.panelRight_IAA = new System.Windows.Forms.Panel();
            this.panelFill_IAA = new System.Windows.Forms.Panel();
            this.splitterPanel_IAA = new System.Windows.Forms.Splitter();
            this.groupBoxTask_IAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputValue_IAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IAA = new System.Windows.Forms.TextBox();
            this.buttonResult_IAA = new System.Windows.Forms.Button();
            this.buttonOpen_IAA = new System.Windows.Forms.Button();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.dataGridViewOutput_IAA = new System.Windows.Forms.DataGridView();
            this.chartOutput_IAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_IAA.SuspendLayout();
            this.panelRight_IAA.SuspendLayout();
            this.panelFill_IAA.SuspendLayout();
            this.groupBoxTask_IAA.SuspendLayout();
            this.groupBoxOutputValue_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_IAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_IAA
            // 
            this.panelTop_IAA.Controls.Add(this.buttonInfo_IAA);
            this.panelTop_IAA.Controls.Add(this.buttonOpen_IAA);
            this.panelTop_IAA.Controls.Add(this.buttonResult_IAA);
            this.panelTop_IAA.Controls.Add(this.groupBoxTask_IAA);
            this.panelTop_IAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_IAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_IAA.Name = "panelTop_IAA";
            this.panelTop_IAA.Size = new System.Drawing.Size(814, 100);
            this.panelTop_IAA.TabIndex = 0;
            // 
            // panelRight_IAA
            // 
            this.panelRight_IAA.Controls.Add(this.groupBoxOutputValue_IAA);
            this.panelRight_IAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight_IAA.Location = new System.Drawing.Point(0, 100);
            this.panelRight_IAA.Name = "panelRight_IAA";
            this.panelRight_IAA.Size = new System.Drawing.Size(200, 350);
            this.panelRight_IAA.TabIndex = 0;
            // 
            // panelFill_IAA
            // 
            this.panelFill_IAA.Controls.Add(this.chartOutput_IAA);
            this.panelFill_IAA.Controls.Add(this.splitterPanel_IAA);
            this.panelFill_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_IAA.Location = new System.Drawing.Point(200, 100);
            this.panelFill_IAA.Name = "panelFill_IAA";
            this.panelFill_IAA.Size = new System.Drawing.Size(614, 350);
            this.panelFill_IAA.TabIndex = 0;
            // 
            // splitterPanel_IAA
            // 
            this.splitterPanel_IAA.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel_IAA.Name = "splitterPanel_IAA";
            this.splitterPanel_IAA.Size = new System.Drawing.Size(3, 350);
            this.splitterPanel_IAA.TabIndex = 0;
            this.splitterPanel_IAA.TabStop = false;
            // 
            // groupBoxTask_IAA
            // 
            this.groupBoxTask_IAA.Controls.Add(this.textBoxTask_IAA);
            this.groupBoxTask_IAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_IAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_IAA.Name = "groupBoxTask_IAA";
            this.groupBoxTask_IAA.Size = new System.Drawing.Size(466, 100);
            this.groupBoxTask_IAA.TabIndex = 0;
            this.groupBoxTask_IAA.TabStop = false;
            this.groupBoxTask_IAA.Text = "Условие";
            // 
            // groupBoxOutputValue_IAA
            // 
            this.groupBoxOutputValue_IAA.Controls.Add(this.dataGridViewOutput_IAA);
            this.groupBoxOutputValue_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputValue_IAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputValue_IAA.Name = "groupBoxOutputValue_IAA";
            this.groupBoxOutputValue_IAA.Size = new System.Drawing.Size(200, 350);
            this.groupBoxOutputValue_IAA.TabIndex = 0;
            this.groupBoxOutputValue_IAA.TabStop = false;
            this.groupBoxOutputValue_IAA.Text = "Вывод данных";
            // 
            // textBoxTask_IAA
            // 
            this.textBoxTask_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_IAA.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_IAA.Multiline = true;
            this.textBoxTask_IAA.Name = "textBoxTask_IAA";
            this.textBoxTask_IAA.ReadOnly = true;
            this.textBoxTask_IAA.Size = new System.Drawing.Size(460, 79);
            this.textBoxTask_IAA.TabIndex = 0;
            this.textBoxTask_IAA.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. Вывести в" +
    "се числа, кратные 2. Построить диаграмму по этим значениям.";
            // 
            // buttonResult_IAA
            // 
            this.buttonResult_IAA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonResult_IAA.Location = new System.Drawing.Point(472, 18);
            this.buttonResult_IAA.Name = "buttonResult_IAA";
            this.buttonResult_IAA.Size = new System.Drawing.Size(103, 65);
            this.buttonResult_IAA.TabIndex = 1;
            this.buttonResult_IAA.Text = "Выполнить";
            this.buttonResult_IAA.UseVisualStyleBackColor = false;
            this.buttonResult_IAA.Click += new System.EventHandler(this.buttonResult_IAA_Click);
            // 
            // buttonOpen_IAA
            // 
            this.buttonOpen_IAA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpen_IAA.Location = new System.Drawing.Point(581, 18);
            this.buttonOpen_IAA.Name = "buttonOpen_IAA";
            this.buttonOpen_IAA.Size = new System.Drawing.Size(103, 65);
            this.buttonOpen_IAA.TabIndex = 1;
            this.buttonOpen_IAA.Text = "Открыть файл";
            this.buttonOpen_IAA.UseVisualStyleBackColor = false;
            this.buttonOpen_IAA.Click += new System.EventHandler(this.buttonOpen_IAA_Click);
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInfo_IAA.Location = new System.Drawing.Point(690, 18);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(103, 65);
            this.buttonInfo_IAA.TabIndex = 1;
            this.buttonInfo_IAA.Text = "Справка";
            this.buttonInfo_IAA.UseVisualStyleBackColor = false;
            this.buttonInfo_IAA.Click += new System.EventHandler(this.buttonInfo_IAA_Click);
            // 
            // dataGridViewOutput_IAA
            // 
            this.dataGridViewOutput_IAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_IAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutput_IAA.Name = "dataGridViewOutput_IAA";
            this.dataGridViewOutput_IAA.RowHeadersWidth = 51;
            this.dataGridViewOutput_IAA.RowTemplate.Height = 24;
            this.dataGridViewOutput_IAA.Size = new System.Drawing.Size(194, 329);
            this.dataGridViewOutput_IAA.TabIndex = 0;
            // 
            // chartOutput_IAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOutput_IAA.ChartAreas.Add(chartArea2);
            this.chartOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartOutput_IAA.Legends.Add(legend2);
            this.chartOutput_IAA.Location = new System.Drawing.Point(3, 0);
            this.chartOutput_IAA.Name = "chartOutput_IAA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartOutput_IAA.Series.Add(series2);
            this.chartOutput_IAA.Size = new System.Drawing.Size(611, 350);
            this.chartOutput_IAA.TabIndex = 1;
            this.chartOutput_IAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.panelFill_IAA);
            this.Controls.Add(this.panelRight_IAA);
            this.Controls.Add(this.panelTop_IAA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTop_IAA.ResumeLayout(false);
            this.panelRight_IAA.ResumeLayout(false);
            this.panelFill_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.PerformLayout();
            this.groupBoxOutputValue_IAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_IAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_IAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_IAA;
        private System.Windows.Forms.Panel panelRight_IAA;
        private System.Windows.Forms.Panel panelFill_IAA;
        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutputValue_IAA;
        private System.Windows.Forms.Splitter splitterPanel_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Button buttonOpen_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
        private System.Windows.Forms.TextBox textBoxTask_IAA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_IAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput_IAA;
    }
}

