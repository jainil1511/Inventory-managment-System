namespace ims
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.passErrorlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lftPanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lftPanel
            // 
            this.lftPanel.Controls.Add(this.btnlogin);
            this.lftPanel.Controls.Add(this.passwordtxt);
            this.lftPanel.Controls.Add(this.label4);
            this.lftPanel.Controls.Add(this.usernametxt);
            this.lftPanel.Controls.Add(this.label2);
            this.lftPanel.Controls.Add(this.nameErrorLbl);
            this.lftPanel.Controls.Add(this.passErrorlbl);
            this.lftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lftPanel_Paint);
            this.lftPanel.Controls.SetChildIndex(this.passErrorlbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.nameErrorLbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.lftPanel.Controls.SetChildIndex(this.label2, 0);
            this.lftPanel.Controls.SetChildIndex(this.usernametxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.label4, 0);
            this.lftPanel.Controls.SetChildIndex(this.passwordtxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.btnlogin, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.pictureBox2);
            this.rightpanel.Controls.Add(this.pictureBox1);
            this.rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightpanel_Paint);
            this.rightpanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.rightpanel.Controls.SetChildIndex(this.pictureBox2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(12, 256);
            this.usernametxt.MaxLength = 30;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(195, 25);
            this.usernametxt.TabIndex = 3;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(16, 319);
            this.passwordtxt.MaxLength = 30;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(195, 25);
            this.passwordtxt.TabIndex = 5;
            this.passwordtxt.UseSystemPasswordChar = true;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnlogin.Location = new System.Drawing.Point(13, 365);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(198, 32);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "LogIn";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.nameErrorLbl.Location = new System.Drawing.Point(182, 234);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(25, 32);
            this.nameErrorLbl.TabIndex = 13;
            this.nameErrorLbl.Text = "*";
            this.nameErrorLbl.Visible = false;
            // 
            // passErrorlbl
            // 
            this.passErrorlbl.AutoSize = true;
            this.passErrorlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passErrorlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.passErrorlbl.Location = new System.Drawing.Point(182, 297);
            this.passErrorlbl.Name = "passErrorlbl";
            this.passErrorlbl.Size = new System.Drawing.Size(25, 32);
            this.passErrorlbl.TabIndex = 14;
            this.passErrorlbl.Text = "*";
            this.passErrorlbl.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ims.Properties.Resources.pngtree_financial_business_financial_management_blackboard_image_15804111;
            this.pictureBox1.Location = new System.Drawing.Point(128, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ims.Properties.Resources.pngtree_financial_business_financial_management_blackboard_image_15804111;
            this.pictureBox2.Location = new System.Drawing.Point(128, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(864, 416);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 534);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.lftPanel.ResumeLayout(false);
            this.lftPanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button btnlogin;
        public System.Windows.Forms.Label nameErrorLbl;
        public System.Windows.Forms.Label passErrorlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}