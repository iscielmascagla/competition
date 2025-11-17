using Microsoft.AspNetCore.Mvc;

namespace Competition.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FirstPage()
        {
            return View();
        }
    }

}
