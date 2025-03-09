namespace GardenManager.Exceptions;

[Serializable]
public class NotSchoolWordException : Exception
{
    public NotSchoolWordException()
    {
        
    }

    public NotSchoolWordException(string message)
        :base(message)
    {
        
    }

    public NotSchoolWordException(string message, Exception inner)
        :base(message, inner)
    {
        
    }
}