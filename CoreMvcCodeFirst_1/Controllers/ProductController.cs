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

        public IActionResult UpdateProduct(int id)
        {
            ProductPageVm pVm = new()
            {
                Categories = _context.Categories.ToList(),
                Product = _context.Products.Find(id)
            };

            return View(pVm);
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductPageVm pVm)
        {
            Product original = _context.Products.Find(pVm.Product.BenimId);
            original.ProductName = pVm.Product.ProductName;
            original.UnitPrice = pVm.Product.UnitPrice;
            original.CategoryId = pVm.Product.CategoryId;
            original.UpdatedDate = DateTime.Now;
            original.Status = Models.Enums.DataStatus.Updated;
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult DeleteProduct(int id)
        {
            _context.Products.Remove(_context.Products.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }


    }
}
