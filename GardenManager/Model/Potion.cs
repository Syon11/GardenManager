using GardenManager.Enums;
using GardenManager.Interfaces;
using GardenManager.Utility;

namespace GardenManager.Model;

public class Potion
{
    public List<SecondaryEffect> SecondaryEffects { get; set; } = [];
    public TieredEffect TieredEffect { get; set; }
    public List<TieredEffect> TieredEffects { get; set; } = [];
    public bool IsMasterwork { get; set; } = true;
    public Effect MainEffect { get; set; }
    public Essence MainEssence { get; set; }
    
    public List<IAlchemizable> Ingredients { get; set; }

    public Potion(List<IAlchemizable> ingredients, List<AlchemyEffect> effectToEssence)
    {
        Ingredients = ingredients;
        MainEffect = SelectEffect(Ingredients.FirstOrDefault());
        MainEssence = effectToEssence.Where(e => e.Effect == MainEffect).Select(e => e.Essence).FirstOrDefault();
        DetermineEffects();
    }

    public void DetermineEffects()
    {
        List<Effect> effects = new List<Effect>();
        List<EffectCalculationModel> effectCalcs = new List<EffectCalculationModel>();
        foreach (var ingredient in Ingredients)
        {
            foreach (var effect in ingredient.AlchemicalEffects)
            {
                if (effects.Contains(effect))
                {
                    effectCalcs.FirstOrDefault(ti => ti.Effect == effect)!.UpQuantity();

                }
                else
                {
                    effects.Add(effect);
                    effectCalcs.Add(new EffectCalculationModel(effect));
                }
            }
        }

        int currentTier = -1;
        foreach (var ingredient in Ingredients)
        {
            if (ingredient.AlchemicalEffects.Contains(MainEffect))
            {
                currentTier++;
            }
            else if (ingredient.Essence == MainEssence)
            {
                currentTier++;
                SecondaryEffects.Add(ingredient.SecondaryEffect);
                IsMasterwork = false;
            }
            else
            {
                IsMasterwork = false;
            }
        }

        TieredEffect = new TieredEffect(MainEffect, currentTier);

        foreach (EffectCalculationModel calc in effectCalcs)
        {
            if (calc.Quantity > 1)
            {
                TieredEffects.Add(calc.ConvertToTieredEffect()!);
            }
        }

        TieredEffect old = TieredEffect;
        foreach (var tieredEffect in TieredEffects)
        {
            if (TieredEffect.Tier < tieredEffect.Tier)
            {
                TieredEffect = tieredEffect;
                MainEffect = tieredEffect.Effect;
                MainEssence = tieredEffect.Essence;
            }
        }

        if (old != TieredEffect)
        {
            foreach (var ingredient in Ingredients)
            {
                if (!ingredient.AlchemicalEffects.Contains(MainEffect))
                {
                    SecondaryEffects.Add(ingredient.SecondaryEffect);
                }
            }
        }
}


    public Effect SelectEffect(IAlchemizable ingredient)
    {
        int iterator = 0;
        foreach (var effect in ingredient.AlchemicalEffects)
        {
            Console.WriteLine($"{iterator}) {Enum.GetName(effect)}");
            iterator++;
        }

        string? selection = Console.ReadLine();
        while (selection == null || !InputValidator.ValidateEntryWithRegex(selection, @$"^[0-{iterator - 1}]*$"))
        {
            Console.Write("Invalid selection, please try again: ");
            selection = Console.ReadLine();
        }

        return ingredient.AlchemicalEffects[int.Parse(selection!)];
    }

    public override string ToString()
    {
        return $"{Enum.GetName(typeof(Effect), TieredEffect.Effect)}: Tier {TieredEffect.Tier}";
    }

    public void PrintFullPotion()
    {
        Console.WriteLine($"Main Effets: {Enum.GetName(typeof(Effect), MainEffect)}" );
        Console.WriteLine($"Effect Tier: {TieredEffect.Tier}");
        Console.WriteLine($"Main Essence: {Enum.GetName(typeof(Essence), MainEssence)}");
        Console.WriteLine("Secondary Effects:");
        foreach (SecondaryEffect secondaryEffect in SecondaryEffects)
        {
            Console.WriteLine($"  - {secondaryEffect.ToString()}");
        }
        Console.WriteLine($"Potion description: {TieredEffect.EffectDescription}");
    }
}