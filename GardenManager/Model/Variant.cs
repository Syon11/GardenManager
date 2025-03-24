namespace GardenManager.Model;

public class Variant
{
    public long Id { get; set; }
    public string Description { get; set; }

    public Variant() {}
    
    public Variant(string description)
    {
        Description = description;
    }
}