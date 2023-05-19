using Merketo.Contexts;
using Merketo.Models.Entities;

namespace Merketo.Helpers.Repositories;

public class ProductRepository : Repository<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}
