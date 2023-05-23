using Merketo.Helpers.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers;

public class HomeController : Controller
{
    private readonly ProductRepository _productRepository;

    public HomeController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _productRepository.GetAllAsync();
        return View(products);
    }
}
