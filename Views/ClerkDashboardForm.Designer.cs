namespace BookHeaven.Views
{
    partial class ClerkDashboardForm
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
            btnOrderManagement = new Button();
            btnSalesTransaction = new Button();
            btnCustomerManagement = new Button();
            btnBookManagement = new Button();
            btnLogOut = new Button();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.BackColor = Color.MediumOrchid;
            btnOrderManagement.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnOrderManagement.ForeColor = SystemColors.Window;
            btnOrderManagement.Location = new Point(58, 356);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(285, 56);
            btnOrderManagement.TabIndex = 5;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = false;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // btnSalesTransaction
            // 
            btnSalesTransaction.BackColor = Color.MediumOrchid;
            btnSalesTransaction.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnSalesTransaction.ForeColor = SystemColors.Window;
            btnSalesTransaction.Location = new Point(58, 405);
            btnSalesTransaction.Name = "btnSalesTransaction";
            btnSalesTransaction.Size = new Size(285, 59);
            btnSalesTransaction.TabIndex = 6;
            btnSalesTransaction.Text = "Sales Transactions";
            btnSalesTransaction.UseVisualStyleBackColor = false;
            btnSalesTransaction.Click += btnSalesTransaction_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.MediumOrchid;
            btnCustomerManagement.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnCustomerManagement.ForeColor = SystemColors.Window;
            btnCustomerManagement.Location = new Point(58, 306);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(285, 51);
            btnCustomerManagement.TabIndex = 7;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnBookManagement
            // 
            btnBookManagement.BackColor = Color.MediumOrchid;
            btnBookManagement.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnBookManagement.ForeColor = SystemColors.Window;
            btnBookManagement.Location = new Point(58, 246);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(285, 62);
            btnBookManagement.TabIndex = 8;
            btnBookManagement.Text = "Book Management";
            btnBookManagement.UseVisualStyleBackColor = false;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(235, 87, 87);
            btnLogOut.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnLogOut.ForeColor = SystemColors.Window;
            btnLogOut.Location = new Point(58, 459);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(285, 60);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // labelName
            // 
            labelName.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(193, 21);
            labelName.Name = "labelName";
            labelName.Size = new Size(631, 66);
            labelName.TabIndex = 11;
            labelName.Text = "Sales Clerk Dshboard";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BookHaven.Properties.Resources.Bookshop_rafiki1;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(990, 614);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ClerkDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(989, 608);
            Controls.Add(labelName);
            Controls.Add(btnLogOut);
            Controls.Add(btnBookManagement);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnSalesTransaction);
            Controls.Add(btnOrderManagement);
            Controls.Add(pictureBox1);
            Name = "ClerkDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClerkDashboardForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // UI Component Declarations
        private Button btnOrderManagement;
        private Button btnSalesTransaction;
        private Button btnCustomerManagement;
        private Button btnBookManagement;
        private Button btnLogOut;
        private Label labelName;
        private PictureBox pictureBox1;
    }
}