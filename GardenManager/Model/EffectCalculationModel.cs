using GardenManager.Enums;

namespace GardenManager.Model;

public class EffectCalculationModel
{
    public int Quantity { get; set; }
    public Effect Effect { get; set; }

    public EffectCalculationModel(Effect effect)
    {
        Effect = effect;
        Quantity = 1;
    }

    public void UpQuantity()
    {
        Quantity++;
    }

    public TieredEffect? ConvertToTieredEffect()
    {
        TieredEffect tieredEffect = new TieredEffect(Effect, Quantity - 1);
        if (Quantity > 1)
            tieredEffect.Tier = Quantity - 1;
        return tieredEffect;
    }
}