﻿using BookHeaven.Models.Dto;
using BookHeaven.Models.Entity;
using BookHeaven.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BookHaven.Models.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order?> GetOrderByIdAsync(Guid orderId)
        {
            return await _orderRepository.GetByIdAsync(orderId);
        }

        public async Task<IEnumerable<Order?>> GetOrdersByCustomerIdAsync(Guid customerId)
        {
            return await _orderRepository.GetByCustomerIdAsync(customerId);
        }

        public async Task CreateOrderAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            await _orderRepository.CreateAsync(order);
        }

        public async Task<IEnumerable<OrderItem?>> GetOrderItemsAsync(Guid orderId)
        {
            return await _orderRepository.GetOrderItemsAsync(orderId);
        }

        public async Task UpdateOrderAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            await _orderRepository.UpdateAsync(order);
        }

        public async Task DeleteOrderAsync(Guid orderId)
        {
            await _orderRepository.DeleteAsync(orderId);
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersByStatusAsync(string status)
        {
            return await _orderRepository.GetByStatusAsync(status);
        }

        public async Task<Order> PlaceOrderAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            return await _orderRepository.PlaceOrderAsync(order);
        }

        public async Task<IEnumerable<Order>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _orderRepository.GetOrdersByDateRangeAsync(startDate, endDate);
        }

        public async Task<IEnumerable<BookSales>> GetBestSellingBooksAsync()
        {
            return await _orderRepository.GetBestSellingBooksAsync();
        }

        public async Task<IEnumerable<BestCustomer>> GetBestCustomersAsync()
        {
            return await _orderRepository.GetBestCustomersAsync();
        }
    }
}
