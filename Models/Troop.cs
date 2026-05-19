namespace ClashRoyaleApi.Models;

using ClashRoyaleApi.StatsList;

public class Troop
{
    public int Id { get; set; }
    public int ElixirCost { get; set; }
    public required string Name { get; set; }
    public  required TroopType TroopType { get; set; }
    public required RarityType Rarity { get; set; }
    public List<TroopLevel> Levels { get; set; } = [];
}
