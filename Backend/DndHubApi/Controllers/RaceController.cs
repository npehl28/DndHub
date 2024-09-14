using DndHubApi.Data;
using DndHubApi.Models;
using DndHubApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DndHubApi.Contollers;

[ApiController]
[Route("api/[controller]")]
public class RaceController : ControllerBase
{
    private readonly RaceDbContext _context;

    public RaceController(RaceDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddRace(AddRaceDTO raceDto)
    {
        var race = new Race
        {
            Id = Guid.NewGuid(),
            Name = raceDto.Name,
            Description = raceDto.Description,
            Proficiencies = raceDto.Proficiencies,
            Languages = raceDto.Languages,
            Speed = raceDto.Speed,
            Size = raceDto.Size,
            DarkVisionRange = raceDto.DarkVisionRange,
            ASIIds = raceDto.ASIIds,
            TraitIds = raceDto.TraitIds,
            SubraceIds = raceDto.SubraceIds,
        };

        _context.Races.Add(race);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetRaceById), new { id = race.Id }, race);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRaceById(Guid id)
    {
        var race = await _context.Races.FindAsync(id);
        return race == null ? NotFound() : Ok(race);
    }

    [HttpGet]
    public async Task<IActionResult> GetRace()
    {
        var races = _context.Races.ToList();
        return Ok(races);
    }
}
