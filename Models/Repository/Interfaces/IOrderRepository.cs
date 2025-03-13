using BookHeaven.Models.Dto;
using BookHeaven.Models.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BookHeaven.Models.Repository.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(Guid orderId);

        Task<IEnumerable<Order?>> GetByCustomerIdAsync(Guid customerId);

        Task CreateAsync(Order order);

        Task<int?> UpdateAsync(Order order);

        Task DeleteAsync(Guid orderId);

        Task<IEnumerable<Order>> GetAllAsync();

        Task<IEnumerable<Order>> GetByStatusAsync(string status);

        Task<Order> PlaceOrderAsync(Order order);

        Task<IEnumerable<OrderItem?>> GetOrderItemsAsync(Guid id);

        Task<IEnumerable<Order>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate);

        Task<IEnumerable<BookSales>> GetBestSellingBooksAsync();

        Task<IEnumerable<BestCustomer>> GetBestCustomersAsync();

    }
}
