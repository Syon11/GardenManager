namespace GardenManager.Model;

public class RacialCompetence
{
    public string name { get; set; }
    public string description { get; set; }

    public RacialCompetence() {}
    
    public RacialCompetence(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}