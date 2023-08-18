using DersModelYapisii.Models;

using DersModelYapisii.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisii.Controllers
{
    public class CardProductController : Controller
    {
        public IActionResult Index()
        {
            var product1 = new ProductViewModel
            {
                Id = 11,
                Name = "Urun1",
                Price = 10.0m
            };

            var product2 = new ProductViewModel
            {
                Id = 22,
                Name = "Urun2",
                Price = 11.0m
            };

            var product3 = new ProductViewModel
            {
                Id = 33,
                Name = "Urun3",
                Price = 12.0m
            };

      

            var cartProduct1 = new CardProduct
            {
                Id = product1.Id,
                Product = product1,
                Quantity = 3,
                Price = product1.Price
            };

            var cartProduct2 = new CardProduct
            {
                Id = product2.Id,
                Product = product2,
                Quantity = 5,
                Price = product2.Price
            };

            var cartProduct3 = new CardProduct
            {
                Id = product3.Id,
                Product = product3,
                Quantity = 2,
                Price = product3.Price
            };

            var cardProduct = new List<CardProduct> { cartProduct1, cartProduct2, cartProduct3 };

            return View(cardProduct);
        }


    }
}