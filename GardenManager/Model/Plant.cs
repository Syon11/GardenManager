using System.Text.Json.Serialization;
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

    public Plant(){}
    
    public Plant(long Id, string Name, Essence Essence, Genus Genus, List<Effect> Effects, SecondaryEffect SecondaryEffect)
    {
        this.Id = Id;
        this.Name = Name;
        this.Essence = Essence;
        this.Genus = Genus;
        this.Effects = Effects;
        this.SecondaryEffect = SecondaryEffect;
    }

    public Plant(long id, string name, Essence essence, Genus genus)
    {
        Id = id;
        Name = name;
        Essence = essence;
        Genus = genus;
        Effects = [];
        SecondaryEffect = SecondaryEffect.Aucun;
    }
}