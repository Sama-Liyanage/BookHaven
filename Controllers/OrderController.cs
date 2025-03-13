using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHaven.Models.Services;
using BookHeaven.Models.Dto;
using BookHeaven.Models.Entity;

namespace BookHaven.Controllers
{
    public class OrderController
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        // Get an order by its ID
        public async Task<Order?> GetOrderById(Guid orderId)
        {
            return await _orderService.GetOrderByIdAsync(orderId);
        }

        // Get all orders for a specific customer
        public async Task<List<Order>> GetOrdersByCustomerId(Guid customerId)
        {
            return (List<Order>)await _orderService.GetOrdersByCustomerIdAsync(customerId);
        }

        // Create a new order
        public async Task<bool> CreateOrder(Order order)
        {
            try
            {
                await _orderService.CreateOrderAsync(order);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating order: {ex.Message}");
                return false;
            }
        }

        // Get all items in a specific order
        public async Task<List<OrderItem>> GetOrderItems(Guid orderId)
        {
            return (List<OrderItem>)await _orderService.GetOrderItemsAsync(orderId);
        }

        // Update an existing order
        public async Task<bool> UpdateOrder(Order order)
        {
            try
            {
                await _orderService.UpdateOrderAsync(order);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating order: {ex.Message}");
                return false;
            }
        }

        // Delete an order by its ID
        public async Task<bool> DeleteOrder(Guid orderId)
        {
            try
            {
                await _orderService.DeleteOrderAsync(orderId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting order: {ex.Message}");
                return false;
            }
        }

        // Get all orders
        public async Task<List<Order>> GetAllOrders()
        {
            return (List<Order>)await _orderService.GetAllOrdersAsync();
        }

        // Get orders by their status
        public async Task<List<Order>> GetOrdersByStatus(string status)
        {
            return (List<Order>)await _orderService.GetOrdersByStatusAsync(status);
        }

        // Place a new order
        public async Task<Order> PlaceOrder(Order order)
        {
            return await _orderService.PlaceOrderAsync(order);
        }

        // Get orders within a specific date range
        public async Task<List<Order>> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return (List<Order>)await _orderService.GetOrdersByDateRangeAsync(startDate, endDate);
        }

        // Get the best-selling books
        public async Task<List<BookSales>> GetBestSellingBooks()
        {
            return (List<BookSales>)await _orderService.GetBestSellingBooksAsync();
        }

        // Get the best customers
        public async Task<List<BestCustomer>> GetBestCustomers()
        {
            return (List<BestCustomer>)await _orderService.GetBestCustomersAsync();
        }
    }
}
