using System.Text.Json.Serialization;
using GardenManager.Enums;

namespace GardenManager.Model;

public class Tile
{
    public Plant? Plant { get; set; }
    public Essence? Essence_Override { get; set; }
    public User? Owner { get; set; }
    
    public Tile(){}
    
    public Tile(List<Plant> plants)
    {
        Random rnd = new Random();
        int rng = rnd.Next(0, 100);
        if (rng < 50)
            Plant = null;
        else if (rng < 80)
            Plant = plants[0];
        else 
            Plant = plants[rnd.Next(0, plants.Count)];
        Essence_Override = null;
        Owner = null;
    }

    public Tile(Plant? plant, Essence? essence, User? owner)
    {
        Plant = plant ?? null;
        Essence_Override = essence ?? null;
        Owner = owner ?? null;
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