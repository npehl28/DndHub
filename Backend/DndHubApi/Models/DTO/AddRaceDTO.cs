namespace DndHubApi.Models.DTO;

public class AddRaceDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Proficiencies { get; set; }
    public string Languages { get; set; }
    public int Speed { get; set; }
    public string Size { get; set; }
    public int? DarkVisionRange { get; set; }
    public List<Guid> ASIIds { get; set; }
    public List<Guid> TraitIds { get; set; }
    public List<Guid> SubraceIds { get; set; }
}
