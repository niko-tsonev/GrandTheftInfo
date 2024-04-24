using GrandTheftInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GrandTheftInfo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
