using GardenManager.Enums;
using GardenManager.Interfaces;

namespace GardenManager.Model;

public class Ore : IAlchemizable
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Effect> AlchemicalEffects { get; set; }
    public SecondaryEffect SecondaryEffect { get; set; }
    public Essence Essence { get; set; }
    public int Depth { get; set; }
    public int Tier { get; set; }
    public bool IsMineable { get; set; }

    public Ore(){}
    
    public Ore(int id, string name, string description, List<Effect> alchemicalEffects, Essence essence, int depth, int tier, bool isMineable)
    {
        Id = id;
        Name = name;
        Description = description;
        AlchemicalEffects = alchemicalEffects;
        Essence = essence;
        Depth = depth;
        Tier = tier;
        IsMineable = isMineable;
    }
    
}