using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        //bütün ürünleri listeleme
        List<Product> GetAll();
        //ürünleri kategoriye göre listeleme
        List<Product> GetByCategory(int categoryId);
        Product GetById(int productId);
    }
}
