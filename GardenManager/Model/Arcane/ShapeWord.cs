using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public class ShapeWord : ConfigWord
{
    public ArcaneShape Shape { get; set; }
    
    public ShapeWord
    (
        string WordText, 
        string WordInFrench, 
        int Tier, 
        School school, 
        float potentiaEffect,
        float arcainumEffect, 
        float fluxEffect, 
        ArcaneShape arcaneShape
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
        Shape = arcaneShape;
    }
}