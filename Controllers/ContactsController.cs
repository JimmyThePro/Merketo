using Merketo.Helpers.Repositories;
using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers;

public class ContactsController : Controller
{
    public readonly ContactFormRepository _formRepository;

    public ContactsController(ContactFormRepository formRepository)
    {
        _formRepository = formRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(ContactFormViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            await _formRepository.CreateAsync(viewModel);
            TempData["SuccessMessage"] = "Message sent successfully!";
            return RedirectToAction("Index");
        }
        return View(viewModel);
    }
}
