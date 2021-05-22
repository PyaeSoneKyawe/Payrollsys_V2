
namespace Payrollsys_V2.ReportForm
{
    partial class FormEmployeeDailyReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entdate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.searchbtn = new System.Windows.Forms.Button();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.empattreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empattreportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.empattreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Payrollsys_V2.ReportForm.ReportEmpdaily.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(849, 316);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Emp ID:";
            // 
            // entdate
            // 
            this.entdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entdate.CustomFormat = "dd/mm/yyyy";
            this.entdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.entdate.Location = new System.Drawing.Point(603, 18);
            this.entdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entdate.Name = "entdate";
            this.entdate.Size = new System.Drawing.Size(224, 26);
            this.entdate.TabIndex = 12;
            this.entdate.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // startdate
            // 
            this.startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.CustomFormat = "dd/mm/yyyy";
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startdate.Location = new System.Drawing.Point(307, 21);
            this.startdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(224, 26);
            this.startdate.TabIndex = 11;
            this.startdate.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(307, 74);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(225, 39);
            this.searchbtn.TabIndex = 10;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(90, 21);
            this.txtempid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(133, 26);
            this.txtempid.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.startdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtempid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.entdate);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 126);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 316);
            this.panel2.TabIndex = 17;
            // 
            // empattreportBindingSource
            // 
            this.empattreportBindingSource.DataSource = typeof(Payrollsys_V2.empattreport);
            // 
            // FormEmployeeDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormEmployeeDailyReport";
            this.Text = "FormEmployeeDailyReport";
            this.Load += new System.EventHandler(this.FormEmployeeDailyReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empattreportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource empattreportBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker entdate;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}