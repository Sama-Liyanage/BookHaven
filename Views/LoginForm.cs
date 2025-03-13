using BookHaven.Models.Services;
using BookHeaven.Models.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHeaven.Views
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            if (username.Length < 3 || password.Length < 3)
            {
                lblError.Text = "Username and password must be at least 3 characters long.";
                return;
            }

            var user = await _userService.ValidateUserAsync(username, password);
            if (user != null)
            {
                lblError.Text = "";

                var userExist = await _userService.ValidateUserAsync(username, password);
                if (userExist != null)
                {
                    if (userExist.Role == UserRole.Admin) {
                        var adminForm = new AdminDashboardForm();
                        adminForm.Show();
                        this.Hide();
                    }

                    if (userExist.Role == UserRole.SalesClerk) {
                        var clerkForm = new ClerkDashboardForm();
                        clerkForm.Show();
                        this.Hide();
                    }

                    
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");

                }

            }
            else
            {
                lblError.Text = "Invalid email or password.";
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblwelcme2_Click(object sender, EventArgs e)
        {

        }

        private void ULoginForm_Load(object sender, EventArgs e)
        {

        }

       

     
    }
}
