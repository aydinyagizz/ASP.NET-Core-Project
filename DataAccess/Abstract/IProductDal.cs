using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // veritabanında yapmak istediğimiz operasyonlar yer alır.
    // örneğin Listeleme, Ekleme, Güncelleme, Silme. Ve bunların implementasyonlarını ise Concrete klasöründe yaparız.
    /* Repository Pattern; Temel operasyonları insert, update, select, delete operasyonlarını cenerik bir şekilde yazıp onu
     heryerde ortak bir şekilde kullanma üzerine kurulu bir yapı oluşturuyoruz.*/
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
