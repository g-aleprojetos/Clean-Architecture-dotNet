using CleanArch.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productAppService)
        {
            _productService = productAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetProducts();
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("id,name,Description,Price")])
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return RedirectToAction(nameof(index));
            }
            return View(ProductsController);
        }


   
    }
}
