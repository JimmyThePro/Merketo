using Merketo.Contexts;
using Merketo.Models.Entities;
using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Merketo.Helpers.Services;

public class AuthService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly IdentityContext _identityContext;

    public AuthService(UserManager<IdentityUser> userManager, IdentityContext identityContext, SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _identityContext = identityContext;
        _signInManager = signInManager;
    }

    public async Task<bool> SignUpAsync(UserSignUpViewModel viewModel)
    {
        try
        {
            IdentityUser identityUser = viewModel;
            await _userManager.CreateAsync(identityUser, viewModel.Password);

            UserProfileEntity userProfileEntity = viewModel;
            userProfileEntity.UserId = identityUser.Id;

            _identityContext.UserProfiles.Add(userProfileEntity);
            await _identityContext.SaveChangesAsync();

            return true;
        }
        catch { return false; }
    }

    public async Task<bool> SignInAsync(UserSignInViewModel viewModel)
    {
        try
        {
            var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
            return result.Succeeded;
        }
        catch { return false; }
    }
}
