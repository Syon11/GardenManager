using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using GardenManager.Enums;
using GardenManager.Model;
using System.Text.Json;

namespace GardenManager;

public class Manager
{
    public List<Plant> Plants { get; set; }
    public List<User> Users { get; set; }
    public const string JSON_PLANTS = "plants.json";

    public Manager()
    {
        Plants = [];
        Users = [];
        Init();
    }

    private void Init()
    {
        if (!File.Exists(JSON_PLANTS))
        {
            InitPlantsBase();
            RandomizeEffects();
            SavePlantsToFile();
        }
        else
        {
            LoadPlantsFromFile();
        }
    }
    
    public void InitPlantsBase()
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
        const int EFFECTS_PER_PLANT = 4;
        int PlantsCount = Plants.Count;
        List<int> EffectsNumbers = [];
        int BaseNumber;
        int Inequality;
        int NumberOfEffects = Enum.GetNames(typeof(Effect)).Length;
        int NumberOfSecondaryEffects = Enum.GetNames(typeof(SecondaryEffect)).Length;
        bool GoodDistribution1 = false;
        bool GoodDistribution2 = false;
        Random random = new Random();
        
        BaseNumber = (PlantsCount * EFFECTS_PER_PLANT) / NumberOfEffects;
        Inequality = (PlantsCount * EFFECTS_PER_PLANT) % NumberOfEffects;

        for (int i = 0; i < NumberOfEffects; i++)
        {
            EffectsNumbers.Add(i <= Inequality ? BaseNumber + 1 : BaseNumber);
        }

        while (!GoodDistribution1)
        {
            GoodDistribution1 = true;
            for (int i = 0; i < PlantsCount; i++)
            {
                List<int> numbers = Enumerable.Range(0, NumberOfEffects).ToList();
                RemoveEmptyNumbers(EffectsNumbers, numbers);
                if (numbers.Count < 4)
                {
                    GoodDistribution1 = false;
                    break;
                }

                ShuffleList(numbers, random);
                List<Effect> effects = [(Effect)numbers[0], (Effect)numbers[1], (Effect)numbers[2], (Effect)numbers[3]];
                EffectsNumbers[numbers[0]]--;
                EffectsNumbers[numbers[1]]--;
                EffectsNumbers[numbers[2]]--;
                EffectsNumbers[numbers[3]]--;
                Plants[i].Effects = effects;
            }
        }

        foreach (Plant plant in Plants)
        {
            plant.SecondaryEffect = (SecondaryEffect)random.Next(0, NumberOfSecondaryEffects);
        }

        foreach (var plant in Plants)
        {
            Console.WriteLine(plant.Effects);
        }
    }

    private void RemoveEmptyNumbers(List<int> EffectsNumbers, List<int> numbers)
    {
        List<int> numbersToRemove = new List<int>();
        for (int i = 0; i < EffectsNumbers.Count; i++)
        {
            if (EffectsNumbers[i] == 0)
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
        File.WriteAllText(JSON_PLANTS, jsonString);
    }

    private void LoadPlantsFromFile()
    {
        string jsonString = File.ReadAllText(JSON_PLANTS);
        Plants = JsonSerializer.Deserialize<List<Plant>>(jsonString)!;
    }
}
