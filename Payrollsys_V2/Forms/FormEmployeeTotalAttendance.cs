
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
    public partial class FormEmployeeTotalAttendance : Form
    {
        CONNECT conn = new CONNECT();
        employeeattendancetotal emptot = new employeeattendancetotal();
        public FormEmployeeTotalAttendance()
        {
            InitializeComponent();
        }

        private void FormEmployeeTotalAttendance_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emptot.getemp();
            dataGridViewempatttotal.DataSource = emptot.getEmployeeAttemdamceTotal();
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtemployid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dataGridView1.Visible = false;
            int id;
            id = Convert.ToInt32(txtemployid.Text);
            dataGridViewempatttotal.DataSource = emptot.filterempatt(id);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttotdays.Text = "";
            txttothours.Text = "";
            txttotot.Text = "";
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
            txtleave.Text = "";
            txtactualhours.Text = "";
            txtlate.Text = "";
            txtactualdays.Text = "";

        }
        private void txttotdays_Enter(object sender, EventArgs e)
        {
            /*
            try
            {
                //for total day
                int id = Convert.ToInt32(txtemployid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = enddate.Value;

                DataTable table = emptot.GetTotalDays(id,stdate,endate);
                if (table.Rows.Count > 0)
                {
                    txttotdays.Text = table.Rows[0]["Total"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void txtleave_Enter(object sender, EventArgs e)
        {
            // for total leave day
            /*
            try
            {
                int id = Convert.ToInt32(txtemployid.Text);
                DateTime leavetime = DateTime.Parse("00:00:00");
                DateTime stdate = startdate.Value;
                DateTime endate = enddate.Value;
                DataTable table = emptot.GetTotalLeaveDays(id,leavetime,stdate,endate);
                if (table.Rows.Count > 0)
                {
                    txtleave.Text = table.Rows[0]["Total"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }

        private void txtactualdays_Enter(object sender, EventArgs e)
        {
            // for actual working days
            /*
            try
            {
                int workingday = Convert.ToInt32(txttotdays.Text);
                int leave = Convert.ToInt32(txtleave.Text);
                if (workingday > leave)
                {
                    int actualday = workingday - leave;
                    txtactualdays.Text = actualday.ToString();
                }
                else if (workingday < leave)
                {
                    MessageBox.Show("Totalday should be greater than Leave day ", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */
        }

        private void txtlate_Enter(object sender, EventArgs e)
        {
            // for total late hours
            /*
            try
            {
                int id = Convert.ToInt32(txtemployid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = enddate.Value;
                DataTable table = emptot.GetTotalLateHours(id,stdate,endate);
                if (table.Rows.Count > 0)
                {
                    string s = table.Rows[0]["Total"].ToString();
                    double tottime = Convert.ToDouble(s);
                    int hours = (int)(tottime / 3600);
                    int minute = (int)((tottime % 3600) / 60);


                    string totallate = string.Format("{0:D2}:{1:D2}", hours, minute);
                    txtlate.Text = totallate.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }

        private void txttothours_Enter(object sender, EventArgs e)
        {
            // for total working hours
            /*
            try
            {
                int id = Convert.ToInt32(txtemployid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = enddate.Value;
                DataTable table = emptot.GetTotalWorkingHours(id,stdate,endate);
                if (table.Rows.Count > 0)
                {

                    //DateTime totaltime = Convert.ToDateTime(table.Rows[0]["Total"].ToString());
                    string s = table.Rows[0]["Total"].ToString();
                    double totaltime = Convert.ToDouble(s);
                    int hours = (int)(totaltime / 3600);
                    int minute = (int)((totaltime % 3600) / 60);

                    //double test = totaltime % 3600;
                    // double finalresult = finaltime + test;
                    string totalhours = string.Format("{0:D2}:{1:D2}", hours, minute);
                    txttothours.Text = totalhours.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }

        private void txttotot_Enter(object sender, EventArgs e)
        {
            /*
            try
            {
                //for total OT time
                int id = Convert.ToInt32(txtemployid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = enddate.Value;

                DataTable table = emptot.GetTotalOtTime(id,stdate,endate);
                if (table.Rows.Count > 0)
                {
                    string s = table.Rows[0]["Total"].ToString();
                    double totaltime = Convert.ToDouble(s);
                    int hours = (int)(totaltime / 3600);
                    int minute = (int)((totaltime % 3600) / 60);

                    //double test = totaltime % 3600;
                    // double finalresult = finaltime + test;
                    string totothour = string.Format("{0:D2}:{1:D2}", hours, minute);
                    txttotot.Text = totothour.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }

        private void txtactualhours_Enter(object sender, EventArgs e)
        {
            /*
            try
            {
                string wh = txttothours.Text;
                string lh = txtlate.Text;
                string[] whlist = wh.Split(':');
                string[] lhlist = lh.Split(':');
                foreach (string x in whlist)
                {
                    int whours = Convert.ToInt32(whlist[0]);
                    int wminute = Convert.ToInt32(whlist[1]);
                    foreach (string y in lhlist)
                    {
                        int latehours = Convert.ToInt32(lhlist[0]);
                        int lateminute = Convert.ToInt32(lhlist[1]);
                        if (whours > latehours)
                        {
                            int totalhours = whours - latehours;
                            Console.WriteLine(totalhours);
                            int totalminute = wminute - lateminute;
                            string totalhr = totalhours.ToString();
                            string totalmin = totalminute.ToString();
                            string actualhours = string.Format("{0:D2}:{1:D2}", totalhr, totalmin);
                            txtactualhours.Text = actualhours.ToString();
                            Console.WriteLine(actualhours);

                        }
                        else if (lateminute > wminute)
                        {
                            int totalhours = whours - latehours;
                            int totalminute = lateminute - wminute;
                            string totalhr = totalhours.ToString();
                            string totalmin = totalminute.ToString();
                            string actualhours = string.Format("{0:D2}:{1:D2}", totalhr, totalmin);
                            txtactualhours.Text = actualhours.ToString();
                            Console.WriteLine(actualhours);
                        }
                        else if(latehours > whours)
                        {
                            int totalhours = latehours - whours;
                            int totalminute = wminute - lateminute;
                            string totalhr = totalhours.ToString();
                            string totalmin = totalminute.ToString();
                            string actualhours = string.Format("{0:D2}:{1:D2}", totalhr, totalmin);
                            txtactualhours.Text = actualhours.ToString();
                            Console.WriteLine(actualhours);
                        }
                        /*else if (lateminute > wminute || latehours > whours)
                        {
                            int totalhours = latehours - whours;
                            int totalminute = lateminute - wminute;
                            string totalhr = totalhours.ToString();
                            string totalmin = totalminute.ToString();
                            string actualhours = string.Format("{0:D2}:{1:D2}", totalhr, totalmin);
                            txtactualhours.Text = actualhours.ToString();
                            Console.WriteLine(actualhours);
                        }*/
            /*
                       

                    }
                }

            }
            catch
            {
                MessageBox.Show("Required Fill the Fields!", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //@nm, @ph, @ad, @bp
            //int id, String nm,int tothr, int totday, int totot, DateTime stdate,DateTime endate
            string nm = txtname.Text;
            int id;
            string tothr = txttothours.Text;
            string totactual = txtactualhours.Text;
            string totlate = txtlate.Text;
            int totday;
            string totot = txttotot.Text;
            int leave;
            int actualdays;
            DateTime stdate = startdate.Value;
            DateTime endate = enddate.Value;
            string EID = EmployeeID.Text;
            try
            {
                id = Convert.ToInt32(txtemployid.Text);
                totday = Convert.ToInt32(txttotdays.Text);
                leave = Convert.ToInt32(txtleave.Text);
                actualdays = Convert.ToInt32(txtactualdays.Text);
                int state = 1;

                if (nm.Trim().Equals("") || id.Equals("") || tothr.Equals("") || totday.Equals("") || totot.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (emptot.IfDataexits(id, stdate, endate))
                {
                    string usrid = txtemployid.Text.ToString();
                    dataGridViewempatttotal.DataSource = emptot.filterempatt(id);
                    MessageBox.Show("Employee ID " + usrid + " already exit", "Check again!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = emptot.insertempatttot(id, nm, tothr, totday, totot, stdate, endate, leave, totlate, totactual, actualdays, state,EID);

                    if (insertClient)
                    {
                        dataGridViewempatttotal.DataSource = emptot.getEmployeeAttemdamceTotal();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string s = dataGridViewempatttotal.CurrentRow.Cells[0].Value.ToString();
            string nm = txtname.Text;
            int id;
            string tothr = txttothours.Text;
            string totactual = txtactualhours.Text;
            string totlate = txtlate.Text;
            int totday;
            string totot = txttotot.Text;
            int leave;
            int actualdays;
            DateTime stdate = startdate.Value;
            DateTime endate = enddate.Value;


            try
            {
                int eid = Convert.ToInt32(s);
                id = Convert.ToInt32(txtemployid.Text);
                //tothr = DateTime.Parse(txttothours.Text);
                totday = Convert.ToInt32(txttotdays.Text);
                leave = Convert.ToInt32(txtleave.Text);
                actualdays = Convert.ToInt32(txtactualdays.Text);
                int state = 2;

                if (totday.Equals("") || totot.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = emptot.editempatttot(eid,id, nm, tothr, totday, totot, stdate, endate, leave, totlate, totactual, actualdays, state);

                    if (insertClient)
                    {
                        dataGridViewempatttotal.DataSource = emptot.filterempatt(id);
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
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            string s = dataGridViewempatttotal.CurrentRow.Cells[0].Value.ToString();
            string nm = txtname.Text;
            int id;
            string tothr = txttothours.Text;
            string totactual = txtactualhours.Text;
            string totlate = txtlate.Text;
            int totday;
            string totot = txttotot.Text;
            int leave;
            int actualdays;
            DateTime stdate = startdate.Value;
            DateTime endate = enddate.Value;


            try
            {
                int eid = Convert.ToInt32(s);
                id = Convert.ToInt32(txtemployid.Text);
                //tothr = DateTime.Parse(txttothours.Text);
                totday = Convert.ToInt32(txttotdays.Text);
                leave = Convert.ToInt32(txtleave.Text);
                actualdays = Convert.ToInt32(txtactualdays.Text);
                int state = 3;

                if (totday.Equals("") || totot.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = emptot.editempatttot(eid,id, nm, tothr, totday, totot, stdate, endate, leave, totlate, totactual, actualdays, state);

                    if (insertClient)
                    {
                        dataGridViewempatttotal.DataSource = emptot.filterempatt(id);
                        MessageBox.Show(" Employee Attendance Deleted Sucessfuly!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridViewempatttotal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtemployid.Text = dataGridViewempatttotal.CurrentRow.Cells[1].Value.ToString();
            txtname.Text = dataGridViewempatttotal.CurrentRow.Cells[2].Value.ToString();
            txttothours.Text = dataGridViewempatttotal.CurrentRow.Cells[3].Value.ToString();
            txttotdays.Text = dataGridViewempatttotal.CurrentRow.Cells[4].Value.ToString();
            txttotot.Text = dataGridViewempatttotal.CurrentRow.Cells[5].Value.ToString();
            startdate.Text = dataGridViewempatttotal.CurrentRow.Cells[6].Value.ToString();
            enddate.Text = dataGridViewempatttotal.CurrentRow.Cells[7].Value.ToString();
            txtleave.Text = dataGridViewempatttotal.CurrentRow.Cells[8].Value.ToString();
            txtlate.Text = dataGridViewempatttotal.CurrentRow.Cells[9].Value.ToString();
            txtactualhours.Text = dataGridViewempatttotal.CurrentRow.Cells[10].Value.ToString();
            txtactualdays.Text = dataGridViewempatttotal.CurrentRow.Cells[11].Value.ToString();
            EmployeeID.Text = dataGridViewempatttotal.CurrentRow.Cells[12].Value.ToString();
            TotalID.Text = dataGridViewempatttotal.CurrentRow.Cells[0].Value.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void CalculateAll_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtemployid.Text);
                DateTime leavetime = DateTime.Parse("00:00:00");
                DateTime stdate = startdate.Value;
                DateTime endate = enddate.Value;

                int totaldays = 0;int totalleaves = 0;

                //Get Total Days
                DataTable table = emptot.GetTotalDays(id, stdate, endate);
                if (table.Rows.Count > 0)
                {
                    txttotdays.Text = table.Rows[0]["Total"].ToString();
                    totaldays = Convert.ToInt32(table.Rows[0]["Total"].ToString());
                }
                //Get total leaves
                DataTable t2 = emptot.GetTotalLeaveDays(id, leavetime, stdate, endate);
                if (t2.Rows.Count > 0)
                {
                    txtleave.Text = t2.Rows[0]["Total"].ToString();
                    totalleaves   = Convert.ToInt32(t2.Rows[0]["Total"].ToString());
                }
                if (totaldays > totalleaves)
                {
                    int actualday = totaldays - totalleaves;
                    txtactualdays.Text = actualday.ToString();
                }
                else if (totaldays < totalleaves)
                {
                    MessageBox.Show("Totalday should be greater than Leave day ", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Total Late Hours
                DataTable t3 = emptot.GetTotalLateHours(id, stdate, endate);
                string totallate = "";
                if (t3.Rows.Count > 0)
                {
                    string s = t3.Rows[0]["Total"].ToString();
                    double tottime = Convert.ToDouble(s);
                    int hours = (int)(tottime / 3600);
                    int minute = (int)((tottime % 3600) / 60);


                    totallate = string.Format("{0:D2}:{1:D2}", hours, minute);
                    txtlate.Text = totallate.ToString();
                }

                //Total Working Hours
                DataTable t4 = emptot.GetTotalWorkingHours(id, stdate, endate);
                string totalhours = "";
                if (t4.Rows.Count > 0)
                {

                    //DateTime totaltime = Convert.ToDateTime(table.Rows[0]["Total"].ToString());
                    string s = t4.Rows[0]["Total"].ToString();
                    double totaltime = Convert.ToDouble(s);
                    int hours = (int)(totaltime / 3600);
                    int minute = (int)((totaltime % 3600) / 60);

                    //double test = totaltime % 3600;
                    // double finalresult = finaltime + test;
                    totalhours = string.Format("{0:D2}:{1:D2}", hours, minute);
                    txttothours.Text = totalhours.ToString();
                }

                DataTable t5 = emptot.GetTotalOtTime(id, stdate, endate);
                if (t5.Rows.Count > 0)
                {
                    string s = t5.Rows[0]["Total"].ToString();
                    double totaltime = Convert.ToDouble(s);
                    int hours = (int)(totaltime / 3600);
                    int minute = (int)((totaltime % 3600) / 60);

                    //double test = totaltime % 3600;
                    // double finalresult = finaltime + test;
                    string totothour = string.Format("{0:D2}:{1:D2}", hours, minute);
                    txttotot.Text = totothour.ToString();
                }

                //actual hours
                    
                    string wh = totalhours;
                    string lh = totallate;
                    string[] whlist = wh.Split(':');
                    string[] lhlist = lh.Split(':');
                    foreach (string x in whlist)
                    {
                        int whours = Convert.ToInt32(whlist[0]);
                        int wminute = Convert.ToInt32(whlist[1]);
                        foreach (string y in lhlist)
                        {
                            int latehours = Convert.ToInt32(lhlist[0]);
                            int lateminute = Convert.ToInt32(lhlist[1]);
                            if (whours > latehours)
                            {
                                int totalhour = whours - latehours;
                                Console.WriteLine(totalhours);
                                int totalminute = wminute - lateminute;
                                string totalhr = totalhours.ToString();
                                string totalmin = totalminute.ToString();
                                string actualhours = string.Format("{0:D2}:{1:D2}", totalhr, totalmin);
                                txtactualhours.Text = actualhours.ToString();
                                Console.WriteLine(actualhours);

                            }
                            else if (lateminute > wminute)
                            {
                                int totalhour = whours - latehours;
                                int totalminute = lateminute - wminute;
                                string totalhr = totalhours.ToString();
                                string totalmin = totalminute.ToString();
                                string actualhours = string.Format("{0:D2}:{1:D2}", totalhr, totalmin);
                                txtactualhours.Text = actualhours.ToString();
                                Console.WriteLine(actualhours);
                            }
                            else if (latehours > whours)
                            {
                                int totalhour = latehours - whours;
                                int totalminute = wminute - lateminute;
                                string totalhr = totalhours.ToString();
                                string totalmin = totalminute.ToString();
                                string actualhours = string.Format("{0:D2}:{1:D2}", totalhr, totalmin);
                                txtactualhours.Text = actualhours.ToString();
                                Console.WriteLine(actualhours);
                            }
                           
                        }
                    }
            }
            catch
            {
                MessageBox.Show("There is No Data In Selected Dates", "Empty Data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
