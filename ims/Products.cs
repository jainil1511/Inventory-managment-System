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
    public partial class Products : Sample2
    {
        public Products()
        {
            InitializeComponent();
        }
      
        int edit = 0;//this 0 is an indication for save operation and 1 indiccation for update operation
       Int64 prodID;
  
        retrival r = new retrival();
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


            if (productTxt.Text == "") { proErrorLbl.Visible = true; } else { proErrorLbl.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorlbl.Visible = true; } else { barcodeErrorlbl.Visible = false; }
         //   if (expiryPicker.Value < DateTime.Now) { ExpiryErrorlbl.Visible = true; ExpiryErrorlbl.Text = "Invalid Date"; } else { ExpiryErrorlbl.Visible = true ; }           
            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { categoryErrorlbl.Visible = true; } else { categoryErrorlbl.Visible = false; }
            if (proErrorLbl.Visible || barcodeErrorlbl.Visible  || categoryErrorlbl.Visible )
            {
                MainClass.showMG("Filds With * Are Mandatory", "Stop", "Error"); // Error is the type of Message 
            }
            else
            {
                if(edit == 0)
                {
                    insertion i = new insertion();
                    i.insertProduct(productTxt.Text, barcodeTxt.Text,expiryPicker.Value,Convert.ToInt32(categoryDD.SelectedValue));
                    r.showProducts(dataGridView1,proIDGV,proGV,expiryGV,catGV,barcodeGV,catIDGV);
                    MainClass.disable_reset(lftPanel);

                }
                else if (edit == 1)///for Updte Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to updata Record", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();

                        u.updateProduct(prodID,productTxt.Text, barcodeTxt.Text,expiryPicker.Value , Convert.ToInt32(categoryDD.SelectedValue));
                        r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV,  barcodeGV, catIDGV);
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
                        d.delete(prodID, "st_productDelete", "@proID");
                        r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
                    }

                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(lftPanel);
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
            groupBox1.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                productTxt.Text = row.Cells["proGV"].Value.ToString();
                
                barcodeTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                expiryPicker.Value =Convert.ToDateTime( row.Cells["expiryGV"].Value.ToString());
                categoryDD.SelectedItem = row.Cells["catGV"].Value.ToString();
                MainClass.disable(lftPanel);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
