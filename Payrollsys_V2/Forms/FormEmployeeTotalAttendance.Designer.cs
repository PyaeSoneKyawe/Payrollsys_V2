namespace Payrollsys_V2.Forms
{
    partial class FormEmployeeTotalAttendance
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemployid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtactualhours = new System.Windows.Forms.TextBox();
            this.txtlate = new System.Windows.Forms.TextBox();
            this.txttotot = new System.Windows.Forms.TextBox();
            this.txttothours = new System.Windows.Forms.TextBox();
            this.txtactualdays = new System.Windows.Forms.TextBox();
            this.txtleave = new System.Windows.Forms.TextBox();
            this.txttotdays = new System.Windows.Forms.TextBox();
            this.dataGridViewempatttotal = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewempatttotal)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Actual Days :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 62;
            this.label10.Text = "Actual  Hours :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "Total late :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Total Leave :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Total OT Hours :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Total Hours :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Total Days :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.enddate);
            this.panel1.Controls.Add(this.startdate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtemployid);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 104);
            this.panel1.TabIndex = 66;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(275, 97);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnsearch.IconColor = System.Drawing.Color.Black;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.Location = new System.Drawing.Point(174, 9);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(27, 20);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "?";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // enddate
            // 
            this.enddate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.CustomFormat = "dd/mm/yyyy";
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enddate.Location = new System.Drawing.Point(389, 73);
            this.enddate.Margin = new System.Windows.Forms.Padding(1);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(102, 20);
            this.enddate.TabIndex = 4;
            this.enddate.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // startdate
            // 
            this.startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.CustomFormat = "dd/mm/yyyy";
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startdate.Location = new System.Drawing.Point(105, 71);
            this.startdate.Margin = new System.Windows.Forms.Padding(1);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(102, 20);
            this.startdate.TabIndex = 3;
            this.startdate.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "To Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "From  Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Name :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(105, 42);
            this.txtname.Margin = new System.Windows.Forms.Padding(1);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(93, 24);
            this.txtname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID :";
            // 
            // txtemployid
            // 
            this.txtemployid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployid.Location = new System.Drawing.Point(105, 10);
            this.txtemployid.Margin = new System.Windows.Forms.Padding(1);
            this.txtemployid.Name = "txtemployid";
            this.txtemployid.ReadOnly = true;
            this.txtemployid.Size = new System.Drawing.Size(51, 24);
            this.txtemployid.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.txtactualhours);
            this.panel2.Controls.Add(this.txtlate);
            this.panel2.Controls.Add(this.txttotot);
            this.panel2.Controls.Add(this.txttothours);
            this.panel2.Controls.Add(this.txtactualdays);
            this.panel2.Controls.Add(this.txtleave);
            this.panel2.Controls.Add(this.txttotdays);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 144);
            this.panel2.TabIndex = 67;
            // 
            // txtactualhours
            // 
            this.txtactualhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactualhours.Location = new System.Drawing.Point(429, 111);
            this.txtactualhours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtactualhours.Name = "txtactualhours";
            this.txtactualhours.Size = new System.Drawing.Size(75, 24);
            this.txtactualhours.TabIndex = 11;
            this.txtactualhours.Enter += new System.EventHandler(this.txtactualhours_Enter);
            // 
            // txtlate
            // 
            this.txtlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlate.Location = new System.Drawing.Point(429, 12);
            this.txtlate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtlate.Name = "txtlate";
            this.txtlate.Size = new System.Drawing.Size(75, 24);
            this.txtlate.TabIndex = 8;
            this.txtlate.Enter += new System.EventHandler(this.txtlate_Enter);
            // 
            // txttotot
            // 
            this.txttotot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotot.Location = new System.Drawing.Point(429, 77);
            this.txttotot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttotot.Name = "txttotot";
            this.txttotot.Size = new System.Drawing.Size(75, 24);
            this.txttotot.TabIndex = 10;
            this.txttotot.Enter += new System.EventHandler(this.txttotot_Enter);
            // 
            // txttothours
            // 
            this.txttothours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttothours.Location = new System.Drawing.Point(429, 44);
            this.txttothours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttothours.Name = "txttothours";
            this.txttothours.Size = new System.Drawing.Size(75, 24);
            this.txttothours.TabIndex = 9;
            this.txttothours.Enter += new System.EventHandler(this.txttothours_Enter);
            // 
            // txtactualdays
            // 
            this.txtactualdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactualdays.Location = new System.Drawing.Point(105, 86);
            this.txtactualdays.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtactualdays.Name = "txtactualdays";
            this.txtactualdays.Size = new System.Drawing.Size(77, 24);
            this.txtactualdays.TabIndex = 7;
            this.txtactualdays.Enter += new System.EventHandler(this.txtactualdays_Enter);
            // 
            // txtleave
            // 
            this.txtleave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleave.Location = new System.Drawing.Point(105, 49);
            this.txtleave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtleave.Name = "txtleave";
            this.txtleave.Size = new System.Drawing.Size(75, 24);
            this.txtleave.TabIndex = 6;
            this.txtleave.Enter += new System.EventHandler(this.txtleave_Enter);
            // 
            // txttotdays
            // 
            this.txttotdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotdays.Location = new System.Drawing.Point(105, 11);
            this.txttotdays.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttotdays.Name = "txttotdays";
            this.txttotdays.Size = new System.Drawing.Size(75, 24);
            this.txttotdays.TabIndex = 5;
            this.txttotdays.Enter += new System.EventHandler(this.txttotdays_Enter);
            // 
            // dataGridViewempatttotal
            // 
            this.dataGridViewempatttotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewempatttotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewempatttotal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewempatttotal.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewempatttotal.Name = "dataGridViewempatttotal";
            this.dataGridViewempatttotal.RowHeadersWidth = 62;
            this.dataGridViewempatttotal.RowTemplate.Height = 28;
            this.dataGridViewempatttotal.Size = new System.Drawing.Size(612, 179);
            this.dataGridViewempatttotal.TabIndex = 68;
            this.dataGridViewempatttotal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewempatttotal_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.btnclear);
            this.panel3.Location = new System.Drawing.Point(3, 253);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 46);
            this.panel3.TabIndex = 64;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnupdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnupdate.Location = new System.Drawing.Point(177, 6);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(121, 33);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsave.Location = new System.Drawing.Point(18, 6);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(121, 33);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btndelete.Location = new System.Drawing.Point(323, 6);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(121, 33);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnclear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnclear.Location = new System.Drawing.Point(472, 6);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 33);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dataGridViewempatttotal);
            this.panel4.Location = new System.Drawing.Point(3, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(612, 179);
            this.panel4.TabIndex = 68;
            // 
            // FormEmployeeTotalAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(619, 487);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployeeTotalAttendance";
            this.Text = "FormEmployeeTotalAttendance";
            this.Load += new System.EventHandler(this.FormEmployeeTotalAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewempatttotal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnsearch;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemployid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewempatttotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtactualhours;
        private System.Windows.Forms.TextBox txtlate;
        private System.Windows.Forms.TextBox txttotot;
        private System.Windows.Forms.TextBox txttothours;
        private System.Windows.Forms.TextBox txtactualdays;
        private System.Windows.Forms.TextBox txtleave;
        private System.Windows.Forms.TextBox txttotdays;
        private System.Windows.Forms.Panel panel4;
    }
}