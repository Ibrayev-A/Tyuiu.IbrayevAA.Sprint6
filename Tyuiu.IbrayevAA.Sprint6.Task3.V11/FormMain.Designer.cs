
namespace Tyuiu.IbrayevAA.Sprint6.Task3.V11
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
            this.textBoxTask_IAA = new System.Windows.Forms.TextBox();
            this.dataGridViewTask_IAA = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_IAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_IAA = new System.Windows.Forms.DataGridView();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.buttonResult_IAA = new System.Windows.Forms.Button();
            this.groupBoxTask_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_IAA)).BeginInit();
            this.groupBoxOutput_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_IAA
            // 
            this.groupBoxTask_IAA.Controls.Add(this.textBoxTask_IAA);
            this.groupBoxTask_IAA.Controls.Add(this.dataGridViewTask_IAA);
            this.groupBoxTask_IAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_IAA.Name = "groupBoxTask_IAA";
            this.groupBoxTask_IAA.Size = new System.Drawing.Size(530, 341);
            this.groupBoxTask_IAA.TabIndex = 0;
            this.groupBoxTask_IAA.TabStop = false;
            this.groupBoxTask_IAA.Text = "Условие";
            // 
            // textBoxTask_IAA
            // 
            this.textBoxTask_IAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_IAA.Multiline = true;
            this.textBoxTask_IAA.Name = "textBoxTask_IAA";
            this.textBoxTask_IAA.ReadOnly = true;
            this.textBoxTask_IAA.Size = new System.Drawing.Size(235, 253);
            this.textBoxTask_IAA.TabIndex = 1;
            this.textBoxTask_IAA.Text = resources.GetString("textBoxTask_IAA.Text");
            // 
            // dataGridViewTask_IAA
            // 
            this.dataGridViewTask_IAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask_IAA.ColumnHeadersVisible = false;
            this.dataGridViewTask_IAA.Location = new System.Drawing.Point(247, 21);
            this.dataGridViewTask_IAA.Name = "dataGridViewTask_IAA";
            this.dataGridViewTask_IAA.RowHeadersVisible = false;
            this.dataGridViewTask_IAA.RowHeadersWidth = 51;
            this.dataGridViewTask_IAA.RowTemplate.Height = 24;
            this.dataGridViewTask_IAA.Size = new System.Drawing.Size(277, 253);
            this.dataGridViewTask_IAA.TabIndex = 0;
            // 
            // groupBoxOutput_IAA
            // 
            this.groupBoxOutput_IAA.Controls.Add(this.dataGridViewResult_IAA);
            this.groupBoxOutput_IAA.Location = new System.Drawing.Point(548, 12);
            this.groupBoxOutput_IAA.Name = "groupBoxOutput_IAA";
            this.groupBoxOutput_IAA.Size = new System.Drawing.Size(291, 280);
            this.groupBoxOutput_IAA.TabIndex = 0;
            this.groupBoxOutput_IAA.TabStop = false;
            this.groupBoxOutput_IAA.Text = "Вывод данных";
            // 
            // dataGridViewResult_IAA
            // 
            this.dataGridViewResult_IAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_IAA.ColumnHeadersVisible = false;
            this.dataGridViewResult_IAA.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewResult_IAA.Name = "dataGridViewResult_IAA";
            this.dataGridViewResult_IAA.RowHeadersVisible = false;
            this.dataGridViewResult_IAA.RowHeadersWidth = 51;
            this.dataGridViewResult_IAA.RowTemplate.Height = 24;
            this.dataGridViewResult_IAA.Size = new System.Drawing.Size(280, 253);
            this.dataGridViewResult_IAA.TabIndex = 0;
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_IAA.Location = new System.Drawing.Point(610, 298);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(38, 37);
            this.buttonInfo_IAA.TabIndex = 1;
            this.buttonInfo_IAA.Text = "?";
            this.buttonInfo_IAA.UseVisualStyleBackColor = true;
            this.buttonInfo_IAA.Click += new System.EventHandler(this.buttonInfo_IAA_Click);
            // 
            // buttonResult_IAA
            // 
            this.buttonResult_IAA.Location = new System.Drawing.Point(709, 292);
            this.buttonResult_IAA.Name = "buttonResult_IAA";
            this.buttonResult_IAA.Size = new System.Drawing.Size(95, 49);
            this.buttonResult_IAA.TabIndex = 1;
            this.buttonResult_IAA.Text = "Выполнить";
            this.buttonResult_IAA.UseVisualStyleBackColor = true;
            this.buttonResult_IAA.Click += new System.EventHandler(this.buttonResult_IAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 365);
            this.Controls.Add(this.buttonResult_IAA);
            this.Controls.Add(this.buttonInfo_IAA);
            this.Controls.Add(this.groupBoxOutput_IAA);
            this.Controls.Add(this.groupBoxTask_IAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_IAA.ResumeLayout(false);
            this.groupBoxTask_IAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_IAA)).EndInit();
            this.groupBoxOutput_IAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_IAA;
        private System.Windows.Forms.TextBox textBoxTask_IAA;
        private System.Windows.Forms.DataGridView dataGridViewTask_IAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
    }
}

