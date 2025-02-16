using System.Numerics;
using System.Text.Json.Serialization;
using GardenManager.Enums;
using GardenManager.Interfaces;
using GardenManager.Utility;

namespace GardenManager.Model;

public class Plant : IAlchemizable
{
    private const int EssenceSame = 25;
    private const int EssenceDifferent = 0;
    private const int EssenceOpposite = -25;
    private const int EssenceAlignedSame = 50;
    private const int EssenceAlignedDifferent = 25;
    private const int EssenceAlignedOpposite = 0;
    private const int GenusAdvantage = 50;
    private const int GenusSame = 25;
    private const int GenusDisadvantage = -25;
    
    public long Id { get; set; }
    public string Name { get; set; }
    public Essence Essence { get; set; }
    public Genus Genus { get; set; }
    public List<Effect> AlchemicalEffects { get; set; }
    public SecondaryEffect SecondaryEffect { get; set; }
    public int growthTime { get; set; }
    public int currentGrowth { get; set; }
    public bool hasPropagated { get; set; } = false;
    
    
    public Plant(){}
    
    public Plant(long Id, string Name, Essence Essence, Genus Genus, List<Effect> alchemicalEffects, SecondaryEffect SecondaryEffect)
    {
        this.Id = Id;
        this.Name = Name;
        this.Essence = Essence;
        this.Genus = Genus;
        this.AlchemicalEffects = alchemicalEffects;
        this.SecondaryEffect = SecondaryEffect;

        Random random = new Random();
        this.growthTime = random.Next(1, 3);
        this.currentGrowth = 0;
    }

    public Plant(long id, string name, Essence essence, Genus genus)
    {
        Id = id;
        Name = name;
        Essence = essence;
        Genus = genus;
        AlchemicalEffects = [];
        SecondaryEffect = SecondaryEffect.Aucun;
        
        Random random = new Random();
        this.growthTime = random.Next(1, 3);
        this.currentGrowth = 0;
    }

    public Plant(Plant plant)
    {
        Id = plant.Id;
        Name = plant.Name;
        Essence = plant.Essence;
        Genus = plant.Genus;
        AlchemicalEffects = plant.AlchemicalEffects;
        SecondaryEffect = plant.SecondaryEffect;
        growthTime = plant.growthTime;
        currentGrowth = 0;
    }
    
    public void Modify(ConsoleDisplay CD)
    {
        Console.WriteLine($"Selected plant: {Name}");
        Console.Write("Enter the new plant name: ");
        string? name = Console.ReadLine();
        CD.DisplayEssenceListing();
        Console.Write("Enter the new plant Essence: ");
        string? essence = Console.ReadLine();
        while (!InputValidator.ValidateEntryWithRegex(essence!, @"^[0-7]{1}$"))
        {
            Console.Write("Invalid entry, Try again: ");
            essence = Console.ReadLine();
        }
        Essence actualEssence = (Essence)int.Parse(essence!);
        CD.DisplayGenusListing();
        Console.Write("Enter the new plant genus: ");
        string? genus = Console.ReadLine();
        while (!InputValidator.ValidateEntryWithRegex(genus!, @"^[0-3]{1}$"))
        {
            Console.Write("Invalid entry, Try again: ");
            genus = Console.ReadLine();
        }
        Genus actualGenus = (Genus)int.Parse(genus!);
        List<Effect> effects = new List<Effect>();
        for (int i = 0; i < 4; i++)
        {
            CD.DisplayEffectListing();
            Console.Write($"Enter the new plant effect number {i + 1}: ");
            string? effect = Console.ReadLine();
            while (!InputValidator.ValidateEntryWithRegex(effect!, @"^[0-9]{1,2}$"))
            {
                Console.Write("Invalid entry, Try again: ");
                effect = Console.ReadLine();
            }
            effects.Add((Effect)int.Parse(effect));
        }
        Name = name!;
        Essence = actualEssence;
        Genus = actualGenus;
        AlchemicalEffects = effects;
    }

    public void Grow()
    {
        if (currentGrowth < growthTime)
            currentGrowth++;
    }
    
