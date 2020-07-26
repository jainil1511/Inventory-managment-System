namespace ims
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.prodpribtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.catbtn = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.lftPanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lftPanel
            // 
            this.lftPanel.Size = new System.Drawing.Size(250, 600);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.tableLayoutPanel1);
            this.rightpanel.Size = new System.Drawing.Size(1104, 600);
            this.rightpanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightpanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1104, 46);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnpurchase, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStock, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProducts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.prodpribtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.supplierBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.catbtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSales, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1104, 590);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnpurchase
            // 
            this.btnpurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnpurchase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpurchase.FlatAppearance.BorderSize = 2;
            this.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchase.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.Image = global::ims.Properties.Resources.bill1;
            this.btnpurchase.Location = new System.Drawing.Point(831, 3);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(270, 141);
            this.btnpurchase.TabIndex = 3;
            this.btnpurchase.Text = "Purchase Invoice";
            this.btnpurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnpurchase.UseVisualStyleBackColor = true;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStock.FlatAppearance.BorderSize = 2;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Image = global::ims.Properties.Resources.stock;
            this.btnStock.Location = new System.Drawing.Point(555, 3);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(270, 141);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProducts.FlatAppearance.BorderSize = 2;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnProducts.Image = global::ims.Properties.Resources.dairy_products22;
            this.btnProducts.Location = new System.Drawing.Point(279, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(270, 141);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsers.FlatAppearance.BorderSize = 2;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = global::ims.Properties.Resources.Users_icon;
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(270, 141);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // prodpribtn
            // 
            this.prodpribtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodpribtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodpribtn.FlatAppearance.BorderSize = 2;
            this.prodpribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodpribtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodpribtn.Image = global::ims.Properties.Resources.money2;
            this.prodpribtn.Location = new System.Drawing.Point(831, 150);
            this.prodpribtn.Name = "prodpribtn";
            this.prodpribtn.Size = new System.Drawing.Size(270, 141);
            this.prodpribtn.TabIndex = 8;
            this.prodpribtn.Text = "Product Pricing";
            this.prodpribtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.prodpribtn.UseVisualStyleBackColor = true;
            this.prodpribtn.Click += new System.EventHandler(this.prodpribtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplierBtn.FlatAppearance.BorderSize = 2;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.Image = global::ims.Properties.Resources.sq;
            this.supplierBtn.Location = new System.Drawing.Point(555, 150);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(270, 141);
            this.supplierBtn.TabIndex = 6;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.supplierBtn.UseVisualStyleBackColor = true;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // catbtn
            // 
            this.catbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catbtn.FlatAppearance.BorderSize = 2;
            this.catbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catbtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catbtn.Image = global::ims.Properties.Resources.o1;
            this.catbtn.Location = new System.Drawing.Point(279, 150);
            this.catbtn.Name = "catbtn";
            this.catbtn.Size = new System.Drawing.Size(270, 141);
            this.catbtn.TabIndex = 5;
            this.catbtn.Text = "Category";
            this.catbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.catbtn.UseVisualStyleBackColor = true;
            this.catbtn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSales.FlatAppearance.BorderSize = 2;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::ims.Properties.Resources.sales11;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSales.Location = new System.Drawing.Point(3, 150);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(270, 141);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 600);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.lftPanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button catbtn;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button prodpribtn;
    }
}