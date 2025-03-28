namespace GardenManager.Model.Arcane;

public abstract class ArcaneConfig
{
    public long Id { get; set; }
    public string Name { get; set; }
    public List<int> Thresholds { get; set; }
    public List<string> DescriptionAtThresholds { get; set; }

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