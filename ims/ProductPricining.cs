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
    public partial class ProductPricining :Sample2
    {
        retrival r = new retrival();
        updation u = new updation();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public ProductPricining()
        {
            InitializeComponent();
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
        }
       
        private void ProductPricining_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        public override void button1_Click(object sender, EventArgs e)
        {

        }

        public override void button2_Click(object sender, EventArgs e)
        {

        }


        public override void button3_Click(object sender, EventArgs e)
        {
            int che=0;
            try {
                if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if ((bool)row.Cells["selectGV"].FormattedValue == true)
                        {
                            che++;
                            Int64 pID;
                            float disc, pm, bp, sp;
                            pID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                            bp = Convert.ToSingle(row.Cells["BuyingPriceGv"].Value.ToString());
                          
                            disc = row.Cells["DiscountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString());
                            pm = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());
                    
                            if(disc == 0 && pm == 0)
                            {
                                sp = bp;

                            }
                            else
                            {
                               sp = Convert.ToSingle(row.Cells["FinalPriceGV"].Value.ToString());
                            }
                            u.updateProductPrice(pID, bp, sp, disc, pm);

                         
                        }

                    }
                    if(che > 0)
                    {
                        MainClass.showMG("Product Pricing updated Successfully....", "Success", "success");
                        che = 0;
                    }
                    else
                    {
                        MainClass.showMG("please Select The CheckBox....", "Error", "Error");
                        che = 0;
                    }
                    
                }
            }
            catch (Exception)
            {
               
            }

           
        }

        public override void button4_Click(object sender, EventArgs e)
        {

        }

        public override  void btnView_Click(object sender, EventArgs e)
        {

        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                r.showproductsWRTCategory(Convert.ToInt32(categoryDD.SelectedValue.ToString()), dataGridView1, proIDGV, proGV, BuyingPriceGv, FinalPriceGV,DiscountGV,profitMarginGV);

            }
        }
       
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1 & e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                { 
                    float buyingPrice = Convert.ToSingle(row.Cells["BuyingPriceGv"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100;
                    float amountToIncrease = profitMargin * buyingPrice;
                   
                    float finalSellingPrice = buyingPrice + amountToIncrease;

                    float discountPer;
                    if (row.Cells["DiscountGV"].Value != null && rg.Match(row.Cells["DiscountGV"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()) / 100);

                    }
                    else
                    {
                        discountPer = 0;
                    }
                    row.Cells["FinalPriceGV"].Value = finalSellingPrice - discountPer;
                }
                else
                {
                    row.Cells["FinalPriceGV"].Value = null;
                    row.Cells["DiscountGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;
                }
               

            }
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    dataGridView1.BeginEdit(true);
                }
            
          
           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
