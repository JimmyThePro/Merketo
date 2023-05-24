﻿using System.ComponentModel.DataAnnotations;

namespace Merketo.Models.ViewModels;

public class UserSignInViewModel
{
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public bool RememberMe { get; set; }
}
