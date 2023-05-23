using Merketo.Helpers.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers;

public class ProductController : Controller
{
    private readonly ProductRepository _productRepository;

    public ProductController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    [Route("/products")]
    public async Task<IActionResult> Index()
    {
        var products = await _productRepository.GetAllAsync();
        return View(products);
    }
}
