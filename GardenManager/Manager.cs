using System.ComponentModel.DataAnnotations.Schema;
using GardenManager.Enums;
using GardenManager.Model;

namespace GardenManager;

public class Manager
{
    public List<Plant> Plants { get; set; }
    public List<User> Users { get; set; }


    public Manager()
    {
        Plants = [];
        Users = [];
    }

    public void initPlants()
    {
        Plants =
        [
            new Plant("Baies Poilues du Désert", Essence.Acide, Genus.Grimpante, [Effect.Stimulant, Effect.Corps_Epineux],
                SecondaryEffect.Amnesie),
            new Plant("Azalée", Essence.Acide, Genus.Bulbe, [Effect.Flux, Effect.Extrait_Abjuration], SecondaryEffect.Demangeaisons)
        ];
    }
}