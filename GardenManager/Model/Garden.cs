using System.Text.Json.Serialization;
using GardenManager.Enums;

namespace GardenManager.Model;

public class Garden
{
    public int Id { get; set; }
    public WeatherEffects WeatherEffect { get; set; } = WeatherEffects.Sunny;
    [JsonInclude]
    public List<List<Tile>> Tiles { get; set; } = new List<List<Tile>>();

    public Garden(){}
    
    public void Init(List<Plant> plants)
    {
        Tiles.Add(new List<Tile>());
        Tiles.Add(new List<Tile>());
        Tiles.Add(new List<Tile>());
        Tiles.Add(new List<Tile>());
        foreach (List<Tile> list in Tiles)
        {
            list.Add(new Tile(plants));
            list.Add(new Tile(plants));
            list.Add(new Tile(plants));
            list.Add(new Tile(plants));
        }
    }

}