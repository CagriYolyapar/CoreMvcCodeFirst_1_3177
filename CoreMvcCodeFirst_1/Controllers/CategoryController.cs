using CoreMvcCodeFirst_1.Models.ContextClasses;
using CoreMvcCodeFirst_1.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcCodeFirst_1.Controllers
{
    public class CategoryController : Controller
    {
        //readonly keyword'u bir alana sadece ve sadece constructor'da atama yapılabilecegini belirtir


        //MVC'de Action'ların üzerine HTTP Request attributelarını yazmazsanız otomatik olarak HttpGet yönteminde calısırlar...
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

        //Eger BackEnd'den Front End'e bir model gönderilmiyorsa. Ama buna ragmen Front End View sayfamız sanki kendisine bir model geliyor gibi karsılama yapıyorsa o zaman anlamalıyız ki, Front End'den Back End'e post durumunda bir model gönderilecek...

        public IActionResult CreateCategory()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            //Kişiyi View'a göndermektense Action'a yönlendirmek her zaman en saglıklısıdır...
            return RedirectToAction("CategoryList");
        }


        /*
         

        BaseUrl -- RouteData


        /Controller/Action?id=2
         
         
         
         
         */

        public IActionResult UpdateCategory(int id)
        {
            Category guncellenecek = _context.Categories.Find(id);
            return View(guncellenecek);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {

            Category orijinalHali = _context.Categories.Find(category.BenimId);
            orijinalHali.CategoryName = category.CategoryName;
            orijinalHali.Description = category.Description;
            orijinalHali.Status = Models.Enums.DataStatus.Updated;
            orijinalHali.UpdatedDate = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public IActionResult DeleteCategory(int id)
        {
            _context.Categories.Remove(_context.Categories.Find(id));
            _context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}
