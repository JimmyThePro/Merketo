using Merketo.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Merketo.Contexts;

public class IdentityContext : IdentityDbContext
{
    public IdentityContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserProfileEntity> UserProfiles { get; set; }
}
