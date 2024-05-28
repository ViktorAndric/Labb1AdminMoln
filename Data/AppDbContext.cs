using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml;
using Labb1AdminMoln.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb1AdminMoln.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

}