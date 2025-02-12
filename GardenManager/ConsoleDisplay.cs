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
        Console.WriteLine("4) Exit");
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
        Console.WriteLine("2) Cancel");
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
    
    
    
    public void DisplayGardenGrid()
    {
        
        DisplayGardenHeader(4);
        DisplayGardenCore();
        DisplayGardenFooter();
    }

    private void DisplayGardenHeader(int size)
    {
        Console.Write("   |");
        
        for (int i = 0; i < size; i++)
        {
            Console.Write($" {i} |");
            Console.WriteLine("");
        }
    }

    private void DisplayGardenFooter()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter a command using this format: [Action][X][Y]");
        Console.WriteLine("Possible actions:");
        Console.WriteLine("1) Plant a seed");
        Console.WriteLine("2) Harvest");
        Console.WriteLine("3) Use fertilizer");
        Console.WriteLine("4) Add a row");
        Console.WriteLine("5) Add a column");
        Console.WriteLine("6) Trigger weather effect");
        Console.WriteLine("7) Cancel");
        Console.Write("Select action: ");
    }

    private void DisplayGardenCore()
    {
        
    }
}