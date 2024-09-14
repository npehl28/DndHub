using DndHubApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DndHubApi.Data;

public class RaceDbContext : DbContext
{
    public RaceDbContext(DbContextOptions<RaceDbContext> options)
        : base(options) { }

    public DbSet<Race> Races { get; set; }
    public DbSet<Subrace> Subraces { get; set; }
    public DbSet<ASI> ASIs { get; set; }
    public DbSet<Trait> Traits { get; set; }
}