    public void Propagate(Garden garden, int y, int x, int maxY, int maxX, Plant? originator = null)
    {
        if (!hasPropagated)
        {
            Random rng = new Random();
            hasPropagated = true;
            Vector2 tile = new Vector2(y - 1, x);
            List<Tile> tilesToPropagate = new List<Tile>();
            if (tile.X >= 0)
            {
                tilesToPropagate.Add(garden.Tiles[(int)tile.X][(int)tile.Y]);
            }
            tile = new Vector2(y + 1, x);
            if (tile.X < maxX)
            {

                tilesToPropagate.Add(garden.Tiles[(int)tile.X][(int)tile.Y]);
            }
            tile = new Vector2(y, x - 1);
            if (tile.Y >= 0)
            {
                tilesToPropagate.Add(garden.Tiles[(int)tile.X][(int)tile.Y]);
            }
            tile = new Vector2(y, x + 1);
            if (tile.Y < maxY)
            {
                tilesToPropagate.Add(garden.Tiles[(int)tile.X][(int)tile.Y]);
            }

            List<Tile> tilesToRemove = new List<Tile>();
            
            foreach (Tile tileToPropagate in tilesToPropagate)
            {
                if (originator == null)
                {
                    if (tileToPropagate.Plant != null && tileToPropagate.Plant.Id == Id)
                    {
                        tilesToRemove.Add(tileToPropagate);
                    }    
                }
                else
                {
                    if (tileToPropagate.Plant != null && tileToPropagate.Plant.Id == originator.Id)
                    {
                        tilesToRemove.Add(tileToPropagate);
                    }
                }
            }

            foreach (Tile tileToRemove in tilesToRemove)
            {
                tilesToPropagate.Remove(tileToRemove);
            }
            
            foreach (Tile tileToPropagate in tilesToPropagate)
            {
                int interractibility = 25;
                if (tileToPropagate.Plant != null)
                {
                    interractibility = GetGenusInterractibility(Genus, tileToPropagate.Plant!.Genus);
                    interractibility += GetEssenceInterractibility(Essence, tileToPropagate.Plant!.Essence);
                }

                int rngResult = rng.Next(0, 100);

                if (rngResult < interractibility && tileToPropagate.Plant != null)
                {
                    if (tileToPropagate.Plant.Genus != Genus.Communicante)
                    {
                        tileToPropagate.Plant = new Plant(this);
                    }
                    else
                    {
                        if (originator == null)
                        {
                            tileToPropagate.Plant.Propagate(garden, tileToPropagate.Y, tileToPropagate.X, maxY, maxX);
                        }
                        else
                        {
                            tileToPropagate.Plant.Propagate(garden, tileToPropagate.Y, tileToPropagate.X, maxY, maxX,
                                originator);
                        }
                    }
                }
                else if (rngResult < interractibility)
                {
                    tileToPropagate.Plant = new Plant(this);
                }
            }
        }
    }
    
   
    private int GetGenusInterractibility(Genus originator, Genus subject)
    {
        switch (originator)
        {
            case Genus.Invasive:
                switch (subject)
                {
                    case Genus.Invasive:
                        return GenusSame;
                    case Genus.Bulbe:
                        return GenusAdvantage;
                    case Genus.Grimpante:
                        return GenusDisadvantage;
                }
                break;
            case Genus.Grimpante:
                switch (subject)
                {
                    case Genus.Grimpante:
                        return GenusSame;
                    case Genus.Bulbe:
                        return GenusDisadvantage;
                    case Genus.Invasive:
                        return GenusAdvantage;
                }
                break;
            case Genus.Bulbe:
                switch (subject)
                {
                    case Genus.Bulbe:
                        return GenusSame;
                    case Genus.Grimpante:
                        return GenusAdvantage;
                    case Genus.Invasive:
                        return GenusDisadvantage;
                }
                break;
        }
        return 50;
    }

