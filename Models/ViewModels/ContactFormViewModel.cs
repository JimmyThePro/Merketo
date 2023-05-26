using Merketo.Models.Entities;

namespace Merketo.Models.ViewModels;

public class ContactFormViewModel
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Message { get; set; } = null!;

    public static implicit operator ContactFormEntity(ContactFormViewModel viewModel)
    {
        return new ContactFormEntity
        {
            Name = viewModel.Name,
            Email = viewModel.Email,
            Message = viewModel.Message,
        };
    }
}
