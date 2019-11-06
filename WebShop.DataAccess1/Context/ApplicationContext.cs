using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebShop.DataAccess1;
using WebShop.DataAccess1.Entities;
using System;

namespace WebShop.DataAccess1.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Order> Orders { get; set;}
        public DbSet<OrderItem> OrderItems { get; set; }

        //internal void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}

        //internal object Entry(User user)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
