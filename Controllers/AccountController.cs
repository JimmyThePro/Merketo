using Merketo.Helpers.Services;
using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers;

public class AccountController : Controller
{
    private readonly AuthService _authService;

    public AccountController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(UserSignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            if (await _authService.SignUpAsync(viewModel))
                return RedirectToAction("SignIn");

            ModelState.AddModelError("", "A user with that email already exists");
        }
        return View(viewModel);
    }

    [HttpGet]
    public IActionResult SignIn()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignIn(UserSignInViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            if (await _authService.SignInAsync(viewModel))
                return RedirectToAction("Index");

            ModelState.AddModelError("", "Incorrect Email or Password.");
        }
        return View(viewModel);
    }

    [Authorize]
    public IActionResult Index()
    {
        return View();
    }

    [Authorize]
    public new async Task<IActionResult> SignOut()
    {
        if (await _authService.SignOutAsync(User))
            return LocalRedirect("/");

        return RedirectToAction("Index");
    }
}
