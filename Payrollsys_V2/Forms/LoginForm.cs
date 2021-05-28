using MySql.Data.MySqlClient;
using Payrollsys_V2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payrollsys_V2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /*
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `user_list` WHERE `Name`= @usn AND `Password`= @pass";

            command.CommandText = query;
            command.Connection = conn.getConnetion();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // if the username and the password exists
            if (table.Rows.Count > 0)
            {
                // show the main form
                this.Hide();
                Form1 mform = new Form1();
                mform.Show();
            
            }
            else
            {
                if (textBoxUsername.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } */

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `user_list` WHERE `Name`= @usn AND `Password`= @pass";

            command.CommandText = query;
            command.Connection = conn.getConnetion();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUserName.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // if the username and the password exists
            if (table.Rows.Count > 0)
            {
                // show the main form
                this.Hide();
                Form1 mform = new Form1();
                mform.Show();

            }
            else
            {
                if (txtUserName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
               
            }
            else
            {
                txtPassword.PasswordChar = '•';
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }
    }
}
