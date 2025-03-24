using System.Runtime.CompilerServices;
using GardenManager.Enums;

namespace GardenManager.Model;

public class Competence
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Tier { get; set; }
    public Trunk Trunk { get; set; }
    public Specialisation Specialisation { get; set; }
    public List<Variant> Variants { get; set; }
    public string? VocalComponent { get; set; }
    public long? PrerequisiteId { get; set; }
    public List<Character> Characters { get; set; }

    public Competence(){}
    public Competence(long id, string name, int tier, Trunk trunk, Specialisation spec, string description, List<Variant> variants)
    {
        Id = id;
        Name = name;
        Tier = tier;
        Trunk = trunk;
        Specialisation = spec;
        Description = description;
        Variants = variants;
        
    }

    public Competence(long id, string name, int tier, Trunk trunk, Specialisation spec, string description, List<Variant> variants, string vocalComponent)
    {
        Id = id;
        Name = name;
        Tier = tier;
        Trunk = trunk;
        Specialisation = spec;
        Description = description;
        Variants = variants;
        VocalComponent = vocalComponent;
    }

    public Competence(long id, string name, int tier, Trunk trunk, Specialisation spec, string description, List<Variant> variants, long prerequisiteId)
    {
        Id = id;
        Name = name;
        Tier = tier;
        Trunk = trunk;
        Specialisation = spec;
        Description = description;
        Variants = variants;
        PrerequisiteId = prerequisiteId;
    }

    public Competence(long id, string name, int tier, Trunk trunk, Specialisation spec, string description, List<Variant> variants, string vocalComponent,
        long prerequisiteId)
    {
        Id = id;
        Name = name;
        Tier = tier;
        Trunk = trunk;
        Specialisation = spec;
        Description = description;
        Variants = variants;
        VocalComponent = vocalComponent;
        PrerequisiteId = prerequisiteId;
    }
}