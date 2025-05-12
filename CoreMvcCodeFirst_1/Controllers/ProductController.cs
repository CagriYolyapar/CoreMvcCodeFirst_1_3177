using CoreMvcCodeFirst_1.Models.ContextClasses;
using CoreMvcCodeFirst_1.Models.Entities;
using CoreMvcCodeFirst_1.Models.PageVm;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcCodeFirst_1.Controllers
{
    public class ProductController : Controller
    {
        readonly MyContext _context;
        public ProductController(MyContext context)
        {
            _context = context;
        }
        public IActionResult ProductList()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult CreateProduct()
        {
            List<Category> categories = _context.Categories.ToList();
            ProductPageVm pVm = new ProductPageVm()
            {
                Categories = categories
            };
            return View(pVm);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductPageVm model)
        {
            _context.Products.Add(model.Product);
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}
