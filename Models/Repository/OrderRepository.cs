using BookHeaven.Models.Dto;
using BookHeaven.Models.Entity;
using BookHeaven.Models.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace BookHeaven.Models.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookHavenDbContext _context;

        public OrderRepository(BookHavenDbContext context)
        {
            _context = context;
        }

        public async Task<Order?> GetByIdAsync(Guid orderId)
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .FirstOrDefaultAsync(o => o.Id == orderId);
        }

        public async Task<IEnumerable<Order?>> GetByCustomerIdAsync(Guid customerId)
        {
            return await _context.Orders
                .Where(o => o.CustomerId == customerId)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .ToListAsync();
        }

        public async Task CreateAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderItem?>> GetOrderItemsAsync(Guid orderId)
        {
            var orderItems = await _context.Orders
                .Where(o => o.Id == orderId)
                .Include(o => o.Items)
                .SelectMany(o => o.Items)
                .ToListAsync();

            return orderItems;
        }



        public async Task<int?> UpdateAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            var existingOrder = await _context.Orders.FindAsync(order.Id);
            if (existingOrder == null)
            {
                return null;
            }

            _context.Entry(existingOrder).CurrentValues.SetValues(order);
            return await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetByStatusAsync(string status)
        {
            return await _context.Orders
                .Where(o => o.Status == status)
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .ToListAsync();
        }

        public async Task<Order> PlaceOrderAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                order.OrderDate = DateTime.UtcNow;

                order.Total = order.Items.Sum(i => i.Quantity * i.Book.Price);

                order.Total -= order.Discount;

                await _context.Orders.AddAsync(order);

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return order;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<IEnumerable<Order>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.Orders
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<BookSales>> GetBestSellingBooksAsync()
        {
            return await _context.Orders
                .SelectMany(o => o.Items) 
                .GroupBy(oi => oi.BookId)
                .Select(group => new BookSales
                {
                    Author = group.First().Book.Author,
                    Title = group.First().Book.Title,
                    TotalSold = group.Sum(oi => oi.Quantity)
                })
                .OrderByDescending(b => b.TotalSold)
                .Take(10)
                .ToListAsync();
        }

        public async Task<IEnumerable<BestCustomer>> GetBestCustomersAsync()
        {
            return await _context.Orders
                .GroupBy(o => o.CustomerId)
                .Select(group => new BestCustomer
                {
                    Name = group.First().Customer.Name,
                    Email = group.First().Customer.Email,
                    PhoneNumber = group.First().Customer.PhoneNumber,
                    TotalSpent = group.Sum(o => o.Total)
                })
                .OrderByDescending(c => c.TotalSpent)
                .Take(10)
                .ToListAsync();
        }



    }
}
