using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.DomainModels
{
    public class CartLine : IDomainModel
    {
        //ürünler ve üründen kaç tane olduğunu tutuyoruz. Sepetin elemanlarını oluşturuyoruz.
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
