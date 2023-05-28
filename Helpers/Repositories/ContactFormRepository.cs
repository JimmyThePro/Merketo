using Merketo.Contexts;
using Merketo.Models.Entities;

namespace Merketo.Helpers.Repositories;

public class ContactFormRepository : Repository<ContactFormEntity>
{
    public ContactFormRepository(DataContext context) : base(context)
    {
    }
}
