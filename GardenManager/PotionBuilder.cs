using GardenManager.Interfaces;
using GardenManager.Model;
using GardenManager.Utility;

namespace GardenManager;

public class PotionBuilder
{
    private List<Plant> Plants { get; set; }
    private List<Ore> Ores { get; set; }
    private List<IAlchemizable> Ingredients { get; set; }
    private List<Potion> Potions { get; set; }
    
    
    public PotionBuilder(List<Plant> plants, List<Ore> ores, List<AlchemyEffect> effectsToEssence)
    {
        Plants = plants;
        Ores = ores;
        Ingredients = [];
        Potions = [];
        SelectAction(effectsToEssence);
    }

    private void SelectAction(List<AlchemyEffect> effectsToEssence)
    {
        bool done = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Potion Maker");
            Console.WriteLine("--------------");
            Console.WriteLine("Choose an Action");
            Console.WriteLine("1) Print previous potions");
            Console.WriteLine("2) Print Plant effects");
            Console.WriteLine("3) Print Plant effects [DEBUG]");
            Console.WriteLine("4) Build a Potion");
            Console.WriteLine("5) Exit to Main menu");
            Console.Write("Selected Action: ");
            string? action = Console.ReadLine();
            if (string.IsNullOrEmpty(action) || !InputValidator.ValidateEntryWithRegex(action, @"^[1-5]{1}$"))
            {
                Console.Write("Invalid action. Please try again: ");
                action = Console.ReadLine();
            }

            switch (action)
            {
                case "1":
                    PotionSelect();
                    break;
                case "2":
                    PrintAllPlantsWithFirstEffect();
                    break;
                case "3":
                    PrintAllPlantsWithAllEffect();
                    break;
                case "4":
                    BuildPotion(effectsToEssence);
                    break;
                case "5":
                    done = true;
                    break;
            }
        } while (!done);
    }

    private void PotionSelect()
    {
        Console.Clear();
        int iterator = 0;
        if (Potions.Count > 0)
        {
            foreach (Potion potion in Potions)
            {
                Console.WriteLine($"{iterator}) {potion}");
                iterator++;
            }
            Console.Write("Choose a Potion: ");
            string? selection = Console.ReadLine();
            while (string.IsNullOrEmpty(selection) || !InputValidator.ValidateEntryWithRegex(selection, @"^[0-9]{1,3}$")|| !int.TryParse(selection, out iterator))
            {
                Console.Write("Invalid selection. Please try again: ");
                selection = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Print normal or catalyzed effect?");
            Console.WriteLine("1) Print the normal potion");
            Console.WriteLine("2) Print the catalyzed potion");
            selection = Console.ReadLine();
            while (string.IsNullOrEmpty(selection) || !InputValidator.ValidateEntryWithRegex(selection, @"^[1-2]{1}$"))
            {
                Console.Write("Invalid selection. Please try again: ");
                selection = Console.ReadLine();
            }

            switch (selection)
            {
                case "1":
                    Potions[iterator].PrintFullPotion();
                    break;
                case "2":
                    Potions[iterator].PrintFullCatalyzedPotion();
                    break;
            }
            Console.ReadLine();
        }
    }

    private void BuildPotion(List<AlchemyEffect> effectsToEssences)
    {
        ConsoleDisplay cd = new ConsoleDisplay();
        Console.Clear();
        Console.Write("How many ingredients?: ");
        string? selection = Console.ReadLine();
        while (string.IsNullOrEmpty(selection) || !InputValidator.ValidateEntryWithRegex(selection, @"^[1-4]{1}$"))
        {
            Console.Write("Invalid selection. Please try again: ");
            selection = Console.ReadLine();
        }

        for (int i = 0; i < int.Parse(selection); i++)
        {
            Console.Clear();
            Console.WriteLine("Which type of ingredient will you use?");
            Console.WriteLine("1) Plant");
            Console.WriteLine("2) Ore");
            String? selection3 = Console.ReadLine();
            while (string.IsNullOrEmpty(selection3) ||
                   !InputValidator.ValidateEntryWithRegex(selection3, @"^[1-2]{1}$"))
            {
                Console.Write("Invalid selection. Please try again: ");
                selection3 = Console.ReadLine();
            }

            switch (selection3)
            {
                case "1":
                    SelectAPlant(cd);
                    break;
                case "2":
                    SelectAnOre(cd);
                    break;
            }
        }

        Potion currentPotion = new Potion(new List<IAlchemizable>(Ingredients), effectsToEssences);
        Ingredients.Clear();
        if (currentPotion.TieredEffect.Tier > 0)
        {
            Potions.Add(currentPotion);
        }

        Console.Clear();
        currentPotion.PrintFullPotion();
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }
    
    private void PrintAllPlantsWithFirstEffect()
    {
        Console.Clear();
        foreach (Plant plant in Plants)
        {
            plant.PrintWithFirstEffect();
        }
        Console.ReadLine();
    }

    private void PrintAllPlantsWithAllEffect()
    {
        Console.Clear();
        foreach (var plant in Plants)
        {
            plant.PrintWithAllEffects();
        }
        Console.ReadLine();
    }

    private void SelectAPlant(ConsoleDisplay cd)
    {
        cd.DisplayPlantListing(Plants);
        Console.Write("Please select a plant: ");
        string? selection2 = Console.ReadLine();
        do
        {
            while (string.IsNullOrEmpty(selection2) ||
                   !InputValidator.ValidateEntryWithRegex(selection2, @"^[0-9]{1,3}$"))
            {
                Console.Write("Invalid selection. Please try again: ");
                selection2 = Console.ReadLine();
            }
        } while (Plants.Find(x => x.Id == int.Parse(selection2)) == null);
        Ingredients.Add(Plants.Find(x => x.Id == int.Parse(selection2))!);
    }

    private void SelectAnOre(ConsoleDisplay cd)
    {
        cd.DisplayOreListing(Ores);
        Console.Write("Please select an ore: ");
        string? selection = Console.ReadLine();
        do
        {
            while (string.IsNullOrEmpty(selection) || !InputValidator.ValidateEntryWithRegex(selection, @"^[0-9]{1,3}$"))
            {
                Console.Write("Invalid selection. Please try again: ");
                selection = Console.ReadLine();
            }
        } while (Ores.Find(x => x.Id == int.Parse(selection)) == null);
        Ingredients.Add(Ores.Find(x => x.Id == int.Parse(selection))!);
    }
}