using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public class ModifierWord : ConfigWord
{
    public ArcaneModifier? Modifier { get; set; }
    public bool IsSchoolWord { get; set; } 
    public ModifierWord
    (
        string WordText, 
        string WordInFrench, 
        int Tier, 
        School school, 
        float potentiaEffect,
        float arcainumEffect, 
        float fluxEffect, 
        ArcaneModifier? arcaneModifier = null,
        bool isHidden = false,
        bool isSchoolWord = false
    ) 
        : base(
            WordText, 
            WordInFrench, 
            Tier, 
            school,
            potentiaEffect, 
            arcainumEffect, 
            fluxEffect,
            isHidden
        )
    {
        Modifier = arcaneModifier;
        IsSchoolWord = isSchoolWord;
    }
}