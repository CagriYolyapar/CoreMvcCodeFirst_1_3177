using CoreMvcCodeFirst_1.Models.ContextClasses;
using CoreMvcCodeFirst_1.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcCodeFirst_1.Controllers
{
    public class CategoryController : Controller
    {
        //readonly keyword'u bir alana sadece ve sadece constructor'da atama yapılabilecegini belirtir
        readonly MyContext _context;

        public CategoryController(MyContext context)
        {
            _context = context;
        }
        public IActionResult CategoryList()
        {
            List<Category> categories = _context.Categories.ToList();
         


            return View(categories);
        }
    }
}
