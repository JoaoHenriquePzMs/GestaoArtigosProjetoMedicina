using GestaoArtigos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestaoArtigos.Infra;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Admin> Admins { get; set; }
}
