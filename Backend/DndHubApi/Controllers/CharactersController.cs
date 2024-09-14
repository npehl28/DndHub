using System.Collections.Generic;
using System.Linq;
using DndHubApi;
using DndHubApi.Data;
using DndHubApi.Models;
using DndHubApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DndHubApi.Contollers;

[ApiController]
[Route("api/[controller]")]
public class CharactersController : ControllerBase
{
    private readonly CharacterDbContext dbContext;

    public CharactersController(CharacterDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetAllCharacters()
    {
        var characters = dbContext.Character.ToList();
        return Ok(characters);
    }

    [HttpPost]
    public IActionResult AddContact(AddCharacterDTO request)
    {
        var domainModelCharacter = new Character
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Class = request.Class,
            Level = request.Level,
            Race = request.Race,
            Background = request.Background,
        };

        dbContext.Character.Add(domainModelCharacter);
        dbContext.SaveChanges();

        return Ok(domainModelCharacter);
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public IActionResult DeleteCharacter(Guid id)
    {
        var character = dbContext.Character.Find(id);
        if (character is not null)
        {
            dbContext.Character.Remove(character);
            dbContext.SaveChanges();
            return Ok(
                new { message = "Successfuly deleted character with name: " + character.Name + "." }
            );
        }
        return BadRequest(new { message = "Character with Id " + id + " does not exist." });
    }
}
