using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Context: DB Tabloları ile proje classlarını bağlamak için

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        // projemizin hangi db ile ilişkili olduğunu belirteceğimiz metot:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true"); 
                                     // "\" tırnak içinde \ algılaması için başına @ koyduk.
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        // bizim nesnemizim veritabanında hangi tabloya karşılık geldiğini burada belirttik.
    }
}
