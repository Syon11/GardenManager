using GardenManager.Enums.Arcane;

namespace GardenManager.Model.Arcane;

public abstract class Word
{
    public string WordText { get; set; }
    public string WordInFrench { get; set; }
    public int Tier { get; set; }
    public School School { get; set; }
    public bool IsHidden { get; set; }

    public Word(string wordText, string wordInFrench, int tier, School school, bool isHidden = false)
    {
        WordText = wordText;
        WordInFrench = wordInFrench;
        Tier = tier;
        School = school;
        IsHidden = isHidden;
    }
}