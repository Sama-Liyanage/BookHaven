using BookHaven.Models.Services;
using BookHeaven.Models.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven.Views
{
    public partial class ClerkDashboardForm : Form
    {
        public ClerkDashboardForm()
        {
            InitializeComponent();
        }


        //Opens the Order Management form and hides the current form.
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();

            // Creating and opening the Order Management form
            var orderForm = new OrderManagementForm(orderService, customerService, bookService, UserRole.SalesClerk);
            orderForm.Show();
            this.Hide();// Hides the current dashboard form
        }


        // Event handler for 'Customer Management' button click
        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var customerForm = new CustomerForm(customerService, UserRole.SalesClerk);
            customerForm.Show();
            this.Hide();
        }

        // Event handler for 'Book Management' button click
        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var bookForm = new BookForm(bookService, UserRole.SalesClerk);
            bookForm.Show();
            this.Hide();
        }

        // Event handler for 'Sales Transactions' button click
        private void btnSalesTransaction_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var salesForm = new SalesForm(orderService, UserRole.SalesClerk);
            salesForm.Show();
            this.Hide();
        }

        // Event handler for 'LogOut' button click
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var userService = Program.ServiceProvider.GetRequiredService<UserService>();
            var loginForm = new LoginForm(userService);
            loginForm.Show();
            this.Hide();
        }

       
    }
}