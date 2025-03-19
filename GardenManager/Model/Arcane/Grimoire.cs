namespace GardenManager.Model.Arcane;

public class Grimoire
{
    private List<Word> Words { get; set; } = new List<Word>();
    private List<Spell> Spells { get; set; } = new List<Spell>();

    public Grimoire() {}

    public Grimoire(List<Word> words)
    {
        Words = words;
    }

    public Grimoire(List<Word> words, List<Spell> spells)
    {
        Words = words;
        Spells = spells;
    }
}