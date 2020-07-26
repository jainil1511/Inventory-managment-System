using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class Supplier : Sample2
    {
        int edit = 0;//this 0 is an indication for save operation and 1 indiccation for update operation
        int SupplierID;
        short stat;
        retrival r = new retrival();
        public Supplier()
        {
            InitializeComponent();
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

            if (supplierComTxt.Text == "") { nameErrorLbl.Visible = true; } else { nameErrorLbl.Visible = false; }
            if (personNameTxt.Text == "") { ContPerErrorlbl.Visible = true; } else { ContPerErrorlbl.Visible = false; }
            if (phone1txt.Text == "") { phone1Errorlbl.Visible = true; } else { phone1Errorlbl.Visible = false; }
         //   if (phone2txt.Text == "") { phone2Errorlbl.Visible = true; } else { phone2Errorlbl.Visible = false; }
            if (addresstxt.Text == "") { AddressErroorlbl.Visible = true; } else { AddressErroorlbl.Visible = false; }
          //  if (TaxNotxt.Text == "") { TaxNoErrorlbl.Visible = true; } else { TaxNoErrorlbl.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorlbl.Visible = true; } else { statusErrorlbl.Visible = false; }

            if (nameErrorLbl.Visible || ContPerErrorlbl.Visible || phone1Errorlbl.Visible  || AddressErroorlbl.Visible ||  statusErrorlbl.Visible)
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
                    if (phone2txt.Text == "" && TaxNotxt.Text != "") {
                        i.insertSupplier(supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat,null,TaxNotxt.Text);
                    }
                    else if(phone2txt.Text != "" && TaxNotxt.Text == ""){
                        i.insertSupplier(supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat,phone2txt.Text, null);
                    }
                    else if (phone2txt.Text == "" && TaxNotxt.Text == "")
                    {
                        i.insertSupplier(supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSupplier(supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat,phone2txt.Text);
                    }
                    r.showSupplier(dataGridView1, suppIDGV,companyGV ,personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                    MainClass.disable_reset(lftPanel);

                }
                else if (edit == 1)///for Updte Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to updata Record", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (phone2txt.Text == "" && TaxNotxt.Text != "")
                        {
                            u.updateSupplier(SupplierID, supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat,null,TaxNotxt.Text);
                        }
                        else if (phone2txt.Text != "" && TaxNotxt.Text == "")
                        {
                            u.updateSupplier(SupplierID, supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, null);
                        }
                        else if (phone2txt.Text == "" && TaxNotxt.Text == "")
                        {
                            u.updateSupplier(SupplierID, supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(SupplierID, supplierComTxt.Text, personNameTxt.Text, phone1txt.Text, addresstxt.Text, stat, phone1txt.Text, phone2txt.Text);
                        }
                        r.showSupplier(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                       
                        
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
                        d.delete(SupplierID, "st_deleteSupplier", "@suppID");
                        r.showSupplier(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                    }

                }
            }

        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showSupplier(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(lftPanel);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SupplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                supplierComTxt.Text = row.Cells["companyGV"].Value.ToString();
                personNameTxt.Text = row.Cells["personGV"].Value.ToString();
                phone1txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2txt.Text = row.Cells["phone2GV"].Value.ToString();
                TaxNotxt.Text = row.Cells["ntnGV"].Value.ToString();
                addresstxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(lftPanel);


            }
        }
    }
}
