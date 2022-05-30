using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            //usinge gelen  nesneler using bitince bellekten atılır çünkü context nesnesi biraz maliyetli
            //Direkt NorthwindContext contex=new NorthwindContext() yazsaakta olur ama using daha tasarruflu bir yapı sunuyor

            //Bu Usinge IDısposable pattern implementation of c# denir. Bellek hızlıca temizlenir.

            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); // Veri kaynağıyla entity 'i ilişkilendirir.
                addedEntity.State = EntityState.Added; // Eklenecek nesne olduğunu söyledik
                context.SaveChanges(); // Ekle.İşlemleri yürürlüğe sokar.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); // Veri kaynağıyla entity 'i ilişkilendirir.
                deletedEntity.State = EntityState.Deleted; // Silinecek nesne olduğunu söyledik
                context.SaveChanges(); // Sil.İşlemleri yürürlüğe sokar.
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); // Veri kaynağıyla entity 'i ilişkilendirir.
                updatedEntity.State = EntityState.Modified; // Güncelleme nesne olduğunu söyledik
                context.SaveChanges(); // Güncelle.İşlemleri yürürlüğe sokar.
            }
        }
    }
}
