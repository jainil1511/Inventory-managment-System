using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims
{

    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        
        retrival r = new retrival();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        int productID;
        float gt,tot;

        public override void button1_Click(object sender, EventArgs e)
        {

        }

        public override void button2_Click(object sender, EventArgs e)
        {

        }

        int co;
        public override void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                insertion i = new insertion();
                updation u = new updation();
               
                using (TransactionScope sc = new TransactionScope())
                {
                    
                        purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrival.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));
                        if (r.checkproductPriceExistence(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString())))
                         {
                            u.updateProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }
                    
                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        if(ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                        }                          
                            
                        else {
                            i.insertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantGV"].Value.ToString()));
                        }                            
                        }
                        if (co > 0)
                        {
                            MainClass.showMG("Purchase Invoice Created Successfullly..", "success", "success");
                        }
                        else
                        {
                            MainClass.showMG("error", "error", "error");
                        }
                        sc.Complete();
                    }
                    
                 }
        }
            

        public override void button4_Click(object sender, EventArgs e)
        {

        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);

        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", supplierDD, "Company", "ID");
        }
        string[] prodARR = new string[4];


        private void lftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private  void barcodetxt_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void barcodetxt_Validated(object sender, EventArgs e)
        {
        }

        private void quantxt_TextChanged(object sender, EventArgs e)
        {
            if (quantxt.Text != "")
            {
                if (rg.Match(quantxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quantxt.Text);
                    price = Convert.ToSingle(puptxt.Text);
                    tot = quan * price;
                    totLbl.Text = tot.ToString("#######.##");
                }

                else
                {
                    quantxt.SelectAll();
                }
            }
            else
            {
                totLbl.Text = "0.00";
            }
        }

       
        private void cartbtn_Click(object sender, EventArgs e)
        {
            if (supplierDD.SelectedIndex == -1) { suppErrorLbl.Visible = true; } else { suppErrorLbl.Visible = false; }
            if(quantxt.Text == "") { QuantityErrorlbl.Visible = true; } else { QuantityErrorlbl.Visible = false; }
            if (barcodetxt.Text == "") { barerrorlbl.Visible = true; } else { barerrorlbl.Visible = false; }
            if(suppErrorLbl.Visible || QuantityErrorlbl.Visible || barerrorlbl.Visible)
            {
                MainClass.showMG("Fields with * Are Mandatory", "Stop", "Error");
            }
            else
            {

               dataGridView1.Rows.Add(productID, producttxt.Text, quantxt.Text, puptxt.Text, totLbl.Text);
                gt += Convert.ToSingle(totLbl.Text);
                grossLabel.Text = gt.ToString();
                productID = 0;
                producttxt.Text = "";
                puptxt.Text = "";
                barcodetxt.Text = "";
                totLbl.Text = "0.00";
                quantxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
              
               
            }

        

        private void puptxt_TextChanged(object sender, EventArgs e)
        {
            if(puptxt.Text != "")
            {
                if (!rg.Match(puptxt.Text).Success)
                {
                    puptxt.Text = "";
                    puptxt.Focus();
                }
            }
        }

        private void barcodetxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodetxt.Text != "")
            {
                prodARR = r.getProductsWRTBarcode(barcodetxt.Text);
                productID = Convert.ToInt32(prodARR[0]);
                producttxt.Text = prodARR[1];
                string barco = prodARR[2];

                producttxt.Enabled = false;


                if (barco != null)
                {
                    puptxt.Focus();
                }


            }
            else
            {
                productID = 0;
                producttxt.Text = "";
                puptxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        gt -= Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                    grossLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);

                    }
                }
            }
        }

    }

    


