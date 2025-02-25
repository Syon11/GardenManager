using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public class PowerWord : Word
{
    int Potentia { get; set; }
    int Arcainum { get; set; }
    int Flux { get; set; }

    public PowerWord(string WordText, string WordInFrench, int Tier, School school, int potentia, int arcainum, int flux, bool isHidden = false) 
        : base(WordText, WordInFrench, Tier, school, isHidden)
    {
        Potentia = potentia;
        Arcainum = arcainum;
        Flux = flux;
    }
}