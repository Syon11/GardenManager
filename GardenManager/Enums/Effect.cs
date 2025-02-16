namespace GardenManager.Enums;

public enum Effect
{
    Flux,
    Graisseux,
    Huileux,
    Naphta,
    Antidouleur,
    Antitoxine,
    Antimagie,
    Argent_Alchimique,
    Armure_Naturelle,
    Calme,
    Celerite,
    Charisme,
    Concentration,	
    Corps_Epineux,
    Decoposition,
    Extrait_Arcanique,
    Faiblesse,
    Force,
    Terre,
    Feu,
    Foudre,
    Glace,
    Insomnie,
    Invisibilite,
    Mana,
    Mensonge,
    Paralysie,	
    Charme,
    Peur,
    Poison,
    Polymorphe,
    Rage,
    Remede,
    Soin,
    Sommeil,
    Stabilisant,
    Stimulant,
    Vitalite,
    Silence
}


// Collapse Extraits en extraits de magie. Garder les catalyseur comme séparés
// Stabilisant et Vivifiant même pots = prolonger l'agonie
// Stimulant = annuler les effets de sommeil Replaced by Insomnie
// Vitalite = PVT

// Antitoxine = Réduit la toxicité de l'utilisateur
// Contre_Poison, Remède = le même effet