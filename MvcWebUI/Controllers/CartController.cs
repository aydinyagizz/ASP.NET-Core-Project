using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        //sepete ekle operasyonu
        public IActionResult AddToCart(int productId)
        {
            // ürün çekme
            Product product = _productService.GetById(productId);

            //ürünü çektikten sonra sessionda sepeti çekiyoruz.
            var cart = _cartSessionHelper.GetCart("cart");

            //ürün ekleme
            _cartService.AddToCart(cart, product);

            //sepeti session'a geri ekliyoruz.
            _cartSessionHelper.SetCart("cart", cart);

            //Tek request'lik data taşır. kullanıcıya mesaj veriyoruz.
            TempData.Add("message", product.ProductName + " sepete eklendi!");

            //ProductController'daki index'e gönderiyoruz.
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }

        public IActionResult RemoveFromCart(int productId)
        {
            // ürün çekme
            Product product = _productService.GetById(productId);

            //ürünü çektikten sonra sessionda sepeti çekiyoruz.
            var cart = _cartSessionHelper.GetCart("cart");

            //silme işlemi
            _cartService.RemoveFromCart(cart, productId);

            //sepeti session'a geri ekliyoruz.
            _cartSessionHelper.SetCart("cart", cart);

            //Tek request'lik data taşır. kullanıcıya mesaj veriyoruz.
            TempData.Add("message", product.ProductName + " sepetten silindi!");

            //ProductController'daki index'e gönderiyoruz.
            return RedirectToAction("Index", "Cart");
        }

        //siparişi tamamlama aksiyonu
        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            // model geçerli mi değil mi kontrolü
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", "Siparişiniz başarıyla tamamlandı.");

            //sepeti temizliyoruz.
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Cart");
        }
    }
}
