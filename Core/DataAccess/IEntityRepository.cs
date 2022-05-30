using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint/cenerik kısıtlama = (<T> where T : class,IEntity)
    //buradaki class demek referans tip olabilir demek.
    //IEntity ise IEntity ve onu implemente eden bir sınıf olabilir demek.
    //new() = newlenebilir olsun demek. Bunu koyma sebebimiz IEntity nin interface olması iterfaceler newlenemez.
    //Sonuç olarak bu constraint şunu demek istiyor: T IEntity i implemente eden bir sınıf olacak (Category,customer...)
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
