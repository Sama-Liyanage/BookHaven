namespace BookHeaven.Views
{
    partial class Reports
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnBestSelling = new Button();
            Inventory = new Button();
            btnBestcustomer = new Button();
            dgvReports = new DataGridView();
            labelName = new Label();
            btnBack = new Button();
            btnDownload = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBestSelling
            // 
            btnBestSelling.BackColor = Color.RoyalBlue;
            btnBestSelling.Font = new Font("Arial Rounded MT Bold", 12F);
            btnBestSelling.ForeColor = SystemColors.Window;
            btnBestSelling.Location = new Point(389, 183);
            btnBestSelling.Name = "btnBestSelling";
            btnBestSelling.Size = new Size(191, 43);
            btnBestSelling.TabIndex = 3;
            btnBestSelling.Text = "Top Buyer";
            btnBestSelling.UseVisualStyleBackColor = false;
            btnBestSelling.Click += btnBestSelling_Click;
            // 
            // Inventory
            // 
            Inventory.BackColor = Color.RoyalBlue;
            Inventory.Font = new Font("Arial Rounded MT Bold", 12F);
            Inventory.ForeColor = SystemColors.Window;
            Inventory.Location = new Point(133, 183);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(186, 43);
            Inventory.TabIndex = 4;
            Inventory.Text = "Stock";
            Inventory.UseVisualStyleBackColor = false;
            Inventory.Click += Inventory_Click;
            // 
            // btnBestcustomer
            // 
            btnBestcustomer.BackColor = Color.RoyalBlue;
            btnBestcustomer.Font = new Font("Arial Rounded MT Bold", 12F);
            btnBestcustomer.ForeColor = SystemColors.Window;
            btnBestcustomer.Location = new Point(665, 183);
            btnBestcustomer.Name = "btnBestcustomer";
            btnBestcustomer.Size = new Size(209, 43);
            btnBestcustomer.TabIndex = 5;
            btnBestcustomer.Text = "Best Customer";
            btnBestcustomer.UseVisualStyleBackColor = false;
            btnBestcustomer.Click += btnBestcustomer_Click;
            // 
            // dgvReports
            // 
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReports.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReports.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReports.Location = new Point(119, 276);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.RowTemplate.Height = 30;
            dgvReports.Size = new Size(766, 186);
            dgvReports.TabIndex = 9;
            dgvReports.Visible = false;
            // 
            // labelName
            // 
            labelName.BackColor = SystemColors.Window;
            labelName.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(231, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(529, 66);
            labelName.TabIndex = 10;
            labelName.Text = "Reports";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(758, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 43);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Teal;
            btnDownload.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnDownload.ForeColor = SystemColors.Window;
            btnDownload.Location = new Point(598, 521);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(127, 43);
            btnDownload.TabIndex = 12;
            btnDownload.Text = "Export";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BookHaven.Properties.Resources.Report_cuate;
            pictureBox1.Location = new Point(5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(985, 611);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(989, 608);
            Controls.Add(btnDownload);
            Controls.Add(btnBack);
            Controls.Add(labelName);
            Controls.Add(btnBestcustomer);
            Controls.Add(Inventory);
            Controls.Add(btnBestSelling);
            Controls.Add(dgvReports);
            Controls.Add(pictureBox1);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Splitter splitter1;
        private Button btnBestSelling;
        private Button Inventory;
        private Button btnBestcustomer;
        private DataGridView dgvReports;
        private Label labelName;
        private Button btnBack;
        private Button btnDownload;
        private PictureBox pictureBox1;
    }
}