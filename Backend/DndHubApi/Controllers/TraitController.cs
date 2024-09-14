using DndHubApi.Data;
using DndHubApi.Models;
using DndHubApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DndHubApi.Contollers;

[ApiController]
[Route("api/[controller]")]
public class TraitController : ControllerBase
{
    private readonly RaceDbContext _context;

    public TraitController(RaceDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddTrait(AddTraitDTO traitDto)
    {
        var trait = new Trait
        {
            Id = Guid.NewGuid(),
            Name = traitDto.Name,
            Description = traitDto.Description,
        };

        _context.Traits.Add(trait);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTraitById), new { id = trait.Id }, trait);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTraitById(Guid id)
    {
        var trait = await _context.Traits.FindAsync(id);
        return trait == null ? NotFound() : Ok(trait);
    }
}
