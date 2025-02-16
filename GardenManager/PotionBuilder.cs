using GardenManager.Model;

namespace GardenManager;

public class PotionBuilder
{
    public List<Plant> Plants { get; set; }
    public List<Ore> Ores { get; set; }
    public PotionBuilder(List<Plant> plants, List<Ore> ores)
    {
        Plants = plants;
        Ores = ores;
    }

    public void Init()
    {
        
    }
}