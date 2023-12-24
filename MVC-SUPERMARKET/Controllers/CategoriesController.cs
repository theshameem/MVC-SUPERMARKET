using Microsoft.AspNetCore.Mvc;

namespace MVC_SUPERMARKET.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {            
            return View(); 
        }

        public IActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                return new ContentResult { Content = "You're viewing categories with id: " + id.ToString() };
            }
            return new ContentResult { Content = "Null content" };
        }
    }
}
