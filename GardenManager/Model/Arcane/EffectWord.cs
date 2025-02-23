using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public class EffectWord : ConfigWord
{
    ArcaneEffect Effect { get; set; }

    public EffectWord
    (
        string WordText, 
        string WordInFrench, 
        int Tier, 
        School school, 
        float potentiaEffect,
        float arcainumEffect, 
        float fluxEffect, 
        ArcaneEffect arcaneEffect
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
        Effect = arcaneEffect;
    }
}