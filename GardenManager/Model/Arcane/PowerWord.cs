using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public class PowerWord : Word
{
    public decimal Potentia { get; set; }
    public decimal Arcainum { get; set; }
    public decimal Flux { get; set; }

    public PowerWord(string WordText, string WordInFrench, int Tier, School school, decimal potentia, decimal arcainum, decimal flux, bool isHidden = false) 
        : base(WordText, WordInFrench, Tier, school, isHidden)
    {
        Potentia = potentia;
        Arcainum = arcainum;
        Flux = flux;
    }
}