using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ims
{
    public partial class Settings : Sample
    {
        

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (inCB.Checked)
            {
                if (serverTxt.Text != "" && DatabaseTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";initial catalog=" + DatabaseTxt.Text + ";Integrated Security = true; MultipleActiveResultSets=true";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please Give Complete Data To continue....");
                        }
            }
            else
            {
                if (serverTxt.Text != "" && DatabaseTxt.Text != "" && userTxt.Text != "" && PassTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";initial catalog=" + DatabaseTxt.Text + ";User ID=" + userTxt.Text + ";Password=" + PassTxt.Text + ";MultipleActiveResultSets=true; ";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please Give Complete Information.....");
                }
                }

                }
           
        

        private void inCB_CheckedChanged(object sender, EventArgs e)
        {
            if (inCB.Checked)
            {
                userTxt.Enabled = false;
                PassTxt.Enabled = false;

                userTxt.Text = "";
                PassTxt.Text = "";

            }
            else
            {
                userTxt.Enabled = true;
                PassTxt.Enabled = true;

            }
        }
    }
}
