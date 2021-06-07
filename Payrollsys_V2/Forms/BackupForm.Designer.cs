
namespace Payrollsys_V2.Forms
{
    partial class BackupForm
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
            this.backupbtn = new System.Windows.Forms.Button();
            this.Text1 = new System.Windows.Forms.Label();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backupbtn
            // 
            this.backupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.backupbtn.FlatAppearance.BorderSize = 0;
            this.backupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupbtn.ForeColor = System.Drawing.Color.White;
            this.backupbtn.Location = new System.Drawing.Point(189, 62);
            this.backupbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(86, 29);
            this.backupbtn.TabIndex = 5;
            this.backupbtn.Text = "BackUp";
            this.backupbtn.UseVisualStyleBackColor = false;
            this.backupbtn.Click += new System.EventHandler(this.backupbtn_Click);
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(5, 25);
            this.Text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(114, 13);
            this.Text1.TabIndex = 4;
            this.Text1.Text = "Backup File Name:";
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(123, 22);
            this.txtfilename.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(152, 20);
            this.txtfilename.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.backupbtn);
            this.panel1.Controls.Add(this.txtfilename);
            this.panel1.Controls.Add(this.Text1);
            this.panel1.Location = new System.Drawing.Point(79, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 148);
            this.panel1.TabIndex = 6;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 301);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BackupForm";
            this.Text = "BackupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backupbtn;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Panel panel1;
    }
}