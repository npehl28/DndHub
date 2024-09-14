namespace DndHubApi.Models;

public class ASI
{
    public Guid Id { get; set; }
    public string AbilityScore { get; set; } // "STR", "DEX", "CON", "INT", "WIS", or "CHA"
    public int IncreaseAmount { get; set; }
}
