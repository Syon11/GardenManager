using GardenManager.Enums;
using GardenManager.Model;
using System.Text.Json;
using GardenManager.Utility;

namespace GardenManager;

public class Manager
{
    private List<Plant> Plants { get; set; }
    private List<User> Users { get; set; }
    private List<Garden> Gardens { get; set; }
    private User? CurrentUser { get; set; }
    private ConsoleDisplay CD { get; set; } = new();
    private const string JsonPlants = "plants.json";
    private const string JsonUsers = "users.json";
    private const string JsonGardens = "gardens.json";
    
    public Manager()
    {
        Plants = [];
        Users = [];
        Gardens = [];
        Init();
        Run();
    }

    private void Run()
    {
        bool running = true;
        while (running)
        {
            bool inMainMenu = true;
            while (inMainMenu)
            {
                CD.DisplayMainMenu(CurrentUser);
                string? input = Console.ReadLine();
                while (!InputValidator.ValidateEntryWithRegex(input!, @"^[0-3]$"))
                {
                    Console.Write("Invalid entry. Try again: ");
                    input = Console.ReadLine();
                }

                switch (input)
                {
                    case "0":
                        HandleUserSelection();
                        break;
                    case "1":
                        HandlePlantManagement();
                        break;
                    case "2":
                        HandleGardenManagement();
                        break;
                    case "3":
                        inMainMenu = false;
                        break;
                }
            }
            
                
            running = false;
        }
        
        TerminateProgram();
    }

    private void HandleUserSelection()
    {
        CD.DisplayUserSelection(Users);
        string? input = Console.ReadLine();
        while (!InputValidator.ValidateEntryWithRegex(input!, @"^[0-9]{1,3}$"))
        {
            Console.Write("Invalid entry. Try again: ");
            input = Console.ReadLine();
        }
        int userId = int.Parse(input);
        User? user = Users.FirstOrDefault(x => x.Id == userId);
        if (user == null)
        {
            user = HandleUserCreation();
            Users.Add(user);
            SaveUsersToFile();
        }
    }

    private User HandleUserCreation()
    {
        int id = Users.Count;
        CD.DisplayUserCreation();
        string? name = Console.ReadLine();
        while (!InputValidator.ValidateEntryWithRegex(name, @"^\w{1,80}$"))
        {
            Console.Write("Invalid entry, Try again: ");
            name = Console.ReadLine();
        }

        User user = new User();
        user.Id = id;
        user.Name = name;
        return user;
    }
    
    private void HandlePlantManagement()
    {
        bool inPlantManagement = true;
        
        while (inPlantManagement){
            CD.DisplayPlantManagement();
            string? input = Console.ReadLine();
            while (!InputValidator.ValidateEntryWithRegex(input!, @"^[1-2]{1}$"))
            {
                Console.Write("Invalid entry, Try again: ");
                input = Console.ReadLine();
            }

            switch (input)
            {
                case "1":
                    Plant selection = HandlePlantSelection();
                    HandlePlantModification(selection);
                    break;
                case "2": 
                    inPlantManagement = false;
                    break;
            }
        }
    }

    private Plant HandlePlantSelection()
    {
        Plant? plant = null; 
        while (plant == null)
        {
            CD.DisplayPlantListing(Plants);
            CD.DisplayPlantSelection();
            string? input = Console.ReadLine();

            while (!InputValidator.ValidateEntryWithRegex(input!, @"^[0-9]{1,3}$"))
            {
                Console.Write("Invalid entry, Try again: ");
                input = Console.ReadLine();
            }

            int id = int.Parse(input!);
            plant = Plants.FirstOrDefault(x => x.Id == id);
            
        }
        return plant;
    }

    private void HandlePlantModification(Plant plant)
    {
        
    }
    
    private void HandleGardenManagement()
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

