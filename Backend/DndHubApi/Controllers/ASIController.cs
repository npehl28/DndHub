using DndHubApi.Data;
using DndHubApi.Models;
using DndHubApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DndHubApi.Contollers;

[ApiController]
[Route("api/[controller]")]
public class ASIController : ControllerBase
{
    private readonly RaceDbContext _context;

    public ASIController(RaceDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddASI(AddASIDTO asiDto)
    {
        var asi = new ASI
        {
            Id = Guid.NewGuid(),
            AbilityScore = asiDto.AbilityScore,
            IncreaseAmount = asiDto.IncreaseAmount,
        };

        _context.ASIs.Add(asi);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetASIById), new { id = asi.Id }, asi);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetASIById(Guid id)
    {
        var asi = await _context.ASIs.FindAsync(id);
        return asi == null ? NotFound() : Ok(asi);
    }
}
