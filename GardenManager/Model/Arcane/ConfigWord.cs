using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public abstract class ConfigWord : Word
{
    private float PotentiaEffect { get; set; }
    private float ArcainumEffect { get; set; }
    private float FluxEffect { get; set; }

    public ConfigWord(string WordText, string WordInFrench, int Tier, School school, float potentiaEffect, float arcainumEffect, float fluxEffect, bool isHidden = false) : base(WordText, WordInFrench, Tier, school, isHidden)
    {
        PotentiaEffect = potentiaEffect;
        ArcainumEffect = arcainumEffect;
        FluxEffect = fluxEffect;
    }
}