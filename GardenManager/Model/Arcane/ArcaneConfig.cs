namespace GardenManager.Model.Arcane;

public abstract class ArcaneConfig
{
    string Name { get; set; }
    List<int> Thresholds { get; set; }
    List<string> DescriptionAtThresholds { get; set; }
    

    public ArcaneConfig(){}

    public ArcaneConfig(string name, List<int> thresholds, List<string> descriptionAtThresholds)
    {
        Name = name;
        Thresholds = thresholds;
        DescriptionAtThresholds = descriptionAtThresholds;
    }
    
    public int GetTier(int potentia)
    {
        int tier = 0;
        foreach (var threshold in Thresholds)
        {
            if (potentia >= threshold)
            {
                tier++;
            }
        }
        return tier;
    }
}