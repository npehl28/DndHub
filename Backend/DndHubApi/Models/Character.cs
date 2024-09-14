namespace DndHubApi.Models;

public class Character
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Class { get; set; }
    public int Level { get; set; }
    public required string Race { get; set; }
    public required string Background { get; set; }
    // Add other relevant fields here
}
