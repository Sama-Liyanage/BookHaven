using BookHeaven.Models.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookHaven.Models.Services;

namespace BookHeaven.Views
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        // Opens Employee Management form
        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            var userService = Program.ServiceProvider.GetRequiredService<UserService>();
            var staffForm = new EmployeeForm(userService);
            staffForm.Show();
            this.Hide();
        }

        // Opens Book Inventory form
        private void btnBookInventory_Click(object sender, EventArgs e)
        {
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var bookForm = new BookForm(bookService, UserRole.Admin);
            bookForm.Show();
            this.Hide();
        }

        // Opens Customer Management form
        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var customerForm = new CustomerForm(customerService, UserRole.Admin);
            customerForm.Show();
            this.Hide();
        }

        // Opens Sales Transactions form
        private void btnSalesTransactions_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var salesForm = new SalesForm(orderService, UserRole.Admin);
            salesForm.Show();
            this.Hide();
        }

        // Opens Order Management form
        private void btnOrdersManagement_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var orderForm = new OrderManagementForm(orderService, customerService, bookService, UserRole.Admin);
            orderForm.Show();
            this.Hide();
        }

        // Opens Supplier Management form
        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            var supplierService = Program.ServiceProvider.GetRequiredService<SupplierService>();
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var supplierForm = new SupplierForm(supplierService, bookService);
            supplierForm.Show();
            this.Hide();
        }

        // Opens Reports
        private void btnReport_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var dashboard = new Reports(bookService, customerService, orderService);
            dashboard.Show();
            this.Hide();
        }

        // Logs out and returns to the Login form
        private void btnLogOutClick(object sender, EventArgs e)
        {
            var userService = Program.ServiceProvider.GetRequiredService<UserService>();
            var loginForm = new LoginForm(userService);
            loginForm.Show();
            this.Hide();
        }
    }
}
