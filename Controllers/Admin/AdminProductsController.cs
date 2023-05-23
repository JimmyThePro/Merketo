using Merketo.Contexts;
using Merketo.Helpers.Repositories;
using Merketo.Helpers.Services;
using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Merketo.Controllers.Admin;

public class AdminProductsController : Controller
{
    #region constructors & private fields

    private readonly ProductService _productService;
    private readonly ProductRepository _productRepository;

    public AdminProductsController(ProductService productService, ProductRepository productRepository)
    {
        _productService = productService;
        _productRepository = productRepository;
    }

    #endregion

    [HttpGet]
    [Route("/admin/products")]
    public async Task<IActionResult> Index()
    {
        return View(await _productRepository.GetAllAsync());
    }

    [HttpGet]
    [Route("/admin/products/create")]
    public async Task<IActionResult> Create()
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

    [HttpGet]
    [Route("/admin/products/edit/{id}")]
    public async Task<IActionResult> Edit(string id)
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
        return RedirectToAction("Index", "AdminProducts");
    }

    [HttpPost]
    [Route("/admin/products/edit/{id}")]
    public async Task<IActionResult> Edit(string id, AdminProductsCreateViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var entity = await _productRepository.GetAsync(x => x.ArticleNumber == id);
            if (entity != null)
            {
                entity.Name = viewModel.Name;
                entity.Price = viewModel.Price;
                entity.Description = viewModel.Description;
                await _productRepository.UpdateAsync(entity);
                return RedirectToAction("Index", "AdminProducts");
            }
        }
        return View(viewModel);
    }

    [HttpGet]
    [Route("/admin/products/delete/{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var isDeleted = await _productRepository.DeleteAsync(x => x.ArticleNumber == id);
        if (isDeleted)
        {
            return RedirectToAction("Index", "AdminProducts");
        }
        return RedirectToAction("Index", "AdminProducts");
    }
}
