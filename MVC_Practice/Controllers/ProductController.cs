using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MVC_Practice.Controllers
{
    public class ProductController : Controller
    {
        private readonly Service.Interface.IProductService _productService;
        public  ProductController(Service.Interface.IProductService productService)
        {
            _productService = productService;
        }


        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}
