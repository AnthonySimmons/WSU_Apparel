namespace WSU_Apparel
{
    partial class WSU_Apparel_Form
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
            this.components = new System.ComponentModel.Container();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.treeViewInventory = new System.Windows.Forms.TreeView();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.dgvShoppingCart = new System.Windows.Forms.DataGridView();
            this.cboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.cboBoxGender = new System.Windows.Forms.ComboBox();
            this.cboBoxSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblShopping = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvDiscounts = new System.Windows.Forms.DataGridView();
            this.TypeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateDiscount = new System.Windows.Forms.Button();
            this.TitleColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Gray;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.ForeColor = System.Drawing.Color.Maroon;
            this.btnCheckout.Location = new System.Drawing.Point(774, 12);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gray;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemove.Location = new System.Drawing.Point(644, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // treeViewInventory
            // 
            this.treeViewInventory.BackColor = System.Drawing.Color.Maroon;
            this.treeViewInventory.ForeColor = System.Drawing.Color.Gray;
            this.treeViewInventory.Location = new System.Drawing.Point(12, 52);
            this.treeViewInventory.Name = "treeViewInventory";
            this.treeViewInventory.Size = new System.Drawing.Size(231, 321);
            this.treeViewInventory.TabIndex = 5;
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Gray;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddItems.Location = new System.Drawing.Point(36, 379);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(166, 32);
            this.btnAddItems.TabIndex = 12;
            this.btnAddItems.Text = "Add To Shopping Cart";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // dgvShoppingCart
            // 
            this.dgvShoppingCart.AllowUserToOrderColumns = true;
            this.dgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn1,
            this.ItemColumn,
            this.CategoryColumn1,
            this.GenderColumn,
            this.SizeColumn,
            this.IDColumn,
            this.PriceColumn,
            this.QuantityColumn,
            this.TotalPrice,
            this.DescriptionColumn1});
            this.dgvShoppingCart.Location = new System.Drawing.Point(287, 52);
            this.dgvShoppingCart.Name = "dgvShoppingCart";
            this.dgvShoppingCart.Size = new System.Drawing.Size(675, 247);
            this.dgvShoppingCart.TabIndex = 13;
            // 
            // cboBoxDiscount
            // 
            this.cboBoxDiscount.BackColor = System.Drawing.Color.Gray;
            this.cboBoxDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.cboBoxDiscount.FormattingEnabled = true;
            this.cboBoxDiscount.Location = new System.Drawing.Point(217, 25);
            this.cboBoxDiscount.Name = "cboBoxDiscount";
            this.cboBoxDiscount.Size = new System.Drawing.Size(137, 21);
            this.cboBoxDiscount.TabIndex = 14;
            this.cboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.cboBoxDiscount_SelectedIndexChanged);
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(243, 6);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(79, 13);
            this.lblDiscountType.TabIndex = 15;
            this.lblDiscountType.Text = "Discount Type:";
            // 
            // cboBoxGender
            // 
            this.cboBoxGender.BackColor = System.Drawing.Color.Gray;
            this.cboBoxGender.ForeColor = System.Drawing.Color.Maroon;
            this.cboBoxGender.FormattingEnabled = true;
            this.cboBoxGender.Location = new System.Drawing.Point(12, 25);
            this.cboBoxGender.Name = "cboBoxGender";
            this.cboBoxGender.Size = new System.Drawing.Size(90, 21);
            this.cboBoxGender.TabIndex = 16;
            // 
            // cboBoxSize
            // 
            this.cboBoxSize.BackColor = System.Drawing.Color.Gray;
            this.cboBoxSize.ForeColor = System.Drawing.Color.Maroon;
            this.cboBoxSize.FormattingEnabled = true;
            this.cboBoxSize.Location = new System.Drawing.Point(115, 25);
            this.cboBoxSize.Name = "cboBoxSize";
            this.cboBoxSize.Size = new System.Drawing.Size(90, 21);
            this.cboBoxSize.TabIndex = 17;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(141, 6);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 18;
            this.lblSize.Text = "Size:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(33, 6);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToOrderColumns = true;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.dataGridViewTextBoxColumn1,
            this.CategoryColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.IDColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.DescriptionColumn});
            this.dgvInventory.Location = new System.Drawing.Point(287, 352);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(676, 247);
            this.dgvInventory.TabIndex = 20;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(551, 336);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(54, 13);
            this.lblInventory.TabIndex = 21;
            this.lblInventory.Text = "Inventory:";
            // 
            // lblShopping
            // 
            this.lblShopping.AutoSize = true;
            this.lblShopping.Location = new System.Drawing.Point(528, 36);
            this.lblShopping.Name = "lblShopping";
            this.lblShopping.Size = new System.Drawing.Size(77, 13);
            this.lblShopping.TabIndex = 22;
            this.lblShopping.Text = "Shopping Cart:";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Gray;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.Maroon;
            this.btnSignIn.Location = new System.Drawing.Point(396, 314);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(88, 32);
            this.btnSignIn.TabIndex = 23;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackColor = System.Drawing.Color.Gray;
            this.btnUpdateInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInventory.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateInventory.Location = new System.Drawing.Point(287, 314);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(103, 32);
            this.btnUpdateInventory.TabIndex = 24;
            this.btnUpdateInventory.Text = "Update Inventory";
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.Maroon;
            this.btnReturn.Location = new System.Drawing.Point(869, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 23);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return Items";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn1,
            this.DiscountColumn1});
            this.dgvDiscounts.Location = new System.Drawing.Point(25, 417);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.Size = new System.Drawing.Size(205, 141);
            this.dgvDiscounts.TabIndex = 26;
            // 
            // TypeColumn1
            // 
            this.TypeColumn1.HeaderText = "Discount Type";
            this.TypeColumn1.Name = "TypeColumn1";
            // 
            // DiscountColumn1
            // 
            this.DiscountColumn1.HeaderText = "Amount";
            this.DiscountColumn1.Name = "DiscountColumn1";
            this.DiscountColumn1.Width = 60;
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.BackColor = System.Drawing.Color.Gray;
            this.btnUpdateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateDiscount.Location = new System.Drawing.Point(67, 564);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(104, 35);
            this.btnUpdateDiscount.TabIndex = 27;
            this.btnUpdateDiscount.Text = "Update Discounts";
            this.btnUpdateDiscount.UseVisualStyleBackColor = false;
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
            // 
            // TitleColumn1
            // 
            this.TitleColumn1.HeaderText = "Title";
            this.TitleColumn1.Name = "TitleColumn1";
            this.TitleColumn1.Width = 80;
            // 
            // ItemColumn
            // 
            this.ItemColumn.HeaderText = "Subcategory";
            this.ItemColumn.Name = "ItemColumn";
            this.ItemColumn.Width = 75;
            // 
            // CategoryColumn1
            // 
            this.CategoryColumn1.HeaderText = "Category";
            this.CategoryColumn1.Name = "CategoryColumn1";
            this.CategoryColumn1.Width = 60;
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.Width = 60;
            // 
            // SizeColumn
            // 
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.Width = 60;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Width = 60;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 50;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.Width = 50;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 60;
            // 
            // DescriptionColumn1
            // 
            this.DescriptionColumn1.HeaderText = "Description";
            this.DescriptionColumn1.Name = "DescriptionColumn1";
            this.DescriptionColumn1.Width = 200;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Subcategory";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.HeaderText = "Category";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // IDColumn2
            // 
            this.IDColumn2.HeaderText = "ID";
            this.IDColumn2.Name = "IDColumn2";
            this.IDColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.Width = 200;
            // 
            // WSU_Apparel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(983, 611);
            this.Controls.Add(this.btnUpdateDiscount);
            this.Controls.Add(this.dgvDiscounts);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblShopping);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cboBoxSize);
            this.Controls.Add(this.cboBoxGender);
            this.Controls.Add(this.lblDiscountType);
            this.Controls.Add(this.cboBoxDiscount);
            this.Controls.Add(this.dgvShoppingCart);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.treeViewInventory);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCheckout);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "WSU_Apparel_Form";
            this.Text = "WSU Apparel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TreeView treeViewInventory;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.DataGridView dgvShoppingCart;
        private System.Windows.Forms.ComboBox cboBoxDiscount;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.ComboBox cboBoxGender;
        private System.Windows.Forms.ComboBox cboBoxSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblShopping;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.Button btnUpdateDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    }
}