        LoadGardensFromFile();
        LoadUsersFromFile();
    }
    
    private void InitPlantsBase()
    {
        Plants =
        [
            new Plant(0,"Baies Poilues du Désert", Essence.Acide, Genus.Grimpante),
            new Plant(1,"Azalée", Essence.Acide, Genus.Bulbe),
            new Plant(2,"Datura", Essence.Acide, Genus.Invasive),
            new Plant(3,"Oeillet", Essence.Acide, Genus.Communicante),
            new Plant(4,"Pissenlit", Essence.Acide, Genus.Grimpante),
            new Plant(5,"Vikrolier", Essence.Acide, Genus.Bulbe),
            new Plant(6,"Plante Mystérieuse 1", Essence.Acide, Genus.Invasive),
            new Plant(7,"Bleuet de l'enfer", Essence.Acide, Genus.Communicante),
            new Plant(8,"Plante mystérieuse 3", Essence.Acide, Genus.Grimpante),
            new Plant(9,"Plante mystérieuse 4", Essence.Acide, Genus.Bulbe),
            new Plant(10,"Plante Mystérieuse 5", Essence.Acide, Genus.Invasive),
            new Plant(11,"Plante mystérieuse 6", Essence.Acide, Genus.Communicante),
            new Plant(12,"Piment Defoego", Essence.Feu, Genus.Grimpante),
            new Plant(13,"Cactus", Essence.Feu, Genus.Bulbe),
            new Plant(14,"Chardon", Essence.Feu, Genus.Invasive),
            new Plant(15,"Rose", Essence.Feu, Genus.Communicante),
            new Plant(16,"Yucca", Essence.Feu, Genus.Grimpante),
            new Plant(17,"Aetubosie", Essence.Feu, Genus.Bulbe),
            new Plant(18,"Plante mystérieuse 1", Essence.Feu, Genus.Invasive),
            new Plant(19,"Plante mystérieuse 2", Essence.Feu, Genus.Communicante),
            new Plant(20,"Plante mystérieuse 3", Essence.Feu, Genus.Grimpante),
            new Plant(21,"Plante mystérieuse 4", Essence.Feu, Genus.Bulbe),
            new Plant(22,"Plante mystérieuse 5", Essence.Feu, Genus.Invasive),
            new Plant(23,"Plante mystérieuse 6", Essence.Feu, Genus.Communicante),
            new Plant(24,"Ail d'eau", Essence.Glace, Genus.Grimpante),
            new Plant(25,"Dahlia", Essence.Glace, Genus.Bulbe),
            new Plant(26,"Perce-Neige", Essence.Glace, Genus.Invasive),
            new Plant(27,"Marguerite", Essence.Glace, Genus.Communicante),
            new Plant(28,"Églantier", Essence.Glace, Genus.Grimpante),
            new Plant(29,"Méliot Arctique", Essence.Glace, Genus.Bulbe),
            new Plant(30,"Plante mystérieuse 1", Essence.Glace, Genus.Invasive),
            new Plant(31,"Plante mystérieuse 2", Essence.Glace, Genus.Communicante),
            new Plant(32,"Plante mystérieuse 3", Essence.Glace, Genus.Grimpante),
            new Plant(33,"Plante mystérieuse 4", Essence.Glace, Genus.Bulbe),
            new Plant(34,"Plante mystérieuse 5", Essence.Glace, Genus.Invasive),
            new Plant(35,"Plante mystérieuse 6", Essence.Glace, Genus.Communicante),
            new Plant(36,"Laitue Sauvage", Essence.Foudre, Genus.Grimpante),
            new Plant(37,"Capucine", Essence.Foudre, Genus.Bulbe),
            new Plant(38,"Pivoine", Essence.Foudre, Genus.Invasive),
            new Plant(39,"Gueule de Loup", Essence.Foudre, Genus.Communicante),
            new Plant(40,"Alstroemère", Essence.Foudre, Genus.Grimpante),
            new Plant(41,"Iothenfore", Essence.Foudre, Genus.Bulbe),
            new Plant(42,"Plante mystérieuse 1", Essence.Foudre, Genus.Invasive),
            new Plant(43,"Plante mystérieuse 2", Essence.Foudre, Genus.Communicante),
            new Plant(44,"Plante mystérieuse 3", Essence.Foudre, Genus.Grimpante),
            new Plant(45,"Plante mystérieuse 4", Essence.Foudre, Genus.Bulbe),
            new Plant(46,"Plante mystérieuse 5", Essence.Foudre, Genus.Invasive),
            new Plant(47,"Plante mystérieuse 6", Essence.Foudre, Genus.Communicante),
            new Plant(48,"Fleur d'Arkasé", Essence.Vie, Genus.Grimpante),
            new Plant(49,"Souci", Essence.Vie, Genus.Bulbe),
            new Plant(50,"Lys", Essence.Vie, Genus.Invasive),
            new Plant(51,"Giroflée", Essence.Vie, Genus.Communicante),
            new Plant(52,"Immortelle", Essence.Vie, Genus.Grimpante),
            new Plant(53,"Souci des Miracles", Essence.Vie, Genus.Bulbe),
            new Plant(54,"Plante mystérieuse 1", Essence.Vie, Genus.Invasive),
            new Plant(55,"Plante mystérieuse 2", Essence.Vie, Genus.Communicante),
            new Plant(56,"Plante mystérieuse 3", Essence.Vie, Genus.Grimpante),
            new Plant(57,"Plante mystérieuse 4", Essence.Vie, Genus.Bulbe),
            new Plant(58,"Plante mystérieuse 5", Essence.Vie, Genus.Invasive),
            new Plant(59,"Plante mystérieuse 6", Essence.Vie, Genus.Communicante),
            new Plant(60,"Lichen Noir", Essence.Mort, Genus.Grimpante),
            new Plant(61,"Violette", Essence.Mort, Genus.Bulbe),
            new Plant(62,"Muguet", Essence.Mort, Genus.Invasive),
            new Plant(63,"Capucine des fous", Essence.Mort, Genus.Communicante),
            new Plant(64,"Lierre", Essence.Mort, Genus.Grimpante),
            new Plant(65,"Aamogale", Essence.Mort, Genus.Bulbe),
            new Plant(66,"Plante mystérieuse 1", Essence.Mort, Genus.Invasive),
            new Plant(67,"Plante mystérieuse 2", Essence.Mort, Genus.Communicante),
            new Plant(68,"Plante mystérieuse 3", Essence.Mort, Genus.Grimpante),
            new Plant(69,"Plante mystérieuse 4", Essence.Mort, Genus.Bulbe),
            new Plant(70,"Plante mystérieuse 5", Essence.Mort, Genus.Invasive),
            new Plant(71,"Plante mystérieuse 6", Essence.Mort, Genus.Communicante),
            new Plant(72,"Papaye Impériale", Essence.Soleil, Genus.Grimpante),
            new Plant(73,"Tournesol", Essence.Soleil, Genus.Bulbe),
            new Plant(74,"Jonquille", Essence.Soleil, Genus.Invasive),
            new Plant(75,"Zinnia", Essence.Soleil, Genus.Communicante),
            new Plant(76,"Pétunia", Essence.Soleil, Genus.Grimpante),
            new Plant(77,"Biaire", Essence.Soleil, Genus.Bulbe),
            new Plant(78,"Plante mystérieuse 1", Essence.Soleil, Genus.Invasive),
            new Plant(79,"Plante mystérieuse 2", Essence.Soleil, Genus.Communicante),
            new Plant(80,"Plante mystérieuse 3", Essence.Soleil, Genus.Grimpante),
            new Plant(81,"Plante mystérieuse 4", Essence.Soleil, Genus.Bulbe),
            new Plant(82,"Plante mystérieuse 5", Essence.Soleil, Genus.Invasive),
            new Plant(83,"Plante mystérieuse 6", Essence.Soleil, Genus.Communicante),
            new Plant(84,"Fleur d'Ombricus Bonsola", Essence.Lune, Genus.Grimpante),
            new Plant(85,"Iris", Essence.Lune, Genus.Bulbe),
            new Plant(86,"Chrysanthème", Essence.Lune, Genus.Invasive),
            new Plant(87,"Hibiscus", Essence.Lune, Genus.Communicante),
            new Plant(88,"Myrte", Essence.Lune, Genus.Grimpante),
            new Plant(89,"Nigelle de Crépuscule", Essence.Lune, Genus.Bulbe),
            new Plant(90,"Plante mystérieuse 1", Essence.Lune, Genus.Invasive),
            new Plant(91,"Plante mystérieuse 2", Essence.Lune, Genus.Communicante),
            new Plant(92,"Plante mystérieuse 3", Essence.Lune, Genus.Grimpante),
            new Plant(93,"Plante mystérieuse 4", Essence.Lune, Genus.Bulbe),
            new Plant(94,"Plante mystérieuse 5", Essence.Lune, Genus.Invasive),
            new Plant(95,"Plante mystérieuse 6", Essence.Lune, Genus.Communicante)
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

    private void LoadGardensFromFile()
    {
        string jsonString = File.ReadAllText(JsonGardens);
        List<Garden>? TempGardens = JsonSerializer.Deserialize<List<Garden>>(jsonString);
        if (TempGardens != null)
        {
            Gardens = TempGardens;
        }
    }

    private void TerminateProgram()
    {
        SaveUsersToFile();
        SavePlantsToFile();
    }

    private void SaveUsersToFile()
    {
        string jsonString = JsonSerializer.Serialize(Users);
        File.WriteAllText(JsonUsers, jsonString);
    }
}
