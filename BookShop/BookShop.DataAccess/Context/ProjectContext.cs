using BookShop.Entites.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.DataAccess.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.; Database=BookCoreDb; integrated security=true");


            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<BookShops> BookShops { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }



    }
}