using GardenManager.Enums;
using GardenManager.Utility;

namespace GardenManager.Model;

public class Garden
{
    public int Id { get; set; }
    public WeatherEffects WeatherEffect { get; set; } = WeatherEffects.Sunny;
    public List<List<Tile>> Tiles { get; set; } = new List<List<Tile>>();

    public Garden(){}
    
    public void Init(List<Plant> plants)
    {
        Tiles.Add(new List<Tile>());
        Tiles.Add(new List<Tile>());
        Tiles.Add(new List<Tile>());
        Tiles.Add(new List<Tile>());
        int i = 0;
        foreach (List<Tile> list in Tiles)
        {
            list.Add(new Tile(plants, 0, i));
            list.Add(new Tile(plants, 1, i));
            list.Add(new Tile(plants, 2, i));
            list.Add(new Tile(plants, 3, i));
            i++;
        }
    }

    public void Handle(ConsoleDisplay CD, List<Plant> plants, User user)
    {
        bool inMenu = true;
        while (inMenu)
        {
            CD.DisplayGardenGrid(this);
            string? action = Console.ReadLine();
            if (string.IsNullOrEmpty(action) || !InputValidator.ValidateEntryWithRegex(action, $"^[1-9][0-{Tiles.Count}][0-{Tiles[0].Count}]$"))
            {
                Console.Write("Invalid input, please try again: ");
                action = Console.ReadLine();
            }

            switch (action![0])
            {
                case('0'):
                    PurchasePlot(user, action);
                    break;
                case('1'):
                    HandlePlanting(user, CD, plants, action);
                    break;
                case('2'):
                    HandleHarvest(user, action);
                    break;
                case('3'):
                    HandleFertilizing(user, action);
                    break;
                case('4'):
                    GrowRow();
                    break;
                case('5'):
                    GrowCol();
                    break;
                case('6'):
                    ChangeWeather();
                    break;
                case('7'):
                    EndTurn();
                    break;
                case('8'):
                    ExaminePlot(action);
                    break;
                case('9'):
                    inMenu = false;
                    break;
            }
        }
    }

    private void ExaminePlot(string action)
    {
        Console.Clear();
        if (Tiles[action[1] - '0'][action[2] - '0'].Plant != null)
        {
            Console.WriteLine($"Plant: {Tiles[action[1] - '0'][action[2] - '0'].Plant!.Name}");
            Console.WriteLine($"Growth stage: {Tiles[action[1] - '0'][action[2] - '0'].Plant!.currentGrowth}/{Tiles[action[1] - '0'][action[2] - '0'].Plant!.growthTime}");
        }
        else
        {
            Console.WriteLine("Plant: None");
        }

        if (Tiles[action[1] - '0'][action[2] - '0'].Owner != null)
        {
            Console.WriteLine($"Owner: {Tiles[action[1] - '0'][action[2] - '0'].Owner!.Name}");
        }
        else
        {
            Console.WriteLine("Owner: None");
        }
    }

    private void PurchasePlot(User? user, string action)
    {
        if (user != null)
        {
            Tiles[action[1] - '0'][action[2] - '0'].Owner = user;
        }
    }
    private void HandlePlanting(User user, ConsoleDisplay CD, List<Plant> plants, string action)
    {
        if (VerifyOwnership(user, Tiles[action[1] - '0'][action[2] - '0']))
        {
            CD.DisplayPlantListing(plants);
            string? selection = Console.ReadLine();
            if (string.IsNullOrEmpty(selection) || !InputValidator.ValidateEntryWithRegex(selection, "^[0-9]{1,3}$"))
            {
                Console.Write("Invalid input, please try again: ");
                selection = Console.ReadLine();
            }

            Tiles[action[1] - '0'][action[2] - '0'].Plant = new Plant(plants[int.Parse(selection!)]);
        }
        else
        {
            Console.Write("The user doesn't own this plot");
        }
    }

    private void HandleHarvest(User user, string action)
    {
        if (VerifyOwnership(user, Tiles[action[1] - '0'][action[2] - '0']))
        {
            Random rnd = new Random();
            Plant? plant = Tiles[action[1] - '0'][action[2] - '0'].Plant;

            Console.WriteLine("Which type of harvesting will you use?");
            Console.WriteLine("1) Gentle harvest (Low yield, better chance to keep plant intact)");
            Console.WriteLine("2) Savage harvest (Better yield, will break plant)");
            string? skill = Console.ReadLine();
            if (string.IsNullOrEmpty(skill) || !InputValidator.ValidateEntryWithRegex(skill, "^[1-2]{1}$"))
            {
                Console.Write("Invalid input, please try again: ");
                skill = Console.ReadLine();
            }
            bool isPlantBroken = false;
            int chance = rnd.Next(0, 100);
            if (skill!.Equals("1"))
            {
                if (chance < 20)
                {
                    isPlantBroken = true;
                }
            }
            else
            {
                if (chance < 90)
                {
                    isPlantBroken = true;
                }
            }
            if (plant != null)
            {
                if (plant.currentGrowth < plant.growthTime)
                {
                    Console.WriteLine($"Harvested: {plant.Name} seed x 1");    
                } 
                else
                {
                    int yield = skill.Equals("2") ? rnd.Next(1, plant.growthTime * 3) : rnd.Next(0, plant.growthTime / 2) + 1;
                    int seedYield = skill.Equals("2") ? rnd.Next(1, plant.growthTime * 5) / 6 : 1;
                    Console.WriteLine($"Harvested: {plant.Name} x {yield}");
                    if (seedYield > 0)
                        Console.WriteLine($"Harvested: {plant.Name} seed x {seedYield}");
                }
            }
            if (isPlantBroken)
            {
                Tiles[action[1] - '0'][action[2] - '0'].Plant = null;
            }
        }
        else
        {
            Console.WriteLine("The user doesn't own this plot");
        }
        
    }

