namespace GardenManager.Exceptions;

[Serializable]
public class NotPartOfSelectedSchoolsException : Exception
{
    public NotPartOfSelectedSchoolsException()
    {
        
    }

    public NotPartOfSelectedSchoolsException(string message)
        :base(message)
    {
        
    }

    public NotPartOfSelectedSchoolsException(string message, Exception inner)
        :base(message, inner)
    {
        
    }
}