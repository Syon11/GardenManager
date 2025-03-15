using System.Text;

namespace GardenManager.Model.Arcane;

public class FormattedSpell
{
    public int ManaCost { get; set; }
    public int? HpCost { get; set; }
    public int SpellLevel { get; set; }
    public string Description { get; set; }
    public string Incantation { get; set; }
    public string? Shape { get; set; }
    public string? ShapeDescription { get; set; }

    public FormattedSpell() {}
    public FormattedSpell(Spell spell)
    {
        ManaCost = spell.ManaCost;
        if (spell.HealthCost != 0)
        {
            HpCost = spell.HealthCost;
        }
        SpellLevel = spell.SpellLevel;
        StringBuilder sb = new StringBuilder();
        sb.Append(spell.SpellDescription);
        sb.Append(spell.ModifierDescriptions);
        Description = sb.ToString();
        StringBuilder incantation = new StringBuilder();
        foreach (Word word in spell.Incantation)
        {
            incantation.Append($"{word.WordText} ");
        }
        Incantation = incantation.ToString();
        Shape = spell.Shape.Name;
        ShapeDescription = spell.Shape.DescriptionAtThresholds[spell.ShapeTier];
    }
    
    
}