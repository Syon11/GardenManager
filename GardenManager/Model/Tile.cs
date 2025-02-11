using GardenManager.Enums;

namespace GardenManager.Model;

public class Tile
{
    private long Id;
    private Plant? Plant;
    private Essence? Essence_Override;
    private User? Owner;

    public Tile()
    {
        Plant = null;
        Essence_Override = null;
        Owner = null;
    }

    public void PlantSeed(Plant plant)
    {
        Plant = plant;
    }

    public void FertilizeEssence(Essence essence)
    {
        Essence_Override = essence;
    }

    public void ChangeOwner(User owner)
    {
        Owner = owner;
    }
}