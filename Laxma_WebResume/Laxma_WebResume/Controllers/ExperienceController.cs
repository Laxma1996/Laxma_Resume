using Laxma_WebResume.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laxma_WebResume.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult Education()
        {
            return View("Education");
        }
        public IActionResult TCS()
        {
            return View("TCS");
        }

        public IActionResult Infosys()
        {
            return View("Infosys");
        }

        public IActionResult SIUC()
        {
            return View("SIUC");
        }
    }
}
