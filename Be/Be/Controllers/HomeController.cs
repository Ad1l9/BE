using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Be.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
    }
}