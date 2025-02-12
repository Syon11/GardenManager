using System.Text.RegularExpressions;

namespace GardenManager.Utility;

public static class InputValidator
{
    public static bool ValidateEntryWithRegex(string entry, string regex)
    {
        var match = Regex.Match(entry, regex);
        return match.Success;
    }
}