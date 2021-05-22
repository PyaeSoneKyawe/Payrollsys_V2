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
    public partial class FormRegister : Form
    {
        //employee class create
        employee emp = new employee();
        public FormRegister()
        {
            InitializeComponent();
        }

        // For clear 
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtempid.Text = "";
            txtname.Text = "";
            txtphnumber.Text = "";
            txtdailypay.Text = "";
            txtotpay.Text = "";
            richTextBoxaddress.Text = "";

        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emp.getdelemp();

         }
        //For Save Button
        private void btnsave_Click(object sender, EventArgs e)
        {
            //@nm, @ph, @ad, @bp
            String nm = txtname.Text;
            String ph = txtphnumber.Text;
            String ad = richTextBoxaddress.Text;
            int bp;
            int otp;
            int state =1 ; 
            try
            {
                bp = Convert.ToInt32(txtdailypay.Text);
                otp = Convert.ToInt32(txtotpay.Text);

                if (nm.Trim().Equals("") || ph.Trim().Equals("") || ad.Trim().Equals("") || bp.Equals("") || otp.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = emp.insertClient(nm, ph, ad, bp, otp,state);

                    if (insertClient)
                    {
                        dataGridView1.DataSource = emp.getdelemp();
                        MessageBox.Show("New Employee Inserted Sucessfuly!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnclear.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("Error Employee Not Inserted!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // for update button
        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id;
            String nm = txtname.Text;
            String ph = txtphnumber.Text;
            String ad = richTextBoxaddress.Text;
            int bp;
            int otp;
            

            try
            {
                id = Convert.ToInt32(txtempid.Text);
                bp = Convert.ToInt32(txtdailypay.Text);
                otp = Convert.ToInt32(txtotpay.Text);
                int state = 2;

                if (nm.Trim().Equals("") || ph.Trim().Equals("") || ad.Trim().Equals("") || bp.Equals("") || otp.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = emp.editemp(id,nm,ph,ad,bp,otp,state);

                    if (insertClient)
                    {
                        dataGridView1.DataSource = emp.getdelemp();
                        MessageBox.Show("New Employee Updated Sucessfuly!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnclear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error Employee Not Updated!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // to take data from datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtphnumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBoxaddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdailypay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtotpay.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtphnumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBoxaddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdailypay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtotpay.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id;
            String nm = txtname.Text;
            String ph = txtphnumber.Text;
            String ad = richTextBoxaddress.Text;
            int bp;
            int otp;
            try
            {
                id = Convert.ToInt32(txtempid.Text);
                bp = Convert.ToInt32(txtdailypay.Text);
                otp = Convert.ToInt32(txtotpay.Text);
                int state = 3;
                if (nm.Trim().Equals("") || ph.Trim().Equals("") || ad.Trim().Equals("") || bp.Equals("") || otp.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = emp.editemp(id,nm,ph,ad,bp,otp,state);
                    if (insertClient)
                    {
                        dataGridView1.DataSource = emp.getdelemp();
                        MessageBox.Show("New Employee Delete Sucessfuly!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnclear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error Employee Not Deleted!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
