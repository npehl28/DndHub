namespace DndHubApi.Models;

public class Subrace
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Guid> ASIIds { get; set; } // List of ASI Ids
    public List<Guid> TraitIds { get; set; } // List of Trait Ids
}
