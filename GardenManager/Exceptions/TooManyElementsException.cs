namespace GardenManager.Exceptions;

[Serializable]
public class TooManyElementsException: Exception
{
    public TooManyElementsException()
    {
        
    }

    public TooManyElementsException(string message)
        :base(message)
    {
        
    }

    public TooManyElementsException(string message, Exception inner)
        :base(message, inner)
    {
        
    }
}