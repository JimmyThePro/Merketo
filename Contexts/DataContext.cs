﻿using Merketo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Merketo.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }
}