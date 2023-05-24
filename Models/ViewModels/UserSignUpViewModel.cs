using Merketo.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Merketo.Models.ViewModels;

public class UserSignUpViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string? StreetName { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }

    public static implicit operator IdentityUser(UserSignUpViewModel viewModel)
    {
        return new IdentityUser
        {
            UserName = viewModel.Email,
            Email = viewModel.Email,
            PhoneNumber = viewModel.PhoneNumber
        };
    }

    public static implicit operator UserProfileEntity(UserSignUpViewModel viewModel)
    {
        return new UserProfileEntity
        {
            FirstName = viewModel.FirstName,
            LastName = viewModel.LastName,
            StreetName = viewModel.StreetName,
            PostalCode = viewModel.PostalCode,
            City = viewModel.City
        };
    }
}
