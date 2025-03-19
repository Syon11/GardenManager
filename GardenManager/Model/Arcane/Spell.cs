using System.Diagnostics;
using System.Text;
using GardenManager.Enums;
using GardenManager.Enums.Arcane;
using GardenManager.Exceptions;

namespace GardenManager.Model.Arcane;

public class Spell
{
    public decimal PotentiaMultiplier { get; set; } = 1.0m;
    public decimal ArcainumMultiplier { get; set; } = 1.0m;
    public decimal FluxMultiplier { get; set; } = 1.0m;
    public int SpellLevel { get; set; }
    public int ManaCost { get; set; }
    public int HealthCost { get; set; } = 0;
    public string SpellDescription { get; set; } = String.Empty;
    public StringBuilder ModifierDescriptions { get; set; } = new StringBuilder();
    public List<Word> Incantation { get; set; } = [];
    public List<ArcaneEffect> Effects { get; set; } = [];
    public List<int> EffectTiers { get; set; } = [];
    public List<ArcaneValues> EffectValues { get; set; } = [];
    public List<School> Schools { get; set; } = [];
    public ShapeWord ShapeWord { get; set; }
    public ArcaneShape Shape { get; set; }
    public int ShapeTier { get; set; } = 0;
    public ArcaneValues ShapeValues { get; set; }
    public List<ArcaneModifier> Modifiers { get; set; } = [];
    public List<ModifierWord> ModifierWords { get; set; } = [];
    public List<int> ModifierTiers { get; set; } = [];
    public List<ArcaneValues> ModifierValues { get; set; } = [];
    public decimal TotalPotentia { get; set; } = 0;
    public decimal TotalArcainum { get; set; } = 0;
    public decimal TotalFlux { get; set; } = 0;
    public string? AdverseEffect { get; set; }
    public string? AdverseEffectReason { get; set; }
    public bool IsCombinaison { get; set; } = false;
    public bool IsElemental { get; set; } = false;
    public Element? Element { get; set; } 
    public bool IsInverse { get; set; } = false;
    public bool IsSacrificiel { get; set; } = false;
    
    
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (!string.IsNullOrEmpty(AdverseEffect)) return AdverseEffect;
        sb.AppendLine(SpellDescription);
        sb.AppendLine(ModifierDescriptions.ToString());
        return sb.ToString();

    }

    public void VerifyStructure(List<ShapeWord> shapeWords, List<EffectWord> effectWords, List<PowerWord> powerWords, List<ModifierWord> modifierWords)
    {
        int shapeStart = -1;
        int effectStart = -1;
        int secondEffectStart = -1;
        List<int> modifierStart = [];

        shapeStart = DetermineSchools();
        CheckIfPartOfSchool();
        effectStart = DetermineShape(shapeStart, shapeWords, powerWords);
        DetermineEffect(effectStart, 0, effectWords, powerWords);
        DetermineModifierStarts(modifierStart, modifierWords);
        for (int i = 0; i < modifierStart.Count; i++)
        {
            DetermineModifierTier(Modifiers[i], modifierStart[i], i, powerWords);
        }
        DetermineCombinationEffect(effectWords, powerWords);
        CalculateValues();
        EnableModifiers();
        DetermineManaCost();
        RecalculateSacrificialCost();
        SetDescription();
    }

    private void CheckIfPartOfSchool()
    {
        foreach (Word word in Incantation)
        {
            if (Schools.Contains(word.School)) continue;
            throw new NotPartOfSelectedSchoolsException($"Mot sélectionné: {word.WordText} ne fait partie d'aucune écoles choisies du sort.");
        }
    }

    private void CalculateValues()
    {
        ShapeValues.Potentia *= PotentiaMultiplier;
        ShapeValues.Arcainum *= ArcainumMultiplier;
        ShapeValues.Flux *= FluxMultiplier;
        ShapeTier = TestShapeThresholds(ShapeValues.Potentia);
        for (int i = 0; i < Effects.Count; i++)
        {
            EffectValues[i].Potentia *= PotentiaMultiplier;
            EffectValues[i].Arcainum *= ArcainumMultiplier;
            EffectValues[i].Flux *= FluxMultiplier;
            EffectTiers.Add(TestEffectThresholds(i, EffectValues[i].Potentia));
        }
        for (int i = 0; i < Modifiers.Count; i++)
        {
            ModifierValues[i].Potentia *= PotentiaMultiplier;
            ModifierValues[i].Arcainum *= ArcainumMultiplier;
            ModifierValues[i].Flux *= FluxMultiplier;
            ModifierTiers.Add(TestModifierThreshold(Modifiers[i], ModifierValues[i].Potentia));
        }
        TotalPotentia = ModifierValues.Sum(x => x.Potentia) + EffectValues.Sum(x => x.Potentia) + ShapeValues.Potentia;
        TotalArcainum = ModifierValues.Sum(x => x.Arcainum) + EffectValues.Sum(x => x.Arcainum) + ShapeValues.Arcainum;
        TotalFlux = ModifierValues.Sum(x => x.Flux) + EffectValues.Sum(x => x.Flux) + ShapeValues.Flux;
    }
    
    
    private int DetermineSchools()
    {
        int shapeStart = -1;
        if (Incantation[0].GetType() != typeof(ModifierWord) || Incantation[0].Tier != 1)
        {
            throw new NotSchoolWordException("First word is not a school word");
        }
        Schools.Add(Incantation[0].School);
        for (int i = 1; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(ModifierWord) || Incantation[i].Tier != 1)
            {
                shapeStart = i;
                break;
            }
            Schools.Add(Incantation[i].School);
            FluxMultiplier += 0.20m;
            if (Schools.Count > 3)
            {
                throw new TooManySchoolsException("No spell can contain more than three school words");
            }
        }
        return shapeStart;
    }

    private int DetermineShape(int shapeStart, List<ShapeWord> shapeWords, List<PowerWord> powerWords)
    {
        int effectStart = -1;
        if (shapeStart == -1 || Incantation[shapeStart].GetType() != typeof(ShapeWord))
        {
            throw new ShapeRequiredException("Shape is required after the school words");
        }
        ShapeWord = shapeWords.Find(w => w.WordText == Incantation[shapeStart].WordText)!;
        Shape = ShapeWord.Shape;
        PotentiaMultiplier += (decimal)(ShapeWord.PotentiaEffect - 1);
        ArcainumMultiplier += (decimal)(ShapeWord.ArcainumEffect - 1);
        FluxMultiplier += (decimal)(ShapeWord.FluxEffect - 1);
        ShapeValues = new ArcaneValues();
        for (int i = shapeStart + 1; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(PowerWord))
            {
                effectStart = i;
                break;
            }
            PowerWord pw = powerWords.Find(w => w.WordText == Incantation[i].WordText)!;
            ShapeValues.Potentia += pw.Potentia;
            ShapeValues.Flux += pw.Flux;
            ShapeValues.Arcainum += pw.Arcainum;
        }
        
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
        if (effectStart == -1 || Incantation[effectStart].GetType() != typeof(EffectWord))
        {
            throw new EffectRequiredException("Effect is required after the shape word and it's power words");
        }
        EffectWord effect = effectWords.Find(e => e.WordText == Incantation[effectStart].WordText)!;
        Effects.Add(effect.Effect);
        EffectValues.Add(new ArcaneValues());
        PotentiaMultiplier += (decimal)(effect.PotentiaEffect - 1);
        ArcainumMultiplier += (decimal)(effect.ArcainumEffect - 1);
        FluxMultiplier += (decimal)(effect.FluxEffect - 1);
        for (int i = effectStart + 1; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(PowerWord))
            {
                modStart = i;
                return modStart;
            }
            PowerWord pw = powerWords.Find(e => e.WordText == Incantation[i].WordText)!;
            EffectValues[effectIndex].Potentia += pw.Potentia;
            EffectValues[effectIndex].Arcainum += pw.Arcainum;
            EffectValues[effectIndex].Flux += pw.Flux;
        }
        return modStart;
    }

    private int TestEffectThresholds(int effectIndex, decimal effectPotentia)
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

    private void DetermineModifierStarts(List<int> modifierStart, List<ModifierWord> modifierWords)
    {
        for (int i = 0; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(ModifierWord)) 
                continue;
            ModifierWord? mod = modifierWords.Find(w => w.WordText == Incantation[i].WordText && w.Modifier != null);
            if (mod == null) 
                continue;
            ModifierWords.Add(mod);
            Modifiers.Add(mod.Modifier!);
            PotentiaMultiplier += (decimal)(mod.PotentiaEffect - 1);
            ArcainumMultiplier += (decimal)(mod.ArcainumEffect - 1);
            FluxMultiplier += (decimal)(mod.FluxEffect - 1);
            modifierStart.Add(i);
        }
    }

    private void DetermineModifierTier(ArcaneModifier currentModifier, int modifierIndexInIncantation, int modifierIndexInList, List<PowerWord> powerWords)
    {
        decimal modifierPotentia = 0;
        ModifierValues.Add(new ArcaneValues());
        for (int i = modifierIndexInIncantation + 1; i < Incantation.Count; i++)
        {
            if (Incantation[i].GetType() != typeof(PowerWord))
            {
                return;
            }
            PowerWord pw = powerWords.Find(e => e.WordText == Incantation[i].WordText)!;
            
            ModifierValues[modifierIndexInList].Potentia += pw.Potentia;
            ModifierValues[modifierIndexInList].Arcainum += pw.Arcainum;
            ModifierValues[modifierIndexInList].Flux += pw.Flux;
        }
    }

    private int TestModifierThreshold(ArcaneModifier modifier,decimal modifierPotentia)
    {
        return modifier.Thresholds.Count(t => modifierPotentia >= t);
    }

    private void DetermineManaCost()
    {
        int wordCount = Incantation.Count;
        List<int> thresholds = [4, 8, 14, 24, 48, 90];
        SpellLevel = thresholds.Count(t => wordCount >= t) + 1;
        ManaCost = (SpellLevel * 2) - 1;
        ManaCost += GetManaAdjustment(SpellLevel);
        
    }

    private int GetManaAdjustment(int level)
    {
        List<int> thresholds = [level, level * 2, level * 4, level * 8, level * 16];
        decimal differential = TotalPotentia - TotalFlux;
        if (differential < 0)
            differential *= -1;
        return thresholds.Count(t => differential >= t);
    }

    private void EnableModifiers()
    {
        int iter = 0;
        foreach (ArcaneModifier mod in Modifiers)
        {
            int maxTiers = mod.Thresholds.Count;
            var currentTier = ModifierTiers[iter] >= maxTiers ? maxTiers - 1 : ModifierTiers[iter];
            
            switch (mod.Name)
            {
                case "Cibles":
                    ModifierDescriptions.Append($"Cibles: ");
                    break;
                case "Combinaison":
                    IsCombinaison = true;
                    ModifierDescriptions.Append($"Combinaison: ");
                    break;
                case "Durée":
                    ModifierDescriptions.Append($"Durée: ");
                    break;
                case "Distance" :
                    ModifierDescriptions.Append($"Distance: ");
                    break;
                case "ElementalFeu" :
                    if (IsElemental)
                    {
                        ModifierDescriptions.Clear();
                        throw new TooManyElementsException("Only one element can be selected.");
                    }
                    IsElemental = true;
                    Element = Enums.Element.Fire;
                    ModifierDescriptions.Append($"Elemental: ");
                    break;
                case "ElementalGlace" :
                    if (IsElemental)
                    {
                        ModifierDescriptions.Clear();
                        throw new TooManyElementsException("Only one element can be selected.");
                    }
                    IsElemental = true;
                    Element = Enums.Element.Ice;
                    ModifierDescriptions.Append($"Elemental: ");
                    break;
                case "ElementalFoudre" :
                    if (IsElemental)
                    {
                        ModifierDescriptions.Clear();
                        throw new TooManyElementsException("Only one element can be selected.");
                    }
                    IsElemental = true;
                    Element = Enums.Element.Thunder;
                    ModifierDescriptions.Append($"Elemental: ");
                    break;
                case "ElementalAcide" :
                    if (IsElemental)
                    {
                        ModifierDescriptions.Clear();
                        throw new TooManyElementsException("Only one element can be selected.");
                    }
                    IsElemental = true;
                    Element = Enums.Element.Acid;
                    ModifierDescriptions.Append($"Elemental: ");
                    break;
                case "ElementalBeni" :
                    if (IsElemental)
                    {
                        ModifierDescriptions.Clear();
                        throw new TooManyElementsException("Only one element can be selected.");
                    }
                    IsElemental = true;
                    Element = Enums.Element.Holy;
                    ModifierDescriptions.Append($"Elemental: ");
                    break;
                case "ElementalMaudit" :
                    if (IsElemental)
                    {
                        ModifierDescriptions.Clear();
                        throw new TooManyElementsException("Only one element can be selected.");
                    }
                    IsElemental = true;
                    Element = Enums.Element.Unholy;
                    ModifierDescriptions.Append($"Elemental: ");
                    break;
                case "Impact" :
                    ModifierDescriptions.Append($"Impact: ");
                    break;
                case "Inversement" :
                    if (ModifierTiers[iter] == 0)
                    {
                        continue;
                    }
                    IsInverse = true;
                    ModifierDescriptions.Append($"Inversement: ");
                    break;
                case "Rayon" :
                    ModifierDescriptions.Append($"Rayon: ");
                    break;
                case "Sacrificiel" :
                    IsSacrificiel = true;
                    ModifierDescriptions.Append($"Sacrificiel: ");
                    break;
            }
            ModifierDescriptions.Append(mod.DescriptionAtThresholds[currentTier]);
            iter++;
        }
    }

    private void RecalculateSacrificialCost()
    {
        if (IsSacrificiel)
        {
            int modIndex =  Modifiers.FindIndex(m => m.Name == "Sacrificiel");
            int tier = ModifierTiers[modIndex];
            switch (tier)
            {
                case 1:
                    HealthCost = ManaCost;
                    ManaCost = 0;
                    break;
                case 2:
                    HealthCost = ManaCost / 3;
                    HealthCost += ManaCost % 3 == 0 ? 0 : 1;
                    ManaCost = 0;
                    break;
                case 3:
                    HealthCost = ManaCost / 10;
                    HealthCost += ManaCost % 10 == 0 ? 0 : 1;
                    ManaCost = 0;
                    break;
            }
        }
    }

    private void DetermineCombinationEffect(List<EffectWord> effectWords, List<PowerWord> powerWords)
    {
        if (IsCombinaison)
        {
            int modIndex = Modifiers.FindIndex(m => m.Name == "Combinaison");
            int tier = ModifierTiers[modIndex];
            if (tier < 1)
            {
                return;
            }
            DetermineEffect(modIndex+1, 1, effectWords, powerWords);
        }
    }

    private void SetDescription()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Effet: ");
        int iter = 0;
        foreach (ArcaneEffect effect in Effects)
        {
            if (IsInverse)
            {
                if (effect.HasElementalEffects && IsElemental)
                {
                    sb.AppendLine(GetElementalDescriptors(effect, Element, iter, effect.ScalesOnElements, true));
                    continue;
                }

                if (effect.InvertedEffects is { Count: > 0})
                {
                    sb.AppendLine(effect.InvertedEffects.Count > EffectTiers[iter] ? effect.InvertedEffects[EffectTiers[iter]] : effect.InvertedEffects[effect.InvertedEffects.Count - 1]);
                    continue;
                }

                throw new EffectAndModifierIncompatibilityException(
                    "Modificateur \"Inversement\" incompatible avec cet effet!");
            }

            if (effect.HasElementalEffects && IsElemental)
            {
                sb.AppendLine(GetElementalDescriptors(effect, Element, iter, effect.ScalesOnElements));
                continue;
            }

            sb.AppendLine(effect.DescriptionAtThresholds.Count > EffectTiers[iter]
                ? effect.DescriptionAtThresholds[EffectTiers[iter]]
                : effect.DescriptionAtThresholds[effect.DescriptionAtThresholds.Count - 1]);
        }
        SpellDescription = sb.ToString();
    }

    private string GetElementalDescriptors(ArcaneEffect effect, Element? element, int effectIterator, bool scalesOnModifier, bool inverted = false)
    {
        if (inverted)
        {
            switch(element){
                case Enums.Element.Fire:
                    if (effect.InvertedFireEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.InvertedFireEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                    ? effect.InvertedFireEffects[GetElementalModificatorTier(element)]
                                    : effect.InvertedFireEffects[effect.InvertedFireEffects.Count - 1];
                        }
                        return effect.InvertedFireEffects.Count > EffectTiers[effectIterator] ? effect.InvertedFireEffects[EffectTiers[effectIterator]] : effect.InvertedFireEffects[effect.InvertedFireEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Feu\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Ice:
                    if (effect.InvertedIceEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.InvertedIceEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                    ? effect.InvertedIceEffects[GetElementalModificatorTier(element)]
                                    : effect.InvertedIceEffects[effect.InvertedIceEffects.Count - 1];
                        }
                        return effect.InvertedIceEffects.Count > EffectTiers[effectIterator] ? effect.InvertedIceEffects[EffectTiers[effectIterator]] : effect.InvertedIceEffects[effect.InvertedIceEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Glace\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Holy:
                    if (effect.InvertedHolyEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.InvertedHolyEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.InvertedHolyEffects[GetElementalModificatorTier(element)]
                                : effect.InvertedHolyEffects[effect.InvertedHolyEffects.Count - 1];
                        }
                        return effect.InvertedHolyEffects.Count > EffectTiers[effectIterator] ? effect.InvertedHolyEffects[EffectTiers[effectIterator]] : effect.InvertedHolyEffects[effect.InvertedHolyEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Béni\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Unholy:
                    if (effect.InvertedUnholyEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.InvertedUnholyEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.InvertedUnholyEffects[GetElementalModificatorTier(element)]
                                : effect.InvertedUnholyEffects[effect.InvertedUnholyEffects.Count - 1];
                        }
                        return effect.InvertedUnholyEffects.Count > EffectTiers[effectIterator] ? effect.InvertedUnholyEffects[EffectTiers[effectIterator]] : effect.InvertedUnholyEffects[effect.InvertedUnholyEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Maudit\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Thunder:
                    if (effect.InvertedThunderEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.InvertedThunderEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.InvertedThunderEffects[GetElementalModificatorTier(element)]
                                : effect.InvertedThunderEffects[effect.InvertedThunderEffects.Count - 1];
                        }
                        return effect.InvertedThunderEffects.Count > EffectTiers[effectIterator] ? effect.InvertedThunderEffects[EffectTiers[effectIterator]] : effect.InvertedThunderEffects[effect.InvertedThunderEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Foudre\" incompatible avec la version inversée de cet effet!"); 
                case Enums.Element.Acid :
                    if (effect.InvertedAcidEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.InvertedAcidEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.InvertedAcidEffects[GetElementalModificatorTier(element)]
                                : effect.InvertedAcidEffects[effect.InvertedAcidEffects.Count - 1];
                        }
                        return effect.InvertedAcidEffects.Count > EffectTiers[effectIterator] ? effect.InvertedAcidEffects[EffectTiers[effectIterator]] : effect.InvertedAcidEffects[effect.InvertedAcidEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Acide\" incompatible avec la version inversée de cet effet!");
                }
        }
        else
        {
                switch(element){
                case Enums.Element.Fire:
                    if (effect.FireEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.FireEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                    ? effect.FireEffects[GetElementalModificatorTier(element)]
                                    : effect.FireEffects[effect.FireEffects.Count - 1];
                        }
                        return effect.FireEffects.Count > EffectTiers[effectIterator] ? effect.FireEffects[EffectTiers[effectIterator]] : effect.FireEffects[effect.FireEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Feu\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Ice:
                    if (effect.IceEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.IceEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                    ? effect.IceEffects[GetElementalModificatorTier(element)]
                                    : effect.IceEffects[effect.IceEffects.Count - 1];
                        }
                        return effect.IceEffects.Count > EffectTiers[effectIterator] ? effect.IceEffects[EffectTiers[effectIterator]] : effect.IceEffects[effect.IceEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Glace\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Holy:
                    if (effect.HolyEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.HolyEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.HolyEffects[GetElementalModificatorTier(element)]
                                : effect.HolyEffects[effect.HolyEffects.Count - 1];
                        }
                        return effect.HolyEffects.Count > EffectTiers[effectIterator] ? effect.HolyEffects[EffectTiers[effectIterator]] : effect.HolyEffects[effect.HolyEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Béni\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Unholy:
                    if (effect.UnholyEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.UnholyEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.UnholyEffects[GetElementalModificatorTier(element)]
                                : effect.UnholyEffects[effect.UnholyEffects.Count - 1];
                        }
                        return effect.UnholyEffects.Count > EffectTiers[effectIterator] ? effect.UnholyEffects[EffectTiers[effectIterator]] : effect.UnholyEffects[effect.UnholyEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Maudit\" incompatible avec la version inversée de cet effet!");
                case Enums.Element.Thunder:
                    if (effect.ThunderEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.ThunderEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.ThunderEffects[GetElementalModificatorTier(element)]
                                : effect.ThunderEffects[effect.ThunderEffects.Count - 1];
                        }
                         return effect.ThunderEffects.Count > EffectTiers[effectIterator] ? effect.ThunderEffects[EffectTiers[effectIterator]] : effect.ThunderEffects[effect.ThunderEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Foudre\" incompatible avec la version inversée de cet effet!"); 
                case Enums.Element.Acid :
                    if (effect.AcidEffects is { Count: > 0 })
                    {
                        if (scalesOnModifier)
                        {
                            return effect.AcidEffects.Count > ModifierTiers[GetElementalModificatorTier(element)]
                                ? effect.AcidEffects[GetElementalModificatorTier(element)]
                                : effect.AcidEffects[effect.AcidEffects.Count - 1];
                        }
                        return effect.AcidEffects.Count > EffectTiers[effectIterator] ? effect.AcidEffects[EffectTiers[effectIterator]] : effect.AcidEffects[effect.AcidEffects.Count - 1];
                    }
                    throw new EffectAndModifierIncompatibilityException(
                        "Modificateur \"Elemental-Acide\" incompatible avec la version inversée de cet effet!");
                }
        }

        throw new Exception("Fatal Exception: This shouldn't be possible");
    }

    private int GetElementalModificatorTier(Element? element)
    {
        switch (element)
        {
            case Enums.Element.Acid:
                return ModifierTiers[Modifiers.FindIndex(m => m.Name == "ElementalAcide")];
            case Enums.Element.Ice:
                return ModifierTiers[Modifiers.FindIndex(m => m.Name == "ElementalGlace")];
            case Enums.Element.Holy:
                return ModifierTiers[Modifiers.FindIndex(m => m.Name == "ElementalBeni")];
            case Enums.Element.Unholy:
                return ModifierTiers[Modifiers.FindIndex(m => m.Name == "ElementalMaudit")];
            case Enums.Element.Thunder:
                return ModifierTiers[Modifiers.FindIndex(m => m.Name == "ElementalFoudre")];
            case Enums.Element.Fire:
                return ModifierTiers[Modifiers.FindIndex(m => m.Name == "ElementalFeu")];
        }

        throw new Exception("Fatal exception: Stacktrace: GardenManager.Model.Arcane.Spell.GetElementalModificatorTier No element was passed, should not have happened");
    }
}