using ClashRoyaleApi.StatsList;
using System.ComponentModel.DataAnnotations;
public class TroopLevel
{
    [Range(1, 16)] //Minimum level is 1, maximum level is 16 (as of May 2026)
    public int Level { get; set; }

    public StatsList Stats { get; set; } = new();
}