using Microsoft.AspNetCore.Mvc;

namespace proje_2.Controllers
{
    public class BlogContorollers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
