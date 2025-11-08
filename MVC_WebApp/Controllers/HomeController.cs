using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Bll.Models;
using MVC_Bll.Services;
using MVC_WebApp.Models;

namespace MVC_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            UserModel user = await _userService.GetUserAsync(2);

            return View(new IndexViewModel { User = user });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
