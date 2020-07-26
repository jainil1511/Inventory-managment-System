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
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            base.btnAdd.Enabled = false;
            base.btnDelete.Enabled = false;
            base.btnEdit.Enabled = false;
            base.btnSave.Enabled = false;

        }
        public override void button1_Click(object sender, EventArgs e)
        {

        }

        public override void button2_Click(object sender, EventArgs e)
        {

        }


        public override void button3_Click(object sender, EventArgs e)
        {

        }

        public override  void button4_Click(object sender, EventArgs e)
        {

        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            retrival r = new retrival();
            r.showStockDetails(dataGridView1, proIDGV, proGV, barGV, expiryGV, bpGV,spGV, catGV, quantGV, statusGV, finalGV);
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usrlbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