    private void HandleFertilizing(User user, string action)
    {
        if (VerifyOwnership(user, Tiles[action[1] - '0'][action[2] - '0']))
        {
            Console.WriteLine("Which type of fertilizing will you use?");
            Console.WriteLine("1) Essence Fertilizer");
            Console.WriteLine("2) Other Fertilizer");
            string? act = Console.ReadLine();
            if (string.IsNullOrEmpty(action) || !InputValidator.ValidateEntryWithRegex(action, "^[1-2]{1}$"))
            {
                Console.Write("Invalid input, please try again: ");
                act = Console.ReadLine();
            }

            if (act!.Equals("1"))
            {
                int iter = 0;
                Console.WriteLine("Select a fertilizer");
                foreach (string essence in Enum.GetNames(typeof(Essence)))
                {
                    iter++;
                    Console.WriteLine($"{iter}) {essence} Fertilizer");
                }
                Console.Write("Enter your selection: ");
                string? selection = Console.ReadLine();
                if (string.IsNullOrEmpty(selection) || !InputValidator.ValidateEntryWithRegex(selection, "^[1-8]{1}$"))
                {
                    Console.Write("Invalid input, please try again: ");
                    selection = Console.ReadLine();
                }
                Tiles[action[1]][action[2]].Essence_Override = (Essence)iter - 1;
            }
            else
            {
                Console.WriteLine("No other fertilizer implemented yet");   
            }    
        }
        else
        {
            Console.WriteLine("The user doesn't own this plot");
        }

        
    }

    private bool VerifyOwnership(User user, Tile tile)
    {
        if (tile.Owner != null)
        {
            return user.Id == tile.Owner.Id;    
        }
        return false;
    }
    private void GrowRow()
    {
        Tiles.Add(new List<Tile>());
        for (int i = 0; i < Tiles[0].Count; i++)
        {
            Tiles.Last().Add(new Tile());
        }
    }

    private void GrowCol()
    {
        for (int i = 0; i < Tiles.Count; i++)
        {
            Tiles[i].Add(new Tile());
        }
    }

    private void ChangeWeather()
    {
        
    }

    private void EndTurn()
    {
        Random rnd = new Random();
        Genus firstType = (Genus)rnd.Next(0, 3);
        Genus secondType;
        do
        {
            secondType = (Genus)rnd.Next(0, 3);
        } while (secondType == firstType);

        Genus thirdType;
        do
        {
            thirdType = (Genus)rnd.Next(0, 3);
        } while (thirdType == firstType || thirdType == secondType);


        for (int i = 0; i < Tiles.Count; i++)
        {
            for (int j = 0; j < Tiles[i].Count; j++)
            {
                if (Tiles[i][j].Plant != null)
                {
                    if (Tiles[i][j].Plant!.Genus == firstType)
                    {
                        Tiles[i][j].Plant!.Propagate(this, i, j, Tiles.Count, Tiles[i].Count);
                        ResetPropagation();
                        Tiles[i][j].Plant!.currentGrowth++;
                    }

                    if (Tiles[i][j].Plant!.Genus == Genus.Communicante)
                    {
                        Tiles[i][j].Plant!.currentGrowth++;
                    }
                }
            }
        }
        for (int i = 0; i < Tiles.Count; i++)
        {
            for (int j = 0; j < Tiles[i].Count; j++)
            {
                if (Tiles[i][j].Plant != null)
                {
                    if (Tiles[i][j].Plant!.Genus == secondType)
                    {
                        Tiles[i][j].Plant!.Propagate(this, i, j, Tiles.Count, Tiles[i].Count);
                        ResetPropagation();
                        Tiles[i][j].Plant!.currentGrowth++;
                    }
                }
            }
        }
        for (int i = 0; i < Tiles.Count; i++)
        {
            for (int j = 0; j < Tiles[i].Count; j++)
            {
                if (Tiles[i][j].Plant != null)
                {
                    if (Tiles[i][j].Plant!.Genus == thirdType)
                    {
                        Tiles[i][j].Plant!.Propagate(this, i, j, Tiles.Count, Tiles[i].Count);
                        ResetPropagation();
                        Tiles[i][j].Plant!.currentGrowth++;
                    }
                }
            }
        }
        
        // OUTLINE:
        // Determine first, second and third plant type
        // Act fist plant type invasions
        // Act 2nd plant type invasions
        // Act 3rd plant type invations
        // Act weeds invations
        // Act edge infestations
        // Act Weather effect

    }

    private void ResetPropagation()
    {
        for (int i = 0; i < Tiles.Count; i++)
        {
            for (int j = 0; j < Tiles[i].Count; j++)
            {
                if (Tiles[i][j].Plant != null)
                    Tiles[i][j].Plant!.hasPropagated = false;
            }
        }
    }
}