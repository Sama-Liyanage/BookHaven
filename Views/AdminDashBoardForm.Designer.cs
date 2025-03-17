namespace BookHeaven.Views
{
    partial class AdminDashboardForm
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
            btnEmployeeManagement = new Button();
            btnBookInventory = new Button();
            btnCustomerManagement = new Button();
            btnSalesTransactions = new Button();
            btnOrdersManagement = new Button();
            btnSupplierManagement = new Button();
            btnReport = new Button();
            btnLogOut = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEmployeeManagement
            // 
            btnEmployeeManagement.BackColor = SystemColors.MenuHighlight;
            btnEmployeeManagement.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnEmployeeManagement.ForeColor = SystemColors.Window;
            btnEmployeeManagement.Location = new Point(0, 252);
            btnEmployeeManagement.Name = "btnEmployeeManagement";
            btnEmployeeManagement.Size = new Size(226, 62);
            btnEmployeeManagement.TabIndex = 0;
            btnEmployeeManagement.Text = "Employee Management";
            btnEmployeeManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeManagement.UseVisualStyleBackColor = false;
            btnEmployeeManagement.Click += btnEmployeeManagement_Click;
            // 
            // btnBookInventory
            // 
            btnBookInventory.BackColor = SystemColors.MenuHighlight;
            btnBookInventory.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnBookInventory.ForeColor = SystemColors.Window;
            btnBookInventory.Location = new Point(0, 85);
            btnBookInventory.Name = "btnBookInventory";
            btnBookInventory.Size = new Size(226, 62);
            btnBookInventory.TabIndex = 1;
            btnBookInventory.Text = "Book Inventory";
            btnBookInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnBookInventory.UseVisualStyleBackColor = false;
            btnBookInventory.Click += btnBookInventory_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = SystemColors.MenuHighlight;
            btnCustomerManagement.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnCustomerManagement.ForeColor = SystemColors.Window;
            btnCustomerManagement.Location = new Point(0, 139);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(226, 62);
            btnCustomerManagement.TabIndex = 2;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnSalesTransactions
            // 
            btnSalesTransactions.BackColor = SystemColors.MenuHighlight;
            btnSalesTransactions.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnSalesTransactions.ForeColor = SystemColors.Window;
            btnSalesTransactions.Location = new Point(0, 364);
            btnSalesTransactions.Name = "btnSalesTransactions";
            btnSalesTransactions.Size = new Size(226, 62);
            btnSalesTransactions.TabIndex = 3;
            btnSalesTransactions.Text = "Sales Transactions";
            btnSalesTransactions.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesTransactions.UseVisualStyleBackColor = false;
            btnSalesTransactions.Click += btnSalesTransactions_Click;
            // 
            // btnOrdersManagement
            // 
            btnOrdersManagement.BackColor = SystemColors.MenuHighlight;
            btnOrdersManagement.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnOrdersManagement.ForeColor = SystemColors.Window;
            btnOrdersManagement.Location = new Point(0, 306);
            btnOrdersManagement.Name = "btnOrdersManagement";
            btnOrdersManagement.Size = new Size(226, 62);
            btnOrdersManagement.TabIndex = 4;
            btnOrdersManagement.Text = "Order Management";
            btnOrdersManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnOrdersManagement.UseVisualStyleBackColor = false;
            btnOrdersManagement.Click += btnOrdersManagement_Click;
            // 
            // btnSupplierManagement
            // 
            btnSupplierManagement.BackColor = SystemColors.MenuHighlight;
            btnSupplierManagement.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnSupplierManagement.ForeColor = SystemColors.Window;
            btnSupplierManagement.Location = new Point(0, 198);
            btnSupplierManagement.Name = "btnSupplierManagement";
            btnSupplierManagement.Size = new Size(226, 62);
            btnSupplierManagement.TabIndex = 5;
            btnSupplierManagement.Text = "Supplier Management";
            btnSupplierManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnSupplierManagement.UseVisualStyleBackColor = false;
            btnSupplierManagement.Click += btnSupplierManagement_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = SystemColors.MenuHighlight;
            btnReport.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnReport.ForeColor = SystemColors.Window;
            btnReport.Location = new Point(0, 419);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(226, 62);
            btnReport.TabIndex = 6;
            btnReport.Text = "Reports";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(235, 87, 87);
            btnLogOut.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnLogOut.ForeColor = SystemColors.Window;
            btnLogOut.Location = new Point(0, 474);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(226, 60);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOutClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BookHaven.Properties.Resources.Revenue_cuate;
            pictureBox1.Location = new Point(157, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 2);
            label1.Name = "label1";
            label1.Size = new Size(543, 66);
            label1.TabIndex = 9;
            label1.Text = "Admin Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Window;
            ClientSize = new Size(900, 530);
            Controls.Add(label1);
            Controls.Add(btnLogOut);
            Controls.Add(btnReport);
            Controls.Add(btnSupplierManagement);
            Controls.Add(btnOrdersManagement);
            Controls.Add(btnSalesTransactions);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnBookInventory);
            Controls.Add(btnEmployeeManagement);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // UI Components
        private Button btnEmployeeManagement;
        private Button btnBookInventory;
        private Button btnCustomerManagement;
        private Button btnSalesTransactions;
        private Button btnOrdersManagement;
        private Button btnSupplierManagement;
        private Button btnReport;
        private Button btnLogOut;
        private PictureBox pictureBox1;
        private Label label1;
    }
}