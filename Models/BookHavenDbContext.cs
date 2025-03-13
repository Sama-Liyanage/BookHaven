using BookHeaven.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.EntityFrameworkCore.Extensions; 


namespace BookHeaven.Models
{
    public class BookHavenDbContext : DbContext
    {

        public BookHavenDbContext(DbContextOptions<BookHavenDbContext> options)
           : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierOrder> SupplierOrders { get; set; }
        public DbSet<SupplierOrderItem> SupplierOrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=bookhavendb;user=root;password=1234;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Supplier)
                .WithMany(s => s.Books)
                .HasForeignKey(b => b.SupplierId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.BookId, oi.OrderId });

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Book)
                .WithMany()
                .HasForeignKey(oi => oi.BookId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<SupplierOrder>()
                .HasOne(so => so.Supplier)
                .WithMany(s => s.SupplierOrders)
                .HasForeignKey(so => so.SupplierId);

            modelBuilder.Entity<SupplierOrderItem>()
                .HasOne(soi => soi.Book)
                .WithMany()
                .HasForeignKey(soi => soi.BookId);

            modelBuilder.Entity<Book>()
                .Property(b => b.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SupplierOrderItem>()
                .Property(soi => soi.PricePerUnit)
                .HasColumnType("decimal(18,2)");
        }
    }
}
