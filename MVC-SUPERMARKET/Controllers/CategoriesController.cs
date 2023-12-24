using Microsoft.AspNetCore.Mvc;

namespace MVC_SUPERMARKET.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
