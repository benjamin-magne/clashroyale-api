namespace ClashRoyaleApi.Models;
using ClashRoyaleApi.Enums;
public class Troop
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Range { get; set; } = string.Empty;
    public int Cost { get; set; }
    public int HitPoints { get; set; }
    public int Damage { get; set; }
    public double HitSpeed { get; set; }
    public double Speed { get; set; }
    public RarityType Rarity { get; set; }
}