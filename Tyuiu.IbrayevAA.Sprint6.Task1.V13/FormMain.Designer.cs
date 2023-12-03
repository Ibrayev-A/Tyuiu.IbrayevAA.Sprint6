
namespace Tyuiu.IbrayevAA.Sprint6.Task1.V13
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
            this.groupBoxTask_IAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_IAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_IAA = new System.Windows.Forms.GroupBox();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.buttonResult_IAA = new System.Windows.Forms.Button();
            this.textBoxStopValue_IAA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_IAA = new System.Windows.Forms.TextBox();
            this.labelStartValue_IAA = new System.Windows.Forms.Label();
            this.labelStopValue_IAA = new System.Windows.Forms.Label();
            this.textBoxTask_IAA = new System.Windows.Forms.TextBox();
            this.pictureBoxTask_IAA = new System.Windows.Forms.PictureBox();
            this.textBoxOutput_IAA = new System.Windows.Forms.TextBox();
            this.labelOutput_IAA = new System.Windows.Forms.Label();
            this.groupBoxTask_IAA.SuspendLayout();
            this.groupBoxOutput_IAA.SuspendLayout();
            this.groupBoxInput_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_IAA
            // 
            this.groupBoxTask_IAA.Controls.Add(this.pictureBoxTask_IAA);
            this.groupBoxTask_IAA.Controls.Add(this.textBoxTask_IAA);
            this.groupBoxTask_IAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_IAA.Name = "groupBoxTask_IAA";
            this.groupBoxTask_IAA.Size = new System.Drawing.Size(530, 326);
            this.groupBoxTask_IAA.TabIndex = 0;
            this.groupBoxTask_IAA.TabStop = false;
            this.groupBoxTask_IAA.Text = "Условие";
            // 
            // groupBoxOutput_IAA
            // 
            this.groupBoxOutput_IAA.Controls.Add(this.labelOutput_IAA);
            this.groupBoxOutput_IAA.Controls.Add(this.textBoxOutput_IAA);
            this.groupBoxOutput_IAA.Location = new System.Drawing.Point(560, 12);
            this.groupBoxOutput_IAA.Name = "groupBoxOutput_IAA";
            this.groupBoxOutput_IAA.Size = new System.Drawing.Size(228, 415);
            this.groupBoxOutput_IAA.TabIndex = 1;
            this.groupBoxOutput_IAA.TabStop = false;
            this.groupBoxOutput_IAA.Text = "Вывод данных";
            // 
            // groupBoxInput_IAA
            // 
            this.groupBoxInput_IAA.Controls.Add(this.labelStopValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.labelStartValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.textBoxStartValue_IAA);
            this.groupBoxInput_IAA.Controls.Add(this.textBoxStopValue_IAA);
            this.groupBoxInput_IAA.Location = new System.Drawing.Point(12, 344);
            this.groupBoxInput_IAA.Name = "groupBoxInput_IAA";
            this.groupBoxInput_IAA.Size = new System.Drawing.Size(298, 83);
            this.groupBoxInput_IAA.TabIndex = 1;
            this.groupBoxInput_IAA.TabStop = false;
            this.groupBoxInput_IAA.Text = "Ввод данных";
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_IAA.Location = new System.Drawing.Point(330, 362);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(95, 48);
            this.buttonInfo_IAA.TabIndex = 2;
            this.buttonInfo_IAA.Text = "Справка";
            this.buttonInfo_IAA.UseVisualStyleBackColor = false;
            this.buttonInfo_IAA.Click += new System.EventHandler(this.buttonInfo_IAA_Click);
            // 
            // buttonResult_IAA
            // 
            this.buttonResult_IAA.BackColor = System.Drawing.Color.Green;
            this.buttonResult_IAA.Location = new System.Drawing.Point(431, 362);
            this.buttonResult_IAA.Name = "buttonResult_IAA";
            this.buttonResult_IAA.Size = new System.Drawing.Size(111, 48);
            this.buttonResult_IAA.TabIndex = 2;
            this.buttonResult_IAA.Text = "Выполнить";
            this.buttonResult_IAA.UseVisualStyleBackColor = false;
            this.buttonResult_IAA.Click += new System.EventHandler(this.buttonResult_IAA_Click);
            // 
            // textBoxStopValue_IAA
            // 
            this.textBoxStopValue_IAA.Location = new System.Drawing.Point(149, 44);
            this.textBoxStopValue_IAA.Name = "textBoxStopValue_IAA";
            this.textBoxStopValue_IAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopValue_IAA.TabIndex = 0;
            this.textBoxStopValue_IAA.Text = "5";
            // 
            // textBoxStartValue_IAA
            // 
            this.textBoxStartValue_IAA.Location = new System.Drawing.Point(19, 44);
            this.textBoxStartValue_IAA.Name = "textBoxStartValue_IAA";
            this.textBoxStartValue_IAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartValue_IAA.TabIndex = 0;
            this.textBoxStartValue_IAA.Text = "-5";
            // 
            // labelStartValue_IAA
            // 
            this.labelStartValue_IAA.AutoSize = true;
            this.labelStartValue_IAA.Location = new System.Drawing.Point(16, 24);
            this.labelStartValue_IAA.Name = "labelStartValue_IAA";
            this.labelStartValue_IAA.Size = new System.Drawing.Size(87, 17);
            this.labelStartValue_IAA.TabIndex = 1;
            this.labelStartValue_IAA.Text = "Старт шага:";
            // 
            // labelStopValue_IAA
            // 
            this.labelStopValue_IAA.AutoSize = true;
            this.labelStopValue_IAA.Location = new System.Drawing.Point(146, 24);
            this.labelStopValue_IAA.Name = "labelStopValue_IAA";
            this.labelStopValue_IAA.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_IAA.TabIndex = 1;
            this.labelStopValue_IAA.Text = "Конец шага:";
            // 
            // textBoxTask_IAA
            // 
            this.textBoxTask_IAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_IAA.Multiline = true;
            this.textBoxTask_IAA.Name = "textBoxTask_IAA";
            this.textBoxTask_IAA.ReadOnly = true;
            this.textBoxTask_IAA.Size = new System.Drawing.Size(517, 60);
            this.textBoxTask_IAA.TabIndex = 0;
            this.textBoxTask_IAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "";
            // 
            // pictureBoxTask_IAA
            // 
            this.pictureBoxTask_IAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_IAA.Image")));
            this.pictureBoxTask_IAA.Location = new System.Drawing.Point(7, 88);
            this.pictureBoxTask_IAA.Name = "pictureBoxTask_IAA";
            this.pictureBoxTask_IAA.Size = new System.Drawing.Size(469, 102);
            this.pictureBoxTask_IAA.TabIndex = 1;
            this.pictureBoxTask_IAA.TabStop = false;
            // 
            // textBoxOutput_IAA
            // 
            this.textBoxOutput_IAA.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput_IAA.Location = new System.Drawing.Point(7, 49);
            this.textBoxOutput_IAA.Multiline = true;
            this.textBoxOutput_IAA.Name = "textBoxOutput_IAA";
            this.textBoxOutput_IAA.ReadOnly = true;
            this.textBoxOutput_IAA.Size = new System.Drawing.Size(215, 360);
            this.textBoxOutput_IAA.TabIndex = 0;
            // 
            // labelOutput_IAA
            // 
            this.labelOutput_IAA.AutoSize = true;
            this.labelOutput_IAA.Location = new System.Drawing.Point(7, 22);
            this.labelOutput_IAA.Name = "labelOutput_IAA";
            this.labelOutput_IAA.Size = new System.Drawing.Size(80, 17);
            this.labelOutput_IAA.TabIndex = 1;
            this.labelOutput_IAA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResult_IAA);
            this.Controls.Add(this.buttonInfo_IAA);
            this.Controls.Add(this.groupBoxInput_IAA);
            this.Controls.Add(this.groupBoxOutput_IAA);
            this.Controls.Add(this.groupBoxTask_IAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.PerformLayout();
            this.groupBoxOutput_IAA.ResumeLayout(false);
            this.groupBoxOutput_IAA.PerformLayout();
            this.groupBoxInput_IAA.ResumeLayout(false);
            this.groupBoxInput_IAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_IAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_IAA;
        private System.Windows.Forms.GroupBox groupBoxInput_IAA;
        private System.Windows.Forms.Label labelStopValue_IAA;
        private System.Windows.Forms.Label labelStartValue_IAA;
        private System.Windows.Forms.TextBox textBoxStartValue_IAA;
        private System.Windows.Forms.TextBox textBoxStopValue_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
        private System.Windows.Forms.PictureBox pictureBoxTask_IAA;
        private System.Windows.Forms.TextBox textBoxTask_IAA;
        private System.Windows.Forms.Label labelOutput_IAA;
        private System.Windows.Forms.TextBox textBoxOutput_IAA;
    }
}

