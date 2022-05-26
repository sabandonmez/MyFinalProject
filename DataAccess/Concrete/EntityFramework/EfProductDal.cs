using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //usinge gelen  nesneler using bitince bellekten atılır çünkü context nesnesi biraz maliyetli
            //Direkt NorthwindContext contex=new NorthwindContext() yazsaakta olur ama using daha tasarruflu bir yapı sunuyor
            
            //Bu Usinge IDısposable pattern implementation of c# denir. Bellek hızlıca temizlenir.

            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); // Veri kaynağıyla entity 'i ilişkilendirir.
                addedEntity.State = EntityState.Added; // Eklenecek nesne olduğunu söyledik
                context.SaveChanges(); // Ekle.İşlemleri yürürlüğe sokar.
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); // Veri kaynağıyla entity 'i ilişkilendirir.
                deletedEntity.State = EntityState.Deleted; // Silinecek nesne olduğunu söyledik
                context.SaveChanges(); // Sil.İşlemleri yürürlüğe sokar.
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); 

            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();          
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); // Veri kaynağıyla entity 'i ilişkilendirir.
                updatedEntity.State = EntityState.Modified; // Güncelleme nesne olduğunu söyledik
                context.SaveChanges(); // Güncelle.İşlemleri yürürlüğe sokar.
            }
        }
    }
}
