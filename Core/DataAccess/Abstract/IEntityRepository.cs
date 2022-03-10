using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        // tüm ürünleri çekmek için, istedğimiz zaman da filtrelemeler yapabiliriz.
        List<T> GetList(Expression<Func<T, bool>> filter=null);
        //tek bir şey çekmek için 
        T Get(Expression<Func<T, bool>> filter);
        //veritabanına ekleme
        void Add(T entity);
        //veritabanında güncelleme
        void Update(T entity);
        //veritabanında silme
        void Delete(T entity);
    }
}
