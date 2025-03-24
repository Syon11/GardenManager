using GardenManager.Model.Arcane;
using Newtonsoft.Json;

namespace GardenManager.Model;

public class Character
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long HP { get; set; }
    public long TempHP { get; set; }
    public long MP { get; set; }
    public Race Race { get; set; }
    public int SelectedRacialCompetence { get; set; }
    public Origin Origin { get; set; }
    public int SelectedOrigin { get; set; }
    public long SkillPoints { get; set; }
    public List<Competence> Competences { get; set; } = [];
    public Grimoire Grimoire { get; set; }

    public Character() {}
    
    public Character(string name, Race race, int raceSkill, Origin origin, int originSkill)
    {
        Name = name;
        HP = 7;
        TempHP = 4;
        MP = 5;
        Race = race;
        SelectedRacialCompetence = raceSkill;
        Origin = origin;
        SelectedOrigin = originSkill;
        SkillPoints = 4;
    }
}