using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StoreApi.Models;

public partial class AdventureStoreDBContext : DbContext
{
    public AdventureStoreDBContext()
    {
    }

    public AdventureStoreDBContext(DbContextOptions<AdventureStoreDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
