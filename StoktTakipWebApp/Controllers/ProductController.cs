
using Microsoft.AspNetCore.Mvc;
using StoktTakipWebApp.Models;


namespace StoktTakipWebApp.Controllers
{ 
    public class ProductController : Controller
{
    private List<Product> _products;
    public ProductController()
    {
        _products= new List<Product>()
            {
              new Product{ Id=1,Name="Msi",Description="Oyun Bilgisayarı",Price=25000,Stock=25 },
              new Product{ Id=2,Name="Monster",Description="Oyun Bilgisayarı",Price=7500, Stock=20 }
            };
    }

    public IActionResult Anasayfa()
    {
        return View(_products);
    }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product) {
            _products.Add(product);
            return RedirectToAction("Anasayfa");
        
        }
}
}