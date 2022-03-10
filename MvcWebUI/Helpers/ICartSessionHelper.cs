using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DomainModels;

namespace MvcWebUI.Helpers
{
    public interface ICartSessionHelper
    {
        //session'daki sepete çekme işlemi
        Cart GetCart(string key);

        //sepeti set etme 
        void SetCart(string key, Cart cart);

        //sepeti silme
        void Clear();
    }
}
