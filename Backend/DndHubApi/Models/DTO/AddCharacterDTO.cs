namespace DndHubApi.Models.DTO;

public class AddCharacterDTO
{
    public required string Name { get; set;}
    public required string Class { get; set; }
    public required int Level { get; set; }
    public required string Race { get; set; }
    public required string Background { get; set; }
}
