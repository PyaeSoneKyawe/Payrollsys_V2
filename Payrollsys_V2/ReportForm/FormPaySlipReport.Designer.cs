
namespace Payrollsys_V2.ReportForm
{
    partial class FormPaySlipReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.payslipreportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.entdate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.payslipreportsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // payslipreportsBindingSource
            // 
            this.payslipreportsBindingSource.DataSource = typeof(Payrollsys_V2.payslipreports);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.startdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtempid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.entdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 134);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 106);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(141, 14);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(33, 23);
            this.btnsearch.TabIndex = 47;
            this.btnsearch.Text = "?";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // startdate
            // 
            this.startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.CustomFormat = "dd/mm/yyyy";
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startdate.Location = new System.Drawing.Point(226, 17);
            this.startdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(151, 20);
            this.startdate.TabIndex = 11;
            this.startdate.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "To:";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(11, 61);
            this.txtempid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(110, 20);
            this.txtempid.TabIndex = 9;
            this.txtempid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "From:";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(227, 76);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(150, 25);
            this.searchbtn.TabIndex = 10;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // entdate
            // 
            this.entdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entdate.CustomFormat = "dd/mm/yyyy";
            this.entdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.entdate.Location = new System.Drawing.Point(423, 15);
            this.entdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.entdate.Name = "entdate";
            this.entdate.Size = new System.Drawing.Size(151, 20);
            this.entdate.TabIndex = 12;
            this.entdate.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 285);
            this.panel2.TabIndex = 19;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.payslipreportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Payrollsys_V2.ReportForm.ReportPayslip.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(855, 285);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(11, 16);
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Size = new System.Drawing.Size(110, 20);
            this.EmpName.TabIndex = 48;
            // 
            // FormPaySlipReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPaySlipReport";
            this.Text = "FormPaySlipReport";
            this.Load += new System.EventHandler(this.FormPaySlipReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payslipreportsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DateTimePicker entdate;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource payslipreportsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox EmpName;
    }
}