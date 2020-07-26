using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        retrival r = new retrival();
        private void datepicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datepicker.Value.Month, "@year", datepicker.Value.Year);

        }

       public override void BackBtn_Click(object sender, EventArgs e)
        {
      
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
       
    }

        private void purDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            float gt=0;
            if (purDD.SelectedIndex != -1 && purDD.SelectedIndex  != 0)
            {
                
               r.showPurchaseInvoiceDetails(Convert.ToInt64(purDD.SelectedValue.ToString()),dataGridView1,mPIDGV ,proIDGV, proGV, quantGV, pupGV,totalGV);
                foreach (DataGridViewRow row  in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                grossLabel.Text = gt.ToString();
                gt = 0;
            }
            

        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datepicker.Value.Month, "@year", datepicker.Value.Year);

        }
        insertion i = new insertion();
        updation u = new updation();
        deletion d = new deletion();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int q;
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are u sure,want to delete? "+row.Cells["proGV"].Value.ToString() + "from purchase invoice ?\nWARNING\t\nDELETION OF PRODUCT WILL EFFECT STOCK","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if(dr == DialogResult.Yes)
                    {

                        using (TransactionScope sc = new TransactionScope())
                        {


                            i.insertDeletedItem(Convert.ToInt64(purDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantGV"].Value.ToString()), retrival.USER_ID, DateTime.Today);

                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text)-Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                                grossLabel.Text = tot.ToString();
                                d.delete(Convert.ToInt64(row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFromPID", "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }

                            sc.Complete();
                        }
                    }
                }
            
            }
        }
    }
}
