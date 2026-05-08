namespace ClashRoyaleApi.Models;
using ClashRoyaleApi.Enums;
using Microsoft.Identity.Client;

public class Troop
{
    public int Id { get; set; }
    public int ElixirCost { get; set; }
    public required string Name { get; set; }
    public required RarityType Rarity { get; set; }
    public required TroopType TroopType { get; set; }
    public List<DamageType> Damage { get; set; } = [];
    public List<HitpointsType> Hitpoints { get; set; } = [];
    public double HitSpeed { get; set; }
    public required RangeType Range { get; set; }
    public required TargetType Target { get; set; }
    public required SpeedType Speed { get; set; }



}
