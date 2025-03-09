namespace GardenManager.Exceptions;

[Serializable]
public class EffectRequiredException : Exception
{
    public EffectRequiredException()
    {
        
    }

    public EffectRequiredException(string message)
        :base(message)
    {
        
    }

    public EffectRequiredException(string message, Exception inner)
        :base(message, inner)
    {
        
    }
}