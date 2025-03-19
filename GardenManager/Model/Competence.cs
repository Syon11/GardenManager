using System.Runtime.CompilerServices;

namespace GardenManager.Model;

public class Competence
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Variant> Variants { get; set; }
    public string? VocalComponent { get; set; }
    public long? PrerequisiteId { get; set; }

    public Competence(){}
    public Competence(long id, string name, string description, List<Variant> variants)
    {
        Id = id;
        Name = name;
        Description = description;
        Variants = variants;
    }

    public Competence(long id, string name, string description, List<Variant> variants, string vocalComponent)
    {
        Id = id;
        Name = name;
        Description = description;
        Variants = variants;
        VocalComponent = vocalComponent;
    }

    public Competence(long id, string name, string description, List<Variant> variants, long prerequisiteId)
    {
        Id = id;
        Name = name;
        Description = description;
        Variants = variants;
        PrerequisiteId = prerequisiteId;
    }

    public Competence(long id, string name, string description, List<Variant> variants, string vocalComponent,
        long prerequisiteId)
    {
        Id = id;
        Name = name;
        Description = description;
        Variants = variants;
        VocalComponent = vocalComponent;
        PrerequisiteId = prerequisiteId;
    }
}