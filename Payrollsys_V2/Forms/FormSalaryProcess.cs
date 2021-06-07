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
    public partial class FormSalaryProcess : Form
    {
        employeepay pay = new employeepay();
        public FormSalaryProcess()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridViewemp.Visible = true;
        }

        private void FormSalaryProcess_Load(object sender, EventArgs e)
        {
            dataGridViewemp.DataSource = pay.getemp();
            dataGridViewemppay.DataSource = pay.getemppay();
        }

        private void dataGridViewemp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtemployid.Text = dataGridViewemp.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridViewemp.CurrentRow.Cells[1].Value.ToString();
            txtbasic.Text = dataGridViewemp.CurrentRow.Cells[2].Value.ToString();
            txtot.Text = dataGridViewemp.CurrentRow.Cells[3].Value.ToString();
            txttotwh.Text = dataGridViewemp.CurrentRow.Cells[11].Value.ToString();
            txtday.Text = dataGridViewemp.CurrentRow.Cells[12].Value.ToString();
            txttotot.Text = dataGridViewemp.CurrentRow.Cells[6].Value.ToString();
            txtfrom.Text = dataGridViewemp.CurrentRow.Cells[7].Value.ToString();
            txtto.Text = dataGridViewemp.CurrentRow.Cells[8].Value.ToString();
            txtleave.Text = dataGridViewemp.CurrentRow.Cells[9].Value.ToString();
            txtlate.Text = dataGridViewemp.CurrentRow.Cells[10].Value.ToString();
            dataGridViewemp.Visible = false;
            int id;
            id = Convert.ToInt32(txtemployid.Text);
            dataGridViewemppay.DataSource = pay.filterempatt(id);
        }

        private void dataGridViewemppay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtemployid.Text = dataGridViewemppay.CurrentRow.Cells[1].Value.ToString();
            txtname.Text = dataGridViewemppay.CurrentRow.Cells[2].Value.ToString();
            txtbasic.Text = dataGridViewemppay.CurrentRow.Cells[3].Value.ToString();
            txtot.Text = dataGridViewemppay.CurrentRow.Cells[4].Value.ToString();
            txtday.Text = dataGridViewemppay.CurrentRow.Cells[5].Value.ToString();
            txttotwh.Text = dataGridViewemppay.CurrentRow.Cells[6].Value.ToString();
            txttotot.Text = dataGridViewemppay.CurrentRow.Cells[7].Value.ToString();
            txtlate.Text = dataGridViewemppay.CurrentRow.Cells[8].Value.ToString();
            txtfrom.Text = dataGridViewemppay.CurrentRow.Cells[9].Value.ToString();
            txtto.Text = dataGridViewemppay.CurrentRow.Cells[10].Value.ToString();
            txtleave.Text = dataGridViewemppay.CurrentRow.Cells[11].Value.ToString();
            txtadv.Text = dataGridViewemppay.CurrentRow.Cells[12].Value.ToString();
            txtother.Text = dataGridViewemppay.CurrentRow.Cells[13].Value.ToString();
            txtbounus.Text = dataGridViewemppay.CurrentRow.Cells[14].Value.ToString();
            txtdeduction.Text = dataGridViewemppay.CurrentRow.Cells[15].Value.ToString();
            txtlate_1.Text = dataGridViewemppay.CurrentRow.Cells[16].Value.ToString();
            txtnetpay.Text = dataGridViewemppay.CurrentRow.Cells[17].Value.ToString();
            txttotalearning.Text = dataGridViewemppay.CurrentRow.Cells[18].Value.ToString();

        }
        private void txttotalearning_Enter(object sender, EventArgs e)
        {
            int basic;
            int ot;
            int totday;
            int adv;
            int other;
            int bonus;
            int deduction;
            int late;
            int earning;
            basic = Convert.ToInt32(txtbasic.Text);
            ot = Convert.ToInt32(txtot.Text);
            totday = Convert.ToInt32(txtday.Text);
            //leave = Convert.ToInt32(txtleave.Text);
            // totot = txttotot.Text.ToString();
            //Tot = Convert.ToDecimal(totot);
            //totot = DateTime.Parse(txttotot.Text);
            adv = Convert.ToInt32(txtadv.Text);
            other = Convert.ToInt32(txtother.Text);
            bonus = Convert.ToInt32(txtbounus.Text);
            deduction = Convert.ToInt32(txtdeduction.Text);
            late = Convert.ToInt32(txtlate_1.Text);
            earning = (basic * totday) + ot + other + bonus;
            int netpay = earning - adv - deduction - late;
            txttotalearning.Text = earning.ToString();
            txtnetpay.Text = netpay.ToString();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            //
            //@eid,@nm,@bp,@totday,@tothr,@totot,@from,@to,@leave,@adv,@other,@netpay
            string nm = txtname.Text;
            int id;
            int bp;
            int ot;
            int totday;
            string tothr = txttotwh.Text;
            string totlate = txtlate.Text;
            string totot=txttotot.Text;
            DateTime stdate;
            DateTime endate;
            int leave;
            int adv;
            int other;
            int netpay;
            int bonus;
            int deduction;
            int state = 1;
            int late;
            int earning;

            try
            {
                id = Convert.ToInt32(txtemployid.Text);
                bp = Convert.ToInt32(txtbasic.Text);
                ot = Convert.ToInt32(txtot.Text);
                stdate = DateTime.Parse(txtfrom.Text);
                endate = DateTime.Parse(txtto.Text);
                //tothr = DateTime.Parse(txttotwh.Text);
                totday = Convert.ToInt32(txtday.Text);                
                leave = Convert.ToInt32(txtleave.Text);
                adv = Convert.ToInt32(txtadv.Text);
                other = Convert.ToInt32(txtother.Text);
                netpay = Convert.ToInt32(txtnetpay.Text);
                bonus = Convert.ToInt32(txtbounus.Text);
                deduction = Convert.ToInt32(txtdeduction.Text);
                late = Convert.ToInt32(txtlate_1.Text);
                earning = Convert.ToInt32(txttotalearning.Text);

                if (nm.Trim().Equals("") || id.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pay.IfDataexits(id, stdate, endate))
                {
                    string usrid = txtemployid.Text.ToString();
                    dataGridViewemppay.DataSource = pay.filterempatt(id);
                    MessageBox.Show("Employee ID " + usrid + " already exit", "Check again!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = pay.insertpayment(id, nm, bp, ot, totday, tothr, totot, totlate, stdate, endate, leave, adv, other, bonus, deduction, late, netpay, earning, state);

                    if (insertClient)
                    {

                        dataGridViewemppay.DataSource = pay.filterempatt(id);
                        //dataGridViewemppay.DataSource = pay.getemppay();
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbasic.Text = "";
            txtot.Text = "";
            txttotwh.Text = "";
            txtday.Text = "";
            txttotot.Text = "";
            txtfrom.Text = "";
            txtto.Text = "";
            txtleave.Text = "";
            txtnetpay.Text = "";
            txtother.Text = "";
            txtother.Text = "";
            txtadv.Text = "";
            txtlate.Text = "";
            txtbounus.Text = "";
            txtdeduction.Text = "";
            txtlate_1.Text = "";
            txttotalearning.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string s = dataGridViewemppay.CurrentRow.Cells[0].Value.ToString();
            string nm = txtname.Text;
            int id;
            int bp;
            int ot;
            int totday;
            string tothr = txttotwh.Text;
            string totlate = txtlate.Text;
            string  totot= txttotot.Text;
            DateTime stdate;
            DateTime endate;
            int leave;
            int adv;
            int other;
            int netpay;
            int bonus;
            int deduction;
            int late;
            int earning;

            try
            {
                int eid = Convert.ToInt32(s);
                id = Convert.ToInt32(txtemployid.Text);
                bp = Convert.ToInt32(txtbasic.Text);
                ot = Convert.ToInt32(txtot.Text);
                stdate = DateTime.Parse(txtfrom.Text);
                endate = DateTime.Parse(txtto.Text);
                //tothr = DateTime.Parse(txttotwh.Text);
                totday = Convert.ToInt32(txtday.Text);          
                leave = Convert.ToInt32(txtleave.Text);
                adv = Convert.ToInt32(txtadv.Text);
                other = Convert.ToInt32(txtother.Text);
                netpay = Convert.ToInt32(txtnetpay.Text);
                bonus = Convert.ToInt32(txtbounus.Text);
                deduction = Convert.ToInt32(txtdeduction.Text);
                late = Convert.ToInt32(txtlate_1.Text);
                earning = Convert.ToInt32(txttotalearning.Text);
                int state = 3;

                if (nm.Trim().Equals("") || id.Equals(""))
                {
                    MessageBox.Show("Required Fill the Fields!", "Empty Field!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
                else
                {
                    Boolean insertClient = pay.removeemppay(eid,id, nm, bp, ot, totday, tothr, totot, totlate, stdate, endate, leave, adv, other, bonus, deduction, late, netpay, earning, state);

                    if (insertClient)
                    {
                        dataGridViewemppay.DataSource = pay.filterempatt(id);
                        //dataGridViewemppay.DataSource = pay.getemppay();
                        MessageBox.Show("Deleted Sucessfuly!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridViewemp.Hide();
        }
    }
}
