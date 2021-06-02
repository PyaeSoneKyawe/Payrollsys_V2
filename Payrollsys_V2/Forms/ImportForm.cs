using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payrollsys_V2.Forms
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void openfilebtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                filename.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object Nothing = System.Reflection.Missing.Value;
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Sheets[1];
            worksheet.Name = "WorkSheet";
            // Write data
            worksheet.Cells[1, 1] = "ID";
            worksheet.Cells[1, 2] = "Empid";
            worksheet.Cells[1, 3] = "Name";
            worksheet.Cells[1, 4] = "Date";
            worksheet.Cells[1, 5] = "IN_Hr";
            worksheet.Cells[1, 6] = "OUT_Hr";
            worksheet.Cells[1, 7] = "DailyWork_Hr";
            worksheet.Cells[1, 8] = "OT_HR";
            worksheet.Cells[1, 9] = "Late_Hr";
            worksheet.Cells[1, 10] = "Status";

            // Save file as xlsx
            SaveFileDialog saveFileDialog = new SaveFileDialog();       
            worksheet.SaveAs(@"F:\File\aa.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
            workBook.Close(false, Type.Missing, Type.Missing);  

            //import file as csv
            string inputFile = @"F:\File\aa.xlsx";
            string outputFile = @"F:\File\DailyList_CSV.csv";
            Microsoft.Office.Interop.Excel.Application app2 = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app2.Workbooks.Open(inputFile);
            Microsoft.Office.Interop.Excel.Worksheet xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            wb.SaveAs(outputFile, Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV);
            wb.Close(false);
            app.Quit();

            MessageBox.Show("Downloaded template at F:\\File\\DailyList.csv", "Template", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
