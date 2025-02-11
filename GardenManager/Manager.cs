using GardenManager.Enums;
using GardenManager.Model;
using System.Text.Json;

namespace GardenManager;

public class Manager
{
    private List<Plant> Plants { get; set; }
    private List<User> Users { get; set; }
    private const string JsonPlants = "plants.json";
    private const string JsonUsers = "users.json";

    public Manager()
    {
        Plants = [];
        Users = [];
        Init();
        Run();
    }

    private void Run()
    {
        
    }
    
    private void Init()
    {
        if (!File.Exists(JsonPlants))
        {
            InitPlantsBase();
            RandomizeEffects();
            SavePlantsToFile();
        }
        else
        {
            LoadPlantsFromFile();
        }
        LoadUsersFromFile();
    }
    
    private void InitPlantsBase()
    {
        Plants =
        [
            new Plant("Baies Poilues du Désert", Essence.Acide, Genus.Grimpante),
            new Plant("Azalée", Essence.Acide, Genus.Bulbe),
            new Plant("Datura", Essence.Acide, Genus.Invasive),
            new Plant("Oeillet", Essence.Acide, Genus.Communicante),
            new Plant("Pissenlit", Essence.Acide, Genus.Grimpante),
            new Plant("Vikrolier", Essence.Acide, Genus.Bulbe),
            new Plant("Plante Mystérieuse 1", Essence.Acide, Genus.Invasive),
            new Plant("Bleuet de l'enfer", Essence.Acide, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Acide, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Acide, Genus.Bulbe),
            new Plant("Plante Mystérieuse 5", Essence.Acide, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Acide, Genus.Communicante),
            new Plant("Piment Defoego", Essence.Feu, Genus.Grimpante),
            new Plant("Cactus", Essence.Feu, Genus.Bulbe),
            new Plant("Chardon", Essence.Feu, Genus.Invasive),
            new Plant("Rose", Essence.Feu, Genus.Communicante),
            new Plant("Yucca", Essence.Feu, Genus.Grimpante),
            new Plant("Aetubosie", Essence.Feu, Genus.Bulbe),
            new Plant("Plante mystérieuse 1", Essence.Feu, Genus.Invasive),
            new Plant("Plante mystérieuse 2", Essence.Feu, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Feu, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Feu, Genus.Bulbe),
            new Plant("Plante mystérieuse 5", Essence.Feu, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Feu, Genus.Communicante),
            new Plant("Ail d'eau", Essence.Glace, Genus.Grimpante),
            new Plant("Dahlia", Essence.Glace, Genus.Bulbe),
            new Plant("Perce-Neige", Essence.Glace, Genus.Invasive),
            new Plant("Marguerite", Essence.Glace, Genus.Communicante),
            new Plant("Églantier", Essence.Glace, Genus.Grimpante),
            new Plant("Méliot Arctique", Essence.Glace, Genus.Bulbe),
            new Plant("Plante mystérieuse 1", Essence.Glace, Genus.Invasive),
            new Plant("Plante mystérieuse 2", Essence.Glace, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Glace, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Glace, Genus.Bulbe),
            new Plant("Plante mystérieuse 5", Essence.Glace, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Glace, Genus.Communicante),
            new Plant("Laitue Sauvage", Essence.Foudre, Genus.Grimpante),
            new Plant("Capucine", Essence.Foudre, Genus.Bulbe),
            new Plant("Pivoine", Essence.Foudre, Genus.Invasive),
            new Plant("Gueule de Loup", Essence.Foudre, Genus.Communicante),
            new Plant("Alstroemère", Essence.Foudre, Genus.Grimpante),
            new Plant("Iothenfore", Essence.Foudre, Genus.Bulbe),
            new Plant("Plante mystérieuse 1", Essence.Foudre, Genus.Invasive),
            new Plant("Plante mystérieuse 2", Essence.Foudre, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Foudre, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Foudre, Genus.Bulbe),
            new Plant("Plante mystérieuse 5", Essence.Foudre, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Foudre, Genus.Communicante),
            new Plant("Fleur d'Arkasé", Essence.Vie, Genus.Grimpante),
            new Plant("Souci", Essence.Vie, Genus.Bulbe),
            new Plant("Lys", Essence.Vie, Genus.Invasive),
            new Plant("Giroflée", Essence.Vie, Genus.Communicante),
            new Plant("Immortelle", Essence.Vie, Genus.Grimpante),
            new Plant("Souci des Miracles", Essence.Vie, Genus.Bulbe),
            new Plant("Plante mystérieuse 1", Essence.Vie, Genus.Invasive),
            new Plant("Plante mystérieuse 2", Essence.Vie, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Vie, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Vie, Genus.Bulbe),
            new Plant("Plante mystérieuse 5", Essence.Vie, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Vie, Genus.Communicante),
            new Plant("Lichen Noir", Essence.Mort, Genus.Grimpante),
            new Plant("Violette", Essence.Mort, Genus.Bulbe),
            new Plant("Muguet", Essence.Mort, Genus.Invasive),
            new Plant("Capucine des fous", Essence.Mort, Genus.Communicante),
            new Plant("Lierre", Essence.Mort, Genus.Grimpante),
            new Plant("Aamogale", Essence.Mort, Genus.Bulbe),
            new Plant("Plante mystérieuse 1", Essence.Mort, Genus.Invasive),
            new Plant("Plante mystérieuse 2", Essence.Mort, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Mort, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Mort, Genus.Bulbe),
            new Plant("Plante mystérieuse 5", Essence.Mort, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Mort, Genus.Communicante),
            new Plant("Papaye Impériale", Essence.Soleil, Genus.Grimpante),
            new Plant("Tournesol", Essence.Soleil, Genus.Bulbe),
            new Plant("Jonquille", Essence.Soleil, Genus.Invasive),
            new Plant("Zinnia", Essence.Soleil, Genus.Communicante),
            new Plant("Pétunia", Essence.Soleil, Genus.Grimpante),
            new Plant("Biaire", Essence.Soleil, Genus.Bulbe),
            new Plant("Plante mystérieuse 1", Essence.Soleil, Genus.Invasive),
            new Plant("Plante mystérieuse 2", Essence.Soleil, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Soleil, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Soleil, Genus.Bulbe),
            new Plant("Plante mystérieuse 5", Essence.Soleil, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Soleil, Genus.Communicante),
            new Plant("Fleur d'Ombricus Bonsola", Essence.Lune, Genus.Grimpante),
            new Plant("Iris", Essence.Lune, Genus.Bulbe),
            new Plant("Chrysanthème", Essence.Lune, Genus.Invasive),
            new Plant("Hibiscus", Essence.Lune, Genus.Communicante),
            new Plant("Myrte", Essence.Lune, Genus.Grimpante),
            new Plant("Nigelle de Crépuscule", Essence.Lune, Genus.Bulbe),
            new Plant("Plante mystérieuse 1", Essence.Lune, Genus.Invasive),
            new Plant("Plante mystérieuse 2", Essence.Lune, Genus.Communicante),
            new Plant("Plante mystérieuse 3", Essence.Lune, Genus.Grimpante),
            new Plant("Plante mystérieuse 4", Essence.Lune, Genus.Bulbe),
            new Plant("Plante mystérieuse 5", Essence.Lune, Genus.Invasive),
            new Plant("Plante mystérieuse 6", Essence.Lune, Genus.Communicante)
        ];
    }

