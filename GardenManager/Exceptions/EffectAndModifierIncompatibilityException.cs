namespace GardenManager.Exceptions;

[Serializable]
public class EffectAndModifierIncompatibilityException : Exception
{
    public EffectAndModifierIncompatibilityException()
    {
        
    }

    public EffectAndModifierIncompatibilityException(string message)
        :base(message)
    {
        
    }

    public EffectAndModifierIncompatibilityException(string message, Exception inner)
        :base(message, inner)
    {
        
    }
}