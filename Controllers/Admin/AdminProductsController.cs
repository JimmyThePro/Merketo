using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers.Admin;

public class AdminProductsController : Controller
{
    [Route("/admin/products")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("/admin/products/create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route("/admin/products/create")]
    public IActionResult Create(AdminProductsCreateViewModel viewModel)
    {
        return View();
    }
}
