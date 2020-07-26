namespace ims
{
    partial class PurchaseInvoice
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
            this.supplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.producttxt = new System.Windows.Forms.TextBox();
            this.quantxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.puptxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.suppErrorLbl = new System.Windows.Forms.Label();
            this.barerrorlbl = new System.Windows.Forms.Label();
            this.QuantityErrorlbl = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.lftPanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dataGridView1);
            // 
            // lftPanel
            // 
            this.lftPanel.Controls.Add(this.totLbl);
            this.lftPanel.Controls.Add(this.label7);
            this.lftPanel.Controls.Add(this.cartbtn);
            this.lftPanel.Controls.Add(this.puptxt);
            this.lftPanel.Controls.Add(this.label6);
            this.lftPanel.Controls.Add(this.barcodetxt);
            this.lftPanel.Controls.Add(this.label5);
            this.lftPanel.Controls.Add(this.label4);
            this.lftPanel.Controls.Add(this.quantxt);
            this.lftPanel.Controls.Add(this.producttxt);
            this.lftPanel.Controls.Add(this.label3);
            this.lftPanel.Controls.Add(this.supplierDD);
            this.lftPanel.Controls.Add(this.label2);
            this.lftPanel.Controls.Add(this.suppErrorLbl);
            this.lftPanel.Controls.Add(this.barerrorlbl);
            this.lftPanel.Controls.Add(this.QuantityErrorlbl);
            this.lftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lftPanel_Paint);
            this.lftPanel.Controls.SetChildIndex(this.QuantityErrorlbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.barerrorlbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.suppErrorLbl, 0);
            this.lftPanel.Controls.SetChildIndex(this.label2, 0);
            this.lftPanel.Controls.SetChildIndex(this.supplierDD, 0);
            this.lftPanel.Controls.SetChildIndex(this.label3, 0);
            this.lftPanel.Controls.SetChildIndex(this.producttxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.quantxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.label4, 0);
            this.lftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.lftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.lftPanel.Controls.SetChildIndex(this.label5, 0);
            this.lftPanel.Controls.SetChildIndex(this.barcodetxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.label6, 0);
            this.lftPanel.Controls.SetChildIndex(this.puptxt, 0);
            this.lftPanel.Controls.SetChildIndex(this.cartbtn, 0);
            this.lftPanel.Controls.SetChildIndex(this.label7, 0);
            this.lftPanel.Controls.SetChildIndex(this.totLbl, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(992, 522);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(992, 46);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Supplier";
            // 
            // supplierDD
            // 
            this.supplierDD.FormattingEnabled = true;
            this.supplierDD.Location = new System.Drawing.Point(16, 138);
            this.supplierDD.Name = "supplierDD";
            this.supplierDD.Size = new System.Drawing.Size(197, 23);
            this.supplierDD.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = " Product";
            // 
            // producttxt
            // 
            this.producttxt.Location = new System.Drawing.Point(17, 226);
            this.producttxt.Name = "producttxt";
            this.producttxt.Size = new System.Drawing.Size(196, 23);
            this.producttxt.TabIndex = 2;
            // 
            // quantxt
            // 
            this.quantxt.Location = new System.Drawing.Point(19, 314);
            this.quantxt.Name = "quantxt";
            this.quantxt.Size = new System.Drawing.Size(195, 23);
            this.quantxt.TabIndex = 4;
            this.quantxt.TextChanged += new System.EventHandler(this.quantxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Quantity";
            // 
            // barcodetxt
            // 
            this.barcodetxt.Location = new System.Drawing.Point(14, 182);
            this.barcodetxt.Name = "barcodetxt";
            this.barcodetxt.Size = new System.Drawing.Size(196, 23);
            this.barcodetxt.TabIndex = 1;
            this.barcodetxt.TextChanged += new System.EventHandler(this.barcodetxt_TextChanged);
            this.barcodetxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcodetxt_Validating);
            this.barcodetxt.Validated += new System.EventHandler(this.barcodetxt_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barcode";
            // 
            // puptxt
            // 
            this.puptxt.Location = new System.Drawing.Point(18, 270);
            this.puptxt.Name = "puptxt";
            this.puptxt.Size = new System.Drawing.Size(196, 23);
            this.puptxt.TabIndex = 3;
            this.puptxt.TextChanged += new System.EventHandler(this.puptxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Per Unit price";
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
            this.quantGV,
            this.pupGV,
            this.totalGV,
            this.deleteGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proIDGV
            // 
            this.proIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            // quantGV
            // 
            this.quantGV.HeaderText = "Quantity";
            this.quantGV.Name = "quantGV";
            this.quantGV.ReadOnly = true;
            // 
            // pupGV
            // 
            this.pupGV.HeaderText = "Per Unit Price";
            this.pupGV.Name = "pupGV";
            this.pupGV.ReadOnly = true;
            // 
            // totalGV
            // 
            this.totalGV.HeaderText = "Total Amount";
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // cartbtn
            // 
            this.cartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartbtn.Location = new System.Drawing.Point(19, 343);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(191, 32);
            this.cartbtn.TabIndex = 5;
            this.cartbtn.Text = "ADD TO CART";
            this.cartbtn.UseVisualStyleBackColor = true;
            this.cartbtn.Click += new System.EventHandler(this.cartbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Amount";
            // 
            // totLbl
            // 
            this.totLbl.AutoSize = true;
            this.totLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLbl.Location = new System.Drawing.Point(21, 415);
            this.totLbl.Name = "totLbl";
            this.totLbl.Size = new System.Drawing.Size(40, 21);
            this.totLbl.TabIndex = 12;
            this.totLbl.Text = "0.00";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 349);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1009, 57);
            this.panel6.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grossLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1009, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grossLabel
            // 
            this.grossLabel.AutoSize = true;
            this.grossLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.grossLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.Location = new System.Drawing.Point(507, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(85, 57);
            this.grossLabel.TabIndex = 14;
            this.grossLabel.Text = "0.00";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 57);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gross Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suppErrorLbl
            // 
            this.suppErrorLbl.AutoSize = true;
            this.suppErrorLbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.suppErrorLbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.suppErrorLbl.Location = new System.Drawing.Point(194, 120);
            this.suppErrorLbl.Name = "suppErrorLbl";
            this.suppErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.suppErrorLbl.TabIndex = 13;
            this.suppErrorLbl.Text = "*";
            // 
            // barerrorlbl
            // 
            this.barerrorlbl.AutoSize = true;
            this.barerrorlbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.barerrorlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.barerrorlbl.Location = new System.Drawing.Point(193, 164);
            this.barerrorlbl.Name = "barerrorlbl";
            this.barerrorlbl.Size = new System.Drawing.Size(20, 25);
            this.barerrorlbl.TabIndex = 14;
            this.barerrorlbl.Text = "*";
            // 
            // QuantityErrorlbl
            // 
            this.QuantityErrorlbl.AutoSize = true;
            this.QuantityErrorlbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.QuantityErrorlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.QuantityErrorlbl.Location = new System.Drawing.Point(194, 296);
            this.QuantityErrorlbl.Name = "QuantityErrorlbl";
            this.QuantityErrorlbl.Size = new System.Drawing.Size(20, 25);
            this.QuantityErrorlbl.TabIndex = 15;
            this.QuantityErrorlbl.Text = "*";
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 522);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.panel5.ResumeLayout(false);
            this.lftPanel.ResumeLayout(false);
            this.lftPanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox supplierDD;
        private System.Windows.Forms.TextBox barcodetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantxt;
        private System.Windows.Forms.TextBox producttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox puptxt;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cartbtn;
        private System.Windows.Forms.Label totLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label suppErrorLbl;
        public System.Windows.Forms.Label barerrorlbl;
        public System.Windows.Forms.Label QuantityErrorlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}