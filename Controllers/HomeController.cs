using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult> Index()
    {
        return View();
    }
}
