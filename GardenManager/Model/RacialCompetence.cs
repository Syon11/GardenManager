namespace GardenManager.Model;

public class RacialCompetence
{
    public int Id { get; set; }
    public string name { get; set; }
    public string description { get; set; }

    public RacialCompetence() {}
    
    public RacialCompetence(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}