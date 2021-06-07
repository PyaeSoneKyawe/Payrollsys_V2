
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
            this.importbtn = new System.Windows.Forms.Button();
            this.csvfilebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openfilebtn
            // 
            this.openfilebtn.Location = new System.Drawing.Point(444, 86);
            this.openfilebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openfilebtn.Name = "openfilebtn";
            this.openfilebtn.Size = new System.Drawing.Size(100, 28);
            this.openfilebtn.TabIndex = 0;
            this.openfilebtn.Text = "Open File";
            this.openfilebtn.UseVisualStyleBackColor = true;
            this.openfilebtn.Click += new System.EventHandler(this.openfilebtn_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(52, 86);
            this.filename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(383, 22);
            this.filename.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // importbtn
            // 
            this.importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.importbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importbtn.Location = new System.Drawing.Point(173, 160);
            this.importbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(164, 55);
            this.importbtn.TabIndex = 2;
            this.importbtn.Text = "Import";
            this.importbtn.UseVisualStyleBackColor = false;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // csvfilebtn
            // 
            this.csvfilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.csvfilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvfilebtn.Location = new System.Drawing.Point(597, 75);
            this.csvfilebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.csvfilebtn.Name = "csvfilebtn";
            this.csvfilebtn.Size = new System.Drawing.Size(224, 53);
            this.csvfilebtn.TabIndex = 3;
            this.csvfilebtn.Text = "CSV file download";
            this.csvfilebtn.UseVisualStyleBackColor = false;
            this.csvfilebtn.Click += new System.EventHandler(this.csvfilebtn_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.csvfilebtn);
            this.Controls.Add(this.importbtn);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.openfilebtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfilebtn;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button importbtn;
        private System.Windows.Forms.Button csvfilebtn;
    }
}