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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void lftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "") { nameErrorLbl.Visible = true; } else { nameErrorLbl.Visible = false; }
            if (passwordtxt.Text == "") { passErrorlbl.Visible = true; } else { passErrorlbl.Visible = false; }
            if (nameErrorLbl.Visible || passErrorlbl.Visible)
            {
                MainClass.showMG("Filds With * Are Mandatory", "Stop", "Error"); // Error is the type of Message 
            }
            else
            {

                if (retrival.getUserDetails(usernametxt.Text, passwordtxt.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);
                }
                else
                {

                }


            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
