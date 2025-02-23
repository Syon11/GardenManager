using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public abstract class Word
{
    private string WordText { get; set; }
    private string WordInFrench { get; set; }
    private int Tier { get; set; }
    private School School { get; set; }

    public Word(string wordText, string wordInFrench, int tier, School school)
    {
        WordText = wordText;
        WordInFrench = wordInFrench;
        Tier = tier;
        School = school;
    }
}