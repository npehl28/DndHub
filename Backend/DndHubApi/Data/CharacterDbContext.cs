using DndHubApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DndHubApi.Data;

public class CharacterDbContext : DbContext
{
    public CharacterDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Character> Character { get; set; }
}
