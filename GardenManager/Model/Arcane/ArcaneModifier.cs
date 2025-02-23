namespace GardenManager.Model.Arcane;

public class ArcaneModifier : ArcaneConfig
{
    public ArcaneModifier(string name, List<int> thresholds, List<string> descriptions) 
        : base(name, thresholds, descriptions)
    {
        
    }
}