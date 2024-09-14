using DndHubApi.Data;
using DndHubApi.Models;
using DndHubApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DndHubApi.Contollers;

[ApiController]
[Route("api/[controller]")]
public class SubraceController : ControllerBase
{
    private readonly RaceDbContext _context;

    public SubraceController(RaceDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddSubrace(AddSubraceDTO subraceDto)
    {
        var subrace = new Subrace
        {
            Id = Guid.NewGuid(),
            Name = subraceDto.Name,
            Description = subraceDto.Description,
            ASIIds = subraceDto.ASIIds,
            TraitIds = subraceDto.TraitIds,
        };

        _context.Subraces.Add(subrace);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetSubraceById), new { id = subrace.Id }, subrace);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSubraceById(Guid id)
    {
        var subrace = await _context.Subraces.FindAsync(id);
        return subrace == null ? NotFound() : Ok(subrace);
    }
}
