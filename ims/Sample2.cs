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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public  virtual void BackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public  virtual void button1_Click(object sender, EventArgs e)
        {

        }

        public virtual void button2_Click(object sender, EventArgs e)
        {

        }

       
        public virtual void button3_Click(object sender, EventArgs e)
        {

        }

        public virtual void button4_Click(object sender, EventArgs e)
        {

        }       

        public virtual void btnView_Click(object sender, EventArgs e)
        {

        }

        public virtual void  SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
