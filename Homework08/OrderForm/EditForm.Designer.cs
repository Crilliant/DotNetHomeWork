namespace OrderForm
{
    partial class EditForm
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
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_editDetails = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addDetails = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_deleteDetail = new System.Windows.Forms.Button();
            this.groupBox_basicInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_orderID_value = new System.Windows.Forms.Label();
            this.cbb_customer_value = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_dealTime = new System.Windows.Forms.Label();
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_editDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.groupBox_basicInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBox_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(OrderForm.OrderDetails);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderForm.Order);
            // 
            // dataGridView_editDetails
            // 
            this.dataGridView_editDetails.AutoGenerateColumns = false;
            this.dataGridView_editDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_editDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Number,
            this.Discount,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView_editDetails.DataSource = this.orderDetailsBindingSource;
            this.dataGridView_editDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_editDetails.Location = new System.Drawing.Point(3, 24);
            this.dataGridView_editDetails.Name = "dataGridView_editDetails";
            this.dataGridView_editDetails.RowHeadersWidth = 62;
            this.dataGridView_editDetails.RowTemplate.Height = 30;
            this.dataGridView_editDetails.Size = new System.Drawing.Size(824, 253);
            this.dataGridView_editDetails.TabIndex = 1;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "商品";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.Width = 150;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "数量";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.Width = 150;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.MinimumWidth = 8;
            this.Discount.Name = "Discount";
            this.Discount.Width = 150;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // nudNum
            // 
            this.nudNum.Location = new System.Drawing.Point(149, 93);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(120, 28);
            this.nudNum.TabIndex = 9;
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Location = new System.Drawing.Point(295, 93);
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.Size = new System.Drawing.Size(100, 28);
            this.txtBoxDiscount.TabIndex = 8;
            // 
            // cbxProduct
            // 
            this.cbxProduct.DataSource = this.productBindingSource;
            this.cbxProduct.DisplayMember = "Name";
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(3, 93);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(121, 26);
            this.cbxProduct.TabIndex = 6;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(OrderForm.Product);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(295, 30);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(44, 18);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "折扣";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(149, 30);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 18);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "数量";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(3, 30);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(80, 18);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "商品名称";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.pnlDetails.SetColumnSpan(this.lblDetails, 2);
            this.lblDetails.Location = new System.Drawing.Point(3, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(116, 18);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "编辑订单明细";
            // 
            // pnlDetails
            // 
            this.pnlDetails.ColumnCount = 6;
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlDetails.Controls.Add(this.btn_addDetails, 4, 1);
            this.pnlDetails.Controls.Add(this.lblDetails, 0, 0);
            this.pnlDetails.Controls.Add(this.lblProduct, 0, 1);
            this.pnlDetails.Controls.Add(this.lblNum, 1, 1);
            this.pnlDetails.Controls.Add(this.lblDiscount, 2, 1);
            this.pnlDetails.Controls.Add(this.cbxProduct, 0, 2);
            this.pnlDetails.Controls.Add(this.txtBoxDiscount, 2, 2);
            this.pnlDetails.Controls.Add(this.nudNum, 1, 2);
            this.pnlDetails.Controls.Add(this.btn_modify, 3, 1);
            this.pnlDetails.Controls.Add(this.btn_exit, 3, 2);
            this.pnlDetails.Controls.Add(this.btn_deleteDetail, 5, 1);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetails.Location = new System.Drawing.Point(0, 462);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.RowCount = 3;
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDetails.Size = new System.Drawing.Size(830, 150);
            this.pnlDetails.TabIndex = 0;
            // 
            // btn_addDetails
            // 
            this.btn_addDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addDetails.Location = new System.Drawing.Point(589, 35);
            this.btn_addDetails.Margin = new System.Windows.Forms.Padding(5);
            this.btn_addDetails.Name = "btn_addDetails";
            this.btn_addDetails.Size = new System.Drawing.Size(136, 50);
            this.btn_addDetails.TabIndex = 12;
            this.btn_addDetails.Text = "添加";
            this.btn_addDetails.UseVisualStyleBackColor = true;
            this.btn_addDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_modify.Location = new System.Drawing.Point(443, 35);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(5);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(136, 50);
            this.btn_modify.TabIndex = 10;
            this.btn_modify.Text = "修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_exit
            // 
            this.pnlDetails.SetColumnSpan(this.btn_exit, 3);
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exit.Location = new System.Drawing.Point(443, 95);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(382, 50);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "保存";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_deleteDetail
            // 
            this.btn_deleteDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_deleteDetail.Location = new System.Drawing.Point(733, 33);
            this.btn_deleteDetail.Name = "btn_deleteDetail";
            this.btn_deleteDetail.Size = new System.Drawing.Size(94, 54);
            this.btn_deleteDetail.TabIndex = 13;
            this.btn_deleteDetail.Text = "删除";
            this.btn_deleteDetail.UseVisualStyleBackColor = true;
            this.btn_deleteDetail.Click += new System.EventHandler(this.btn_deleteDetail_Click);
            // 
            // groupBox_basicInfo
            // 
            this.groupBox_basicInfo.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_basicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_basicInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBox_basicInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox_basicInfo.Name = "groupBox_basicInfo";
            this.groupBox_basicInfo.Size = new System.Drawing.Size(830, 182);
            this.groupBox_basicInfo.TabIndex = 2;
            this.groupBox_basicInfo.TabStop = false;
            this.groupBox_basicInfo.Text = "基本信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbl_orderID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_customer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_time, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_orderID_value, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbb_customer_value, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dealTime, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_orderID.Location = new System.Drawing.Point(3, 0);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(194, 51);
            this.lbl_orderID.TabIndex = 0;
            this.lbl_orderID.Text = "订单号";
            // 
            // lbl_customer
            // 
            this.lbl_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Location = new System.Drawing.Point(3, 67);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(194, 18);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "顾客";
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(0, 119);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(200, 18);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "下单时间";
            // 
            // lbl_orderID_value
            // 
            this.lbl_orderID_value.AutoSize = true;
            this.lbl_orderID_value.Location = new System.Drawing.Point(203, 0);
            this.lbl_orderID_value.Name = "lbl_orderID_value";
            this.lbl_orderID_value.Size = new System.Drawing.Size(17, 18);
            this.lbl_orderID_value.TabIndex = 3;
            this.lbl_orderID_value.Text = "0";
            // 
            // cbb_customer_value
            // 
            this.cbb_customer_value.DataSource = this.customerBindingSource;
            this.cbb_customer_value.DisplayMember = "Name";
            this.cbb_customer_value.FormattingEnabled = true;
            this.cbb_customer_value.Location = new System.Drawing.Point(203, 54);
            this.cbb_customer_value.Name = "cbb_customer_value";
            this.cbb_customer_value.Size = new System.Drawing.Size(121, 26);
            this.cbb_customer_value.TabIndex = 4;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(OrderForm.Customer);
            // 
            // lbl_dealTime
            // 
            this.lbl_dealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dealTime.AutoSize = true;
            this.lbl_dealTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "DealTime", true));
            this.lbl_dealTime.Location = new System.Drawing.Point(203, 119);
            this.lbl_dealTime.Name = "lbl_dealTime";
            this.lbl_dealTime.Size = new System.Drawing.Size(618, 18);
            this.lbl_dealTime.TabIndex = 5;
            this.lbl_dealTime.Text = "2022-4-29";
            // 
            // groupBox_details
            // 
            this.groupBox_details.Controls.Add(this.dataGridView_editDetails);
            this.groupBox_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_details.Location = new System.Drawing.Point(0, 182);
            this.groupBox_details.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.groupBox_details.Name = "groupBox_details";
            this.groupBox_details.Size = new System.Drawing.Size(830, 280);
            this.groupBox_details.TabIndex = 3;
            this.groupBox_details.TabStop = false;
            this.groupBox_details.Text = "订单明细";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 612);
            this.Controls.Add(this.groupBox_details);
            this.Controls.Add(this.groupBox_basicInfo);
            this.Controls.Add(this.pnlDetails);
            this.Name = "EditForm";
            this.Text = "编辑窗口";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_editDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.groupBox_basicInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBox_details.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_editDetails;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.TextBox txtBoxDiscount;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TableLayoutPanel pnlDetails;
        private System.Windows.Forms.GroupBox groupBox_basicInfo;
        private System.Windows.Forms.GroupBox groupBox_details;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_orderID_value;
        private System.Windows.Forms.ComboBox cbb_customer_value;
        private System.Windows.Forms.Label lbl_dealTime;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_addDetails;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_deleteDetail;
    }
}