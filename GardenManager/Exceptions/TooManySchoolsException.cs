namespace GardenManager.Exceptions;

[Serializable]
public class TooManySchoolsException : Exception
{
    public TooManySchoolsException()
    {
        
    }

    public TooManySchoolsException(string message)
        :base(message)
    {
        
    }

    public TooManySchoolsException(string message, Exception inner)
        :base(message, inner)
    {
        
    }
}