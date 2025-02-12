namespace GardenManager.Model;

public class Garden
{
    public int Id { get; set; }
    public string WeatherEffect { get; set; } = String.Empty;
    public List<List<Tile>> Tiles { get; set; } = [];
    
}