using GardenManager.Enums;
using GardenManager.Interfaces;

namespace GardenManager.Model;

public class Potion
{
    public List<SecondaryEffect> SecondaryEffects { get; set; } = [];
    public List<TieredEffect> TieredEffects { get; set; } = [];
    public bool isMasterwork { get; set; }
    
    public List<IAlchemizable> Ingredients { get; set; }

    public Potion(List<IAlchemizable> ingredients)
    {
        Ingredients = ingredients;
        DetermineEffects();
        CheckIfMasterwork();
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
                    var currentCalc = effectCalcs.Where(TI => TI.Effect == effect).FirstOrDefault();
                    currentCalc.UpQuantity();
                }
                else
                {
                    effects.Add(effect);
                    effectCalcs.Add(new EffectCalculationModel(effect));
                }
            }
        }

        foreach (EffectCalculationModel calc in effectCalcs)
        {
            if (calc.Quantity > 1)
            {
                TieredEffects.Add(calc.ConvertToTieredEffect()!);
            }
        }
    }

    public void CheckIfMasterwork()
    {
        
    }
}