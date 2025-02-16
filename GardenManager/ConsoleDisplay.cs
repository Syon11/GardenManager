using GardenManager.Enums;
using GardenManager.Model;
using GardenManager.Utility;

namespace GardenManager;

public class ConsoleDisplay
{
    public void DisplayMainMenu(User? user)
    {
        Console.Clear();
        
        Console.WriteLine(user != null ? $"Current User: {user.Name}" : $"Current User: None");
        Console.WriteLine();
        Console.WriteLine("Garden Manager");
        Console.WriteLine("1) Select User");
        Console.WriteLine("2) Manage Plants");
        Console.WriteLine("3) Manage Gardens");
        Console.WriteLine("4) Make Alchemical Concoctions");
        Console.WriteLine("5) Exit");
        Console.Write("Select an option: ");
    }

    public void DisplayUserSelection(List<User> users)
    {
        int iterator = 0;
        Console.Clear();
        Console.WriteLine("Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Id}) {user.Name}");
            iterator++;
        }
        Console.WriteLine($"{iterator}) Create New User");
    }
    
    public void DisplayUserCreation()
    {
        Console.Write("Enter User's name: ");
    }

    public void DisplayPlantManagement()
    {
        Console.Clear();
        Console.WriteLine("Plant Management");
        Console.WriteLine("");
        Console.WriteLine("1) Modify Plant");
        Console.WriteLine("2) Rename Plant");
        Console.WriteLine("3) Cancel");
        Console.Write("Select an option: ");
    }

    public void DisplayPlantListing(List<Plant> plants)
    {
        Console.WriteLine("Plant Listing: ");
        foreach (Plant plant in plants)
        {
            Console.WriteLine($"{plant.Id}) {plant.Name}");
        }
    }

    public void DisplayEssenceListing()
    {
        int iterator = 0;
        Console.WriteLine("Essences: ");
        foreach (string essence in Enum.GetNames(typeof(Essence)))
        {
            Console.WriteLine($"{iterator}) {essence}");
            iterator++;
        }
    }

    public void DisplayGenusListing()
    {
        int iterator = 0;
        Console.WriteLine("Genus types: ");
        foreach (string genus in Enum.GetNames(typeof(Genus)))
        {
            Console.WriteLine($"{iterator}) {genus}");
        }
    }

    public void DisplayEffectListing()
    {
        int iterator = 0;
        Console.Clear(); 
        Console.WriteLine("List of Alchemical effects: ");
        foreach (string effect in Enum.GetNames(typeof(Effect)))
        {
            Console.WriteLine($"{iterator}) {effect}");
        }
    }

    public void DisplayConfirmation()
    {
        Console.Clear();
        Console.WriteLine("Are you sure you want to commit this action? The changes will be irreversible.");
        Console.Write("Y/N: ");
    }   
    
    public void DisplayPlantSelection()
    {
        Console.Write("Please select a plant by ID: ");
    }
    
    public void DisplayGardenSelection(int numberOfGardens)
    {
        Console.Clear();
        Console.WriteLine("Available gardens:");
        for (int i = 0; i < numberOfGardens; i++)
            Console.WriteLine($"{i})");
        Console.WriteLine($"{numberOfGardens}) New Garden");
        Console.WriteLine("Select a garden: ");
    }
    
    
    
    public void DisplayGardenGrid(Garden garden)
    {
        
        DisplayGardenHeader(garden.Tiles[0].Count);
        DisplayGardenCore(garden);
        DisplayGardenFooter();
    }

    private void DisplayGardenHeader(int size)
    {
        ConsoleHelper.SetBackgroundColorToBlack();
        Console.Write("  |");
        
        for (int i = 0; i < size; i++)
        {
            Console.Write($" {i} |");
            
        }
        Console.WriteLine("");
    }

    private void DisplayGardenFooter()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter a command using this format: [Action][Y][X]");
        Console.WriteLine("Possible actions:");
        Console.WriteLine("0) Examine Plot");
        Console.WriteLine("1) Purchase a plot");
        Console.WriteLine("2) Plant a seed");
        Console.WriteLine("3) Harvest");
        Console.WriteLine("4) Use fertilizer");
        Console.WriteLine("5) Add a row");
        Console.WriteLine("6) Add a column");
        Console.WriteLine("7) Trigger weather effect");
        Console.WriteLine("8) End turn");
        Console.WriteLine("9) Cancel");
        Console.Write("Select action: ");
    }

    private void DisplayGardenCore(Garden garden)
    {
        for (int i = 0; i < garden.Tiles.Count; i++)
        {
            Console.Write($"{i} |");
            for (int j = 0; j < garden.Tiles[i].Count; j++)
            {
                if (garden.Tiles[i][j].Plant != null)
                {
                    switch (garden.Tiles[i][j].Plant!.Essence)
                    {
                        case Essence.Feu:
                            ConsoleHelper.SetBackgroundColorToDarkRed();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                        case Essence.Foudre:
                            ConsoleHelper.SetBackgroundColorToDarkYellow();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                        case Essence.Glace:
                            ConsoleHelper.SetBackgroundColorToDarkBlue();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                        case Essence.Acide:
                            ConsoleHelper.SetBackgroundColorToDarkGreen();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                        case Essence.Vie:
                            ConsoleHelper.SetBackgroundColorToDarkCyan();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                        case Essence.Mort:
                            ConsoleHelper.SetBackgroundColorToDarkMagenta();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                        case Essence.Soleil:
                            ConsoleHelper.SetBackgroundColorToYellow();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                        case Essence.Lune:
                            ConsoleHelper.SetBackgroundColorToGray();
                            ConsoleHelper.SetForegroundColorToBlack();
                            break;
                    }
                }
                if (garden.Tiles[i][j].Owner != null)
                {
                    Console.Write($" {garden.Tiles[i][j].Owner!.Name[0]} ");    
                }
                else
                {
                    Console.Write("   ");
                }
                ConsoleHelper.SetBackgroundColorToBlack();
                ConsoleHelper.SetForegroundColorToWhite();
                Console.Write("|");
            }
            Console.WriteLine();
        }
        
    }
}