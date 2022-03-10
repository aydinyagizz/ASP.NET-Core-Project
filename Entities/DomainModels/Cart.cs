using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.DomainModels
{
    //sepet bilgisini tutuyor olacağız.
    public class Cart : IDomainModel
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }

        //sepet totali
        //public decimal Total
        //{
        //    get { return CartLines.Sum(c => c.Quantity * c.Product.UnitPrice); }
        //}
    }
}
