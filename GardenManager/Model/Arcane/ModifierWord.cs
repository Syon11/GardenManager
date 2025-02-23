using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public class ModifierWord : ConfigWord
{
    ArcaneModifier Modifier { get; set; }
    public ModifierWord
    (
        string WordText, 
        string WordInFrench, 
        int Tier, 
        School school, 
        float potentiaEffect,
        float arcainumEffect, 
        float fluxEffect, 
        ArcaneModifier arcaneModifier
    ) 
        : base(
            WordText, 
            WordInFrench, 
            Tier, 
            school,
            potentiaEffect, 
            arcainumEffect, 
            fluxEffect
        )
    {
        Modifier = arcaneModifier;
    }
}