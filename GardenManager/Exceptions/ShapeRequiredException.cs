namespace GardenManager.Exceptions;

[Serializable]
public class ShapeRequiredException: Exception
{
    public ShapeRequiredException()
    {
        
    }

    public ShapeRequiredException(string message)
        :base(message)
    {
        
    }

    public ShapeRequiredException(string message, Exception inner)
        :base(message, inner)
    {
        
    }
}