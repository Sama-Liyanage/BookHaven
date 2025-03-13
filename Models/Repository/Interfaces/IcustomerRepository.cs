using BookHeaven.Models.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BookHeaven.Models.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync();

        Task<Customer?> GetCustomerByIdAsync(Guid id);

        Task<IEnumerable<Customer>> SearchCustomersAsync(string keyword);

        Task AddCustomerAsync(Customer customer);

        Task<int?> UpdateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(Guid id);

    }
}