    private int GetEssenceInterractibility(Essence originator, Essence subject)
    {
        switch (originator)
        {
            case Essence.Acide:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceAlignedSame;
                    case Essence.Feu:
                        return EssenceAlignedDifferent;
                    case Essence.Foudre:
                        return EssenceAlignedOpposite;
                    case Essence.Glace:
                        return EssenceAlignedDifferent;
                    case Essence.Lune:
                        return EssenceDifferent;
                    case Essence.Mort:
                        return EssenceSame;
                    case Essence.Soleil:
                        return EssenceDifferent;
                    case Essence.Vie:
                        return EssenceOpposite;
                }
                break;
            case Essence.Feu:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceAlignedDifferent;
                    case Essence.Feu:
                        return EssenceAlignedSame;
                    case Essence.Foudre:
                        return EssenceAlignedDifferent;
                    case Essence.Glace:
                        return EssenceAlignedOpposite;
                    case Essence.Lune:
                        return EssenceOpposite;
                    case Essence.Mort:
                        return EssenceDifferent;
                    case Essence.Soleil:
                        return EssenceSame;
                    case Essence.Vie:
                        return EssenceDifferent;
                }
                break;
            case Essence.Foudre:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceAlignedOpposite;
                    case Essence.Feu:
                        return EssenceAlignedDifferent;
                    case Essence.Foudre:
                        return EssenceAlignedSame;
                    case Essence.Glace:
                        return EssenceAlignedDifferent;
                    case Essence.Lune:
                        return EssenceDifferent;
                    case Essence.Mort:
                        return EssenceOpposite;
                    case Essence.Soleil:
                        return EssenceDifferent;
                    case Essence.Vie:
                        return EssenceSame;
                }
                break;
            case Essence.Glace:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceAlignedDifferent;
                    case Essence.Feu:
                        return EssenceAlignedOpposite;
                    case Essence.Foudre:
                        return EssenceAlignedDifferent;
                    case Essence.Glace:
                        return EssenceAlignedSame;
                    case Essence.Lune:
                        return EssenceSame;
                    case Essence.Mort:
                        return EssenceDifferent;
                    case Essence.Soleil:
                        return EssenceOpposite;
                    case Essence.Vie:
                        return EssenceDifferent;
                }
                break;
            case Essence.Lune:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceDifferent;
                    case Essence.Feu:
                        return EssenceOpposite;
                    case Essence.Foudre:
                        return EssenceDifferent;
                    case Essence.Glace:
                        return EssenceSame;
                    case Essence.Lune:
                        return EssenceAlignedSame;
                    case Essence.Mort:
                        return EssenceAlignedDifferent;
                    case Essence.Soleil:
                        return EssenceAlignedOpposite;
                    case Essence.Vie:
                        return EssenceAlignedDifferent;
                }
                break;
            case Essence.Mort:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceSame;
                    case Essence.Feu:
                        return EssenceDifferent;
                    case Essence.Foudre:
                        return EssenceOpposite;
                    case Essence.Glace:
                        return EssenceDifferent;
                    case Essence.Lune:
                        return EssenceAlignedDifferent;
                    case Essence.Mort:
                        return EssenceAlignedSame;
                    case Essence.Soleil:
                        return EssenceAlignedDifferent;
                    case Essence.Vie:
                        return EssenceAlignedOpposite;
                }
                break;
            case Essence.Soleil:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceDifferent;
                    case Essence.Feu:
                        return EssenceSame;
                    case Essence.Foudre:
                        return EssenceDifferent;
                    case Essence.Glace:
                        return EssenceOpposite;
                    case Essence.Lune:
                        return EssenceAlignedOpposite;
                    case Essence.Mort:
                        return EssenceAlignedDifferent;
                    case Essence.Soleil:
                        return EssenceAlignedSame;
                    case Essence.Vie:
                        return EssenceAlignedDifferent;
                }
                break;
            case Essence.Vie:
                switch (subject)
                {
                    case Essence.Acide:
                        return EssenceOpposite;
                    case Essence.Feu:
                        return EssenceDifferent;
                    case Essence.Foudre:
                        return EssenceSame;
                    case Essence.Glace:
                        return EssenceDifferent;
                    case Essence.Lune:
                        return EssenceAlignedDifferent;
                    case Essence.Mort:
                        return EssenceAlignedOpposite;
                    case Essence.Soleil:
                        return EssenceAlignedDifferent;
                    case Essence.Vie:
                        return EssenceAlignedSame;
                }
                break;
        }
        return 0;
    }

    public void ModifyName()
    {
        Console.Write("Please enter a new name for the plant: ");
        string? newName = Console.ReadLine();
        while (string.IsNullOrEmpty(newName) || !InputValidator.ValidateEntryWithRegex(newName, @"^\w{4,80}$"))
        {
            Console.Write("Invalid name, Please try again: ");
            newName = Console.ReadLine();
        }

        Name = newName;
    }
}