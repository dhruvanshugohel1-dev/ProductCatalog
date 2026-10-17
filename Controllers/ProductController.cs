using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop",
                    Price = 50000, Category = "Electronics" },

                new Product { Id = 2, Name = "Mobile",
                    Price = 20000, Category = "Electronics" },

                new Product { Id = 3, Name = "Shoes",
                    Price = 1500, Category = "Fashion" }
            };

            return View(products);
        }
    }
}
