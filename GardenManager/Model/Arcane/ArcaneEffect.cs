using GardenManager.Enums;

namespace GardenManager.Model.Arcane;

public class ArcaneEffect : ArcaneConfig
{
    public List<string>? InvertedEffects { get; set; }
    public List<string>? FireEffects { get; set; }
    public List<string>? IceEffects { get; set; }
    public List<string>? ThunderEffects { get; set; }
    public List<string>? AcidEffects { get; set; }
    public List<string>? HolyEffects { get; set; }
    public List<string>? UnholyEffects { get; set; }
    public List<string>? InvertedFireEffects { get; set; }
    public List<string>? InvertedIceEffects { get; set; }
    public List<string>? InvertedThunderEffects { get; set; }
    public List<string>? InvertedAcidEffects { get; set; }
    public List<string>? InvertedHolyEffects { get; set; }
    public List<string>? InvertedUnholyEffects { get; set; }

    public bool HasElementalEffects;
    public bool ScalesOnElements;
    public ArcaneEffect(){}
    
    public ArcaneEffect(string name, List<int> thresholds, List<string> descriptions)
        : base(name, thresholds, descriptions)
    {
        
    }
    
    public ArcaneEffect(string name, List<int> thresholds, List<string> descriptions, List<string> invertedEffects)
    : base(name, thresholds, descriptions)
    {
        InvertedEffects = invertedEffects;
    }

    public ArcaneEffect(string name, List<int> thresholds, List<string> descriptions, List<string> invertedEffects, bool hasElementalEffects = false, List<string>? fireEffects = null, List<string>? iceEffects = null, List<string>? thunderEffects = null, List<string>? acidEffects = null, List<string>? holyEffects = null, List<string>? unholyEffects = null) :
        base(name, thresholds, descriptions)
    {
        InvertedEffects = invertedEffects;
        HasElementalEffects = hasElementalEffects;
        ScalesOnElements = false;
        if (hasElementalEffects)
        {
            if (fireEffects != null)
                FireEffects = fireEffects;
            else
                FireEffects = new List<string>();
            if (iceEffects != null)
                IceEffects = iceEffects;
            else
                IceEffects = new List<string>();
            if (thunderEffects != null)
                ThunderEffects = thunderEffects;
            else
                ThunderEffects = new List<string>();
            if (acidEffects != null)
                AcidEffects = acidEffects;
            else
                AcidEffects = new List<string>();
            if (holyEffects != null)
                HolyEffects = holyEffects;
            else
                HolyEffects = new List<string>();
            if (unholyEffects != null)
                UnholyEffects = unholyEffects;
            else
                UnholyEffects = new List<string>();
        }
    }
    
    public ArcaneEffect(string name, 
        List<int> thresholds, 
        List<string> descriptions, 
        List<string> invertedEffects, 
        bool hasElementalEffects = false, 
        bool scalesOnElements = false, 
        List<string>? fireEffects = null, 
        List<string>? iceEffects = null, 
        List<string>? thunderEffects = null, 
        List<string>? acidEffects = null, 
        List<string>? holyEffects = null, 
        List<string>? unholyEffects = null, 
        List<string>? invertedFireEffects = null, 
        List<string>? invertedIceEffects = null, 
        List<string>? invertedThunderEffects = null, 
        List<string>? invertedAcidEffects = null, 
        List<string>? invertedHolyEffects = null,
        List<string>? invertedUnholyEffects = null) :
        base(name, thresholds, descriptions)
    {
        InvertedEffects = invertedEffects;
        HasElementalEffects = hasElementalEffects;
        ScalesOnElements = scalesOnElements;
        
        if (fireEffects != null)
            FireEffects = fireEffects;
        else
            FireEffects = new List<string>();
        if (iceEffects != null)
            IceEffects = iceEffects;
        else
            IceEffects = new List<string>();
        if (thunderEffects != null)
            ThunderEffects = thunderEffects;
        else
            ThunderEffects = new List<string>();
        if (acidEffects != null)
            AcidEffects = acidEffects;
        else
            AcidEffects = new List<string>();
        if (holyEffects != null)
            HolyEffects = holyEffects;
        else
            HolyEffects = new List<string>();
        if (unholyEffects != null)
            UnholyEffects = unholyEffects;
        else
            UnholyEffects = new List<string>();
        if (invertedFireEffects != null)
            InvertedFireEffects = invertedFireEffects;
        else
            InvertedFireEffects = new List<string>();
        if (invertedIceEffects != null)
            InvertedIceEffects = invertedIceEffects;
        else
            InvertedIceEffects = new List<string>();
        if (invertedThunderEffects != null)
            InvertedThunderEffects = invertedThunderEffects;
        else
            InvertedThunderEffects = new List<string>();
        if (invertedAcidEffects != null)
            InvertedAcidEffects = invertedAcidEffects;
        else
            InvertedAcidEffects = new List<string>();
        if (invertedHolyEffects != null)
            InvertedHolyEffects = invertedHolyEffects;
        else
            InvertedHolyEffects = new List<string>();
        if (invertedUnholyEffects != null)
            InvertedUnholyEffects = invertedUnholyEffects;
        else
            InvertedUnholyEffects = new List<string>();
    }

    public string ToString(int tier, Element element, bool isInverted = false)
    {
        if (isInverted)
        {
            return element switch
            {
                Element.Acid => AcidEffects is { Count: > 0 } ? AcidEffects[tier] : string.Empty,
                Element.Fire => FireEffects is { Count: > 0 } ? FireEffects[tier] : string.Empty,
                Element.Ice => IceEffects is { Count: > 0 } ? IceEffects[tier] : string.Empty,
                Element.Thunder => ThunderEffects is { Count: > 0 } ? ThunderEffects[tier] : string.Empty,
                Element.Holy => HolyEffects is { Count: > 0 } ? HolyEffects[tier] : string.Empty,
                Element.Unholy => UnholyEffects is { Count: > 0 } ? UnholyEffects[tier] : string.Empty,
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
        return element switch
        {
            Element.Acid => InvertedAcidEffects is { Count: > 0 } ? InvertedAcidEffects[tier] : string.Empty,
            Element.Fire => InvertedFireEffects is { Count: > 0 } ? InvertedFireEffects[tier] : string.Empty,
            Element.Ice => InvertedIceEffects is { Count: > 0 } ? InvertedIceEffects[tier] : string.Empty,
            Element.Thunder => InvertedThunderEffects is { Count: > 0 } ? InvertedThunderEffects[tier] : string.Empty,
            Element.Holy => InvertedHolyEffects is { Count: > 0 } ? InvertedHolyEffects[tier] : string.Empty,
            Element.Unholy => InvertedUnholyEffects is { Count: > 0 } ? InvertedUnholyEffects[tier] : string.Empty,
            _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
        };
    }
}