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
            txtID.Text = "";
            txtempid.Text = "";
            txtname.Text = "";
            txtphnumber.Text = "";
            txtSalary.Text = "";
            txtotpay.Text = "";
            richTextBoxaddress.Text = "";

        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emp.getEmployees();
            dataGridView1.ReadOnly = true;

        }
        //For Save Button
        private void btnsave_Click(object sender, EventArgs e)
        {
            //@nm, @ph, @ad, @bp
            string empId = txtempid.Text;
            string nm = txtname.Text;
            string ph = txtphnumber.Text;
            string ad = richTextBoxaddress.Text;
            int bp;
            int otp;
            int state =1 ; 
            try
            {
                bp = Convert.ToInt32(txtSalary.Text);
                otp = Convert.ToInt32(txtotpay.Text);

                if (nm.Trim().Equals("") || ph.Trim().Equals("") || ad.Trim().Equals("") || bp.Equals("") || otp.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = emp.insertClient(empId, nm, ph, ad, bp, otp,state);

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
            string empID = txtempid.Text;
            string nm = txtname.Text;
            string ph = txtphnumber.Text;
            string ad = richTextBoxaddress.Text;
            int bp;
            int otp;
            

            try
            {
                
               
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("Please Select Employee To Update!", "Select Employee!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nm.Trim().Equals("") || ph.Trim().Equals("") || ad.Trim().Equals("") || txtSalary.Text.Equals("") || txtotpay.Text.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bp = Convert.ToInt32(txtSalary.Text);
                    otp = Convert.ToInt32(txtotpay.Text);
                    int state = 2;
                    id = Convert.ToInt32(txtID.Text);

                    Boolean insertClient = emp.editemp(id, empID, nm,ph,ad,bp,otp,state);

                    if (insertClient)
                    {
                        dataGridView1.DataSource = emp.getEmployees();
                        MessageBox.Show("Employee Updated Sucessfully!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtempid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtphnumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            richTextBoxaddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSalary.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtotpay.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtempid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtphnumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            richTextBoxaddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSalary.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtotpay.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id;
            string empID = txtempid.Text;
            string nm = txtname.Text;
            string ph = txtphnumber.Text;
            string ad = richTextBoxaddress.Text;
            int bp;
            int otp;
            try
            {  
                int state = 3;
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("Please Select Employee To Delete!", "Select Employee!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nm.Trim().Equals("") || ph.Trim().Equals("") || ad.Trim().Equals("") || txtSalary.Text.Equals("") || txtotpay.Text.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    id = Convert.ToInt32(txtID.Text);
                    bp = Convert.ToInt32(txtSalary.Text);
                    otp = Convert.ToInt32(txtotpay.Text);
                     Boolean insertClient = emp.editemp(id,empID,nm,ph,ad,bp,otp,state);
                      if (insertClient)
                      {
                          dataGridView1.DataSource = emp.getEmployees();
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

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txtotpay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txtphnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
