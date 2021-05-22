
using MySql.Data.MySqlClient;
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
    public partial class BackupForm : Form
    {
        CONNECT conn = new CONNECT();
        public BackupForm()
        {
            InitializeComponent();
        }

        private void backupbtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                string filename = txtfilename.Text;
                string file = "D:\\backups\\" + filename + ".sql";
                string constring = "datasource = localhost; port = 3306; username = root; password =; database = payrollmanagesys";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                            MessageBox.Show("Backup Completed....!");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
