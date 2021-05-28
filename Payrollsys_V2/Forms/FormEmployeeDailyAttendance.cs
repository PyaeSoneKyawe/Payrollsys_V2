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
    public partial class FormEmployeeDailyAttendance : Form
    {

        employeeattendancedaily empatt = new employeeattendancedaily();


        public FormEmployeeDailyAttendance()
        {
            InitializeComponent();
        }

        private void FormEmployeeDailyAttendance_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empatt.getemp();
            dataGridViewempdaily.DataSource = empatt.getempatt();
            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker2.CustomFormat = "HH:mm";


        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dataGridView1.Visible = false;
            int id;
            id = Convert.ToInt32(txtempid.Text);
            dataGridViewempdaily.DataSource = empatt.filterempatt(id);
        }

        private void dataGridViewempdaily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridViewempdaily.CurrentRow.Cells[1].Value.ToString();
            txtname.Text = dataGridViewempdaily.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridViewempdaily.CurrentRow.Cells[3].Value.ToString();
            txtin.Text = dataGridViewempdaily.CurrentRow.Cells[4].Value.ToString();
            txtout.Text = dataGridViewempdaily.CurrentRow.Cells[5].Value.ToString();
            txtworkinghour.Text = dataGridViewempdaily.CurrentRow.Cells[6].Value.ToString();
            txtot.Text = dataGridViewempdaily.CurrentRow.Cells[7].Value.ToString();
            txtlate.Text = dataGridViewempdaily.CurrentRow.Cells[8].Value.ToString();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtin.Text = "";
            txtout.Text = "";
            txtworkinghour.Text = "";
            txtot.Text = "";
            txtlate.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }



        private void txtworkinghour_Enter(object sender, EventArgs e)
        {
            try
            {

                DateTime tin;
                DateTime tout;
                tin = DateTime.Parse(txtin.Text);
                tout = DateTime.Parse(txtout.Text);
                TimeSpan tm = (tout - tin);
                txtworkinghour.Text = tm.ToString();
                DateTime regulartime = DateTime.Parse("9:00:00");
                DateTime leavetime = DateTime.Parse("00:00:00");
                DateTime wh;
                wh = DateTime.Parse(txtworkinghour.Text);
                if (wh >= regulartime)
                {
                    TimeSpan othr = wh.Subtract(regulartime);
                    //DateTime othr = (wh-regulartime);
                    txtot.Text = othr.ToString();
                    txtlate.Text = "00:00:00";
                }
                else if (wh == leavetime)
                {
                    txtot.Text = "00:00:00";
                    txtlate.Text = "00:00:00";

                }
                else
                {
                    txtot.Text = "00:00:00";
                    TimeSpan late = wh.Subtract(regulartime);
                    string latetime = late.ToString();
                    txtlate.Text = latetime.Trim('-');
                }

            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //@eid,@nm, @dt,@tin,@tout, @wh, @oth
            int id;
            string nm = txtname.Text;
            DateTime late;
            DateTime dt = dateTimePicker1.Value;
            DateTime tin;
            DateTime tout;
            DateTime oth;
            DateTime wh;
            string val  = dateTimePicker2.Value.ToString("HH:mm");
            string[] value = val.Split(':');
            int state = 1;

            try
            {
                id = Convert.ToInt32(txtempid.Text);
                tin = DateTime.Parse(txtin.Text);
                tout = DateTime.Parse(txtout.Text);
                wh = DateTime.Parse(txtworkinghour.Text);
                oth = DateTime.Parse(txtot.Text);
                late = DateTime.Parse(txtlate.Text);

                if (tin.Equals("") || tout.Equals("") || oth.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (empatt.IfDataexits(id,dt))
                {
                    string usrid = txtempid.Text.ToString();
                    dataGridViewempdaily.DataSource = empatt.filterempatt(id);
                    MessageBox.Show("Employee ID " + usrid + " already exit","Check again!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Boolean insertClient = empatt.insertempatt(id, nm, dt, tin, tout, wh, oth, late, state);

                    if (insertClient)
                    {
                        dataGridViewempdaily.DataSource = empatt.filterempatt(id);
                        //dataGridViewempdaily.DataSource = empatt.filterempatt(id);
                        MessageBox.Show("New Employee ID Attendance Inserted Sucessfuly!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnclear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error Employee Attendance Not Inserted!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string s = dataGridViewempdaily.CurrentRow.Cells[0].Value.ToString();
            int id;
            string nm = txtname.Text;
            DateTime late;
            DateTime tin;
            DateTime tout;
            DateTime oth;
            DateTime wh;

            try
            {
                int eid = Convert.ToInt32(s);
                id = Convert.ToInt32(txtempid.Text);
                tin = DateTime.Parse(txtin.Text);
                tout = DateTime.Parse(txtout.Text);
                wh = DateTime.Parse(txtworkinghour.Text);
                oth = DateTime.Parse(txtot.Text);
                late = DateTime.Parse(txtlate.Text);
                DateTime dt = dateTimePicker1.Value;
                int state = 2;


                if (wh.Equals("") || oth.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = empatt.editempatt(eid,id, nm, dt, tin, tout, wh, oth, late,state);

                    if (insertClient)
                    {
                        dataGridViewempdaily.DataSource = empatt.filterempatt(id);
                        MessageBox.Show("New Employee Attendance Updated Sucessfuly!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnclear.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("Error Employee Attendance Not Updated!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string s = dataGridViewempdaily.CurrentRow.Cells[0].Value.ToString();
            int id;
            string nm = txtname.Text;
            DateTime late;
            DateTime tin;
            DateTime tout;
            DateTime oth;
            DateTime wh;
            int state = 3;

            try
            {

                int eid = Convert.ToInt32(s);
                id = Convert.ToInt32(txtempid.Text);
                tin = DateTime.Parse(txtin.Text);
                tout = DateTime.Parse(txtout.Text);
                wh = DateTime.Parse(txtworkinghour.Text);
                oth = DateTime.Parse(txtot.Text);
                late = DateTime.Parse(txtlate.Text);
                DateTime dt = dateTimePicker1.Value;



                if (id.Equals("") || dt.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = empatt.removeemp(eid,id, nm, dt, tin, tout, wh, oth, late, state);

                    if (insertClient)
                    {
                        dataGridViewempdaily.DataSource = empatt.filterempatt(id);
                        MessageBox.Show("Employee Attendance Deleted Sucessfuly!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnclear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error Employee Attendance Not Deleted!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}
