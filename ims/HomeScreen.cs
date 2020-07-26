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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI.logOutToolStripMenuItem.Enabled = true;
            usrlbl.Text = retrival.EMP_NAME;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void catbtn_Click(object sender, EventArgs e)
        {
            Categories u = new Categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products u = new Products();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Supplier u = new Supplier();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            PurchaseInvoice u = new PurchaseInvoice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stocks u = new Stocks();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales u = new Sales();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void prodpribtn_Click(object sender, EventArgs e)
        {

            ProductPricining u = new ProductPricining();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }
    }
}
