using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using BookHaven.Controllers;
using BookHeaven.Models;
using BookHeaven.Models.Repository.Interfaces;
using BookHeaven.Models.Repository;
using BookHaven.Models.Services;
using BookHeaven.Views; // Added controllers

namespace BookHeaven
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = new ServiceCollection()
               .AddDbContext<BookHavenDbContext>(options =>
                   options.UseMySQL("server=localhost;database=bookhavendb;user=root;password=1234;"))
               .AddScoped<IBookRepository, BookRepository>()
               .AddScoped<ICustomerRepository, CustomerRepository>()
               .AddScoped<IOrderRepository, OrderRepository>()
               .AddScoped<ISupplierRepository, SupplierRepository>()
               .AddScoped<IUserRepository, UserRepository>()
               .AddScoped<BookService>()
               .AddScoped<CustomerService>()
               .AddScoped<OrderService>()
               .AddScoped<SupplierService>()
               .AddScoped<UserService>()
               .AddScoped<BookController>() // Register controllers
               .AddScoped<CustomerController>()
               .AddScoped<OrderController>()
               .AddScoped<SupplierController>()
               .AddScoped<UserController>()
               .BuildServiceProvider();

            ServiceProvider = serviceProvider;

            var loginForm = new LoginForm(serviceProvider.GetRequiredService<UserService>());

            Application.Run(loginForm);
        }
    }
}