    private void RandomizeEffects()
    {
        const int effectsPerPlant = 4;
        int plantsCount = Plants.Count;
        List<int> effectsNumbers = [];
        int baseNumber;
        int inequality;
        int numberOfEffects = Enum.GetNames(typeof(Effect)).Length;
        int numberOfSecondaryEffects = Enum.GetNames(typeof(SecondaryEffect)).Length;
        bool goodDistribution1 = false;
        Random random = new Random();
        
        baseNumber = (plantsCount * effectsPerPlant) / numberOfEffects;
        inequality = (plantsCount * effectsPerPlant) % numberOfEffects;

        for (int i = 0; i < numberOfEffects; i++)
        {
            effectsNumbers.Add(i <= inequality ? baseNumber + 1 : baseNumber);
        }

        while (!goodDistribution1)
        {
            goodDistribution1 = true;
            for (int i = 0; i < plantsCount; i++)
            {
                List<int> numbers = Enumerable.Range(0, numberOfEffects).ToList();
                RemoveEmptyNumbers(effectsNumbers, numbers);
                if (numbers.Count < 4)
                {
                    goodDistribution1 = false;
                    break;
                }

                ShuffleList(numbers, random);
                List<Effect> effects = [(Effect)numbers[0], (Effect)numbers[1], (Effect)numbers[2], (Effect)numbers[3]];
                effectsNumbers[numbers[0]]--;
                effectsNumbers[numbers[1]]--;
                effectsNumbers[numbers[2]]--;
                effectsNumbers[numbers[3]]--;
                Plants[i].Effects = effects;
            }
        }

        foreach (Plant plant in Plants)
        {
            plant.SecondaryEffect = (SecondaryEffect)random.Next(0, numberOfSecondaryEffects);
        }

        foreach (var plant in Plants)
        {
            Console.WriteLine(plant.Effects);
        }
    }

    private void RemoveEmptyNumbers(List<int> effectsNumbers, List<int> numbers)
    {
        List<int> numbersToRemove = new List<int>();
        for (int i = 0; i < effectsNumbers.Count; i++)
        {
            if (effectsNumbers[i] == 0)
            {
                numbersToRemove.Add(numbers[i]);
            }
        }
        numbersToRemove.OrderDescending();
        foreach (int number in numbersToRemove)
        {
            numbers.Remove(number);
        }
    }

    private void ShuffleList<T>(IList<T> list, Random random)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }

    private void SavePlantsToFile()
    {
        string jsonString = JsonSerializer.Serialize(Plants);
        File.WriteAllText(JsonPlants, jsonString);
    }

    private void LoadPlantsFromFile()
    {
        string jsonString = File.ReadAllText(JsonPlants);
        Plants = JsonSerializer.Deserialize<List<Plant>>(jsonString)!;
    }

    private void LoadUsersFromFile()
    {
        string jsonString = File.ReadAllText(JsonUsers);
        List<User>? tempUsers = JsonSerializer.Deserialize<List<User>>(jsonString);
        if (tempUsers != null)
        {
            Users = tempUsers;
        }
    }
}
