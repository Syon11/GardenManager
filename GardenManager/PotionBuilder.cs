using System.Security.Cryptography.X509Certificates;
using GardenManager.Interfaces;
using GardenManager.Model;
using GardenManager.Utility;

namespace GardenManager;

public class PotionBuilder
{
    public List<Plant> Plants { get; set; }
    public List<Ore> Ores { get; set; }
    public List<IAlchemizable> Ingredients { get; set; }
    public List<Potion> Potions { get; set; }
    
    
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
            Console.WriteLine("3) Build a Potion");
            Console.WriteLine("4) Exit to Main menu");
            Console.Write("Selected Action: ");
            string? action = Console.ReadLine();
            if (string.IsNullOrEmpty(action) || !InputValidator.ValidateEntryWithRegex(action, @"^[1-4]{1}$"))
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
                    BuildPotion(effectsToEssence);
                    break;
                case "4":
                    done = true;
                    break;
            }
        } while (!done);
    }

    private void PotionSelect()
    {
        Console.Clear();
        int iterator = 0;
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
        Potions[iterator].PrintFullPotion();
        Console.ReadLine();
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
            cd.DisplayPlantListing(Plants);
            Console.Write("Please select a plant: ");
            string? selection2 = Console.ReadLine();
            while (string.IsNullOrEmpty(selection2) ||
                   !InputValidator.ValidateEntryWithRegex(selection2, @"^[0-9]{1,3}$"))
            {
                Console.Write("Invalid selection. Please try again: ");
                selection2 = Console.ReadLine();
            }
            Ingredients.Add(Plants.Find(x => x.Id == int.Parse(selection2))!);
        }

        Potion currentPotion = new Potion(Ingredients, effectsToEssences);
        Potions.Add(currentPotion);
    }

    public void PrintAllPlantsWithFirstEffect()
    {
        Console.Clear();
        foreach (Plant plant in Plants)
        {
            plant.PrintWithFirstEffect();
        }
        Console.ReadLine();
    }

    public void PrintAllPlantsWithAllEffect()
    {
        Console.Clear();
        foreach (Plant plant in Plants)
        {
            plant.PrintWithAllEffects();
        }
        Console.ReadLine();
    }
}