using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ims
{
    public partial class Users : Sample2
    {
        short stat;
        int edit = 0;//this 0 is an indication for save operation and 1 indiccation for update operation
        int userID;
        retrival r = new retrival();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(lftPanel);
        
        }

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public override void button1_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(lftPanel);
            edit = 0;
        }

        public override void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(lftPanel);
        }


        public override void button3_Click(object sender, EventArgs e)
        {
            
            if (nameTxt.Text == "") { nameErrorLbl.Visible = true; }else { nameErrorLbl.Visible = false; }
            if (usernametxt.Text == "") { UserNameLbl.Visible = true; } else { nameErrorLbl.Visible = false; }
            if (usernametxt.Text == "") { UserNameLbl.Visible = true; } else { UserNameLbl.Visible = false; }
            if (pwdTxt.Text == "") {PwdLbl.Visible = true; } else { PwdLbl.Visible = false; }
            if (phoneTxt.Text == "") { phoneLbl.Visible = true; } else { phoneLbl.Visible = false; }    
            if ( EmailTxt.Text == "") { EmailLbl.Visible = true; } else {EmailLbl.Visible = false; }
            if(statusDD.SelectedIndex == -1) { statusErrorLbl.Visible = true; } else { statusErrorLbl.Visible = false; }

            if(nameErrorLbl.Visible || UserNameLbl.Visible || PwdLbl.Visible || phoneLbl.Visible || EmailLbl.Visible || statusErrorLbl.Visible)
            {
                MainClass.showMG("Filds With * Are Mandatory", "Stop", "Error"); // Error is the type of Message 
            }
            else
            {
               
                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//code for save operation
                {
                    insertion i = new insertion();
                    i.insertUser(nameTxt.Text, usernametxt.Text, pwdTxt.Text, EmailTxt.Text, phoneTxt.Text, stat);
                    r.Showusers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
                    MainClass.disable_reset(lftPanel);

                }
                else if (edit == 1)///for Updte Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to updata Record","Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateUser(userID, nameTxt.Text, usernametxt.Text, pwdTxt.Text, EmailTxt.Text, phoneTxt.Text, stat);
                        r.Showusers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
                        MainClass.disable_reset(lftPanel);
                    }
                }
            }
        }

        public override void button4_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to Delete Record", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        deletion d = new deletion();
                        d.delete(userID, "st_deleteUser","@id");
                        r.Showusers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
                    }

                }
            }

        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.Showusers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if(e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
               usernametxt.Text = row.Cells["UsernameGV"].Value.ToString();
                pwdTxt.Text = row.Cells["PassGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                EmailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(lftPanel);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public override  void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if(SearchTxt.Text != "")
            {
                r.Showusers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV, SearchTxt.Text);
            }
            else
            {
                r.Showusers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, statusGV);
            }
        }
    }
}
