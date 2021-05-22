using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
