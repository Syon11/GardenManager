using GardenManager.Enums;

namespace GardenManager.Model;

public class Plant
{
    public long Id { get; set; }
    public string Name { get; set; }
    public Essence Essence { get; set; }
    public Genus Genus { get; set; }
    public List<Effect> Effects { get; set; }
    public SecondaryEffect SecondaryEffect { get; set; }

    public Plant(string name, Essence essence, Genus genus, List<Effect> effects, SecondaryEffect secondaryEffect)
    {
        Name = name;
        Essence = essence;
        Genus = genus;
        Effects = effects;
        SecondaryEffect = secondaryEffect;
    }
}