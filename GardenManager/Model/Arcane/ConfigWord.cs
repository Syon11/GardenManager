using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public abstract class ConfigWord : Word
{
    public float PotentiaEffect { get; set; }
    public float ArcainumEffect { get; set; }
    public float FluxEffect { get; set; }
    
    public ConfigWord(string WordText, string WordInFrench, int Tier, School school, float potentiaEffect, float arcainumEffect, float fluxEffect, bool isHidden = false) : base(WordText, WordInFrench, Tier, school, isHidden)
    {
        PotentiaEffect = potentiaEffect;
        ArcainumEffect = arcainumEffect;
        FluxEffect = fluxEffect;
    }
}