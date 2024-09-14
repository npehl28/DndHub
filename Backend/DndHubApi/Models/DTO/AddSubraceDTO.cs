namespace DndHubApi.Models.DTO;

public class AddSubraceDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Guid> ASIIds { get; set; }
    public List<Guid> TraitIds { get; set; }
}
