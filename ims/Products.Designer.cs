namespace ims
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.proErrorLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeErrorlbl = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.expiryPicker = new System.Windows.Forms.DateTimePicker();
            this.ExpiryErrorlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryErrorlbl = new System.Windows.Forms.Label();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.lftPanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            // 
            // lftPanel
            // 
            this.lftPanel.Controls.Add(this.categoryDD);
            this.lftPanel.Controls.Add(this.label5);
            this.lftPanel.Controls.Add(this.categoryErrorlbl);
            this.lftPanel.Controls.Add(this.expiryPicker);
            this.lftPanel.Controls.Add(this.label7);
            this.lftPanel.Controls.Add(this.barcodeTxt);
            this.lftPanel.Controls.Add(this.barcodeErrorlbl);
            this.lftPanel.Controls.Add(this.label4);
            this.lftPanel.Controls.Add(this.productTxt);
            this.lftPanel.Controls.Add(this.label2);
            this.lftPanel.Controls.Add(this.proErrorLbl);
            this.lftPanel.Controls.Add(this.ExpiryErrorlbl);
            this.lftPanel.Controls.SetChildIndex(this.ExpiryErrorlbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.proErrorLbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.lftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.lftPanel.Controls.SetChildIndex(this.label2, 0);
            this.lftPanel.Controls.SetChildIndex(this.productTxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.label4, 0);
            this.lftPanel.Controls.SetChildIndex(this.barcodeErrorlbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.label7, 0);
            this.lftPanel.Controls.SetChildIndex(this.expiryPicker, 0);
            this.lftPanel.Controls.SetChildIndex(this.categoryErrorlbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.label5, 0);
            this.lftPanel.Controls.SetChildIndex(this.categoryDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1049, 522);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1049, 46);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // productTxt
            // 
            this.productTxt.Location = new System.Drawing.Point(12, 150);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(194, 23);
            this.productTxt.TabIndex = 3;
            // 
            // proErrorLbl
            // 
            this.proErrorLbl.AutoSize = true;
            this.proErrorLbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.proErrorLbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.proErrorLbl.Location = new System.Drawing.Point(99, 130);
            this.proErrorLbl.Name = "proErrorLbl";
            this.proErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.proErrorLbl.TabIndex = 11;
            this.proErrorLbl.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Barcode";
            // 
            // barcodeErrorlbl
            // 
            this.barcodeErrorlbl.AutoSize = true;
            this.barcodeErrorlbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.barcodeErrorlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.barcodeErrorlbl.Location = new System.Drawing.Point(63, 176);
            this.barcodeErrorlbl.Name = "barcodeErrorlbl";
            this.barcodeErrorlbl.Size = new System.Drawing.Size(20, 25);
            this.barcodeErrorlbl.TabIndex = 13;
            this.barcodeErrorlbl.Text = "*";
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(12, 196);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(194, 23);
            this.barcodeTxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Expiry Date";
            // 
            // expiryPicker
            // 
            this.expiryPicker.CustomFormat = "dd-MMM-yyyy";
            this.expiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryPicker.Location = new System.Drawing.Point(15, 243);
            this.expiryPicker.Name = "expiryPicker";
            this.expiryPicker.Size = new System.Drawing.Size(191, 23);
            this.expiryPicker.TabIndex = 17;
            // 
            // ExpiryErrorlbl
            // 
            this.ExpiryErrorlbl.AutoSize = true;
            this.ExpiryErrorlbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ExpiryErrorlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.ExpiryErrorlbl.Location = new System.Drawing.Point(99, 222);
            this.ExpiryErrorlbl.Name = "ExpiryErrorlbl";
            this.ExpiryErrorlbl.Size = new System.Drawing.Size(20, 25);
            this.ExpiryErrorlbl.TabIndex = 18;
            this.ExpiryErrorlbl.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Category";
            // 
            // categoryErrorlbl
            // 
            this.categoryErrorlbl.AutoSize = true;
            this.categoryErrorlbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.categoryErrorlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.categoryErrorlbl.Location = new System.Drawing.Point(81, 268);
            this.categoryErrorlbl.Name = "categoryErrorlbl";
            this.categoryErrorlbl.Size = new System.Drawing.Size(20, 25);
            this.categoryErrorlbl.TabIndex = 23;
            this.categoryErrorlbl.Text = "*";
            // 
            // categoryDD
            // 
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(15, 289);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(194, 23);
            this.categoryDD.TabIndex = 24;
            this.categoryDD.SelectedIndexChanged += new System.EventHandler(this.categoryDD_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.proGV,
            this.barcodeGV,
            this.expiryGV,
            this.catIDGV,
            this.catGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 406);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Product";
            this.proGV.Name = "proGV";
            this.proGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "CatIDGV";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 522);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel5.ResumeLayout(false);
            this.lftPanel.ResumeLayout(false);
            this.lftPanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productTxt;
        public System.Windows.Forms.Label proErrorLbl;
        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label categoryErrorlbl;
        private System.Windows.Forms.DateTimePicker expiryPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox barcodeTxt;
        public System.Windows.Forms.Label barcodeErrorlbl;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label ExpiryErrorlbl;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
    }
}