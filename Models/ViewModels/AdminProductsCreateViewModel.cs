using Merketo.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Merketo.Models.ViewModels;

public class AdminProductsCreateViewModel
{
    [Display(Name = "Articlenumber")]
    [Required(ErrorMessage = "Please provide an Articlenumber.")]
    public string ArticleNumber { get; set; } = null!;

    [Display(Name = "Productname")]
    [Required(ErrorMessage = "Please provide a Productname.")]
    public string Name { get; set; } = null!;

    [Display(Name = "Productdescription")]
    [Required(ErrorMessage = "Please provide a Productdescription.")]
    public string Description { get; set; } = null!;

    [Display(Name = "Productprice")]
    [Required(ErrorMessage = "Please provide a Productprice.")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Please enter a valid price.")]
    public decimal Price { get; set; }

    [Display(Name = "Productimage")]
    public IFormFile? Image { get; set; }

    public static implicit operator ProductEntity(AdminProductsCreateViewModel model)
    {
        return new ProductEntity
        {
            ArticleNumber = model.ArticleNumber,
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            ImageName = model.Image?.FileName
        };
    }
}
