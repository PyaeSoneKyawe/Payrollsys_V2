
namespace Payrollsys_V2.Forms
{
    partial class ImportForm
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
            this.openfilebtn = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openfilebtn
            // 
            this.openfilebtn.Location = new System.Drawing.Point(333, 70);
            this.openfilebtn.Name = "openfilebtn";
            this.openfilebtn.Size = new System.Drawing.Size(75, 23);
            this.openfilebtn.TabIndex = 0;
            this.openfilebtn.Text = "Open File";
            this.openfilebtn.UseVisualStyleBackColor = true;
            this.openfilebtn.Click += new System.EventHandler(this.openfilebtn_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(39, 70);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(288, 20);
            this.filename.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.openfilebtn);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfilebtn;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}