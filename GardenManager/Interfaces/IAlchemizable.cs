using GardenManager.Enums;

namespace GardenManager.Interfaces;

public interface IAlchemizable
{
    List<Effect> AlchemicalEffects { get; set; }
    SecondaryEffect SecondaryEffect { get; set; }
    Essence Essence { get; set; }
    string Name { get; set; }
}