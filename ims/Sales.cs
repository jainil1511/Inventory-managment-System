using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class Sales : Sample2
    {
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        int productID;
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }
        string[] prodARR = new string[6];
        retrival r = new retrival();
        
        float GROSS = 0;

        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
           
        }
        bool productCheck;
        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                GrossTxt.Text = "";
                TotalDiscountTxt.Text = "";
                amountTxt.Text = "";
                changeGiveTxt.Text = "";
                int qCount = 0;
                int sQuant = 0;
                int nCount = 0;

                prodARR = r.getProductsWRTBarcode(barcodeTxt.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (prodARR[0] == row.Cells["proIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                    }

                }
                sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt64(prodARR[0])));
                
                nCount = sQuant - qCount;
                
                if (nCount <= 0)
                {

                }
                else
                {


                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                            {

                                productCheck = true;
                                break;
                            }
                            else
                            {
                                productCheck = false;
                            }

                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantGV"].Value = Convert.ToInt32(row.Cells["quantGV"].Value.ToString()) + 1;
                                    if (row.Cells["disGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(row.Cells["disGV"].Value.ToString()) + Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                                        row.Cells["disGV"].Value = disc;

                                    }
                                    float tot = (Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantGV"].Value.ToString())) - Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                                    row.Cells["totalGV"].Value = tot;
                                }
                            }


                        }

                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                        }


                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        GROSS += Convert.ToSingle(item.Cells["totalGV"].Value.ToString());
                    }
                    grossLabel.Text = GROSS.ToString();
                    GROSS = 0;
                    barcodeTxt.Focus();
                    barcodeTxt.Clear();
                    
                }
            }
        }

        private void lftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                if(e.ColumnIndex == 6)
                {
                    GrossTxt.Text = "";
                    TotalDiscountTxt.Text = "";
                    amountTxt.Text = "";
                    changeGiveTxt.Text = "";
                    float gt,tot,dis;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                    if(q == 1)
                    {
                        gt = Convert.ToSingle(grossLabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                        grossLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);

                    }else if (q > 1)
                    {
                        q--;
                        row.Cells["quantGV"].Value = q;
                        dis = Convert.ToSingle(row.Cells["disGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                        row.Cells["disGV"].Value = dis;
                        tot = Convert.ToSingle(row.Cells["quantGV"].Value.ToString()) *
                             Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) - dis;
                        row.Cells["totalGV"].Value = tot;
                        
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["totalGV"].Value.ToString());
                        }
                        grossLabel.Text = Math.Round(GROSS, 0).ToString();
                        GROSS = 0;
                        //gt = Convert.ToSingle(grossLabel.Text);
                        //gt = gt - Convert.ToSingle(row.Cells["pupGV"].Value.ToString());
                        //grossLabel.Text = gt.ToString();
                        //row.Cells["qunatGV"].Value = q;
                    }
                }
            }
        }

        private void barcodeTxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                float dis = 0,gross=0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());

                }
                GrossTxt.Text = Math.Round(gross,0).ToString();
                TotalDiscountTxt.Text = Math.Round(dis,0).ToString();
            }

        }

        private void amountTxt_TextChanged(object sender, EventArgs e)
        {
            if (amountTxt.Text != "")
            {
                if (!rg.Match(amountTxt.Text).Success)
                {
                    amountTxt.Text = "";
                    changeGiveTxt.Focus();
                }
                else
                {
                    //    float amountGiven = Convert.ToSingle(amountTxt.Text);
                    //    float amounttoreturn = amountGiven - Convert.ToSingle(GrossTxt.Text);
                    //    changeGiveTxt.Text = amounttoreturn.ToString();
                }
            }
            else
            {
                changeGiveTxt.Text = "";
            }

        }

        private void amountTxt_Validating(object sender, CancelEventArgs e)
        {

            if (amountTxt.Text != "" && GrossTxt.Text != "")
            {
                if (!(Convert.ToSingle(GrossTxt.Text) <= Convert.ToSingle(amountTxt.Text)))
                {
                    amountTxt.Text = "";
                    changeGiveTxt.Text = "";
                    changeGiveTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(amountTxt.Text);
                    float amounttoreturn = amountGiven - Convert.ToSingle(GrossTxt.Text);
                    changeGiveTxt.Text = Math.Round(amounttoreturn,0).ToString();
                }
            }
          }
        insertion i = new insertion();

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(amountTxt.Text != "" && TotalDiscountTxt.Text != "" && GrossTxt.Text != "" && payDD.SelectedIndex!=-1 && changeGiveTxt.Text  != "")
            {
                DialogResult dr = MessageBox.Show("Total Amount : " + GrossTxt.Text +"\n Total Discount : " + TotalDiscountTxt.Text + "\n Amount Given: " +amountTxt.Text + "\n  Amount returned : " + changeGiveTxt.Text + " \n Are You Sure, Submit Current Sales ? \n", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr== DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "proIDGV","qunatGV", retrival.USER_ID, DateTime.Now, Convert.ToSingle(GrossTxt.Text), Convert.ToSingle(TotalDiscountTxt.Text),
                   Convert.ToSingle(amountTxt.Text), Convert.ToSingle(changeGiveTxt.Text),payDD.SelectedItem.ToString());
                    MainClass.enable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                }
               
            }
        }
    }
}
