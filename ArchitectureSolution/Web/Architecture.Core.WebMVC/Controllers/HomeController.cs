using Architecture.Core.WebMVC.Implementation;
using Architecture.Core.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Architecture.Core.WebMVC.Controllers
{
    public class HomeController : Controller
    {

        private SessionManager _sessionManager;

        public IActionResult Index()
        {
            _sessionManager = new SessionManager(HttpContext);
            _sessionManager.CurrentUser = "Saeid";

            ViewBag.User = _sessionManager.CurrentUser;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
