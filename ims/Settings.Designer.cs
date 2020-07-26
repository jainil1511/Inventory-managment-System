namespace ims
{
    partial class Settings
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
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DatabaseTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.inCB = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lftPanel
            // 
            this.lftPanel.Controls.Add(this.btnSave);
            this.lftPanel.Controls.Add(this.inCB);
            this.lftPanel.Controls.Add(this.PassTxt);
            this.lftPanel.Controls.Add(this.userTxt);
            this.lftPanel.Controls.Add(this.DatabaseTxt);
            this.lftPanel.Controls.Add(this.label6);
            this.lftPanel.Controls.Add(this.label5);
            this.lftPanel.Controls.Add(this.label4);
            this.lftPanel.Controls.Add(this.serverTxt);
            this.lftPanel.Controls.Add(this.label2);
            this.lftPanel.Size = new System.Drawing.Size(250, 580);
            this.lftPanel.Controls.SetChildIndex(this.label2, 0);
            this.lftPanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.label4, 0);
            this.lftPanel.Controls.SetChildIndex(this.label5, 0);
            this.lftPanel.Controls.SetChildIndex(this.label6, 0);
            this.lftPanel.Controls.SetChildIndex(this.DatabaseTxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.userTxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.PassTxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.inCB, 0);
            this.lftPanel.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1067, 580);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server";
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(15, 248);
            this.serverTxt.MaxLength = 30;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(218, 23);
            this.serverTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "UserID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // DatabaseTxt
            // 
            this.DatabaseTxt.Location = new System.Drawing.Point(12, 292);
            this.DatabaseTxt.MaxLength = 30;
            this.DatabaseTxt.Name = "DatabaseTxt";
            this.DatabaseTxt.Size = new System.Drawing.Size(218, 23);
            this.DatabaseTxt.TabIndex = 4;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(12, 336);
            this.userTxt.MaxLength = 30;
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(218, 23);
            this.userTxt.TabIndex = 6;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(12, 381);
            this.PassTxt.MaxLength = 30;
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(218, 23);
            this.PassTxt.TabIndex = 8;
            this.PassTxt.UseSystemPasswordChar = true;
            // 
            // inCB
            // 
            this.inCB.AutoSize = true;
            this.inCB.Location = new System.Drawing.Point(15, 410);
            this.inCB.Name = "inCB";
            this.inCB.Size = new System.Drawing.Size(125, 19);
            this.inCB.TabIndex = 9;
            this.inCB.Text = "Integrated Security";
            this.inCB.UseVisualStyleBackColor = true;
            this.inCB.CheckedChanged += new System.EventHandler(this.inCB_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(15, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 580);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.lftPanel.ResumeLayout(false);
            this.lftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox inCB;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox DatabaseTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.Label label2;
    }
}