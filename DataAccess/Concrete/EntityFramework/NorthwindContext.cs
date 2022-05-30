using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //NorthwindContext classınnın sebebi veritabanındaki nesnelerle kendi nesnelerimizi ilişkilendirmek için
    //Bu classa ihtiyaç duyuyoruz.Context(Bağlam) classları bu amaçla kullanıyoruz.
    //Context:DataBase tabloları ile proje classlarını bağlamak
    //DbContext EntityFrameworkCore ile geliyor.
    public class NorthwindContext:DbContext
    {
        //Bu OnConfiguring metot bizim projemizin hangi veritabanı ile ilişkiliyi belirteceğimiz yerdir. 
        //Hangi veritabanı?
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = Northwind; Trusted_Connection = true");
        }

        //Hangi tabloya ne karşılık gelecek?
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
