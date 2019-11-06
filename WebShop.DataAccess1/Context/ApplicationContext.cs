using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebShop.DataAccess1;
using WebShop.DataAccess1.Entities;
using System;

namespace WebShop.DataAccess1.Context
{
    public class ApplicationContext : IdentityDbContext<User, Role, string>
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Order> Orders { get; set;}
        public DbSet<OrderItem> OrderItems { get; set; }

        private static string GetConnectionString()
        {
            const string databaseName = "webapijwt";
            const string databaseUser = "";
            const string databasePass = "";

            return $"Server=localhost;" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }
    }
}
