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

    public void DisplayEssenceListing()
    {
        Console.WriteLine("Essences: ");
        Console.WriteLine("0) Feu");
        Console.WriteLine("1) Foudre");
        Console.WriteLine("2) Glace");
        Console.WriteLine("3) Acide");
        Console.WriteLine("4) Vie");
        Console.WriteLine("5) Mort");
        Console.WriteLine("6) Soleil");
        Console.WriteLine("7) Lune");
    }

    public void DisplayGenusListing()
    {
        Console.WriteLine("Genus types: ");
        Console.WriteLine("0) Invasive");
        Console.WriteLine("1) Bulbe");
        Console.WriteLine("2) Grimpante");
        Console.WriteLine("3) Communicante");
    }

    public void DisplayEffectListing()
    {
        Console.WriteLine("0) Flux");	
        Console.WriteLine("1) Graisseux"); 	
        Console.WriteLine("2) Huileux");
        Console.WriteLine("3) Naphta");
        Console.WriteLine("4) Antidouleur");
        Console.WriteLine("5) Antitoxine");
        Console.WriteLine("6) Antimagie");
        Console.WriteLine("7) Argent_Alchimique");
        Console.WriteLine("8) Armure_Naturelle");
        Console.WriteLine("9) Calme");
        Console.WriteLine("10) Celerite");
        Console.WriteLine("11) Charisme");
        Console.WriteLine("12) Concentration");
        Console.WriteLine("13) Contre_Poison");
        Console.WriteLine("14) Corps_Epineux");
        Console.WriteLine("15) Decoposition");
        Console.WriteLine("16) Extrait_Abjuration");
        Console.WriteLine("17) Extrait_Evocation");
        Console.WriteLine("18) Extrait_Illusion");
        Console.WriteLine("19) Extrait_Enchantement");
        Console.WriteLine("20) Extrait_Conjuration");
        Console.WriteLine("21) Extrait_Divination");
        Console.WriteLine("22) Extrait_Nécromancie");
        Console.WriteLine("23) Faiblesse");
        Console.WriteLine("24) Force");
        Console.WriteLine("25) Terre");
        Console.WriteLine("26) Feu");
        Console.WriteLine("27) Foudre");
        Console.WriteLine("28) Glace");
        Console.WriteLine("29) Insomnie");
        Console.WriteLine("30) Invisibilite");
        Console.WriteLine("31) Mana");
        Console.WriteLine("32) Mensonge");
        Console.WriteLine("33) Paralysie");
        Console.WriteLine("34) Charme");
        Console.WriteLine("35) Peur");
        Console.WriteLine("36) Poison");
        Console.WriteLine("37) Polymorphe");
        Console.WriteLine("38) Rage");	
        Console.WriteLine("39) Remede");	
        Console.WriteLine("40) Soin");
        Console.WriteLine("41) Sommeil");
        Console.WriteLine("42) Stabilisant");	
        Console.WriteLine("43) Stimulant");	
        Console.WriteLine("44) Vitalite"); 	
        Console.WriteLine("45) Vivifiant");	
        Console.WriteLine("46) Silence");
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
        Console.WriteLine("0) Purchase a plot");
        Console.WriteLine("1) Plant a seed");
        Console.WriteLine("2) Harvest");
        Console.WriteLine("3) Use fertilizer");
        Console.WriteLine("4) Add a row");
        Console.WriteLine("5) Add a column");
        Console.WriteLine("6) Trigger weather effect");
        Console.WriteLine("7) End turn");
        Console.WriteLine("8) Examine Plot");
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
                            break;
                        case Essence.Foudre:
                            ConsoleHelper.SetBackgroundColorToDarkYellow();
                            break;
                        case Essence.Glace:
                            ConsoleHelper.SetBackgroundColorToDarkBlue();
                            break;
                        case Essence.Acide:
                            ConsoleHelper.SetBackgroundColorToDarkGreen();
                            break;
                        case Essence.Vie:
                            ConsoleHelper.SetBackgroundColorToDarkCyan();
                            break;
                        case Essence.Mort:
                            ConsoleHelper.SetBackgroundColorToDarkMagenta();
                            break;
                        case Essence.Soleil:
                            ConsoleHelper.SetBackgroundColorToYellow();
                            break;
                        case Essence.Lune:
                            ConsoleHelper.SetBackgroundColorToGray();
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
                Console.Write("|");
            }
            Console.WriteLine();
        }
        
    }
}