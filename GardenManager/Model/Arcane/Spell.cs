using GardenManager.Enums;
using GardenManager.Enums.Arcane;
using GardenManager.Exceptions;

namespace GardenManager.Model.Arcane;

public class Spell
{
    public int SpellLevel { get; set; }
    public int ManaCost { get; set; }
    public string SpellDescription { get; set; }
    public List<Word> Incantation { get; set; } = [];
    public List<ArcaneEffect> Effects { get; set; } = [];
    public List<int> EffectTiers { get; set; } = [];
    public List<School> Schools { get; set; } = [];
    public ShapeWord ShapeWord { get; set; }
    public ArcaneShape Shape { get; set; }
    public int ShapeTier { get; set; }
    public List<ArcaneModifier> Modifiers { get; set; } = [];
    public List<int> ModifierTiers { get; set; } = [];
    public decimal TotalPotentia { get; set; } = 0;
    public decimal TotalArcainum { get; set; } = 0;
    public decimal TotalFlux { get; set; } = 0;
    public string? AdverseEffect { get; set; }
    public string? AdverseEffectReason { get; set; }

    public override string ToString()
    {
        if (AdverseEffect == null)
        {
            return "Spell works!";
        }

        return AdverseEffect;
    }

    public void VerifyStructure(List<ShapeWord> shapeWords, List<EffectWord> effectWords, List<PowerWord> powerWords, List<ModifierWord> modifierWords)
    {
        int shapeStart = -1;
        int effectStart = -1;
        int secondEffectStart = -1;
        int modifierCount = 0;
        List<int> modifierStart = [];

        shapeStart = DetermineSchools();
        effectStart = DetermineShape(shapeStart, shapeWords, powerWords);
        DetermineEffect(effectStart, 0, effectWords, powerWords);
        modifierCount = DetermineModifierCount();

    }

    private int DetermineSchools()
    {
        int ShapeStart = -1;
        if (Incantation[0].GetType() != typeof(ModifierWord) || Incantation[0].Tier != 1)
        {
            throw new NotSchoolWordException("First word is not a school word");
        }
        Schools.Add(Incantation[0].School);
        for (int i = 1; i < Incantation.Count; i++)
        {
            if (Incantation[0].GetType() != typeof(ModifierWord) || Incantation[0].Tier != 1)
            {
                ShapeStart = i;
                break;
            }
            Schools.Add(Incantation[i].School);
            if (Schools.Count > 3)
            {
                throw new TooManySchoolsException("No spell can contain more than three school words");
            }
        }
        return ShapeStart;
    }

    private int DetermineShape(int shapeStart, List<ShapeWord> shapeWords, List<PowerWord> powerWords)
    {
        int effectStart = -1;
        decimal shapePotentia = 0;
        if (shapeStart == -1 || Incantation[shapeStart].GetType() != typeof(ShapeWord))
        {
            throw new ShapeRequiredException("Shape is required after the school words");
        }
        ShapeWord = shapeWords.Find(w => w.WordText == Incantation[shapeStart].WordText)!;
        Shape = ShapeWord.Shape;
        for (int i = shapeStart + 1; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(PowerWord))
            {
                effectStart = i;
                break;
            }
            PowerWord pw = powerWords.Find(w => w.WordText == Incantation[i].WordText)!;
            shapePotentia += pw.Potentia;
            TotalPotentia += pw.Potentia;
            TotalArcainum += pw.Arcainum;
            TotalFlux += pw.Flux;
        }
        ShapeTier = TestShapeThresholds(shapePotentia);
        return effectStart;
    }

    private int TestShapeThresholds(decimal shapePotentia)
    {
        int tier = 0;
        foreach (int threshold in Shape.Thresholds)
        {
            if (shapePotentia < threshold)
            {
                return tier;
            }
            tier++;
        }
        return tier;
    }
    
    private int DetermineEffect(int effectStart, int effectIndex, List<EffectWord> effectWords, List<PowerWord> powerWords)
    {
        int modStart = -1;
        decimal effectPotentia = 0;
        if (effectStart != -1 || Incantation[effectStart].GetType() != typeof(EffectWord))
        {
            throw new EffectRequiredException("Effect is required after the shape word and it's power words");
        }
        EffectWord effect = effectWords.Find(e => e.WordText == Incantation[effectStart].WordText)!;
        Effects.Add(effect.Effect);
        for (int i = effectStart + 1; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(PowerWord))
            {
                EffectTiers.Add(TestEffectTresholds(effectIndex, effectPotentia));
                modStart = i;
                return modStart;
            }
            PowerWord pw = powerWords.Find(e => e.WordText == Incantation[i].WordText)!;
            effectPotentia += pw.Potentia;
            TotalPotentia += pw.Potentia;
            TotalArcainum += pw.Arcainum;
            TotalFlux += pw.Flux;
        }
        EffectTiers.Add(TestEffectTresholds(effectIndex, effectPotentia));
        return modStart;
    }

    private int TestEffectTresholds(int effectIndex, decimal effectPotentia)
    {
        int tier = 0;
        foreach (int threshold in Effects[effectIndex].Thresholds)
        {
            if (effectPotentia < threshold)
            {
                return tier;
            }
            tier++;
        }
        return tier;
    }

    private int DetermineModifierCount()
    {
        int modCount = 0;
        for (int i = 0; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(ModifierWord))
            {
                modCount++;
            }
        }

        return modCount;
    }
}