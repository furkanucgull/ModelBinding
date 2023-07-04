
using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {

        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Ürün1", Price = 17.89m };
            var product2 = new Product { Id = 2, Name = "Ürün2", Price = 27.99m };
            var product3 = new Product { Id = 3, Name = "Ürün3", Price = 33.99m };

            var cartProduct1 = new CartProduct { Product = product1, Quantity = 5 };
            var cartProduct2 = new CartProduct { Product = product2, Quantity = 10 };
            var cartProduct3 = new CartProduct { Product = product3, Quantity = 15 };

            var cartProducts = new List<CartProduct> { cartProduct1, cartProduct2, cartProduct3 };

            return View(cartProducts);
        }
    }
}