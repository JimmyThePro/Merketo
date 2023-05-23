using Merketo.Helpers.Repositories;
using Merketo.Models.ViewModels;
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

    [HttpGet]
    [Route("/products/details/{id}")]
    public async Task<IActionResult> Details(string id)
    {
        var entity = await _productRepository.GetAsync(x => x.ArticleNumber == id);
        if (entity != null)
        {
            var viewModel = new AdminProductsCreateViewModel
            {
                ArticleNumber = entity.ArticleNumber,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
            };
            return View(viewModel);
        }
        return RedirectToAction("Index", "Product");
    }
}
