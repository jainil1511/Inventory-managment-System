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
    public partial class Categories :Sample2
    {
        int edit = 0;
        int catID;
        short stat;
        retrival r = new retrival();

        public Categories()
        {
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(lftPanel);
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
            if (CategoryTxt.Text == "") {CategoryErrorLbl.Visible = true; } else { CategoryErrorLbl.Visible = false; }
            if (activeDD.SelectedIndex == -1) { ActiveErrorlbl.Visible = true; } else { ActiveErrorlbl.Visible = false; }

            if (ActiveErrorlbl.Visible || CategoryErrorLbl.Visible )
            {
                MainClass.showMG("Filds With * Are Mandatory", "Stop", "Error"); // Error is the type of Message 
            }
            else
            {

                if (activeDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (activeDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//code for save operation
                {
                    insertion i = new insertion();
                    i.insertCat(CategoryTxt.Text, stat);
                    r.ShowCategories(dataGridView1, catIDGV, NameGV, statusGV);
                    MainClass.disable_reset(lftPanel);

                }
                else if (edit == 1)///for Updte Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to updata Record", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (activeDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (activeDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateCat(catID, CategoryTxt.Text, stat);
                        r.ShowCategories(dataGridView1, catIDGV, NameGV, statusGV);
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
                        d.delete(catID, "st_deleteCategory", "@id");
                        r.ShowCategories(dataGridView1, catIDGV, NameGV, statusGV);
                    }

                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            r.ShowCategories(dataGridView1, catIDGV, NameGV, statusGV);
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                CategoryTxt.Text = row.Cells["NameGV"].Value.ToString();
                activeDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(lftPanel);


            }
        }
    }
}
