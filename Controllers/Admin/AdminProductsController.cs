using Merketo.Helpers.Repositories;
using Merketo.Helpers.Services;
using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers.Admin;

public class AdminProductsController : Controller
{
    private readonly ProductService _productService;
    private readonly ProductRepository _productRepository;

    public AdminProductsController(ProductService productService, ProductRepository productRepository)
    {
        _productService = productService;
        _productRepository = productRepository;
    }

    [HttpGet]
    [Route("/admin/products")]
    public async Task<IActionResult> Index()
    {
        return View(await _productRepository.GetAllAsync());
    }

    [HttpGet]
    [Route("/admin/products/create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route("/admin/products/create")]
    public async Task<IActionResult> Create(AdminProductsCreateViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var _entity = await _productRepository.CreateAsync(viewModel);
            if (_entity != null)
                return RedirectToAction("Index", "AdminProducts");
        }

        return View(viewModel);
    }
}
