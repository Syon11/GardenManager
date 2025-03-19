namespace GardenManager.Model;

public class Race
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<RacialCompetence> RacialCompetences { get; set; }

    public Race(){}

    public Race(string name, string description, List<RacialCompetence> list)
    {
        Name = name;
        Description = description;
        RacialCompetences = list;
    }
}