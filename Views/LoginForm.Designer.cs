namespace BookHeaven.Views
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            lblSubTitle = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(504, 232);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(352, 30);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            txtUsername.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(504, 284);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(352, 30);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(552, 369);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(238, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(552, 336);
            lblError.Name = "lblError";
            lblError.Size = new Size(238, 16);
            lblError.TabIndex = 6;
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.DimGray;
            lblSubTitle.Location = new Point(566, 137);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(182, 23);
            lblSubTitle.TabIndex = 5;
            lblSubTitle.Text = "Secure. Simple. Smart.";
            lblSubTitle.Click += lblwelcme2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BookHaven.Properties.Resources.Bookshop_cuate;
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 87);
            label1.Name = "label1";
            label1.Size = new Size(288, 50);
            label1.TabIndex = 7;
            label1.Text = "BookHaven";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 515);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblError);
            Controls.Add(lblSubTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += ULoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblSubTitle;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
