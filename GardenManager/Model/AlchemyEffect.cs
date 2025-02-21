using GardenManager.Enums;

namespace GardenManager.Model;

public class AlchemyEffect(Effect effect, Essence essence)
{
    public Effect Effect { get; set; } = effect;
    public Essence Essence { get; set; } = essence;
}