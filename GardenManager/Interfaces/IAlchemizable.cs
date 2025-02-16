using GardenManager.Enums;

namespace GardenManager.Interfaces;

public interface IAlchemizable
{
    List<Effect> AlchemicalEffects { get; set; }
}