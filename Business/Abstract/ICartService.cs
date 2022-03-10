using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Abstract
{
    public interface ICartService
    {
        //sepete ekleme
        void AddToCart(Cart cart, Product product);

        //sepetten çıkarma
        void RemoveFromCart(Cart cart, int productId);

        //sepeti listeleme
        List<CartLine> List(Cart cart);
    }
}
