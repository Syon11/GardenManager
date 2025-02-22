using System.Text.Json.Serialization;
using GardenManager.Enums;

namespace GardenManager.Model;

public class Tile
{
    public Plant? Plant { get; set; }
    public Essence? Essence_Override { get; set; }
    public User? Owner { get; set; }
    public bool IsProtected { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    
    public Tile(){}
    
    public Tile(List<Plant> plants, int x, int y)
    {
        Random rnd = new Random();
        int rng = rnd.Next(0, 100);
        if (rng < 50)
            Plant = null;
        else if (rng < 80)
        {
            int rndEssence = rnd.Next(0, 8);
            int rndGenus = rnd.Next(0, 4);
            Plant = GenerateWeed();
        }
            
        else
            Plant = plants[rnd.Next(0, plants.Count)];
        Essence_Override = null;
        Owner = null;
        X = x;
        Y = y;
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

    public Plant? GenerateWeed()
    {
        Random rnd = new Random();
        int rndEssence = rnd.Next(0, 8);
        int rndGenus = rnd.Next(0, 4);
        if (!IsProtected)
        {
            return new Plant(96, "Mauvaise herbe", (Essence)rndEssence, (Genus)rndGenus, new List<Effect>(), SecondaryEffect.Toxique);
        }
        else
        {
            return Plant;
        }
    }

    public void SetProtected()
    {
        IsProtected = true;
    }
}