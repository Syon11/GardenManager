using GardenManager.Enums;

namespace GardenManager.Model;

public class TieredEffect
{
    public bool IsValid { get; set; }
    public int Tier { get; set; }
    public Essence Essence { get; set; }
    public Effect Effect { get; set; }
    public string EffectDescription { get; set; } = string.Empty;
    public string CatalyzedDescription { get; set; } = string.Empty;

    public TieredEffect(Effect effect, int tier)
    {
        Effect = effect;
        Tier = tier - 1;
        if (Tier < 1)
        {
            IsValid = false;
        }
        else
        {
            CreateEffectDescription();
            CatalyseEffect();
        }
    }
    
    public void CreateEffectDescription()
    {
        switch (Effect)
        {
            case Effect.Antidouleur:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Permet d'ignorer le roleplay de douleur lors du prochain combat, pendant la durée de la concoction";
                        break;
                    case 2:
                        EffectDescription = "Permet d'éviter la prochaine instance d'effet de douleur pendant la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "Permet d'éviter les prochaines instances d'effet de douleur pendant la durée de la concoction";
                        break;
                }
                break;
            case Effect.Antimagie:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "-1/5 mana max pour la durée de la concoction";
                        break;
                    case 2:
                        EffectDescription = "-2/5 mana max pour la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "-3/5 mana max pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Antitoxine:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur se guérit de 30 de toxicité instantanément, ne peut être utilisé qu'une fois aux 4 heures";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur se guérit de 60 de toxicité instantanément, ne peut être utilisé qu'une fois aux 4 heures";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur se guérit de toute sa toxicité instantanément, ne peut être utilisé qu'une fois aux 4 heures";
                        break;
                }
                break;
            case Effect.Calme:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Cesse un effet de rage ou de peur";
                        break;
                    case 2:
                        EffectDescription = "Rends immunisé aux effets de rage ou de peur pour la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "Rends immunisé aux effets de rage, peur, confusion, déconcentration pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Celerite:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Donne une Presquive, utilisable lors du prochain combat.";
                        break;
                    case 2:
                        EffectDescription = "Donne une Esquive, utilisable lors du prochain combat.";
                        break;
                    case 3:
                        EffectDescription = "Donne trois Esquives, utilisable lors du prochain combat.";
                        break;
                }
                break;
            case Effect.Heroisme:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "+1 point d'habilité";
                        break;
                    case 2:
                        EffectDescription = "+2 point d'habilité";
                        break;
                    case 3:
                        EffectDescription = "+3 point d'habilité";
                        break;
                }
                break;
            case Effect.Charme:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Le buveur est attirée envers la première personne qu'elle voit pendant la durée de la potion.";
                        break;
                    case 2:
                        EffectDescription = "Le buveur est en amour envers la première personne qu'elle voit pendant la durée de la potion.";
                        break;
                    case 3:
                        EffectDescription = "Le buveur est en fol amour envers la première personne qu'elle voit pendant la durée de la potion";
                        break;
                }
                break;
            case Effect.Concentration:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Le buveur peut maintenant endurer 3 dégâts de plus avant d'être déconcentré une fois lors du prochain combat";
                        break;
                    case 2:
                        EffectDescription = "Le buveur peut maintenant endurer un coup de plus avant d'être déconcentré une fois lors du prochain combat";
                        break;
                    case 3:
                        EffectDescription = "Le buveur peut maintenant endurer un coup de plus avant d'être déconcentré pour tous ses sorts lors du prochain combat";
                        break;
                }
                break;
            case Effect.Decoposition:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Permet de décomposer un corps mort. Cause 5 de dégâts sur un mort vivant.";
                        break;
                    case 2:
                        EffectDescription = "Permet de décomposer un corps mort. Cause 15 de dégats sur un mort vivant.";
                        break;
                    case 3:
                        EffectDescription = "Permet de décomposer un corps mort. Cause 30 de dégâts sur un mort vivant.";
                        break;
                }
                break;
            case Effect.Faiblesse:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur possède -1 de force pour la durée de la concoction.";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur possède -2 de force et frappes de -1 pour la durée de la concoction.";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur possède -3 de force, frappes de -1, ne peut se battre qu'avec une seule arme a une main, ne peut plus tenir de bouclier et ne peux plus porter d'armure lourde pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Feu: 
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de feu pour les 5 prochain coups.";
                        break;
                    case 2:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de feu pour la durée du prochain combat.";
                        break;
                    case 3:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de feu pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Flux:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Produit 1 unité de Flux";
                        break;
                    case 2:
                        EffectDescription = "Produit 2 unités de Flux";
                        break;
                    case 3:
                        EffectDescription = "Produit 3 unités de Flux";
                        break;
                }
                break;
            case Effect.Force:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur possède +1 de force pour la durée de la concoction";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur possède +1 de force et frappe de +1 (passif) pour les prochains 5 coups";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur possède +1 de force, frappe de +1 (passif) pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Foudre:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de foudre pour les 5 prochain coups.";
                        break;
                    case 2:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de foudre pour la durée du prochain combat.";
                        break;
                    case 3:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de foudre pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Glace:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de glace pour les 5 prochain coups.";
                        break;
                    case 2:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de glace pour la durée du prochain combat.";
                        break;
                    case 3:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera de glace pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Graisseux:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Produit 1 unité de Graisse";
                        break;
                    case 2:
                        EffectDescription = "Produit 2 unités de Graisse";
                        break;
                    case 3:
                        EffectDescription = "Produit 3 unités de Graisse";
                        break;
                }
                break;
            case Effect.Huileux:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Produit 1 unité d'huile";
                        break;
                    case 2:
                        EffectDescription = "Produit 2 unités d'huile";
                        break;
                    case 3:
                        EffectDescription = "Produit 3 unités d'huile";
                        break;
                }
                break;
            case Effect.Insomnie:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur est immunisé au prochain effet de sommeil";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur est immunisé aux effets de sommeil pendant la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur est immunisé aux effets de sommeil pendant la durée de la concoction et ne récupèrera pas lors de la prochaine nuit";
                        break;
                }
                break;
            case Effect.Invisibilite:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur gagnes l'effet \"Camoufflage\" pour la durée de la concoction. L'effet se cancèles s'il effectue une action \"Violente\"";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur gagnes l'effet \"Invisibilité\" pour la durée de la concoction. L'effet se cancèles s'il effectue une action \"Violente\"";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur gagnes l'effet \"Invisibilité\" pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Mana:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur gagnes 5 de mana";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur gagnes 15 de mana";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur gagnes 30 de mana";
                        break;
                }
                break;
            case Effect.Mensonge:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur ne peut plus dire la vérité pour la durée de la concoction";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur est immunisé à la détection de la vérité pour la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur décides si ce qu'il dit passe pour une vérité ou un mensonge pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Naphta:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Produit 1 unité de Naphta Instable";
                        break;
                    case 2:
                        EffectDescription = "Produit 1 unités de Naphta";
                        break;
                    case 3:
                        EffectDescription = "Produit 2 unités de Naphta";
                        break;
                }
                break;
            case Effect.Paralysie:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur devient Paralysé pour 30 secondes. L'effet de paralysie est arrèté dès que l'utilisateur prends un point de dégâts.";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur devient Paralysé pour 5 minutes. L'effet de paralysie est arrèté dès que l'utilisateur prends un point de dégâts.";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur devient Paralysé pour la durée de la concoction. L'effet de paralysie est arrèté dès que l'utilisateur prends cinq point de dégâts.";
                        break;
                }
                break;
            case Effect.Peur:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur est victime d'un effet de Peur, la source de sa peur est la première personne qu'il voit suite à la consommation de la concoction. L'effet de peur dures 1 minute";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur est victime d'un effet de Peur, la source de sa peur est la première personne qu'il voit suite à la consommation de la concoction. L'effet de peur dures la durée de la concoction.";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur est victime d'un effet de Peur, la source de sa peur est la première personne qu'il voit suite à la consommation de la concoction. Il est incapable d'utiliser ses résistances mentales pendant la durée de l'effet de peur. L'effet de peur dures pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Poison:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur est victime de l'effet Poison pour 5 minutes";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur est victime de l'effet Poison pour la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur est victime de l'effet Poison Mortel pour la durée de la concoction. Lorsque l'effet Poison Mortel cesse, si l'utilisateur n'a pas reçu de soins appropriés, il tombe à l'agonie.";
                        break;
                }
                break;
            case Effect.Polymorphe:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur peut modifier l'apparence d'un objet ou d'une personne qui utilise la concoction pour la durée de la concoction";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur peut transmuter une ressource pour une autre d'un tiers inférieur de façon permanente";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur peut transmuter une ressource pour une autre du même tier de façon permanente.";
                        break;
                }
                break;
            case Effect.Rage:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur devient fâché pour la durée de la concoction.";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur est atteint de rage meurtrière et attaque les gens qui entrent en contact avec lui pour la durée de la concoction. S'il n'est pas dérangé pendant 2 minutes, l'effet prends fin prématurément";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur est atteint de rage meurtrière et cherche activement à attaquer tous ceux qu'il voit pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Remede:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Guérit l'utilisateur d'un effet d'une maladie mineure";
                        break;
                    case 2:
                        EffectDescription = "Guérit l'utilisateur d'un effet de poison ou d'une maladie modérée.";
                        break;
                    case 3:
                        EffectDescription = "Guérit l'utilisateur d'un effet de poison, poison mortel ou d'une maladie majeure";
                        break;
                }
                break;
            case Effect.Silence:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur est affligé de l'effet \"Toux\" pour la durée de 1 minute";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur est affligé de l'effet \"Silence\" pour la durée de 5 minutes";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur est affligé de l'effet \"Silence\" pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Soin:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur guéris instantanément de 3 PV";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur guéris instantanément de 6 PV";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur guéris instantanément de 9 PV";
                        break;
                }
                break;
            case Effect.Sommeil:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur tombe endormi, il peut être réveillé en le secouant, l'effet dures 5 minutes";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur tombe endormi, il est réveillé après avoir pris 1 de dégât. L'effet dures pour la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur tombe endormi profondément, il est réveillé après avoir pris plus de 5 de dégâts. L'effet dures pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Stabilisant:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Réduit la durée de la convalescence de 15 minutes.";
                        break;
                    case 2:
                        EffectDescription = "Termine la convalescence instantanément.";
                        break;
                    case 3:
                        EffectDescription = "Relèves un agonisant directement sans passer par la convalescence.";
                        break;
                }
                break;
            case Effect.Stimulant:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Donnes une instance de résistance mentale à l'utilisateur, utilisable lors de la durée de la concoction";
                        break;
                    case 2:
                        EffectDescription = "Donnes une instance de résistance générale à l'utilisateur, utilisable lors de la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "Permet à l'utilisateur, lors de la durée de la concoction, de canceller tous les effets négatifs sur lui même (Excluant la mort, l'agonie et la convalescence). Ces effets reviendront 5 minutes après avoir été cancellés.";
                        break;
                }
                break;
            case Effect.Terre:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera d'acide pour les 5 prochain coups.";
                        break;
                    case 2:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera d'acide pour la durée du prochain combat.";
                        break;
                    case 3:
                        EffectDescription = "Si utilisé en tant qu'huile, l'arme frappera d'acide pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Vitalite:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur gagnes 5 PVT, ceux-ci durent jusqu'à la fin du prochain combat";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur gagnes 10 PVTs, ceux-ci durent jusqu'à la fin du prochain combat";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur gagnes 15 PVTs, ceux-ci durent jusqu'à la fin du prochain combat, ensuite se rechargent et durent le temps de la concoction";
                        break;
                }
                break;
            case Effect.Argent_Alchimique:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Si utilisé comme huile sur une arme, permet aux 5 prochains coups de frapper d'Argent.";
                        break;
                    case 2:
                        EffectDescription = "Si utilisé comme huile sur une arme, permet aux prochains coups de frapper d'Argent, cet effet dures un combat";
                        break;
                    case 3:
                        EffectDescription = "Si utilisé comme huile sur une arme, permet aux prochains coups de frapper d'Argent, cet effet dures un combat plus la durée de la concoction";
                        break;
                }
                break;
            case Effect.Armure_Naturelle:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur de cette concoction gagnes trois charge de DR1, non cumulable avec l'armure. Dures la durée de la concoction";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur de cette concoction gagnes trois charges de DR2, non cumulable avec l'armure. Dures la durée de la concoction";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur de cette concoction gagnes trois charges de DR2, cumulable avec l'armure en nombre de charges. Dures la durée de la concoction";
                        break;
                }
                break;
            case Effect.Corps_Epineux:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "L'utilisateur gagnes 3 charges de Rétaliation. Il effectue 1 point de dégât instantané à quiconque le frappe en mêlée pendant la durée de la concoction.";
                        break;
                    case 2:
                        EffectDescription = "L'utilisateur gagnes 3 charges de Rétaliation. Il effectue 2 points de dégâts instantanés à quiconque le frappe en mêlée pendant la durée de la concoction.";
                        break;
                    case 3:
                        EffectDescription = "L'utilisateur gagnes 5 charges de Rétaliation. Il effectue le nombre de dégâts de son arme de manière instantanée à quiconque le frappe en mêlée pendant la durée de la concoction";
                        break;
                }
                break;
            case Effect.Extrait_Arcanique:
                switch (Tier)
                {
                    case 1:
                        EffectDescription = "Un Extrait Arcanique ne peut être consommé, il ne peut être utilisé que comme encre à parchemin. Il sera utilisé pour augmenter le tiers de l'effet d'un parchemin de 1. Il peut être mélangé à une autre encre afin d'avoir les deux effets.";
                        break;
                    case 2:
                        EffectDescription = "L'Extrait Arcanique est consommable et cause une économie de 1 de mana par sorts lancés pour la durée de la concoction. Minimum 0";
                        break;
                    case 3:
                        EffectDescription = "L'extrait Arcanique est consommable et donnes +1 en tiers de pouvoir à l'effet des sorts lancés pour la durée de la concoction";
                        break;
                }
                break;
        }
    }
    
    
    public void CatalyseEffect()
    {
        switch (Effect)
        {
            case Effect.Antidouleur:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Permet d'ignorer le roleplay de douleur lors du prochain combat, pendant la durée de la concoction";
                        break;
                    case 2:
                        CatalyzedDescription = "Permet d'éviter la prochaine instance d'effet de douleur pendant la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "Permet d'éviter les prochaines instances d'effet de douleur pendant la durée de la concoction";
                        break;
                }
                break;
            case Effect.Antimagie:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "-1/5 mana max pour la durée de la concoction";
                        break;
                    case 2:
                        CatalyzedDescription = "-2/5 mana max pour la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "-3/5 mana max pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Antitoxine:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur se guérit de 30 de toxicité instantanément, ne peut être utilisé qu'une fois aux 4 heures";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur se guérit de 60 de toxicité instantanément, ne peut être utilisé qu'une fois aux 4 heures";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur se guérit de toute sa toxicité instantanément, ne peut être utilisé qu'une fois aux 4 heures";
                        break;
                }
                break;
            case Effect.Calme:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Cesse un effet de rage ou de peur";
                        break;
                    case 2:
                        CatalyzedDescription = "Rends immunisé aux effets de rage ou de peur pour la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "Rends immunisé aux effets de rage, peur, confusion, déconcentration pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Celerite:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Donne une Presquive, utilisable lors du prochain combat.";
                        break;
                    case 2:
                        CatalyzedDescription = "Donne une Esquive, utilisable lors du prochain combat.";
                        break;
                    case 3:
                        CatalyzedDescription = "Donne trois Esquives, utilisable lors du prochain combat.";
                        break;
                }
                break;
            case Effect.Heroisme:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "+1 point d'habilité";
                        break;
                    case 2:
                        CatalyzedDescription = "+2 point d'habilité";
                        break;
                    case 3:
                        CatalyzedDescription = "+3 point d'habilité";
                        break;
                }
                break;
            case Effect.Charme:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Le buveur est attirée envers la première personne qu'elle voit pendant la durée de la potion.";
                        break;
                    case 2:
                        CatalyzedDescription = "Le buveur est en amour envers la première personne qu'elle voit pendant la durée de la potion.";
                        break;
                    case 3:
                        CatalyzedDescription = "Le buveur est en fol amour envers la première personne qu'elle voit pendant la durée de la potion";
                        break;
                }
                break;
            case Effect.Concentration:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Le buveur peut maintenant endurer 3 dégâts de plus avant d'être déconcentré une fois lors du prochain combat";
                        break;
                    case 2:
                        CatalyzedDescription = "Le buveur peut maintenant endurer un coup de plus avant d'être déconcentré une fois lors du prochain combat";
                        break;
                    case 3:
                        CatalyzedDescription = "Le buveur peut maintenant endurer un coup de plus avant d'être déconcentré pour tous ses sorts lors du prochain combat";
                        break;
                }
                break;
            case Effect.Decoposition:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Permet de décomposer un corps mort. Cause 5 de dégâts sur un mort vivant.";
                        break;
                    case 2:
                        CatalyzedDescription = "Permet de décomposer un corps mort. Cause 15 de dégats sur un mort vivant.";
                        break;
                    case 3:
                        CatalyzedDescription = "Permet de décomposer un corps mort. Cause 30 de dégâts sur un mort vivant.";
                        break;
                }
                break;
            case Effect.Faiblesse:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur possède -1 de force pour la durée de la concoction.";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur possède -2 de force et frappes de -1 pour la durée de la concoction.";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur possède -3 de force, frappes de -1, ne peut se battre qu'avec une seule arme a une main, ne peut plus tenir de bouclier et ne peux plus porter d'armure lourde pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Feu: 
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de feu pour les 5 prochain coups.";
                        break;
                    case 2:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de feu pour la durée du prochain combat.";
                        break;
                    case 3:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de feu pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Flux:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Produit 1 unité de Flux";
                        break;
                    case 2:
                        CatalyzedDescription = "Produit 2 unités de Flux";
                        break;
                    case 3:
                        CatalyzedDescription = "Produit 3 unités de Flux";
                        break;
                }
                break;
            case Effect.Force:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur possède +1 de force pour la durée de la concoction";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur possède +1 de force et frappe de +1 (passif) pour les prochains 5 coups";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur possède +1 de force, frappe de +1 (passif) pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Foudre:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de foudre pour les 5 prochain coups.";
                        break;
                    case 2:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de foudre pour la durée du prochain combat.";
                        break;
                    case 3:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de foudre pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Glace:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de glace pour les 5 prochain coups.";
                        break;
                    case 2:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de glace pour la durée du prochain combat.";
                        break;
                    case 3:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera de glace pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Graisseux:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Produit 1 unité de Graisse";
                        break;
                    case 2:
                        CatalyzedDescription = "Produit 2 unités de Graisse";
                        break;
                    case 3:
                        CatalyzedDescription = "Produit 3 unités de Graisse";
                        break;
                }
                break;
            case Effect.Huileux:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Produit 1 unité d'huile";
                        break;
                    case 2:
                        CatalyzedDescription = "Produit 2 unités d'huile";
                        break;
                    case 3:
                        CatalyzedDescription = "Produit 3 unités d'huile";
                        break;
                }
                break;
            case Effect.Insomnie:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur est immunisé au prochain effet de sommeil";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur est immunisé aux effets de sommeil pendant la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur est immunisé aux effets de sommeil pendant la durée de la concoction et ne récupèrera pas lors de la prochaine nuit";
                        break;
                }
                break;
            case Effect.Invisibilite:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur gagnes l'effet \"Camoufflage\" pour la durée de la concoction. L'effet se cancèles s'il effectue une action \"Violente\"";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur gagnes l'effet \"Invisibilité\" pour la durée de la concoction. L'effet se cancèles s'il effectue une action \"Violente\"";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur gagnes l'effet \"Invisibilité\" pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Mana:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur gagnes 5 de mana";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur gagnes 15 de mana";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur gagnes 30 de mana";
                        break;
                }
                break;
            case Effect.Mensonge:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur ne peut plus dire la vérité pour la durée de la concoction";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur est immunisé à la détection de la vérité pour la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur décides si ce qu'il dit passe pour une vérité ou un mensonge pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Naphta:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Produit 1 unité de Naphta Instable";
                        break;
                    case 2:
                        CatalyzedDescription = "Produit 1 unités de Naphta";
                        break;
                    case 3:
                        CatalyzedDescription = "Produit 2 unités de Naphta";
                        break;
                }
                break;
            case Effect.Paralysie:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur devient Paralysé pour 30 secondes. L'effet de paralysie est arrèté dès que l'utilisateur prends un point de dégâts.";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur devient Paralysé pour 5 minutes. L'effet de paralysie est arrèté dès que l'utilisateur prends un point de dégâts.";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur devient Paralysé pour la durée de la concoction. L'effet de paralysie est arrèté dès que l'utilisateur prends cinq point de dégâts.";
                        break;
                }
                break;
            case Effect.Peur:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur est victime d'un effet de Peur, la source de sa peur est la première personne qu'il voit suite à la consommation de la concoction. L'effet de peur dures 1 minute";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur est victime d'un effet de Peur, la source de sa peur est la première personne qu'il voit suite à la consommation de la concoction. L'effet de peur dures la durée de la concoction.";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur est victime d'un effet de Peur, la source de sa peur est la première personne qu'il voit suite à la consommation de la concoction. Il est incapable d'utiliser ses résistances mentales pendant la durée de l'effet de peur. L'effet de peur dures pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Poison:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur est victime de l'effet Poison pour 5 minutes";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur est victime de l'effet Poison pour la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur est victime de l'effet Poison Mortel pour la durée de la concoction. Lorsque l'effet Poison Mortel cesse, si l'utilisateur n'a pas reçu de soins appropriés, il tombe à l'agonie.";
                        break;
                }
                break;
            case Effect.Polymorphe:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur peut modifier l'apparence d'un objet ou d'une personne qui utilise la concoction pour la durée de la concoction";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur peut transmuter une ressource pour une autre d'un tiers inférieur de façon permanente";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur peut transmuter une ressource pour une autre du même tier de façon permanente.";
                        break;
                }
                break;
            case Effect.Rage:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur devient fâché pour la durée de la concoction.";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur est atteint de rage meurtrière et attaque les gens qui entrent en contact avec lui pour la durée de la concoction. S'il n'est pas dérangé pendant 2 minutes, l'effet prends fin prématurément";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur est atteint de rage meurtrière et cherche activement à attaquer tous ceux qu'il voit pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Remede:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Guérit l'utilisateur d'un effet d'une maladie mineure";
                        break;
                    case 2:
                        CatalyzedDescription = "Guérit l'utilisateur d'un effet de poison ou d'une maladie modérée.";
                        break;
                    case 3:
                        CatalyzedDescription = "Guérit l'utilisateur d'un effet de poison, poison mortel ou d'une maladie majeure";
                        break;
                }
                break;
            case Effect.Silence:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur est affligé de l'effet \"Toux\" pour la durée de 1 minute";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur est affligé de l'effet \"Silence\" pour la durée de 5 minutes";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur est affligé de l'effet \"Silence\" pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Soin:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur guéris instantanément de 3 PV";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur guéris instantanément de 6 PV";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur guéris instantanément de 9 PV";
                        break;
                }
                break;
            case Effect.Sommeil:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur tombe endormi, il peut être réveillé en le secouant, l'effet dures 5 minutes";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur tombe endormi, il est réveillé après avoir pris 1 de dégât. L'effet dures pour la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur tombe endormi profondément, il est réveillé après avoir pris plus de 5 de dégâts. L'effet dures pour la durée de la concoction";
                        break;
                }
                break;
            case Effect.Stabilisant:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Réduit la durée de la convalescence de 15 minutes.";
                        break;
                    case 2:
                        CatalyzedDescription = "Termine la convalescence instantanément.";
                        break;
                    case 3:
                        CatalyzedDescription = "Relèves un agonisant directement sans passer par la convalescence.";
                        break;
                }
                break;
            case Effect.Stimulant:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Donnes une instance de résistance mentale à l'utilisateur, utilisable lors de la durée de la concoction";
                        break;
                    case 2:
                        CatalyzedDescription = "Donnes une instance de résistance générale à l'utilisateur, utilisable lors de la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "Permet à l'utilisateur, lors de la durée de la concoction, de canceller tous les effets négatifs sur lui même (Excluant la mort, l'agonie et la convalescence). Ces effets reviendront 5 minutes après avoir été cancellés.";
                        break;
                }
                break;
            case Effect.Terre:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera d'acide pour les 5 prochain coups.";
                        break;
                    case 2:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera d'acide pour la durée du prochain combat.";
                        break;
                    case 3:
                        CatalyzedDescription = "Si utilisé en tant qu'huile, l'arme frappera d'acide pour la durée de la concoction.";
                        break;
                }
                break;
            case Effect.Vitalite:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur gagnes 5 PVT, ceux-ci durent jusqu'à la fin du prochain combat";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur gagnes 10 PVTs, ceux-ci durent jusqu'à la fin du prochain combat";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur gagnes 15 PVTs, ceux-ci durent jusqu'à la fin du prochain combat, ensuite se rechargent et durent le temps de la concoction";
                        break;
                }
                break;
            case Effect.Argent_Alchimique:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Si utilisé comme huile sur une arme, permet aux 5 prochains coups de frapper d'Argent.";
                        break;
                    case 2:
                        CatalyzedDescription = "Si utilisé comme huile sur une arme, permet aux prochains coups de frapper d'Argent, cet effet dures un combat";
                        break;
                    case 3:
                        CatalyzedDescription = "Si utilisé comme huile sur une arme, permet aux prochains coups de frapper d'Argent, cet effet dures un combat plus la durée de la concoction";
                        break;
                }
                break;
            case Effect.Armure_Naturelle:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur de cette concoction gagnes trois charge de DR1, non cumulable avec l'armure. Dures la durée de la concoction";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur de cette concoction gagnes trois charges de DR2, non cumulable avec l'armure. Dures la durée de la concoction";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur de cette concoction gagnes trois charges de DR2, cumulable avec l'armure en nombre de charges. Dures la durée de la concoction";
                        break;
                }
                break;
            case Effect.Corps_Epineux:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "L'utilisateur gagnes 3 charges de Rétaliation. Il effectue 1 point de dégât instantané à quiconque le frappe en mêlée pendant la durée de la concoction.";
                        break;
                    case 2:
                        CatalyzedDescription = "L'utilisateur gagnes 3 charges de Rétaliation. Il effectue 2 points de dégâts instantanés à quiconque le frappe en mêlée pendant la durée de la concoction.";
                        break;
                    case 3:
                        CatalyzedDescription = "L'utilisateur gagnes 5 charges de Rétaliation. Il effectue le nombre de dégâts de son arme de manière instantanée à quiconque le frappe en mêlée pendant la durée de la concoction";
                        break;
                }
                break;
            case Effect.Extrait_Arcanique:
                switch (Tier)
                {
                    case 1:
                        CatalyzedDescription = "Un Extrait Arcanique ne peut être consommé, il ne peut être utilisé que comme encre à parchemin. Il sera utilisé pour augmenter le tiers de l'effet d'un parchemin de 1. Il peut être mélangé à une autre encre afin d'avoir les deux effets.";
                        break;
                    case 2:
                        CatalyzedDescription = "L'Extrait Arcanique est consommable et cause une économie de 1 de mana par sorts lancés pour la durée de la concoction. Minimum 0";
                        break;
                    case 3:
                        CatalyzedDescription = "L'extrait Arcanique est consommable et donnes +1 en tiers de pouvoir à l'effet des sorts lancés pour la durée de la concoction";
                        break;
                }
                break;
        }
    }
    
}



