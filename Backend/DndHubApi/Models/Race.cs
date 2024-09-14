namespace DndHubApi.Models;

public class Race
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Proficiencies { get; set; }
    public required string Languages { get; set; }
    public int Speed { get; set; }
    public required string Size { get; set; }
    public int? DarkVisionRange { get; set; }
    public required List<Guid> ASIIds { get; set; } // List of ASI Ids
    public required List<Guid> TraitIds { get; set; } // List of Trait Ids
    public required List<Guid> SubraceIds { get; set; } // List of Subrace Ids
}
