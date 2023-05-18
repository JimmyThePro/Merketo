using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers.Admin;

public class AdminProductsController : Controller
{
    [Route("/admin/products")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("/admin/products/create")]
    public IActionResult Create()
    {
        return View();
    }
}
