namespace GardenManager.Model;

public class Origin
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<RacialCompetence> OriginCompetences { get; set; }
    
    public Origin(){}

    public Origin(string name, string description, List<RacialCompetence> list)
    {
        Name = name;
        Description = description;
        OriginCompetences = list;
    }
}