namespace BookHeaven.Views
{
    partial class OrderManagementForm
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
            components = new System.ComponentModel.Container();
            dataGridViewOrders = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            lblInvoice = new Label();
            lblOrderId = new Label();
            txtOrderId = new TextBox();
            lblDate = new Label();
            txtDate = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            lblCustomer = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmBook = new ComboBox();
            lblCustId = new Label();
            txtCustId = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblConatctNo = new Label();
            txtContact = new TextBox();
            lblItemDetails = new Label();
            lblItemId = new Label();
            lblBook = new Label();
            cmbCustomer = new ComboBox();
            txtIBookId = new TextBox();
            txtBookName = new TextBox();
            lblBookName = new Label();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblAvailable = new Label();
            txtAvailable = new TextBox();
            btnAdd = new Button();
            lblGrossTotal = new Label();
            txtGrossTotal = new TextBox();
            lblNetTotal = new Label();
            txtNetTotal = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            btnPlaceOrder = new Button();
            lblQty = new Label();
            txtQty = new TextBox();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            btnBack = new Button();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOrders.BorderStyle = BorderStyle.None;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPrice, colQuantity, colTotal, colDelete });
            dataGridViewOrders.Location = new Point(41, 615);
            dataGridViewOrders.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(1518, 135);
            dataGridViewOrders.TabIndex = 1;
            dataGridViewOrders.CellContentClick += dataGridViewOrdersClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // lblInvoice
            // 
            lblInvoice.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoice.Location = new Point(41, 90);
            lblInvoice.Margin = new Padding(4, 0, 4, 0);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(381, 28);
            lblInvoice.TabIndex = 2;
            lblInvoice.Text = "Invoice Details";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblOrderId.Location = new Point(50, 143);
            lblOrderId.Margin = new Padding(4, 0, 4, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(77, 20);
            lblOrderId.TabIndex = 3;
            lblOrderId.Text = "OrderId ";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(50, 165);
            txtOrderId.Margin = new Padding(4, 3, 4, 3);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(180, 27);
            txtOrderId.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblDate.Location = new Point(258, 141);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 20);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date ";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(258, 165);
            txtDate.Margin = new Padding(4, 3, 4, 3);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(202, 27);
            txtDate.TabIndex = 6;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblCustomer.Location = new Point(503, 141);
            lblCustomer.Margin = new Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(93, 20);
            lblCustomer.TabIndex = 7;
            lblCustomer.Text = "Customer ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cmBook
            // 
            cmBook.FormattingEnabled = true;
            cmBook.Location = new Point(52, 296);
            cmBook.Margin = new Padding(4, 3, 4, 3);
            cmBook.Name = "cmBook";
            cmBook.Size = new Size(180, 28);
            cmBook.TabIndex = 9;
            cmBook.SelectedIndexChanged += cmBookIndexChanged;
            // 
            // lblCustId
            // 
            lblCustId.AutoSize = true;
            lblCustId.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblCustId.Location = new Point(793, 144);
            lblCustId.Margin = new Padding(4, 0, 4, 0);
            lblCustId.Name = "lblCustId";
            lblCustId.Size = new Size(29, 20);
            lblCustId.TabIndex = 10;
            lblCustId.Text = "Id ";
            // 
            // txtCustId
            // 
            txtCustId.Location = new Point(793, 167);
            txtCustId.Margin = new Padding(4, 3, 4, 3);
            txtCustId.Name = "txtCustId";
            txtCustId.ReadOnly = true;
            txtCustId.Size = new Size(170, 27);
            txtCustId.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblEmail.Location = new Point(1022, 147);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1022, 167);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 13;
            // 
            // lblConatctNo
            // 
            lblConatctNo.AutoSize = true;
            lblConatctNo.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblConatctNo.Location = new Point(1305, 147);
            lblConatctNo.Margin = new Padding(4, 0, 4, 0);
            lblConatctNo.Name = "lblConatctNo";
            lblConatctNo.Size = new Size(105, 20);
            lblConatctNo.TabIndex = 14;
            lblConatctNo.Text = "Conatct No ";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(1305, 167);
            txtContact.Margin = new Padding(4, 3, 4, 3);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(230, 27);
            txtContact.TabIndex = 15;
            // 
            // lblItemDetails
            // 
            lblItemDetails.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemDetails.Location = new Point(41, 234);
            lblItemDetails.Margin = new Padding(4, 0, 4, 0);
            lblItemDetails.Name = "lblItemDetails";
            lblItemDetails.Size = new Size(302, 28);
            lblItemDetails.TabIndex = 16;
            lblItemDetails.Text = "Item Details";
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblItemId.Location = new Point(283, 273);
            lblItemId.Margin = new Padding(4, 0, 4, 0);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(29, 20);
            lblItemId.TabIndex = 17;
            lblItemId.Text = "Id ";
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblBook.Location = new Point(52, 273);
            lblBook.Margin = new Padding(4, 0, 4, 0);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(55, 20);
            lblBook.TabIndex = 18;
            lblBook.Text = "Book ";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(503, 165);
            cmbCustomer.Margin = new Padding(4, 3, 4, 3);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(216, 28);
            cmbCustomer.TabIndex = 19;
            cmbCustomer.SelectedIndexChanged += cmbCustomerIndexChange;
            // 
            // txtIBookId
            // 
            txtIBookId.Location = new Point(283, 296);
            txtIBookId.Margin = new Padding(4, 3, 4, 3);
            txtIBookId.Name = "txtIBookId";
            txtIBookId.ReadOnly = true;
            txtIBookId.Size = new Size(148, 27);
            txtIBookId.TabIndex = 20;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(506, 297);
            txtBookName.Margin = new Padding(4, 3, 4, 3);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(308, 27);
            txtBookName.TabIndex = 21;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblBookName.Location = new Point(506, 273);
            lblBookName.Margin = new Padding(4, 0, 4, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(61, 20);
            lblBookName.TabIndex = 22;
            lblBookName.Text = "Name ";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblUnitPrice.Location = new Point(880, 275);
            lblUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(98, 20);
            lblUnitPrice.TabIndex = 23;
            lblUnitPrice.Text = "Unit Price  ";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(880, 297);
            txtUnitPrice.Margin = new Padding(4, 3, 4, 3);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(232, 27);
            txtUnitPrice.TabIndex = 24;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblAvailable.Location = new Point(1173, 273);
            lblAvailable.Margin = new Padding(4, 0, 4, 0);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(94, 20);
            lblAvailable.TabIndex = 25;
            lblAvailable.Text = "Available  ";
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(1173, 297);
            txtAvailable.Margin = new Padding(4, 3, 4, 3);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.Size = new Size(170, 27);
            txtAvailable.TabIndex = 26;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(1380, 407);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 43);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddClick;
            // 
            // lblGrossTotal
            // 
            lblGrossTotal.AutoSize = true;
            lblGrossTotal.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblGrossTotal.Location = new Point(53, 385);
            lblGrossTotal.Margin = new Padding(4, 0, 4, 0);
            lblGrossTotal.Name = "lblGrossTotal";
            lblGrossTotal.Size = new Size(111, 20);
            lblGrossTotal.TabIndex = 28;
            lblGrossTotal.Text = "Gross Total  ";
            lblGrossTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGrossTotal
            // 
            txtGrossTotal.Location = new Point(279, 379);
            txtGrossTotal.Margin = new Padding(4, 3, 4, 3);
            txtGrossTotal.Name = "txtGrossTotal";
            txtGrossTotal.ReadOnly = true;
            txtGrossTotal.Size = new Size(192, 27);
            txtGrossTotal.TabIndex = 29;
            // 
            // lblNetTotal
            // 
            lblNetTotal.AutoSize = true;
            lblNetTotal.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblNetTotal.Location = new Point(53, 480);
            lblNetTotal.Margin = new Padding(4, 0, 4, 0);
            lblNetTotal.Name = "lblNetTotal";
            lblNetTotal.Size = new Size(92, 20);
            lblNetTotal.TabIndex = 30;
            lblNetTotal.Text = "Net Total  ";
            lblNetTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNetTotal
            // 
            txtNetTotal.Location = new Point(279, 473);
            txtNetTotal.Margin = new Padding(4, 3, 4, 3);
            txtNetTotal.Name = "txtNetTotal";
            txtNetTotal.ReadOnly = true;
            txtNetTotal.Size = new Size(192, 27);
            txtNetTotal.TabIndex = 31;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblDiscount.Location = new Point(53, 435);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(90, 20);
            lblDiscount.TabIndex = 32;
            lblDiscount.Text = "Discount  ";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(279, 428);
            txtDiscount.Margin = new Padding(4, 3, 4, 3);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(192, 27);
            txtDiscount.TabIndex = 33;
            txtDiscount.KeyDown += txtDiscountKeyDown;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(40, 167, 69);
            btnPlaceOrder.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlaceOrder.ForeColor = SystemColors.Window;
            btnPlaceOrder.Location = new Point(533, 501);
            btnPlaceOrder.Margin = new Padding(4, 3, 4, 3);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(221, 43);
            btnPlaceOrder.TabIndex = 34;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblQty.Location = new Point(1383, 273);
            lblQty.Margin = new Padding(4, 0, 4, 0);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(86, 20);
            lblQty.TabIndex = 36;
            lblQty.Text = "Quantity  ";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(1383, 297);
            txtQty.Margin = new Padding(4, 3, 4, 3);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(170, 27);
            txtQty.TabIndex = 37;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(279, 519);
            cmbStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(192, 28);
            cmbStatus.TabIndex = 38;
            cmbStatus.SelectedIndexChanged += CmbStatusIndexChange;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblStatus.Location = new Point(53, 519);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 20);
            lblStatus.TabIndex = 39;
            lblStatus.Text = "Status ";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(1394, 807);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(175, 43);
            btnBack.TabIndex = 40;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelName
            // 
            labelName.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(443, 9);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(747, 67);
            labelName.TabIndex = 41;
            labelName.Text = "Order Management";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1680, 895);
            Controls.Add(labelName);
            Controls.Add(btnBack);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(txtQty);
            Controls.Add(lblQty);
            Controls.Add(btnPlaceOrder);
            Controls.Add(txtDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(txtNetTotal);
            Controls.Add(lblNetTotal);
            Controls.Add(txtGrossTotal);
            Controls.Add(lblGrossTotal);
            Controls.Add(btnAdd);
            Controls.Add(txtAvailable);
            Controls.Add(lblAvailable);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblBookName);
            Controls.Add(txtBookName);
            Controls.Add(txtIBookId);
            Controls.Add(cmbCustomer);
            Controls.Add(lblBook);
            Controls.Add(lblItemId);
            Controls.Add(lblItemDetails);
            Controls.Add(txtContact);
            Controls.Add(lblConatctNo);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtCustId);
            Controls.Add(lblCustId);
            Controls.Add(cmBook);
            Controls.Add(lblCustomer);
            Controls.Add(txtDate);
            Controls.Add(lblDate);
            Controls.Add(txtOrderId);
            Controls.Add(lblOrderId);
            Controls.Add(lblInvoice);
            Controls.Add(dataGridViewOrders);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "OrderManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblInvoice;
        private Label lblOrderId;
        private TextBox txtOrderId;
        private Label lblDate;
        private TextBox txtDate;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label lblCustomer;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cmBook;
        private Label lblCustId;
        private TextBox txtCustId;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblConatctNo;
        private TextBox txtContact;
        private Label lblItemDetails;
        private Label lblItemId;
        private Label lblBook;
        private ComboBox cmbCustomer;
        private TextBox txtIBookId;
        private TextBox txtBookName;
        private Label lblBookName;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblAvailable;
        private TextBox txtAvailable;
        private Button btnAdd;
        private Label lblGrossTotal;
        private TextBox txtGrossTotal;
        private Label lblNetTotal;
        private TextBox txtNetTotal;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Button btnPlaceOrder;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewButtonColumn colDelete;
        private DataGridView dataGridViewOrders;
        private Label lblQty;
        private TextBox txtQty;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Button btnBack;
        private Label labelName;
    }
}