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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string User = txtUserName.Text;
            string Pass = txtPassword.Text;
            string ConPass = txtConPassword.Text;

            try
            {
                if (User.Equals("") && Pass.Equals(""))
                {
                    MessageBox.Show("Plese Enter User Name And Password", "SignUp Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (User.Equals(""))
                {
                    MessageBox.Show("Plese Enter User Name", "SignUp Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Pass.Equals(""))
                {
                    MessageBox.Show("Plese Enter Password", "SignUp Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(Pass != ConPass)
                {
                    MessageBox.Show("Password Do Not Match", "SignUp Fail", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    CONNECT con = new CONNECT();
                    MySqlCommand command = new MySqlCommand();
                    string query = "insert into user_List(Name,Password) values(@user,@pass)";
                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = User;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Pass;
                    command.CommandText = query;
                    command.Connection = con.getConnetion();
                    con.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User created", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtConPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error user not created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                MessageBox.Show("User Already Exsit", "User not Created", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
