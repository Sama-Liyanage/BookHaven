using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookHeaven.Models
{
    public class BookHavenDbContextFactory : IDesignTimeDbContextFactory<BookHavenDbContext>
    {
        public BookHavenDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookHavenDbContext>();
            optionsBuilder.UseMySQL("server=localhost;database=bookhavendb;user=root;password=1234;");

            return new BookHavenDbContext(optionsBuilder.Options);
        }
    }
}
