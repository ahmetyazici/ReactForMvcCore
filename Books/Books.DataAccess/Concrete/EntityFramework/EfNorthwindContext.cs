using Books.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Books.DataAccess.Concrete.EntityFramework
{
    public class EfNorthwindContext : DbContext
    {
		
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EmployeeDB;User Id=sa;Password=019070");

        }

        public DbSet<Book> Books { get; set; }

    }
}
