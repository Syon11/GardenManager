namespace GardenManager.Model.Arcane;

public class ArcaneShape : ArcaneConfig
{
    public ArcaneShape(){}
    public ArcaneShape(string name, List<int> thresholds, List<string> descriptions)
        : base(name, thresholds, descriptions)
    {
        
    }
}