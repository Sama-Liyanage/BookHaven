using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHaven.Models.Services;
using BookHeaven.Models.Entity;

namespace BookHaven.Controllers
{
    public class CustomerController
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        // Get all customers
        public async Task<List<Customer>> GetAllCustomers()
        {
            return (List<Customer>)await _customerService.GetAllCustomers();
        }

        // Get customer by their ID
        public async Task<Customer?> GetCustomerById(Guid id)
        {
            return await _customerService.GetCustomer(id);
        }

        // Search customers by a keyword
        public async Task<List<Customer>> SearchCustomers(string keyword)
        {
            return (List<Customer>)await _customerService.SearchBooks(keyword); // Possible typo: Should it be SearchCustomers?
        }

        // Add a new customer
        public async Task<bool> AddCustomer(Customer customer)
        {
            try
            {
                await _customerService.AddCustomer(customer);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding customer: {ex.Message}");
                return false;
            }
        }

        // Update an existing customer
        public async Task<bool> UpdateCustomer(Customer customer)
        {
            try
            {
                var result = await _customerService.UpdateCustomer(customer);
                return result != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating customer: {ex.Message}");
                return false;
            }
        }

        // Delete a customer by ID
        public async Task<bool> DeleteCustomer(Guid id)
        {
            try
            {
                await _customerService.DeleteCustomer(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting customer: {ex.Message}");
                return false;
            }
        }
    }
}
