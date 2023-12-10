
namespace Tyuiu.IbrayevAA.Sprint6.Task6.V21
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
            this.panelTop_IAA = new System.Windows.Forms.Panel();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.buttonResult_IAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_IAA = new System.Windows.Forms.Button();
            this.panelFill_IAA = new System.Windows.Forms.Panel();
            this.groupBoxOutput_IAA = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_IAA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_IAA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_IAA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_IAA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_IAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipHelp_IAA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_IAA.SuspendLayout();
            this.panelFill_IAA.SuspendLayout();
            this.groupBoxOutput_IAA.SuspendLayout();
            this.groupBoxInput_IAA.SuspendLayout();
            this.groupBoxTask_IAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_IAA
            // 
            this.panelTop_IAA.Controls.Add(this.buttonInfo_IAA);
            this.panelTop_IAA.Controls.Add(this.buttonResult_IAA);
            this.panelTop_IAA.Controls.Add(this.buttonOpenFile_IAA);
            this.panelTop_IAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_IAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_IAA.Name = "panelTop_IAA";
            this.panelTop_IAA.Size = new System.Drawing.Size(800, 94);
            this.panelTop_IAA.TabIndex = 0;
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInfo_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_IAA.Image")));
            this.buttonInfo_IAA.Location = new System.Drawing.Point(698, 0);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(102, 94);
            this.buttonInfo_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonInfo_IAA, "Сведение о программе");
            this.buttonInfo_IAA.UseVisualStyleBackColor = true;
            this.buttonInfo_IAA.Click += new System.EventHandler(this.buttonInfo_IAA_Click);
            // 
            // buttonResult_IAA
            // 
            this.buttonResult_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonResult_IAA.Image")));
            this.buttonResult_IAA.Location = new System.Drawing.Point(120, 12);
            this.buttonResult_IAA.Name = "buttonResult_IAA";
            this.buttonResult_IAA.Size = new System.Drawing.Size(102, 76);
            this.buttonResult_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonResult_IAA, "Программа выводит слова в которых встречается g в результирующую строку и выводит" +
        " ее в textBoxOut.\r\n");
            this.buttonResult_IAA.UseVisualStyleBackColor = true;
            this.buttonResult_IAA.Click += new System.EventHandler(this.buttonResult_IAA_Click);
            // 
            // buttonOpenFile_IAA
            // 
            this.buttonOpenFile_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_IAA.Image")));
            this.buttonOpenFile_IAA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_IAA.Name = "buttonOpenFile_IAA";
            this.buttonOpenFile_IAA.Size = new System.Drawing.Size(102, 76);
            this.buttonOpenFile_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonOpenFile_IAA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_IAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_IAA.Click += new System.EventHandler(this.buttonOpenFile_IAA_Click);
            // 
            // panelFill_IAA
            // 
            this.panelFill_IAA.Controls.Add(this.groupBoxOutput_IAA);
            this.panelFill_IAA.Controls.Add(this.groupBoxInput_IAA);
            this.panelFill_IAA.Controls.Add(this.groupBoxTask_IAA);
            this.panelFill_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_IAA.Location = new System.Drawing.Point(0, 94);
            this.panelFill_IAA.Name = "panelFill_IAA";
            this.panelFill_IAA.Size = new System.Drawing.Size(800, 356);
            this.panelFill_IAA.TabIndex = 0;
            // 
            // groupBoxOutput_IAA
            // 
            this.groupBoxOutput_IAA.Controls.Add(this.textBoxOutput_IAA);
            this.groupBoxOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_IAA.Location = new System.Drawing.Point(395, 100);
            this.groupBoxOutput_IAA.Name = "groupBoxOutput_IAA";
            this.groupBoxOutput_IAA.Size = new System.Drawing.Size(405, 256);
            this.groupBoxOutput_IAA.TabIndex = 0;
            this.groupBoxOutput_IAA.TabStop = false;
            this.groupBoxOutput_IAA.Text = "Вывод";
            // 
            // textBoxOutput_IAA
            // 
            this.textBoxOutput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_IAA.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutput_IAA.Multiline = true;
            this.textBoxOutput_IAA.Name = "textBoxOutput_IAA";
            this.textBoxOutput_IAA.Size = new System.Drawing.Size(399, 235);
            this.textBoxOutput_IAA.TabIndex = 0;
            // 
            // groupBoxInput_IAA
            // 
            this.groupBoxInput_IAA.Controls.Add(this.textBoxInput_IAA);
            this.groupBoxInput_IAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInput_IAA.Location = new System.Drawing.Point(0, 100);
            this.groupBoxInput_IAA.Name = "groupBoxInput_IAA";
            this.groupBoxInput_IAA.Size = new System.Drawing.Size(395, 256);
            this.groupBoxInput_IAA.TabIndex = 0;
            this.groupBoxInput_IAA.TabStop = false;
            this.groupBoxInput_IAA.Text = "Ввод";
            // 
            // textBoxInput_IAA
            // 
            this.textBoxInput_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_IAA.Location = new System.Drawing.Point(3, 18);
            this.textBoxInput_IAA.Multiline = true;
            this.textBoxInput_IAA.Name = "textBoxInput_IAA";
            this.textBoxInput_IAA.Size = new System.Drawing.Size(389, 235);
            this.textBoxInput_IAA.TabIndex = 0;
            // 
            // groupBoxTask_IAA
            // 
            this.groupBoxTask_IAA.Controls.Add(this.textBox1);
            this.groupBoxTask_IAA.Dock = System.Windows.Forms.DockStyle.Top;
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
            // openFileDialogTask_IAA
            // 
            this.openFileDialogTask_IAA.FileName = "openFileDialog1";
            // 
            // toolTipHelp_IAA
            // 
            this.toolTipHelp_IAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp_IAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFill_IAA);
            this.Controls.Add(this.panelTop_IAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTop_IAA.ResumeLayout(false);
            this.panelFill_IAA.ResumeLayout(false);
            this.groupBoxOutput_IAA.ResumeLayout(false);
            this.groupBoxOutput_IAA.PerformLayout();
            this.groupBoxInput_IAA.ResumeLayout(false);
            this.groupBoxInput_IAA.PerformLayout();
            this.groupBoxTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_IAA;
        private System.Windows.Forms.Panel panelFill_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_IAA;
        private System.Windows.Forms.GroupBox groupBoxInput_IAA;
        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOpenFile_IAA;
        private System.Windows.Forms.TextBox textBoxOutput_IAA;
        private System.Windows.Forms.TextBox textBoxInput_IAA;
        private System.Windows.Forms.ToolTip toolTipHelp_IAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_IAA;
    }
}

