namespace GardenManager.Model.Arcane;

public class Spell
{
    public List<Word> Incantation { get; set; }
    public List<ArcaneEffect> Effects { get; set; }
    public List<int> EffectTiers { get; set; }
    public ArcaneShape Shape { get; set; }
    public List<ArcaneModifier> Modifiers { get; set; }
    public List<int> ModifierTiers { get; set; }
    
}