namespace GardenManager.Model;

public class Variant
{
    public string Description { get; set; }

    public Variant() {}
    
    public Variant(string description)
    {
        Description = description;
    }
}