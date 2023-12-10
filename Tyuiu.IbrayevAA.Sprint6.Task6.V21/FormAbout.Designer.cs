
namespace Tyuiu.IbrayevAA.Sprint6.Task6.V21
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOk_IAA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxMe_IAA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_IAA
            // 
            resources.ApplyResources(this.buttonOk_IAA, "buttonOk_IAA");
            this.buttonOk_IAA.Name = "buttonOk_IAA";
            this.buttonOk_IAA.UseVisualStyleBackColor = true;
            this.buttonOk_IAA.Click += new System.EventHandler(this.buttonOk_IAA_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // pictureBoxMe_IAA
            // 
            resources.ApplyResources(this.pictureBoxMe_IAA, "pictureBoxMe_IAA");
            this.pictureBoxMe_IAA.Name = "pictureBoxMe_IAA";
            this.pictureBoxMe_IAA.TabStop = false;
            // 
            // FormAbout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxMe_IAA);
            this.Controls.Add(this.buttonOk_IAA);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_IAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_IAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBoxMe_IAA;
    }
}