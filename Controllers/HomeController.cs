using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers;

public class HomeController : Controller
{
    private readonly HomeViewModel _homeViewModel;

    public HomeController(HomeViewModel homeViewModel)
    {
        _homeViewModel = homeViewModel;
    }

    public async Task<IActionResult> Index()
    {
        return View(_homeViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Index(HomeViewModel homeViewModel)
    {
        return View();
    }
}
