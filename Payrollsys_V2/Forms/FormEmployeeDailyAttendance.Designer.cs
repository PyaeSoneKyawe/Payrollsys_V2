namespace Payrollsys_V2.Forms
{
    partial class FormEmployeeDailyAttendance
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
            this.txtempid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtout = new System.Windows.Forms.TextBox();
            this.txtworkinghour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtot = new System.Windows.Forms.TextBox();
            this.txtlate = new System.Windows.Forms.TextBox();
            this.dataGridViewempdaily = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewempdaily)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(81, 8);
            this.txtempid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(106, 26);
            this.txtempid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(81, 59);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(161, 26);
            this.txtname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.btnclear);
            this.panel3.Location = new System.Drawing.Point(17, 221);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 46);
            this.panel3.TabIndex = 22;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnupdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnupdate.Location = new System.Drawing.Point(168, 6);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(121, 33);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsave.Location = new System.Drawing.Point(9, 6);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(121, 33);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btndelete.Location = new System.Drawing.Point(314, 6);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(121, 33);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnclear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnclear.Location = new System.Drawing.Point(463, 6);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 33);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 8);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "OUT";
            // 
            // txtin
            // 
            this.txtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtin.Location = new System.Drawing.Point(81, 103);
            this.txtin.Margin = new System.Windows.Forms.Padding(1);
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(67, 26);
            this.txtin.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Working hours";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtout
            // 
            this.txtout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtout.Location = new System.Drawing.Point(218, 99);
            this.txtout.Margin = new System.Windows.Forms.Padding(1);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(67, 26);
            this.txtout.TabIndex = 6;
            // 
            // txtworkinghour
            // 
            this.txtworkinghour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtworkinghour.Location = new System.Drawing.Point(448, 99);
            this.txtworkinghour.Margin = new System.Windows.Forms.Padding(1);
            this.txtworkinghour.Name = "txtworkinghour";
            this.txtworkinghour.Size = new System.Drawing.Size(67, 26);
            this.txtworkinghour.TabIndex = 7;
            this.txtworkinghour.Enter += new System.EventHandler(this.txtworkinghour_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Late";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "OT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtot
            // 
            this.txtot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtot.Location = new System.Drawing.Point(81, 169);
            this.txtot.Margin = new System.Windows.Forms.Padding(1);
            this.txtot.Name = "txtot";
            this.txtot.Size = new System.Drawing.Size(67, 26);
            this.txtot.TabIndex = 8;
            // 
            // txtlate
            // 
            this.txtlate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlate.Location = new System.Drawing.Point(218, 169);
            this.txtlate.Margin = new System.Windows.Forms.Padding(1);
            this.txtlate.Name = "txtlate";
            this.txtlate.Size = new System.Drawing.Size(67, 26);
            this.txtlate.TabIndex = 9;
            // 
            // dataGridViewempdaily
            // 
            this.dataGridViewempdaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewempdaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewempdaily.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewempdaily.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewempdaily.Name = "dataGridViewempdaily";
            this.dataGridViewempdaily.RowHeadersWidth = 51;
            this.dataGridViewempdaily.RowTemplate.Height = 24;
            this.dataGridViewempdaily.Size = new System.Drawing.Size(595, 212);
            this.dataGridViewempdaily.TabIndex = 44;
            this.dataGridViewempdaily.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewempdaily_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtworkinghour);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtlate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtempid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtot);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtin);
            this.panel2.Controls.Add(this.txtout);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(17, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 209);
            this.panel2.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(253, 130);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnsearch.IconColor = System.Drawing.Color.Black;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.Location = new System.Drawing.Point(191, 11);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(27, 20);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "?";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewempdaily);
            this.panel1.Location = new System.Drawing.Point(17, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 212);
            this.panel1.TabIndex = 47;
            // 
            // FormEmployeeDailyAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(619, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployeeDailyAttendance";
            this.Text = "FormEmployeeDailyAttendance";
            this.Load += new System.EventHandler(this.FormEmployeeDailyAttendance_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewempdaily)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtout;
        private System.Windows.Forms.TextBox txtworkinghour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtot;
        private System.Windows.Forms.TextBox txtlate;
        private System.Windows.Forms.DataGridView dataGridViewempdaily;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnsearch;
        public System.Windows.Forms.TextBox txtempid;
        public System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}