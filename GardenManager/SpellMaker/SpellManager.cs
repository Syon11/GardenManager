using System.ComponentModel;
using System.Runtime.CompilerServices;
using GardenManager.Enums.Arcane;
using GardenManager.Model;
using GardenManager.Model.Arcane;
using Newtonsoft.Json;

namespace GardenManager.SpellMaker;

public class SpellManager
{
    public List<FormattedSpell> Spells { get; set; } = [];
    public List<PowerWord> PowerWords { get; set; }
    public List<EffectWord> EffectWords { get; set; }
    public List<ModifierWord> ModifierWords { get; set; }
    public List<ShapeWord> ShapeWords { get; set; }
    public List<ArcaneEffect> ArcaneEffects { get; set; }
    public List<ArcaneShape> ArcaneShapes { get; set; }
    public List<ArcaneModifier> ArcaneModifiers { get; set; }

    private const string JsonShapes = "Shapes.json";
    private const string JsonEffects = "Effects.json";
    private const string JsonModifiers = "Modifiers.json"; 
    private const string JsonPowerWord = "PowerWord.json"; 
    private const string JsonEffectWord = "EffectWord.json"; 
    private const string JsonShapeWord = "ShapeWord.json"; 
    private const string JsonModifierWord = "ModifierWord.json";
    private const string JsonSpellInput = "SpellInput.json";
    private const string JsonSpellOutput = "SpellOutput.json";
    
    public SpellManager()
    {
        PowerWords = new List<PowerWord>();
        EffectWords = new List<EffectWord>();
        ModifierWords = new List<ModifierWord>();
        ShapeWords = new List<ShapeWord>();
        ArcaneEffects = new List<ArcaneEffect>();
        ArcaneShapes = new List<ArcaneShape>();
        ArcaneModifiers = new List<ArcaneModifier>();

        Init();

        ImportSpellsFromJson();
    }

    public SpellManager(string jsonString)
    {
        PowerWords = new List<PowerWord>();
        EffectWords = new List<EffectWord>();
        ModifierWords = new List<ModifierWord>();
        ShapeWords = new List<ShapeWord>();
        ArcaneEffects = new List<ArcaneEffect>();
        ArcaneShapes = new List<ArcaneShape>();
        ArcaneModifiers = new List<ArcaneModifier>();

        Init();

        ImportSpellsFromString(jsonString);
    }

    public string GetSpellsAsJson()
    {
        return JsonConvert.SerializeObject(Spells);
    }
    
    private void Init()
    {
        if (File.Exists(JsonShapes))
            LoadArcaneShapesFromFile();
        else
            InitializeArcaneShapes();
        if (File.Exists(JsonModifiers))
            LoadArcaneModifiersFromFile();
        else
            InitializeArcaneModifiers();
        if (File.Exists(JsonEffects))
            LoadArcaneEffectsFromFile();
        else
            InitializeArcaneEffects();
        if (File.Exists(JsonShapeWord))
            LoadShapeWordsFromFile();
        else
            InitializeShapeWords();
        if (File.Exists(JsonModifierWord))
            LoadModifierWordsFromFile();
        else
            InitializeModifierWords();
        if (File.Exists(JsonEffectWord))
            LoadEffectWordsFromFile();
        else
            InitializeEffectWords();
        if (File.Exists(JsonPowerWord))
            LoadPowerWordsFromFile();
        else
            InitializePowerWords();
    }

    private void LoadArcaneShapesFromFile()
    {
        string jsonString = File.ReadAllText(JsonShapes);
        List<ArcaneShape>? tempShapes = JsonConvert.DeserializeObject<List<ArcaneShape>>(jsonString);
        if (tempShapes != null)
        {
            ArcaneShapes = tempShapes;
        }
    }

    private void LoadArcaneModifiersFromFile()
    {
        string jsonString = File.ReadAllText(JsonModifiers);
        List<ArcaneModifier>? tempMods = JsonConvert.DeserializeObject<List<ArcaneModifier>>(jsonString);
        if (tempMods != null)
        {
            ArcaneModifiers = tempMods;
        }   
    }

    private void LoadArcaneEffectsFromFile()
    {
        string jsonString = File.ReadAllText(JsonEffects);
        List<ArcaneEffect>? tempEffects = JsonConvert.DeserializeObject<List<ArcaneEffect>>(jsonString);
        if (tempEffects != null)
        {
            ArcaneEffects = tempEffects;
        }
    }

    private void LoadShapeWordsFromFile()
    {
        string jsonString = File.ReadAllText(JsonShapeWord);
        List<ShapeWord>? tempShapes = JsonConvert.DeserializeObject<List<ShapeWord>>(jsonString);
        if (tempShapes != null)
        {
            ShapeWords = tempShapes;
        }
    }

    private void LoadModifierWordsFromFile()
    {
        string jsonString = File.ReadAllText(JsonModifierWord);
        List<ModifierWord>? tempMods = JsonConvert.DeserializeObject<List<ModifierWord>>(jsonString);
        if (tempMods != null)
        {
            ModifierWords = tempMods;
        }
    }

    private void LoadEffectWordsFromFile()
    {
        string jsonString = File.ReadAllText(JsonEffectWord);  
        List<EffectWord>? tempEffect = JsonConvert.DeserializeObject<List<EffectWord>>(jsonString);
        if (tempEffect != null)
        {
            EffectWords = tempEffect;
        }
    }

    private void LoadPowerWordsFromFile()
    {
        string jsonString = File.ReadAllText(JsonPowerWord);  
        List<PowerWord>? tempPower = JsonConvert.DeserializeObject<List<PowerWord>>(jsonString);
        if (tempPower != null)
        {
            PowerWords = tempPower;
        }
    }

    private void SaveArcaneShapesToFile()
    {
        File.WriteAllText(JsonShapes, JsonConvert.SerializeObject(ArcaneShapes, Formatting.Indented));
    }

    private void SaveArcaneModifiersToFile()
    {
        File.WriteAllText(JsonModifiers, JsonConvert.SerializeObject(ArcaneModifiers, Formatting.Indented));
    }

    private void SaveArcaneEffectsToFile()
    {
        File.WriteAllText(JsonEffects, JsonConvert.SerializeObject(ArcaneEffects, Formatting.Indented));
    }

    private void SaveModifierWordsToFile()
    {
        File.WriteAllText(JsonModifierWord, JsonConvert.SerializeObject(ModifierWords, Formatting.Indented));
    }

    private void SaveShapeWordsToFile()
    {
        File.WriteAllText(JsonShapeWord, JsonConvert.SerializeObject(ShapeWords, Formatting.Indented));
    }

    private void SaveEffectWordsToFile()
    {
        File.WriteAllText(JsonEffectWord, JsonConvert.SerializeObject(EffectWords, Formatting.Indented));
    }

    private void SavePowerWordsToFile()
    {
        File.WriteAllText(JsonPowerWord, JsonConvert.SerializeObject(PowerWords, Formatting.Indented));
    }
    private void InitializeArcaneShapes()
    {
        ArcaneShapes =
        [
            new ArcaneShape("Assemblée", [5], 
                [
                "Forme pas assez forte, ne fonctionne pas", 
                "Assemblée de trois."
            ]),
            new ArcaneShape("Barrière", [1], 
            [
                "Barrière pour Soi", 
                "Barrière pour Soi et son Familier"
            ]),
            new ArcaneShape("Canalisation", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "La forme donne +0 au tiers de pouvoir", 
                "La forme donne +0.5 au tiers de pouvoir", 
                "La forme donne +1 au tiers de pouvoir", 
                "La forme donne +1.5 au tiers de pouvoir", 
                "La forme donne +2 au tiers de pouvoir", 
                "La forme donne +2.5 au tiers de pouvoir", 
                "La forme donne +3 au tiers de pouvoir", 
                "La forme donne +3.5 au tiers de pouvoir", 
                "La forme donne +4 au tiers de pouvoir", 
                "La forme donne +4.5 au tiers de pouvoir", 
                "La forme donne +5 au tiers de pouvoir"
            ]),
            new ArcaneShape("Chaîne", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Chaîne 3 pieds", 
                "Chaîne 4 pieds", 
                "Chaîne 5 pieds", 
                "Chaîne 6 pieds", 
                "Chaîne 7 pieds", 
                "Chaîne 8 pieds", 
                "Chaîne 9 pieds", 
                "Chaîne 10 pieds", 
                "Chaîne 11 pieds", 
                "Chaîne 12 pieds", 
                "Chaîne 13 pieds"
            ]),
            new ArcaneShape("Cercle", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Cercle 5 pieds de rayon", 
                "Cercle 6 pieds de rayon", 
                "Cercle 7 pieds de rayon", 
                "Cercle 8 pieds de rayon", 
                "Cercle 9 pieds de rayon", 
                "Cercle 10 pieds de rayon", 
                "Cercle 11 pieds de rayon", 
                "Cercle 12 pieds de rayon", 
                "Cercle 13 pieds de rayon", 
                "Cercle 14 pieds de rayon", 
                "Cercle 15 pieds de rayon"
            ]),
            new ArcaneShape("Cône", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Cône 10 pieds de distance", 
                "Cône 12 pieds de distance", 
                "Cône 14 pieds de distance", 
                "Cône 16 pieds de distance", 
                "Cône 18 pieds de distance", 
                "Cône 20 pieds de distance", 
                "Cône 22 pieds de distance", 
                "Cône 24 pieds de distance", 
                "Cône 26 pieds de distance", 
                "Cône 28 pieds de distance", 
                "Cône 30 pieds de distance"
            ]),
            new ArcaneShape("Contrat", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Contrat 1 signataires max", 
                "Contrat 2 signataires max", 
                "Contrat 3 signataires max", 
                "Contrat 4 signataires max", 
                "Contrat 5 signataires max", 
                "Contrat 6 signataires max", 
                "Contrat 7 signataires max", 
                "Contrat 8 signataires max", 
                "Contrat 10 signataires max", 
                "Contrat 15 signataires max", 
                "Contrat 20 signataires max"
            ]),
            new ArcaneShape("Dôme", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Dôme 5 pieds de rayon", 
                "Dôme 6 pieds de rayon", 
                "Dôme 7 pieds de rayon", 
                "Dôme 8 pieds de rayon", 
                "Dôme 9 pieds de rayon", 
                "Dôme 10 pieds de rayon", 
                "Dôme 11 pieds de rayon", 
                "Dôme 12 pieds de rayon", 
                "Dôme 13 pieds de rayon", 
                "Dôme 14 pieds de rayon", 
                "Dôme 15 pieds de rayon"
            ]),
            new ArcaneShape("Émanation", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Émanation 5 pieds de rayon", 
                "Émanation 6 pieds de rayon", 
                "Émanation 7 pieds de rayon", 
                "Émanation 8 pieds de rayon", 
                "Émanation 9 pieds de rayon", 
                "Émanation 10 pieds de rayon", 
                "Émanation 11 pieds de rayon", 
                "Émanation 12 pieds de rayon", 
                "Émanation 13 pieds de rayon", 
                "Émanation 14 pieds de rayon", 
                "Émanation 15 pieds de rayon"
            ]),
            new ArcaneShape("Essaim", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Essaim 5 pieds de rayon", 
                "Essaim 6 pieds de rayon", 
                "Essaim 7 pieds de rayon", 
                "Essaim 8 pieds de rayon", 
                "Essaim 9 pieds de rayon", 
                "Essaim 10 pieds de rayon", 
                "Essaim 11 pieds de rayon", 
                "Essaim 12 pieds de rayon", 
                "Essaim 13 pieds de rayon", 
                "Essaim 14 pieds de rayon", 
                "Essaim 15 pieds de rayon"
            ]),
            new ArcaneShape("Faisceau", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Faisceau 10 pieds de rayon", 
                "Faisceau 12 pieds de rayon", 
                "Faisceau 14 pieds de rayon", 
                "Faisceau 16 pieds de rayon", 
                "Faisceau 18 pieds de rayon", 
                "Faisceau 20 pieds de rayon", 
                "Faisceau 22 pieds de rayon", 
                "Faisceau 24 pieds de rayon", 
                "Faisceau 26 pieds de rayon", 
                "Faisceau 28 pieds de rayon", 
                "Faisceau 30 pieds de rayon"
            ]),
            new ArcaneShape("Intensification", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Intensification pour Rayon T0", 
                "Intensification pour Rayon T1", 
                "Intensification pour Rayon T2", 
                "Intensification pour Rayon T3", 
                "Intensification pour Rayon T4", 
                "Intensification pour Rayon T5", 
                "Intensification pour Rayon T6", 
                "Intensification pour Rayon T7", 
                "Intensification pour Rayon T8", 
                "Intensification pour Rayon T9", 
                "Intensification pour Rayon T10"
            ]),
            new ArcaneShape("Ligne", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Ligne de 20 pieds de distance", 
                "Ligne de 25 pieds de distance", 
                "Ligne de 30 pieds de distance", 
                "Ligne de 35 pieds de distance", 
                "Ligne de 40 pieds de distance", 
                "Ligne de 45 pieds de distance", 
                "Ligne de 50 pieds de distance", 
                "Ligne de 55 pieds de distance", 
                "Ligne de 60 pieds de distance", 
                "Ligne de 65 pieds de distance", 
                "Ligne de 70 pieds de distance"
            ]),
            new ArcaneShape("Méditation", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Méditation 0 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 2 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 4 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 6 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 8 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 10 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 12 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 14 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 16 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 18 pieds de distance entre les personnages qui prennent pars à la méditation", 
                "Méditation 20 pieds de distance entre les personnages qui prennent pars à la méditation"
            ]),
            new ArcaneShape("Mur", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Mur de 5 pieds de longueur", 
                "Mur de 10 pieds de longueur", 
                "Mur de 15 pieds de longueur", 
                "Mur de 20 pieds de longueur", 
                "Mur de 25 pieds de longueur", 
                "Mur de 30 pieds de longueur", 
                "Mur de 35 pieds de longueur", 
                "Mur de 40 pieds de longueur", 
                "Mur de 45 pieds de longueur", 
                "Mur de 50 pieds de longueur", 
                "Mur de 55 pieds de longueur"
            ]),
            new ArcaneShape("Personnnelle", [0], 
            [
                "Soi",
                "Soi et son familier"
            ]),
            new ArcaneShape("Pointé", [1, 2, 4, 8, 16, 32], 
            [
                "Pointé à 20 pieds de distance", 
                "Pointé à 40 pieds de distance", 
                "Pointé à 60 pieds de distance", 
                "Pointé à 80 pieds de distance", 
                "Pointé à 100 pieds de distance", 
                "Pointé à 120 pieds de distance", 
                "Pointé à distance de voix/vision"
            ]),
            new ArcaneShape("Projectile", [0], 
            [
                "Impossible result, should never happen", 
                "Projectile à distance de la force de lancé."
            ]),
            new ArcaneShape("Rituel", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "La forme donne +0 au tiers de pouvoir du sort", 
                "La forme donne +0.5 au tiers de pouvoir du sort", 
                "La forme donne +1 au tiers de pouvoir du sort", 
                "La forme donne +1.5 au tiers de pouvoir du sort", 
                "La forme donne +2 au tiers de pouvoir du sort", 
                "La forme donne +2.5 au tiers de pouvoir du sort", 
                "La forme donne +3 au tiers de pouvoir du sort", 
                "La forme donne +3.5 au tiers de pouvoir du sort", 
                "La forme donne +4 au tiers de pouvoir du sort", 
                "La forme donne +4.5 au tiers de pouvoir du sort", 
                "La forme donne +5 au tiers de pouvoir du sort"
            ]),
            new ArcaneShape("Rituel", [0], 
            [
                "Impossible result, should never happen", 
                "Touché, durée de maitien 30 secondes, 10 pas de déplacement", 
            ]),
            new ArcaneShape("Touché", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "La forme permet de faire 5 pas avant de décharger le sort", 
                "La forme permet de faire 10 pas avant de décharger le sort", 
                "La forme permet de faire 15 pas avant de décharger le sort", 
                "La forme permet de faire 20 pas avant de décharger le sort", 
                "La forme permet de faire 25 pas avant de décharger le sort", 
                "La forme permet de faire 30 pas avant de décharger le sort", 
                "La forme permet de faire 35 pas avant de décharger le sort", 
                "La forme permet de faire 40 pas avant de décharger le sort", 
                "La forme permet de faire 45 pas avant de décharger le sort", 
                "La forme permet de faire 50 pas avant de décharger le sort", 
                "La forme permet de faire 55 pas avant de décharger le sort"
            ]),
            new ArcaneShape("Voyage Astral", [1, 2, 4, 8, 16, 32, 64, 128, 256, 512], 
            [
                "Permet de maintenir 1 sort en Voyage Astral", 
                "Permet de maintenir 2 sort en Voyage Astral", 
                "Permet de maintenir 3 sort en Voyage Astral", 
                "Permet de maintenir 4 sort en Voyage Astral", 
                "Permet de maintenir 5 sort en Voyage Astral", 
                "Permet de maintenir 6 sort en Voyage Astral", 
                "Permet de maintenir 7 sort en Voyage Astral", 
                "Permet de maintenir 8 sort en Voyage Astral", 
                "Permet de maintenir 9 sort en Voyage Astral", 
                "Permet de maintenir 10 sort en Voyage Astral", 
                "Permet de maintenir 12 sort en Voyage Astral"
            ]),
        ];
        SaveArcaneShapesToFile();
    }
    
    private void InitializeArcaneModifiers()
    {
        ArcaneModifiers =
        [
            new ArcaneModifier("Cibles", [10, 50, 250],             
            [
                "Pas assez de potentia investie", 
                "Cibles Tier 1", 
                "Cibles Tier 2", 
                "Cibles Tier 3"
            ]),
            new ArcaneModifier("Combinaison", [10],             
            [
                "Pas assez de potentia investie", 
                "Combinaison possible" 
            ]),
            new ArcaneModifier("Durée", [1, 3, 9, 27, 81, 243],             
            [
                "Pas assez de potentia investie", 
                "Durée Tier 1",
                "Durée Tier 2",
                "Durée Tier 3",
                "Durée Tier 4",
                "Durée Tier 5",
                "Durée Tier 6"
            ]),
            new ArcaneModifier("Distance", [1, 4, 16, 64, 256], [
                "Pas assez de potentia investie", 
                "Distance Tier 1",
                "Distance Tier 2",
                "Distance Tier 3",
                "Distance Tier 4",
                "Distance Tier 5"
            ]),
            new ArcaneModifier("ElementalFeu", [1, 50, 500], [
                "Pas assez de potentia investie", 
                "L'élément change pour Feu",
                "L'élément change pour Feu et devient \"Perce-Résistances\"",
                "L'élément change pour Feu et devient \"Perce-Immunités\"",
            ]),
            new ArcaneModifier("ElementalGlace", [1, 50, 500], [
                "Pas assez de potentia investie", 
                "L'élément change pour Glace",
                "L'élément change pour Glace et devient \"Perce-Résistances\"",
                "L'élément change pour Glace et devient \"Perce-Immunités\"",
            ]),
            new ArcaneModifier("ElementalFoudre", [1, 50, 500], [
                "Pas assez de potentia investie", 
                "L'élément change pour Foudre",
                "L'élément change pour Foudre et devient \"Perce-Résistances\"",
                "L'élément change pour Foudre et devient \"Perce-Immunités\"",
            ]),
            new ArcaneModifier("ElementalAcide", [1, 50, 500], [
                "Pas assez de potentia investie", 
                "L'élément change pour Acide",
                "L'élément change pour Acide et devient \"Perce-Résistances\"",
                "L'élément change pour Acide et devient \"Perce-Immunités\"",
            ]),
            new ArcaneModifier("ElementalBeni", [2, 100, 1000], [
                "Pas assez de potentia investie", 
                "L'élément change pour Béni",
                "L'élément change pour Béni et devient \"Perce-Résistances\"",
                "L'élément change pour Béni et devient \"Perce-Immunités\"",
            ]),
            new ArcaneModifier("ElementalMaudit", [2, 100, 1000], [
                "Pas assez de potentia investie", 
                "L'élément change pour Maudit",
                "L'élément change pour Maudit et devient \"Perce-Résistances\"",
                "L'élément change pour Maudit et devient \"Perce-Immunités\"",
            ]),
            new ArcaneModifier("Impact", [1, 10, 100], [
                "Pas assez de potentia investie",
                "100% des dégâts sont convertis en repoussement",
                "50% des dégâts sont convertis en repoussement",
                "Les dégâts peuvent être échangés en nombre de pas de repoussement de manière instantanée pour un ratio de 1:1"
            ]),
            new ArcaneModifier("Inversement", [10],             
            [
                "Pas assez de potentia investie", 
                "Inversement possible" 
            ]),
            new ArcaneModifier("Rayon", [1, 8, 64, 512],             
            [
                "Pas assez de potentia investie", 
                "Rayon Tiers 1",
                "Rayon Tiers 2",
                "Rayon Tiers 3",
                "Rayon Tiers 4"
            ]),
            new ArcaneModifier("Sacrificiel", [1, 10, 100],             
            [
                "Pas assez de potentia investie", 
                "Efficacité 1 PV pour 1 PM",
                "Efficacité 1 PV pour 2 PM",
                "Efficacité 1 PV pour 5 PM",
            ]),
        ];
        SaveArcaneModifiersToFile();
    }

    private void InitializeArcaneEffects()
    {
        List<int> thresholds = new List<int>() {1, 2, 4, 8, 16, 32, 64, 128, 256, 512};
        ArcaneEffects =
        [
            new ArcaneEffect("Altération de la mémoire", thresholds, [
                "Le sort échoue",
                "Le sort échoue",
                "Le sort échoue",
                "Le sort échoue",
                "Un souvenir peut être effacé",
                "Un souvenir peut être effacé",
                "Un souvenir peut être effacé",
                "Un souvenir peut être effacé",
                "Un souvenir peut être changé",
                "Un souvenir peut être changé",
                "Un souvenir peut être effacé de manière permanente, sans potentiel de récupération. La zone du souvenir est brûlée physiquement du cerveau du détenteur"
            ], [
                "Le sort échoue",
                "Le sort échoue",
                "Le sort échoue",
                "Le sort échoue",
                "Un souvenir effacé peut être restauré",
                "Un souvenir effacé peut être restauré",
                "Un souvenir effacé peut être restauré",
                "Un souvenir effacé peut être restauré",
                "Un souvenir changé peut être restauré",
                "Un souvenir changé peut être restauré",
                "Un souvenir changé peut être restauré"
            ]),
            new ArcaneEffect("Armure du mage", thresholds, [
                "Les charges sont des charges de DR 1.",
                "Les charges sont des charges de DR 1.",
                "Les charges sont des charges de DR 1.",
                "Les charges sont des charges de DR 2.",
                "Les charges sont des charges de DR 2.",
                "Les charges sont des charges de DR 2.",
                "Les charges sont des charges de DR 3.",
                "Les charges sont des charges de DR 3.",
                "Les charges sont des charges de DR 3.",
                "Les charges sont des charges de DR 4.",
                "Les charges sont des charges de DR 4."
            ], [
                "La cible prends 1 dégât de plus par attaque physique",
                "La cible prends 1 dégât de plus par attaque physique",
                "La cible prends 1 dégât de plus par attaque physique",
                "La cible prends 2 dégât de plus par attaque physique",
                "La cible prends 2 dégât de plus par attaque physique",
                "La cible prends 2 dégât de plus par attaque physique",
                "La cible prends 3 dégât de plus par attaque physique",
                "La cible prends 3 dégât de plus par attaque physique",
                "La cible prends 3 dégât de plus par attaque physique",
                "La cible prends 4 dégât de plus par attaque physique",
                "La cible prends 4 dégât de plus par attaque physique",
            ]),
            new ArcaneEffect("Armure d'os", thresholds, [
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 0 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 1 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 1 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 2 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 2 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 3 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 3 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 3 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 3 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 3 de coup encaissé, doit être joint avec le modificateur Durée.",
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 3 de coup encaissé, doit être joint avec le modificateur Durée."
            ], [
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 0 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 1 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 1 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 2 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 2 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 3 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 3 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 3 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 3 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 3 coup encaissé.",
                "Dépendament du modificateur Durée, les prochains coups portés à la cible sont Inesquivables, Imparables et Perce-Armure. Maximum de 3 coup encaissé.",
            ]),
            new ArcaneEffect("Brouillard spirituel", thresholds, [
                "Donnes 1 instance de protection mentale.",
                "Donnes 1 instance de protection mentale.",
                "Donnes 1 instance de protection mentale.",
                "Donnes 2 instance de protection mentale.",
                "Donnes 2 instance de protection mentale.",
                "Donnes 2 instance de protection mentale.",
                "Donnes 3 instance de protection mentale.",
                "Donnes 3 instance de protection mentale.",
                "Donnes 3 instance de protection mentale.",
                "Donnes 4 instance de protection mentale.",
                "Donnes 4 instance de protection mentale."
            ]),
            new ArcaneEffect("Charme", thresholds, [
                "Cause un effet de Charme sur la cible. La cible considère le lanceur comme bien et lui fait confiance.",
                "Cause un effet de Charme sur la cible. La cible considère le lanceur comme bien et lui fait confiance.",
                "Cause un effet de Charme sur la cible. La cible considère le lanceur comme bien et lui fait confiance.",
                "Cause un effet de Charme sur la cible. La cible considère le lanceur comme bien et lui fait confiance.",
                "Cause un effet de Charme sur la cible. La cible considère le lanceur comme un bon ami, à qui on peut confier des choses.",
                "Cause un effet de Charme sur la cible. La cible considère le lanceur comme un bon ami, à qui on peut confier des choses.",
                "Cause un effet de Charme sur la cible. La cible considère le lanceur comme un bon ami, à qui on peut confier des choses.",
                "Cause un effet de Charme sur la cible. La cible aime le lanceur d'un amour véritable.",
                "Cause un effet de Charme sur la cible. La cible aime le lanceur d'un amour véritable.",
                "Cause un effet de Charme sur la cible. La cible aime le lanceur d'un amour véritable.",
                "Cause un effet de Charme sur la cible. La cible est obsédée par le lanceur et boit ses mots."
            ], [
                "La cible devient aggressive envers le lanceur du sort.",
                "La cible devient aggressive envers le lanceur du sort.",
                "La cible devient aggressive envers le lanceur du sort.",
                "La cible devient aggressive envers le lanceur du sort.",
                "La cible devient aggressive envers le lanceur du sort.",
                "La cible subit la condition \"Agacement\" envers le lanceur du sort.",
                "La cible subit la condition \"Agacement\" envers le lanceur du sort.",
                "La cible subit la condition \"Agacement\" envers le lanceur du sort.",
                "La cible subit la condition \"Agacement\" envers le lanceur du sort.",
                "La cible subit la condition \"Agacement\" envers le lanceur du sort.",
                "La cible subit la condition \"Agacement\" envers le lanceur du sort.",
            ]),
            new ArcaneEffect("Communion avec les esprits", thresholds, [
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 0",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 1",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 2",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 3",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 4",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 5",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 6",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 7",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 8",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 9",
                "Permet d'entrer en contact avec les esprits environnants. Effet Tier 10"
            ], [
                "Permet d'éloigner les esprits environnants. Effet Tier 0",
                "Permet d'éloigner les esprits environnants. Effet Tier 1",
                "Permet d'éloigner les esprits environnants. Effet Tier 2",
                "Permet d'éloigner les esprits environnants. Effet Tier 3",
                "Permet d'éloigner les esprits environnants. Effet Tier 4",
                "Permet d'éloigner les esprits environnants. Effet Tier 5",
                "Permet d'éloigner les esprits environnants. Effet Tier 6",
                "Permet d'éloigner les esprits environnants. Effet Tier 7",
                "Permet d'éloigner les esprits environnants. Effet Tier 8",
                "Permet d'éloigner les esprits environnants. Effet Tier 9",
                "Permet d'éloigner les esprits environnants. Effet Tier 10",
            ]),
            new ArcaneEffect("Compréhension des langues", thresholds, [
                "Permet la compréhension parlée des langues communes.",
                "Permet la compréhension parlée des langues communes.",
                "Permet la compréhension parlée des langues communes.",
                "Permet la compréhension parlée des langues communes.",
                "Permet la compréhension parlée des langues communes.",
                "Permet la compréhension parlée des langues communes et mortes.",
                "Permet la compréhension parlée des langues communes et mortes.",
                "Permet la compréhension parlée des langues communes et mortes.",
                "Permet la compréhension parlée des langues communes et mortes.",
                "Permet la compréhension parlée des langues communes et mortes.",
                "Permet la compréhension parlée des langues communes et mortes."
            ], [
                "La cible ne comprends plus sa propre langue parlée.",
                "La cible ne comprends plus sa propre langue parlée.",
                "La cible ne comprends plus sa propre langue parlée.",
                "La cible ne comprends plus sa propre langue parlée.",
                "La cible ne comprends plus aucune langue parlée.",
                "La cible ne comprends plus aucune langue parlée.",
                "La cible ne comprends plus aucune langue parlée.",
                "La cible ne comprends plus aucune langue parlée.",
                "La cible ne comprends plus aucune langue parlée et ne comprends même pas les tentatives de télépathie/truespeech.",
                "La cible ne comprends plus aucune langue parlée et ne comprends même pas les tentatives de télépathie/truespeech.",
                "La cible ne comprends plus aucune langue parlée et ne comprends même pas les tentatives de télépathie/truespeech.",
            ]),
            new ArcaneEffect("Compulsion", thresholds, [
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 0",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 1",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 2",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 3",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 4",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 5",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 6",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 7",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 8",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 9",
                "Permet de donner un ordre simple qui sera rempli par la cible. Effet Tier 10"
            ], [
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
                "N'agis seulement que sur la prochaine tentative de compulsion. Celle-ci sera effectuée au contraire de ce qui est demandé, interprété au mieux de la part de la cible",
            ]),
            new ArcaneEffect("Confusion", thresholds, [
                "Cause la condition Confusion à la cible",
                "Cause la condition Confusion à la cible",
                "Cause la condition Confusion à la cible",
                "Cause la condition Confusion à la cible",
                "Cause la condition Confusion à la cible",
                "Cause la condition Confusion à la cible",
                "Cause la condition Confusion à la cible",
                "Cause la condition Confusion à la cible",
                "Cause la condition Démence à la cible",
                "Cause la condition Démence à la cible",
                "Cause la condition Démence à la cible"
            ], [
                "Permet de guérir la condition Confusion",
                "Permet de guérir la condition Confusion",
                "Permet de guérir la condition Confusion",
                "Permet de guérir la condition Confusion",
                "Guéris et rends immunisé à la condition Confusion",
                "Guéris et rends immunisé à la condition Confusion",
                "Guéris et rends immunisé à la condition Confusion",
                "Guéris et rends immunisé à la condition Confusion",
                "Guéris et rends immunisé aux conditions Démence et Confusion",
                "Guéris et rends immunisé aux conditions Démence et Confusion",
                "Guéris et rends immunisé aux conditions Démence et Confusion",

            ]),
            new ArcaneEffect("Conjuration de ressources", thresholds, [
                "Le sort n'a aucun d'effet",
                "Le sort n'a aucun d'effet",
                "Le sort n'a aucun d'effet",
                "Le sort n'a aucun d'effet",
                "Le sort n'a aucun d'effet",
                "Permet d'agir comme une ressource T1 pendant une fabrication, pas plus d'une conjuration de ressources ne peut être faite par processus de fabrication d'objet",
                "Permet d'agir comme une ressource T1 pendant une fabrication, pas plus d'une conjuration de ressources ne peut être faite par processus de fabrication d'objet",
                "Permet d'agir comme une ressource T1 pendant une fabrication, pas plus d'une conjuration de ressources ne peut être faite par processus de fabrication d'objet",
                "Permet d'agir comme une ressource T2 pendant une fabrication, pas plus d'une conjuration de ressources ne peut être faite par processus de fabrication d'objet",
                "Permet d'agir comme une ressource T2 pendant une fabrication, pas plus d'une conjuration de ressources ne peut être faite par processus de fabrication d'objet",
                "Permet d'agir comme une ressource T2 pendant une fabrication, pas plus d'une conjuration de ressources ne peut être faite par processus de fabrication d'objet",
                "Permet d'agir comme une ressource T3 pendant une fabrication, pas plus d'une conjuration de ressources ne peut être faite par processus de fabrication d'objet"
            ], [
                "N'a aucun effet, pas assez de puissance",
                "N'a aucun effet, pas assez de puissance",
                "N'a aucun effet, pas assez de puissance",
                "N'a aucun effet, pas assez de puissance",
                "Permet la téléportation de ressources T1 à un endroit précis, du choix du lanceur de sort. Une seule resource peut être téléportée par jour.",
                "Permet la téléportation de ressources T1 à un endroit précis, du choix du lanceur de sort. Une seule resource peut être téléportée par jour.",
                "Permet la téléportation de ressources T2 à un endroit précis, du choix du lanceur de sort. Une seule resource peut être téléportée par jour.",
                "Permet la téléportation de ressources T2 à un endroit précis, du choix du lanceur de sort. Une seule resource peut être téléportée par jour.",
                "Permet la téléportation de ressources T3 à un endroit précis, du choix du lanceur de sort. Une seule resource peut être téléportée par jour.",
                "Permet la téléportation de ressources T3 à un endroit précis, du choix du lanceur de sort. Une seule resource peut être téléportée par jour.",
                "Permet la téléportation de ressources T4 à un endroit précis, du choix du lanceur de sort. Une seule resource peut être téléportée par jour.",
            ]),
            new ArcaneEffect("Courage", thresholds, [
                "Protèges contre la prochaine instance de la condition Peur",
                "Protèges contre la prochaine instance de la condition Peur",
                "Protèges contre la prochaine instance de la condition Peur",
                "Protèges contre les 2 prochaines instance de la condition Peur",
                "Protèges contre les 2 prochaines instance de la condition Peur",
                "Protèges contre les 2 prochaines instance de la condition Peur",
                "Protèges contre les 3 prochaines instance de la condition Peur",
                "Protèges contre les 3 prochaines instance de la condition Peur",
                "Protèges contre les 3 prochaines instance de la condition Peur",
                "Protèges contre les 4 prochaines instance de la condition Peur",
                "Protèges contre les 4 prochaines instance de la condition Peur"
            ], [
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
                "Nullifies les résistances à la peur pour la prochaine instance de la condition Peur",
            ]),
            new ArcaneEffect("Dégâts illusoires", thresholds, [
                "Cause 1 dégât dans les PVTs de la cible",
                "Cause 4 dégât dans les PVTs de la cible",
                "Cause 7 dégât dans les PVTs de la cible",
                "Cause 10 dégât dans les PVTs de la cible",
                "Cause 13 dégât dans les PVTs de la cible",
                "Cause 16 dégât dans les PVTs de la cible",
                "Cause 19 dégât dans les PVTs de la cible",
                "Cause 22 dégât dans les PVTs de la cible",
                "Cause 25 dégât dans les PVTs de la cible",
                "Cause 28 dégât dans les PVTs de la cible",
                "Cause 31 dégât dans les PVTs de la cible",
                "Cause 34 dégât dans les PVTs de la cible",
                "Cause 37 dégât dans les PVTs de la cible",
                "Cause encore 37 dégât dans les PVTs de la cible, vous avez atteint la limite de l'effet"
            ], [
                "Augmente les PVTs de la cible de 1",
                "Augmente les PVTs de la cible de 2",
                "Augmente les PVTs de la cible de 3",
                "Augmente les PVTs de la cible de 4",
                "Augmente les PVTs de la cible de 5",
                "Augmente les PVTs de la cible de 6",
                "Augmente les PVTs de la cible de 7",
                "Augmente les PVTs de la cible de 8",
                "Augmente les PVTs de la cible de 9",
                "Augmente les PVTs de la cible de 10",
                "Augmente les PVTs de la cible de 11",
            ]),
            new ArcaneEffect("Dégâts magiques", thresholds, [
                "Cause 1 dégât de type magique à la cible",
                "Cause 2 dégât de type magique à la cible",
                "Cause 3 dégât de type magique à la cible",
                "Cause 4 dégât de type magique à la cible",
                "Cause 5 dégât de type magique à la cible",
                "Cause 6 dégât de type magique à la cible",
                "Cause 7 dégât de type magique à la cible",
                "Cause 8 dégât de type magique à la cible",
                "Cause 9 dégât de type magique à la cible",
                "Cause 10 dégât de type magique à la cible",
                "Cause 11 dégât de type magique à la cible",
                "Cause encore 11 dégât de type magique à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Guéris de 0 PV",
                "Guéris de 1 PV",
                "Guéris de 1 PV",
                "Guéris de 2 PV",
                "Guéris de 2 PV",
                "Guéris de 3 PV",
                "Guéris de 3 PV",
                "Guéris de 4 PV",
                "Guéris de 4 PV",
                "Guéris de 5 PV",
                "Guéris de 5 PV",
            ], true, [
                "Cause 1 dégât de type feu à la cible",
                "Cause 2 dégât de type feu à la cible",
                "Cause 3 dégât de type feu à la cible",
                "Cause 4 dégât de type feu à la cible",
                "Cause 5 dégât de type feu à la cible",
                "Cause 6 dégât de type feu à la cible",
                "Cause 7 dégât de type feu à la cible",
                "Cause 8 dégât de type feu à la cible",
                "Cause 9 dégât de type feu à la cible",
                "Cause 10 dégât de type feu à la cible",
                "Cause 11 dégât de type feu à la cible",
                "Cause encore 11 dégât de type feu à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Cause 1 dégât de type glace à la cible",
                "Cause 2 dégât de type glace à la cible",
                "Cause 3 dégât de type glace à la cible",
                "Cause 4 dégât de type glace à la cible",
                "Cause 5 dégât de type glace à la cible",
                "Cause 6 dégât de type glace à la cible",
                "Cause 7 dégât de type glace à la cible",
                "Cause 8 dégât de type glace à la cible",
                "Cause 9 dégât de type glace à la cible",
                "Cause 10 dégât de type glace à la cible",
                "Cause 11 dégât de type glace à la cible",
                "Cause encore 11 dégât de type glace à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Cause 1 dégât de type foudre à la cible",
                "Cause 2 dégât de type foudre à la cible",
                "Cause 3 dégât de type foudre à la cible",
                "Cause 4 dégât de type foudre à la cible",
                "Cause 5 dégât de type foudre à la cible",
                "Cause 6 dégât de type foudre à la cible",
                "Cause 7 dégât de type foudre à la cible",
                "Cause 8 dégât de type foudre à la cible",
                "Cause 9 dégât de type foudre à la cible",
                "Cause 10 dégât de type foudre à la cible",
                "Cause 11 dégât de type foudre à la cible",
                "Cause encore 11 dégât de type foudre à la cible, vous avez atteint la limite de l'effet"                
            ], [
                "Cause 1 dégât de type acide à la cible",
                "Cause 2 dégât de type acide à la cible",
                "Cause 3 dégât de type acide à la cible",
                "Cause 4 dégât de type acide à la cible",
                "Cause 5 dégât de type acide à la cible",
                "Cause 6 dégât de type acide à la cible",
                "Cause 7 dégât de type acide à la cible",
                "Cause 8 dégât de type acide à la cible",
                "Cause 9 dégât de type acide à la cible",
                "Cause 10 dégât de type acide à la cible",
                "Cause 11 dégât de type acide à la cible",
                "Cause encore 11 dégât de type acide à la cible, vous avez atteint la limite de l'effet"    
            ], [
                "Cause 1 dégât de type béni à la cible",
                "Cause 2 dégât de type béni à la cible",
                "Cause 3 dégât de type béni à la cible",
                "Cause 4 dégât de type béni à la cible",
                "Cause 5 dégât de type béni à la cible",
                "Cause 6 dégât de type béni à la cible",
                "Cause 7 dégât de type béni à la cible",
                "Cause 8 dégât de type béni à la cible",
                "Cause 9 dégât de type béni à la cible",
                "Cause 10 dégât de type béni à la cible",
                "Cause 11 dégât de type béni à la cible",
                "Cause encore 11 dégât de type béni à la cible, vous avez atteint la limite de l'effet"    
            ], [
                "Cause 1 dégât de type maudit à la cible",
                "Cause 2 dégât de type maudit à la cible",
                "Cause 3 dégât de type maudit à la cible",
                "Cause 4 dégât de type maudit à la cible",
                "Cause 5 dégât de type maudit à la cible",
                "Cause 6 dégât de type maudit à la cible",
                "Cause 7 dégât de type maudit à la cible",
                "Cause 8 dégât de type maudit à la cible",
                "Cause 9 dégât de type maudit à la cible",
                "Cause 10 dégât de type maudit à la cible",
                "Cause 11 dégât de type maudit à la cible",
                "Cause encore 11 dégât de type maudit à la cible, vous avez atteint la limite de l'effet"    
            ]),
            new ArcaneEffect("Dégâts magiques majeurs", thresholds, [
                "Cause 1 dégât de type magique à la cible",
                "Cause 2 dégât de type magique à la cible",
                "Cause 3 dégât de type magique à la cible",
                "Cause 4 dégât de type magique à la cible",
                "Cause 5 dégât de type magique à la cible",
                "Cause 6 dégât de type magique à la cible",
                "Cause 8 dégât de type magique à la cible",
                "Cause 10 dégât de type magique à la cible",
                "Cause 12 dégât de type magique à la cible",
                "Cause 14 dégât de type magique à la cible",
                "Cause 16 dégât de type magique à la cible",
                "Cause 18 dégât de type magique à la cible",
                "Cause 20 dégât de type magique à la cible",
                "Cause encore 20 dégât de type magique à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Guéris de 0 PV",
                "Guéris de 1 PV",
                "Guéris de 1 PV",
                "Guéris de 2 PV",
                "Guéris de 2 PV",
                "Guéris de 3 PV",
                "Guéris de 4 PV",
                "Guéris de 5 PV",
                "Guéris de 6 PV",
                "Guéris de 7 PV",
                "Guéris de 8 PV",
                "Guéris de 9 PV",
                "Guéris de 10 PV",
            ], true, [
                "Cause 1 dégât de type feu à la cible",
                "Cause 2 dégât de type feu à la cible",
                "Cause 3 dégât de type feu à la cible",
                "Cause 4 dégât de type feu à la cible",
                "Cause 5 dégât de type feu à la cible",
                "Cause 6 dégât de type feu à la cible",
                "Cause 8 dégât de type feu à la cible",
                "Cause 10 dégât de type feu à la cible",
                "Cause 12 dégât de type feu à la cible",
                "Cause 14 dégât de type feu à la cible",
                "Cause 16 dégât de type feu à la cible",
                "Cause 18 dégât de type feu à la cible",
                "Cause 20 dégât de type feu à la cible",
                "Cause encore 20 dégât de type feu à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Cause 1 dégât de type glace à la cible",
                "Cause 2 dégât de type glace à la cible",
                "Cause 3 dégât de type glace à la cible",
                "Cause 4 dégât de type glace à la cible",
                "Cause 5 dégât de type glace à la cible",
                "Cause 6 dégât de type glace à la cible",
                "Cause 8 dégât de type glace à la cible",
                "Cause 10 dégât de type glace à la cible",
                "Cause 12 dégât de type glace à la cible",
                "Cause 14 dégât de type glace à la cible",
                "Cause 16 dégât de type glace à la cible",
                "Cause 18 dégât de type glace à la cible",
                "Cause 20 dégât de type glace à la cible",
                "Cause encore 20 dégât de type glace à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Cause 1 dégât de type foudre à la cible",
                "Cause 2 dégât de type foudre à la cible",
                "Cause 3 dégât de type foudre à la cible",
                "Cause 4 dégât de type foudre à la cible",
                "Cause 5 dégât de type foudre à la cible",
                "Cause 6 dégât de type foudre à la cible",
                "Cause 8 dégât de type foudre à la cible",
                "Cause 10 dégât de type foudre à la cible",
                "Cause 12 dégât de type foudre à la cible",
                "Cause 14 dégât de type foudre à la cible",
                "Cause 16 dégât de type foudre à la cible",
                "Cause 18 dégât de type foudre à la cible",
                "Cause 20 dégât de type foudre à la cible",
                "Cause encore 20 dégât de type foudre à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Cause 1 dégât de type acide à la cible",
                "Cause 2 dégât de type acide à la cible",
                "Cause 3 dégât de type acide à la cible",
                "Cause 4 dégât de type acide à la cible",
                "Cause 5 dégât de type acide à la cible",
                "Cause 6 dégât de type acide à la cible",
                "Cause 8 dégât de type acide à la cible",
                "Cause 10 dégât de type acide à la cible",
                "Cause 12 dégât de type acide à la cible",
                "Cause 14 dégât de type acide à la cible",
                "Cause 16 dégât de type acide à la cible",
                "Cause 18 dégât de type acide à la cible",
                "Cause 20 dégât de type acide à la cible",
                "Cause encore 20 dégât de type acide à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Cause 1 dégât de type béni à la cible",
                "Cause 2 dégât de type béni à la cible",
                "Cause 3 dégât de type béni à la cible",
                "Cause 4 dégât de type béni à la cible",
                "Cause 5 dégât de type béni à la cible",
                "Cause 6 dégât de type béni à la cible",
                "Cause 8 dégât de type béni à la cible",
                "Cause 10 dégât de type béni à la cible",
                "Cause 12 dégât de type béni à la cible",
                "Cause 14 dégât de type béni à la cible",
                "Cause 16 dégât de type béni à la cible",
                "Cause 18 dégât de type béni à la cible",
                "Cause 20 dégât de type béni à la cible",
                "Cause encore 20 dégât de type béni à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Cause 1 dégât de type maudit à la cible",
                "Cause 2 dégât de type maudit à la cible",
                "Cause 3 dégât de type maudit à la cible",
                "Cause 4 dégât de type maudit à la cible",
                "Cause 5 dégât de type maudit à la cible",
                "Cause 6 dégât de type maudit à la cible",
                "Cause 8 dégât de type maudit à la cible",
                "Cause 10 dégât de type maudit à la cible",
                "Cause 12 dégât de type maudit à la cible",
                "Cause 14 dégât de type maudit à la cible",
                "Cause 16 dégât de type maudit à la cible",
                "Cause 18 dégât de type maudit à la cible",
                "Cause 20 dégât de type maudit à la cible",
                "Cause encore 20 dégât de type maudit à la cible, vous avez atteint la limite de l'effet"
            ]),
            new ArcaneEffect("Dégâts physiques", thresholds, [
                "Cause 1 dégât non typés à la cible",
                "Cause 2 dégât non typés à la cible",
                "Cause 3 dégât non typés à la cible",
                "Cause 4 dégât non typés à la cible",
                "Cause 5 dégât non typés à la cible",
                "Cause 6 dégât non typés à la cible",
                "Cause 7 dégât non typés à la cible",
                "Cause 8 dégât non typés à la cible",
                "Cause 9 dégât non typés à la cible",
                "Cause 10 dégât non typés à la cible",
                "Cause 11 dégât non typés à la cible",
                "Cause encore 11 dégât de non typés à la cible, vous avez atteint la limite de l'effet"
            ], [    
                "Guéris de 0 PV",
                "Guéris de 1 PV",
                "Guéris de 1 PV",
                "Guéris de 2 PV",
                "Guéris de 2 PV",
                "Guéris de 3 PV",
                "Guéris de 3 PV",
                "Guéris de 4 PV",
                "Guéris de 4 PV",
                "Guéris de 5 PV",
                "Guéris de 5 PV",
            ]),
            new ArcaneEffect("Dégâts physiques majeurs", thresholds, [
                "Cause 1 dégât non typés à la cible",
                "Cause 2 dégât non typés à la cible",
                "Cause 3 dégât non typés à la cible",
                "Cause 4 dégât non typés à la cible",
                "Cause 5 dégât non typés à la cible",
                "Cause 6 dégât non typés à la cible",
                "Cause 8 dégât non typés à la cible",
                "Cause 10 dégât non typés à la cible",
                "Cause 12 dégât non typés à la cible",
                "Cause 14 dégât non typés à la cible",
                "Cause 16 dégât non typés à la cible",
                "Cause 18 dégât non typés à la cible",
                "Cause 20 dégât non typés à la cible",
                "Cause encore 20 dégât non typés à la cible, vous avez atteint la limite de l'effet"
            ], [
                "Guéris de 0 PV",
                "Guéris de 1 PV",
                "Guéris de 1 PV",
                "Guéris de 2 PV",
                "Guéris de 2 PV",
                "Guéris de 3 PV",
                "Guéris de 4 PV",
                "Guéris de 5 PV",
                "Guéris de 6 PV",
                "Guéris de 7 PV",
                "Guéris de 8 PV",
                "Guéris de 9 PV",
                "Guéris de 10 PV",
            ]),
            new ArcaneEffect("Détection de la magie", thresholds, [
                "Permet de détecter la magie environnante",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs et intermédiaires",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs et intermédiaires",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs et intermédiaires",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs, intermédiaires et majeurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs, intermédiaires et majeurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs, intermédiaires et majeurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs, intermédiaires et majeurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des objets magiques mineurs, intermédiaires et majeurs",
                "Permet de détecter la magie environnante, ainsi que d'identifier des artefacts magique de puissance incroyable"
            ], [
                "Aucun effet, pas assez de puissance",
                "Permet de maudire un objet mineur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur ou intermédiaire, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur ou intermédiaire, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur ou intermédiaire, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, intermédiaire ou majeur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, intermédiaire ou majeur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, intermédiaire ou majeur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, intermédiaire ou majeur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un objet mineur, intermédiaire ou majeur, doit être combiné avec un sort de malédiction pour déterminer de la malédiction elle même",
                "Permet de maudire un artefact de puissance incroyable, doit être combiné avec un sort de malédiction tout aussi puissant."
            ]),
            new ArcaneEffect("Dissimulation", thresholds, [
                "Octroie à la cible la condition Camouflage",
                "Octroie à la cible la condition Camouflage",
                "Octroie à la cible la condition Camouflage",
                "Octroie à la cible la condition Camouflage",
                "Octroie à la cible la condition Invisibilité",
                "Octroie à la cible la condition Invisibilité",
                "Octroie à la cible la condition Invisibilité",
                "Octroie à la cible la condition Non-Détection",
                "Octroie à la cible la condition Non-Détection",
                "Octroie à la cible la condition Non-Détection",
                "Octroie à la cible la condition Non-Détection"
            ], [
                "Permet de voir les gens qui ont la condition Camouflage",
                "Permet de voir les gens qui ont la condition Camouflage",
                "Permet de voir les gens qui ont la condition Camouflage",
                "Permet de voir les gens qui ont la condition Camouflage",
                "Permet de voir les gens qui ont la condition Invisibilité",
                "Permet de voir les gens qui ont la condition Invisibilité",
                "Permet de voir les gens qui ont la condition Invisibilité",
                "Permet de voir les gens qui ont la condition Non-Détection",
                "Permet de voir les gens qui ont la condition Non-Détection",
                "Permet de voir les gens qui ont la condition Non-Détection",
                "Permet de voir les gens qui ont la condition Non-Détection"
            ]),
            new ArcaneEffect("Dissipation", thresholds, [
                "Si la cible est un extraplanaire, causes 4 points de dégâts non réductibles, et causes la condition Dissipation Tier 0",
                "Si la cible est un extraplanaire, causes 8 points de dégâts non réductibles, et causes la condition Dissipation Tier 1",
                "Si la cible est un extraplanaire, causes 12 points de dégâts non réductibles, et causes la condition Dissipation Tier 2",
                "Si la cible est un extraplanaire, causes 16 points de dégâts non réductibles, et causes la condition Dissipation Tier 3",
                "Si la cible est un extraplanaire, causes 20 points de dégâts non réductibles, et causes la condition Dissipation Tier 4",
                "Si la cible est un extraplanaire, causes 24 points de dégâts non réductibles, et causes la condition Dissipation Tier 5",
                "Si la cible est un extraplanaire, causes 28 points de dégâts non réductibles, et causes la condition Dissipation Tier 6",
                "Si la cible est un extraplanaire, causes 32 points de dégâts non réductibles, et causes la condition Dissipation Tier 7",
                "Si la cible est un extraplanaire, causes 36 points de dégâts non réductibles, et causes la condition Dissipation Tier 8",
                "Si la cible est un extraplanaire, causes 40 points de dégâts non réductibles, et causes la condition Dissipation Tier 9",
                "Si la cible est un extraplanaire, causes 44 points de dégâts non réductibles, et causes la condition Dissipation Tier 10"
            ], [
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
                "Si la cible est un extraplanaire, permet de l'ancrer dans le plan courant de manière non-invasive. Cet effet peut être cancellé par le lanceur et la cible à tout moment. Protège contre la prochaine tentative de Dissipation",
            ]),
            new ArcaneEffect("Dissipation de la magie", thresholds, [
                "Causes un effet Dissipation 0 à la cible, Dissipes tous les effets de sort niveau 0, donc... pas grand chose.",
                "Causes un effet Dissipation 1 à la cible, Dissipes tous les effets de sort niveau 1 et moins",
                "Causes un effet Dissipation 1 à la cible, Dissipes tous les effets de sort niveau 1 et moins",
                "Causes un effet Dissipation 2 à la cible, Dissipes tous les effets de sort niveau 2 et moins",
                "Causes un effet Dissipation 2 à la cible, Dissipes tous les effets de sort niveau 2 et moins",
                "Causes un effet Dissipation 3 à la cible, Dissipes tous les effets de sort niveau 3 et moins",
                "Causes un effet Dissipation 3 à la cible, Dissipes tous les effets de sort niveau 3 et moins",
                "Causes un effet Dissipation 4 à la cible, Dissipes tous les effets de sort niveau 4 et moins",
                "Causes un effet Dissipation 4 à la cible, Dissipes tous les effets de sort niveau 4 et moins",
                "Causes un effet Dissipation 5 à la cible, Dissipes tous les effets de sort niveau 5 et moins",
                "Causes la condition Disjonction à la cible, celle-ci dissipe TOUS les effets magiques sur la cible, et décharges TOUS ses objets magiques, sauf les artefacts. Si lancé sur un artefact, voir l'animation"
            ]),
            new ArcaneEffect("Domination", thresholds, [
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle prendra 1 de dégât physique lorsqu'elle le désobéit directement pendant la durée du sort.",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle perdra 1 PM lorsqu'elle le désobéit directement pendant la durée du sort.",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle subira la condition Nauséeux lorsqu'elle le désobéit directement, jusqu'à ce qu'elle retourne dans le droit chemin ou que le sort se termines.",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle subira la condition Faiblesse 1 lorsqu'elle le désobéit directement pour le reste de la durée du sort.",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle prendra 3 points de dégâts non réductibles lorsqu'elle le désobéit directement pendant la durée du sort",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle perdra 10 PM lorsqu'elle le désobéit directement pendant la durée du sort",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle sera mise a l'agonie immédiatement lorsqu'elle désobéit directement l'ordre",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle subira la condition Nauséeux dès qu'elle pense à désobéir ou ne fait pas une action qui est utile a l'ordre en question",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle subira la condition Faiblesse 3 dès qu'elle pense à désobéir ou ne fait pas une action qui est utile à l'ordre en question",
                "Causes la condition \"Domination\" sur la cible. Doit être suivie d'un ordre qui devra être remplis par la cible sans quoi elle mourra immédiatement lorsqu'elle désobéit directement l'ordre"
            ], [
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
                "Détruit la condition \"Domination\" sur la cible.",
            ]),
            new ArcaneEffect("Drain de vie", thresholds, [
                "Ne fait strictement rien, pas assez de puissance",
                "Causes 1 de dégât non réductible à la cible et restaures 1 de vie à l'utilisateur",
                "Causes 1 de dégât non réductible à la cible et restaures 1 de vie à l'utilisateur",
                "Causes 2 de dégât non réductible à la cible et restaures 2 de vie à l'utilisateur",
                "Causes 2 de dégât non réductible à la cible et restaures 2 de vie à l'utilisateur",
                "Causes 3 de dégât non réductible à la cible et restaures 3 de vie à l'utilisateur",
                "Causes 4 de dégât non réductible à la cible et restaures 4 de vie à l'utilisateur",
                "Causes 5 de dégât non réductible à la cible et restaures 5 de vie à l'utilisateur",
                "Causes 6 de dégât non réductible à la cible et restaures 6 de vie à l'utilisateur",
                "Causes 7 de dégât non réductible à la cible et restaures 7 de vie à l'utilisateur",
                "Causes 8 de dégât non réductible à la cible et restaures 8 de vie à l'utilisateur"
            ]),
            new ArcaneEffect("Envhevêtrement", thresholds, [
                "Ne fait strictement rien, pas assez de puissance",
                "Causes la condition \"Enchevêtrement\" à la cible",
                "Causes la condition \"Enchevêtrement\" à la cible",
                "Causes la condition \"Enchevêtrement\" à la cible",
                "Causes la condition \"Enchevêtrement\" à la cible",
                "Causes la condition \"Enchevêtrement\" à la cible",
                "Causes la condition \"Enchevêtrement\" à la cible",
                "Causes la condition \"Enchevêtrement\" à la cible",
                "Causes la condition \"Paralysie\" à la cible",
                "Causes la condition \"Paralysie\" à la cible",
                "Causes la condition \"Paralysie\" à la cible"
            ]),
            new ArcaneEffect("Endurance", thresholds, [
                "Octroie à la cible 1 PVT",
                "Octroie à la cible 2 PVT",
                "Octroie à la cible 3 PVT",
                "Octroie à la cible 4 PVT",
                "Octroie à la cible 5 PVT",
                "Octroie à la cible 6 PVT",
                "Octroie à la cible 7 PVT",
                "Octroie à la cible 8 PVT",
                "Octroie à la cible 9 PVT",
                "Octroie à la cible 10 PVT",
                "Octroie à la cible 11 PVT",
                "Octroie à la cible 12 PVT",
                "Octroie à la cible 13 PVT",
                "Octroie à la cible 14 PVT",
                "Octroie à la cible 15 PVT"
            ], [
                "Réduit les PVTs max de la cible de 1, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 2, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 3, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 4, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 5, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 6, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 7, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 8, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 9, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 10, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 11, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 12, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 13, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 14, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
                "Réduit les PVTs max de la cible de 15, si l'utilisateur n'en a pas assez, prends le reste sur le Max PV, minimum 1",
            ]),
            new ArcaneEffect("Érosion de l'Esprit", thresholds, [
                "La cible ne peut plus résister à la prochaine instance d'effet mental qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister à la prochaine instance d'effet mental qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister à la prochaine instance d'effet mental qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 2 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 2 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 2 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 3 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 3 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 3 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 4 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel",
                "La cible ne peut plus résister aux 4 prochaines instances d'effets mentaux qu'elle subit. Résistable seulement avec Brouillard Spirituel"
            ], [
                "Aucun effet, trop faible",
                "Aucun effet, trop faible",
                "Aucun effet, trop faible",
                "Aucun effet, trop faible",
                "Permet de retirer une condition mentale à la cible, de son choix.",
                "Permet de retirer une condition mentale à la cible, de son choix.",
                "Permet de retirer une condition mentale à la cible, de son choix.",
                "Permet de retirer une condition mentale à la cible, de son choix.",
                "Permet de retirer une condition mentale à la cible, de son choix.",
                "Permet de retirer deux condition mentale à la cible, de son choix.",
                "Permet de retirer deux condition mentale à la cible, de son choix."
            ]),
            new ArcaneEffect("Explosion de Cadavres", thresholds, [
                "Cause 1 de dégâts aux personnages à portée de 5 pieds d'un des cadavres ciblés, maximum 1 cadavre",
                "Cause 1 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 2 cadavres",
                "Cause 1 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 3 cadavres",
                "Cause 1 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 4 cadavres",
                "Cause 1 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 5 cadavres",
                "Cause 2 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 6 cadavres",
                "Cause 2 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 7 cadavres",
                "Cause 2 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 8 cadavres",
                "Cause 2 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 9 cadavres",
                "Cause 2 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 10 cadavres",
                "Cause 3 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 11 cadavres"
            ], [
                "Cause 1 PM de dégâts aux personnages à portée de 5 pieds d'un des cadavres ciblés, maximum 1 cadavre",
                "Cause 1 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 2 cadavres",
                "Cause 1 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 3 cadavres",
                "Cause 2 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 4 cadavres",
                "Cause 2 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 5 cadavres",
                "Cause 2 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 6 cadavres",
                "Cause 3 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 7 cadavres",
                "Cause 3 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 8 cadavres",
                "Cause 4 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 9 cadavres",
                "Cause 4 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 10 cadavres",
                "Cause 5 PM de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 11 cadavres"
            ]),
            new ArcaneEffect("Fixation", thresholds, [
                "Si la cible est un extraplanaire, cause la condition \"Fixation 0\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 1\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 2\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 3\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 4\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 5\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 6\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 7\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 8\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 9\"",
                "Si la cible est un extraplanaire, cause la condition \"Fixation 10\""
            ]),
            new ArcaneEffect("Flétrissement", thresholds, [
                "Cause à la cible la perte de 1 niveau de force",
                "Cause à la cible la perte de 1 niveau de force",
                "Cause à la cible la perte de 1 niveau de force et de 1 dégât physique",
                "Cause à la cible la perte de 2 niveau de force et de 1 dégât physique",
                "Cause à la cible la perte de 2 niveau de force et de 1 dégât physique",
                "Cause à la cible la perte de 2 niveau de force et de 1 dégât physique",
                "Cause à la cible la perte de 3 niveau de force et de 2 dégât physique",
                "Cause à la cible la perte de 3 niveau de force et de 2 dégât physique",
                "Cause à la cible la perte de 3 niveau de force et de 2 dégât physique",
                "Cause à la cible la perte de 4 niveau de force et de 2 dégât physique",
                "Cause à la cible la perte de 4 niveau de force et de 3 dégât physique"
            ], [
                "Donne à la cible 1 niveau de force",
                "Donne à la cible 1 niveau de force",
                "Donne à la cible 1 niveau de force et 1 dégât physique",
                "Donne à la cible 2 niveau de force et 1 dégât physique",
                "Donne à la cible 2 niveau de force et 1 dégât physique",
                "Donne à la cible 2 niveau de force et 1 dégât physique",
                "Donne à la cible 3 niveau de force et 2 dégât physique",
                "Donne à la cible 3 niveau de force et 2 dégât physique",
                "Donne à la cible 3 niveau de force et 2 dégât physique",
                "Donne à la cible 4 niveau de force et 2 dégât physique",
                "Donne à la cible 4 niveau de force et 3 dégât physique"
            ]),
            new ArcaneEffect("Force", thresholds, [
                "Aucun effet, pas assez de puissance",
                "Aucun effet, pas assez de puissance",
                "Aucun effet, pas assez de puissance",
                "Aucun effet, pas assez de puissance",
                "Cause la condition \"Renversement\" chez la cible",
                "Cause la condition \"Renversement\" chez la cible",
                "Cause la condition \"Renversement\" chez la cible",
                "Cause la condition \"Renversement\" chez la cible",
                "Cause la condition \"Renversement\" chez la cible",
                "Cause la condition \"Renversement\" et \"Enchevêtrement\" chez la cible",
                "Cause la condition \"Renversement\" et \"Enchevêtrement\" chez la cible"
            ], [
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement. Ne protège pas d'un renversement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement. Ne protège pas d'un renversement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement. Ne protège pas d'un renversement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement. Ne protège pas d'un renversement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement, défait la condition Enchevêtrement.",
                "Protèges de la prochaine instance d'une compétence ou d'un sort causant un déplacement, défait la condition Enchevêtrement.",
            ], true, [
                "Rapproches la cible du lanceur de 1 pas",
                "Rapproches la cible du lanceur de 2 pas",
                "Rapproches la cible du lanceur de 3 pas",
                "Rapproches la cible du lanceur de 4 pas",
                "Rapproches la cible du lanceur de 5 pas",
                "Rapproches la cible du lanceur de 6 pas",
                "Rapproches la cible du lanceur de 7 pas",
                "Rapproches la cible du lanceur de 8 pas",
                "Rapproches la cible du lanceur de 9 pas",
                "Rapproches la cible du lanceur de 10 pas",
                "Rapproches la cible du lanceur de 11 pas"
            ], [
                "Éloignes la cible du lanceur de 1 pas",
                "Éloignes la cible du lanceur de 2 pas",
                "Éloignes la cible du lanceur de 3 pas",
                "Éloignes la cible du lanceur de 4 pas",
                "Éloignes la cible du lanceur de 5 pas",
                "Éloignes la cible du lanceur de 6 pas",
                "Éloignes la cible du lanceur de 7 pas",
                "Éloignes la cible du lanceur de 8 pas",
                "Éloignes la cible du lanceur de 9 pas",
                "Éloignes la cible du lanceur de 10 pas",
                "Éloignes la cible du lanceur de 11 pas"
            ], [
                "Balaie la cible de coté de 1 pas",
                "Balaie la cible de coté de 2 pas",
                "Balaie la cible de coté de 3 pas",
                "Balaie la cible de coté de 4 pas",
                "Balaie la cible de coté de 5 pas",
                "Balaie la cible de coté de 6 pas",
                "Balaie la cible de coté de 7 pas",
                "Balaie la cible de coté de 8 pas",
                "Balaie la cible de coté de 9 pas",
                "Balaie la cible de coté de 10 pas",
                "Balaie la cible de coté de 11 pas"
            ], [
                "Balaie la cible de coté de 1 pas",
                "Balaie la cible de coté de 2 pas",
                "Balaie la cible de coté de 3 pas",
                "Balaie la cible de coté de 4 pas",
                "Balaie la cible de coté de 5 pas",
                "Balaie la cible de coté de 6 pas",
                "Balaie la cible de coté de 7 pas",
                "Balaie la cible de coté de 8 pas",
                "Balaie la cible de coté de 9 pas",
                "Balaie la cible de coté de 10 pas",
                "Balaie la cible de coté de 11 pas"
            ]),
            new ArcaneEffect("Fureur des Éléments", thresholds,
                ["N'a aucun effet sans élément"],
                ["N'a aucun effet sans élément"],
                true,
                true, 
                [
                    "Causes la condition Immolation 1, qui causes 1 de dégât par minutes pour la durée du sort, maximum 10 minutes",
                    "Causes la condition Immolation 2, qui causes 2 de dégât par minutes pour la durée du sort, maximum 10 minutes",
                    "Causes la condition Immolation 3, qui causes 3 de dégât par minutes pour la durée du sort, maximum 10 minutes"
                ], [
                    "Nullifies temporairement les PVTs de la cible pour la durée du sort.",
                    "Nullifies temporairement les PVTs de la cible et cause -1 a ses PV max pour la durée du sort.",
                    "Nullifies temporairement les PVTs de la cible et cause -1 a ses PV max pour la durée du sort."
                ], [
                    "Causes une faiblesse à la foudre, la cible se prends +1 dégâts de foudre sur toutes les attaques de foudre pour la durée du sort.",
                    "Causes une faiblesse à la foudre, la cible se prends +3 dégâts de foudre sur toutes les attaques de foudre pour la durée du sort.",
                    "Causes une faiblesse à la foudre, la cible se prends +5 dégâts de foudre sur toutes les attaques de foudre pour la durée du sort."
                ], [
                    "Causes un ralentissement chez la cible, lui empêchant de courir pour la durée du sort.",
                    "Causes un ralentissement chez la cible, l'enchevêtrant pour la durée du sort.",
                    "Causes un ralentissement chez la cible, lui causant une paralysie pour la durée du sort."
                ], [
                    "La cible fait un dégât de moins sur ses attaques, pour la durée du sort",
                    "La cible fait un dégât de moins sur ses attaques, et est sous l'effet de peur dès qu'elle est directement en contact avec les rayons du soleil, pour la durée du sort",
                    "La cible fait un dégât au moins sur ses attaques, et est aveuglée dès qu'elle est directement en contact avec les rayons du soleil, pour la durée du sort"
                ], [
                    "La cible fait un dégât de moins sur ses attaques lorsqu'elle est dans le noir pour la durée du sort.",
                    "La cible fait un dégât de moins sur ses attaques lorsqu'elle est dans le noir et est sous l'effet de peur si elle est dans le noir et éloignée de toutes source de lumière pour la durée du sort.",
                    "La cible fait un dégât de moins sur ses attaques lorsqu'elle est dans le noir et prends 2 dégâts par minute lorsqu'elle est dans le noir a plus de dix pied d'une source de lumière pour la durée du sort."
                ], [
                    "La cible obtiens une régénération de 1 pv par minute pour la durée du sort, maximum 10 minutes",
                    "La cible obtiens une régénération de 2 pv par minute pour la durée du sort, maximum 10 minutes",
                    "La cible obtiens une régénération de 3 pv par minute pour la durée du sort, maximum 10 minutes",
                ], [
                    "La cible peut maintenant respirer sous l'eau pour la durée du sort",
                    "La cible peut maintenant respirer sous l'eau et se déplace dans l'eau librement pour la durée du sort",
                    "La cible peut maintenant respirer sous l'eau, se déplace librement dans l'eau et est immunisé aux maladies pour la durée du sort"
                ], [
                    "La cible causes 1 dégât de plus sur ses sorts de foudre pour la durée du sort.",
                    "La cible causes 2 dégâts de plus sur ses sorts de foudre pour la durée du sort.",
                    "La cible causes 3 dégâts de plus sur ses sorts de foudre, et est immunisé à la paralysie pour la durée du sort."
                ], [
                    "La cible devient immunisée aux effets de déplacement pour la durée du sort pour la durée du sort.",
                    "La cible devient immunisée aux effets de déplacement et possèdes +1 DR sur tous les coups physiques reçus pour la durée du sort pour la durée du sort.",
                    "La cible devient immunisée aux effets de déplacement, possèdes +1 DR sur tous les coups physiques reçus et est immunisé aux bris de membres pour la durée du sort.",
                ], [
                    "La cible possède +2 Max PV dans la lumière du soleil pour la durée du sort",
                    "La cible possède +2 Max PV dans la lumière du soleil et est immunisée à l'aveuglement pour la durée du sort",
                    "La cible possède +2 Max PV dans la lumière du soleil, est immunisée à l'aveuglement et est immunisée aux dégâts bénis pour la durée du sort",
                ], [
                    "La cible possède +2 Max PV dans la noirceur de la nuit pour la durée du sort",
                    "La cible possède +2 Max PV dans la noirceur de la nuit et est immunisée aux effets de Noirceur pour la durée du sort",
                    "La cible possède +2 Max PV dans la noirceur de la nuit, est immunisée aux effets de Noirceur pour la durée du sort"
                ]),
            new ArcaneEffect("Hallucination", thresholds, [
                "La cible possède maintenant une vision chambranlante, celle-ci à de la difficulté avec son équilibre, et la perception des distances. La terre semble faire des vagues",
                "La cible possède maintenant une vision chambranlante, celle-ci à de la difficulté avec son équilibre, et la perception des distances. La terre semble faire des vagues",
                "La cible possède maintenant une vision chambranlante, celle-ci à de la difficulté avec son équilibre, et la perception des distances. La terre semble faire des vagues",
                "La cible possède maintenant une vision chambranlante, celle-ci à de la difficulté avec son équilibre, et la perception des distances. La terre semble faire des vagues",
                "La cible voit maintenant des choses qui n'existent pas, hallucines des choses qui ne sont pas là.",
                "La cible voit maintenant des choses qui n'existent pas, hallucines des choses qui ne sont pas là.",
                "La cible voit maintenant des choses qui n'existent pas, hallucines des choses qui ne sont pas là.",
                "La cible voit des choses qui n'existent clairement pas, elle se dissocie de la réalité. L'utilisateur du sort peut guider les hallucinations.",
                "La cible voit des choses qui n'existent clairement pas, elle se dissocie de la réalité. L'utilisateur du sort peut guider les hallucinations.",
                "La cible voit des choses qui n'existent clairement pas, elle se dissocie de la réalité. L'utilisateur du sort peut guider les hallucinations.",
                "La cible fusionnes avec l'univers et est considérée comme inconsciente pour la durée du sort."
            ], [
                "Pas assez de pouvoir, aucun effet",
                "Pas assez de pouvoir, aucun effet",
                "Pas assez de pouvoir, aucun effet",
                "Pas assez de pouvoir, aucun effet",
                "La cible peut voir à travers des illusions. Elle sait ce qui est une illusion et ce qui ne l'est pas.",
                "La cible peut voir à travers des illusions. Elle sait ce qui est une illusion et ce qui ne l'est pas.",
                "La cible peut voir à travers des illusions. Elle sait ce qui est une illusion et ce qui ne l'est pas.",
                "La cible peut voir à travers des illusions. Elle sait ce qui est une illusion et ce qui ne l'est pas.",
                "La cible peut voir à travers des illusions. Elle sait ce qui est une illusion et ce qui ne l'est pas.",
                "La cible peut voir à travers des illusions. Elle sait ce qui est une illusion et ce qui ne l'est pas.",
                "La cible peut voir à travers des illusions. Elle sait ce qui est une illusion et ce qui ne l'est pas.",
            ]),
            new ArcaneEffect("Illusion", thresholds, [
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité.",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité.",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité.",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité.",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité.",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité. Seules les cibles du sort peuvent voir cette illusion",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité. Seules les cibles du sort peuvent voir cette illusion",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité. Seules les cibles du sort peuvent voir cette illusion",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité. Seules les cibles du sort peuvent voir cette illusion",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité. Seules les cibles du sort peuvent voir cette illusion",
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité. Seules les cibles du sort peuvent voir cette illusion"
            ], [
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite.",
                "L'illusion ciblée est détruite."
            ]),
            new ArcaneEffect("Invocation", thresholds, [
                "Aucun effet, pas assez de puissance",
                "Aucun effet, pas assez de puissance",
                "Aucun effet, pas assez de puissance",
                "Aucun effet, pas assez de puissance",
                "Permet d'invoquer une créature d'un plan inférieur qui confèrera un léger bonus pour la durée du sort [Bonus défini par l'animation au moment de la création du sort]",
                "Permet d'invoquer une créature d'un plan inférieur qui confèrera un léger bonus pour la durée du sort [Bonus défini par l'animation au moment de la création du sort]",
                "Permet d'invoquer une créature d'un plan inférieur qui confèrera un léger bonus pour la durée du sort [Bonus défini par l'animation au moment de la création du sort]",
                "Permet d'invoquer une créature d'un plan suppérieur qui confèrera un léger bonus pour la durée du sort [Bonus défini par l'animation au moment de la création du sort]",
                "Permet d'invoquer une créature d'un plan suppérieur qui confèrera un léger bonus pour la durée du sort [Bonus défini par l'animation au moment de la création du sort]",
                "Permet d'invoquer une créature d'un plan suppérieur qui confèrera un léger bonus pour la durée du sort [Bonus défini par l'animation au moment de la création du sort]",
                "Permet d'invoquer une créature d'un plan inconnu, et étrange qui pourrait causer bien des effets à l'utilisateur. [Effet défini par l'animation au moment de la création du sort]"
            ]),
            new ArcaneEffect("Maladie", thresholds, [
                "Afflige la cible avec une maladie Tiers 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 3 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 3 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tiers 3 [Maladie aléatoire choisie au moment de la création du sort]"
            ], [
                "Guérit d'une maladie spécifique de Tiers 1 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 1 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 1 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 1 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 2 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 2 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 2 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 2 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 3 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 3 (Maladie aléatoire choisie au moment de la création du sort)",
                "Guérit d'une maladie spécifique de Tiers 3 (Maladie aléatoire choisie au moment de la création du sort)",
            ]),
            new ArcaneEffect("Malédiction", thresholds, [
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 0 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 5 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 10 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 20 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 25 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 30 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 35 écus)",
                "Permet de maudire une cible de manière insidieuse, lui créant un effet légèrement nuisible (-1 à une caractéristique choisie) et manifestant des éléments roleplay du choix de l'utilisateur. La clause n'est plus que matérielle, mais peut être fonctionnelle aussi. Ex: Aller vendre quelque chose, mentir à quelqu'un... Tant que ça ne blesse personne physiquement.",
                "Permet de maudire une cible de manière insidieuse, lui créant un effet légèrement nuisible (-1 à une caractéristique choisie) et manifestant des éléments roleplay du choix de l'utilisateur. La clause n'est plus que matérielle, mais peut être fonctionnelle aussi. Ex: Aller vendre quelque chose, mentir à quelqu'un... Tant que ça ne blesse personne physiquement.",
                "Permet de manifester une malédiction unique et ancienne, créant un effet distinct et handicapant à discuter avec l'animation après l'obtention du sort. La clause peut maintenant être une clause de vie, ex: La cible doit sacrifier un être cher, ou soi même, même. Peut nécessiter de tuer quelqu'un."
            ], [
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques",
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques",
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques. Permet de temporairement retirer un objet maudit mineur",
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques. Permet de temporairement retirer un objet maudit mineur",
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques. Permet de temporairement retirer un objet maudit mineur",
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques. Permet de temporairement retirer un objet maudit mineur ou intermédiaire",
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques. Permet de temporairement retirer un objet maudit mineur ou intermédiaire",
                "Permet de renverser une malédiction, guérissant la cible. Ne fonctionne que sur les malédictions n'aillant pas d'effet sur les caractéristiques. Permet de temporairement retirer un objet maudit mineur ou intermédiaire",
                "Permet de renverser une malédiction, guérissant la cible. Fonctionnes sur les malédictions avec une clause fonctionnelle. Permet de temporairement retirer un objet maudit mineur, intermédiaire ou majeur",
                "Permet de renverser une malédiction, guérissant la cible. Fonctionnes sur les malédictions avec une clause fonctionnelle. Permet de temporairement retirer un objet maudit mineur, intermédiaire ou majeur",
                "Permet de renverser une malédiction, guérissant la cible. Fonctionnes sur les malédictions uniques avec une clause de vie. Permet de temporairement retirer un objet maudit mineur, intermédiaire ou majeur"
            ]), 
            new ArcaneEffect("Mensonge", thresholds, [
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides, les esprits et les extraplanaires",
                "La cible de l'utilisateur est obligée de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides, les esprits et les extraplanaires"
            ], [
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides, les esprits et les extraplanaires. Ne fonctionne qu'une fois par jour par cible.",
                "La cible de l'utilisateur est obligée de dire la vérité lors de la prochaine question qu'on lui posera, n'affecte que les humanoides, les esprits et les extraplanaires. Ne fonctionne qu'une fois par jour par cible."
            ]),
            new ArcaneEffect("Mur de force", thresholds, [
                "Maximise les dégâts non-typés reçus par la cible a 7",
                "Maximise les dégâts non-typés reçus par la cible a 7",
                "Maximise les dégâts non-typés reçus par la cible a 7",
                "Maximise les dégâts non-typés reçus par la cible a 7",
                "Maximise les dégâts non-typés reçus par la cible a 6",
                "Maximise les dégâts non-typés reçus par la cible a 6",
                "Maximise les dégâts non-typés reçus par la cible a 5",
                "Maximise les dégâts non-typés reçus par la cible a 5",
                "Maximise les dégâts non-typés reçus par la cible a 4",
                "Maximise les dégâts non-typés reçus par la cible a 4",
                "Maximise les dégâts non-typés reçus par la cible a 3"
            ], [
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 1",
                "Augmente les dégâts non-typés reçus par la cible de 2",
                "Augmente les dégâts non-typés reçus par la cible de 2",
                "Augmente les dégâts non-typés reçus par la cible de 2",
            ]),
            new ArcaneEffect("Peur", thresholds, [
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Peur\" chez la cible",
                "Cause la condition \"Mort de Peur\" chez la cible, cette condition cause l'agonie si elle n'est pas évitée par une résistance a la peur",
                "Cause la condition \"Mprt de Peur\" chez la cible, cette condition cause l'agonie si elle n'est pas évitée par une résistance a la peur"
            ], [
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
                "La cible n'a plus aucune inhibitions face à la peur, et lui est immunisée, elle l'ignore et ne prends plus le danger en considération pendant la durée du sort",
            ]),
            new ArcaneEffect("Précognition", thresholds, [
                "Permet d'éviter la prochaine attaque physique",
                "Permet d'éviter la prochaine attaque physique",
                "Permet d'éviter la prochaine attaque physique",
                "Permet d'éviter la prochaine attaque physique",
                "Permet d'éviter la prochaine attaque magique",
                "Permet d'éviter la prochaine attaque magique",
                "Permet d'éviter la prochaine attaque magique",
                "Permet d'éviter la prochaine attaque surprise, qu'elle soit physique ou magique",
                "Permet d'éviter la prochaine attaque surprise, qu'elle soit physique ou magique",
                "Permet d'éviter la prochaine attaque surprise, qu'elle soit physique ou magique",
                "Permet d'esquiver l'apocalypse?"
            ], [
                "Rends impossible l'utilisation de toute Presquive pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive ou Parade pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive ou Parade pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive ou Parade pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive, Esquive ou Parade pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive, Esquive ou Parade pendant la durée du sort",
                "Rends impossible l'utilisation de toute Presquive, Esquive ou Parade pendant la durée du sort",
                "Rends impossible de tenter d'esquiver les coups pendant la durée du sort."
            ]),
            new ArcaneEffect("Préservation", thresholds, [
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 0",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 1",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 2",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 3",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 4",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 5",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 6, permet d'éviter un effet de décomposition/compostage",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 7, permet d'éviter un effet de décomposition/compostage",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 8, permet d'éviter un effet de décomposition/compostage",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 9, permet d'éviter un effet de décomposition/compostage",
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 10, permet d'éviter un effet de décomposition/compostage"
            ], [
                "La cible agonisante voit son agonie accélérée de 2 minutes",
                "La cible agonisante voit son agonie accélérée de 4 minutes",
                "La cible agonisante voit son agonie accélérée de 6 minutes",
                "La cible agonisante voit son agonie accélérée de 8 minutes",
                "La cible agonisante voit son agonie accélérée de 10 minutes",
                "La cible agonisante voit son agonie accélérée de 12 minutes",
                "La cible agonisante voit son agonie accélérée de 14 minutes",
                "La cible agonisante voit son agonie accélérée de 16 minutes",
                "La cible agonisante voit son agonie accélérée de 18 minutes",
                "La cible agonisante voit son agonie accélérée de 20 minutes",
                "La cible agonisante voit son agonie accélérée de 22 minutes",
            ]),
            new ArcaneEffect("Questionner les astres", thresholds, [
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir sans nuage. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir sans nuage. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir sans nuage. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir nuageux. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir nuageux. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir nuageux. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir pluvieux. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir pluvieux. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé que lors d'un soir pluvieux. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé en plein jour, qu'il pleuves ou non. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé en plein jour, qu'il pleuves ou non. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)"
            ], [
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
                "Le prochain questionnement des astres de la cible sera faussé, cette condition peut être retirée par tout ce qui retires une malédiction.",
            ]),
            new ArcaneEffect("Réincarnation", thresholds, [
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Permet de réincarner un mort dans son corps originel. Le corps originel doit recevoir une quantité de soins équivalente a son maximum de PV post mortem avant que le sort de réincarnation ne soit lancé. Le mort doit tout de même aller voir la mort pour avoir une discussion avec elle, mais reviendra sans problème dans son corps originel",
                "Permet de réincarner un mort dans son corps originel. Le corps originel doit recevoir une quantité de soins équivalente a son maximum de PV post mortem avant que le sort de réincarnation ne soit lancé. Le mort doit tout de même aller voir la mort pour avoir une discussion avec elle, mais reviendra sans problème dans son corps originel",
                "Permet de réincarner quelqu'un en ne possédant qu'une partie de son corps. La cible sera réincarnée dans un nouveau corps aléatoire, sans possibilité de choisir. Il est possible que la race changes de manière permanente.",
                "Permet de réincarner quelqu'un en ne possédant qu'une partie de son corps. La cible sera réincarnée dans un nouveau corps aléatoire, sans possibilité de choisir. Il est possible que la race changes de manière permanente.",
                "Permet de réincarner quelqu'un en ne possédant qu'une partie de son corps. La cible sera réincarnée dans un corps parfait, formé à l'image de son âme. La cible peut choisir sa nouvelle race et même changer ses compétences raciales et de provenance."
            ], [
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Aucun effet, le sort n'est pas assez puissant",
                "Permet de Désincarner quelqu'un ou quelque chose?... Même la toile semble se demander ce que ça veut dire exactement...",
            ]),
            new ArcaneEffect("Relever les morts", thresholds, [
                "Permet de relever un mort vivant avec une fiche a 5 points",
                "Permet de relever un mort vivant avec une fiche a 7 points",
                "Permet de relever un mort vivant avec une fiche a 9 points",
                "Permet de relever un mort vivant avec une fiche a 11 points",
                "Permet de relever un mort vivant avec une fiche a 13 points",
                "Permet de relever un mort vivant avec une fiche a 15 points",
                "Permet de relever un mort vivant avec une fiche a 18 points",
                "Permet de relever un mort vivant avec une fiche a 21 points",
                "Permet de relever un mort vivant avec une fiche a 24 points",
                "Permet de relever un mort vivant avec une fiche a 28 points",
                "Permet de relever un mort vivant avec une fiche a 32 points"
            ], [
                "Renvoies un mort vivant, lui effectuant 5 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 10 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 15 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 20 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 25 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 30 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 35 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 40 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 45 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 50 points de dégâts non réductibles",
                "Renvoies un mort vivant, lui effectuant 55 points de dégâts non réductibles",
            ]),
            new ArcaneEffect("Réparation", thresholds, [
                "L'objet mondain ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 1 minute du temps de réparation",
                "L'objet mondain ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 2 minute du temps de réparation",
                "L'objet mondain ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 3 minute du temps de réparation",
                "L'objet mondain ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 4 minute du temps de réparation",
                "L'objet mondain ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 5 minute du temps de réparation",
                "L'objet mondain ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 6 minute du temps de réparation",
                "L'objet magique mineur ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 7 minute du temps de réparation",
                "L'objet magique mineur ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 8 minute du temps de réparation",
                "L'objet magique intermédiaire ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 9 minute du temps de réparation",
                "L'objet magique intermédiaire ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 10 minute du temps de réparation",
                "L'objet magique majeur ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 11 minute du temps de réparation"
            ], [
                "L'objet mondain ciblé sera brisé pour la durée du sort. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet mondain ciblé sera brisé pour la durée du sort. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet mondain ciblé sera brisé pour la durée du sort. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet mondain ciblé sera brisé pour la durée du sort. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet mondain ciblé sera brisé pour la durée du sort. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet mondain ciblé sera brisé pour la durée du sort. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet magique mineur ciblé sera brisé pour la durée du sort. Lorsque le sort prends fin, les charges de l'objet lui sont retournées. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet magique mineur ciblé sera brisé pour la durée du sort. Lorsque le sort prends fin, les charges de l'objet lui sont retournées. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet magique intermédiaire ciblé sera brisé pour la durée du sort. Lorsque le sort prends fin, les charges de l'objet lui sont retournées. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet magique intermédiaire ciblé sera brisé pour la durée du sort. Lorsque le sort prends fin, les charges de l'objet lui sont retournées. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
                "L'objet magique majeur ciblé sera brisé pour la durée du sort. Lorsque le sort prends fin, les charges de l'objet lui sont retournées. Dans le cas ou cela causerait une destruction, le sort ne prends pas effet.",
            ]),
            new ArcaneEffect("Résistance à la magie", thresholds, [
                "Applique un nommbre de charges de DR1 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques magiques dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques magiques dépendant du modificateur Durée"
            ], [
                "La cible prends 1 dégât additionnel aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 1 dégât additionnel aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 1 dégât additionnel aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 2 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 2 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 2 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 3 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 3 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 3 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 4 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
                "La cible prends 4 dégâts additionnels aux prochaines attaques magiques reçues, le nombre dépends du modificateur Durée",
            ], true, [
                "Applique un nommbre de charges de DR1 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques de feu dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques de feu dépendant du modificateur Durée"
            ], [
                "Applique un nommbre de charges de DR1 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques de glace dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques de glace dépendant du modificateur Durée"
            ], [
                "Applique un nommbre de charges de DR1 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques de foudre dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques de foudre dépendant du modificateur Durée"
            ], [
                "Applique un nommbre de charges de DR1 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques d'acide dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques d'acide dépendant du modificateur Durée"
            ], [
                "Applique un nommbre de charges de DR1 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques bénies dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques bénies dépendant du modificateur Durée"
            ], [
                "Applique un nommbre de charges de DR1 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR1 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR2 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR3 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques maudites dépendant du modificateur Durée",
                "Applique un nommbre de charges de DR4 aux attaques maudites dépendant du modificateur Durée"
            ]),
            new ArcaneEffect("Serrure Magique", thresholds, [
                "Permet de créer une serrure magique mondaine, comme un loquet. Déverrouillable par n'importe qui pouvant déverrouiller une serrure en 5 secondes",
                "Permet de créer une serrure magique de Tiers 1.",
                "Permet de créer une serrure magique de Tiers 1.",
                "Permet de créer une serrure magique de Tiers 1.",
                "Permet de créer une serrure magique de Tiers 2.",
                "Permet de créer une serrure magique de Tiers 2.",
                "Permet de créer une serrure magique de Tiers 2.",
                "Permet de créer une serrure magique de Tiers 3.",
                "Permet de créer une serrure magique de Tiers 3.",
                "Permet de créer une serrure magique de Tiers 3.",
                "Permet de créer une serrure magique de Tiers 4."
            ]),
            new ArcaneEffect("Stimulant", thresholds, [
                "Permet à la cible d'effectuer une action complèxe pendant sa période de convalescence.",
                "Permet à la cible d'effectuer une action complèxe pendant sa période de convalescence.",
                "Permet à la cible d'effectuer une action complèxe pendant sa période de convalescence.",
                "Permet à la cible d'effectuer deux actions complèxes pendant sa période de convalescence.",
                "Permet à la cible d'effectuer deux actions complèxes pendant sa période de convalescence. Le convalescent possède +1 Max PV pendant sa période de convalescence.",
                "Permet à la cible d'effectuer deux actions complèxes pendant sa période de convalescence. Le convalescent possède +1 Max PV pendant sa période de convalescence.",
                "Permet à la cible d'effectuer trois actions complèxes pendant sa période de convalescence. Le convalescent possède +1 Max PV pendant sa période de convalescence.",
                "Permet à la cible d'effectuer trois actions complèxes pendant sa période de convalescence. Le convalescent possède +1 Max PV pendant sa période de convalescence.",
                "Permet à la cible d'effectuer trois actions complèxes pendant sa période de convalescence. Le convalescent possède +2 Max PV pendant sa période de convalescence.",
                "Permet à la cible d'effectuer quatre actions complèxes pendant sa période de convalescence. Le convalescent possède +2 Max PV pendant sa période de convalescence.",
                "Permet à la cible d'effectuer quatre actions complèxes pendant sa période de convalescence. Le convalescent possède +2 Max PV pendant sa période de convalescence.",
            ]),
            new ArcaneEffect("Suture", thresholds, [
                "Fait passer la cible de l'agonie à la convalescence.",
                "Fait passer la cible de l'agonie à la convalescence.",
                "Fait passer la cible de l'agonie à la convalescence.",
                "Fait passer la cible de l'agonie à la convalescence.",
                "Fait passer la cible de l'agonie à la convalescence. La cible possèdes +1 Max PV pendant sa convalescence",
                "Fait passer la cible de l'agonie à la convalescence. La cible possèdes +1 Max PV pendant sa convalescence",
                "Fait passer la cible de l'agonie à la convalescence. La cible possèdes +1 Max PV pendant sa convalescence",
                "Fait passer la cible de l'agonie à la convalescence. La cible possèdes +1 Max PV pendant sa convalescence",
                "Fait passer la cible de l'agonie à la convalescence. La cible possèdes +2 Max PV pendant sa convalescence",
                "Fait passer la cible de l'agonie à la convalescence. La cible possèdes +2 Max PV pendant sa convalescence",
                "Fait passer la cible de l'agonie à la convalescence. La cible possèdes +2 Max PV pendant sa convalescence",
            ], [
                "Fait passer la cible de la convalescence à l'agonie.",
                "Fait passer la cible de la convalescence à l'agonie.",
                "Fait passer la cible de la convalescence à l'agonie.",
                "Fait passer la cible de la convalescence à l'agonie.",
                "Fait passer la cible de la convalescence à l'agonie. Diminues le temps d'agonie de 15 minutes",
                "Fait passer la cible de la convalescence à l'agonie. Diminues le temps d'agonie de 15 minutes",
                "Fait passer la cible de la convalescence à l'agonie. Diminues le temps d'agonie de 15 minutes",
                "Fait passer la cible de la convalescence à l'agonie. Diminues le temps d'agonie de 25 minutes",
                "Fait passer la cible de la convalescence à l'agonie. Diminues le temps d'agonie de 25 minutes",
                "Fait passer la cible de la convalescence à l'agonie. Diminues le temps d'agonie de 25 minutes",
                "Fait passer la cible de la convalescence à la mort."
            ]),
            new ArcaneEffect("Transfusion", thresholds, [
                "Permet de souffrir de 2 PV pour guérir la cible de 1 PV.",
                "Permet de souffrir de 2 PV pour guérir la cible de 1 PV.",
                "Permet de souffrir de 4 PV pour guérir la cible de 2 PV.",
                "Permet de souffrir de 4 PV pour guérir la cible de 2 PV.",
                "Permet de souffrir de 6 PV pour guérir la cible de 3 PV. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 6 PV pour guérir la cible de 3 PV. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 8 PV pour guérir la cible de 4 PV. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 8 PV pour guérir la cible de 4 PV. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 10 PV pour guérir la cible de 5 PV. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 10 PV pour guérir la cible de 5 PV. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit. Permet de transférer une malédiction du lanceur à la cible si l'élément selectionné est maudit.",
                "Permet de souffrir de 12 PV pour guérir la cible de 6 PV. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit. Permet de transférer une malédiction du lanceur à la cible si l'élément selectionné est maudit."
            ], [
                "Permet de souffrir de 2 PM pour donner à la cible de 1 PM.",
                "Permet de souffrir de 2 PM pour donner à la cible de 1 PM.",
                "Permet de souffrir de 4 PM pour donner à la cible de 2 PM.",
                "Permet de souffrir de 4 PM pour donner à la cible de 2 PM.",
                "Permet de souffrir de 6 PM pour donner à la cible de 3 PM. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 6 PM pour donner à la cible de 3 PM. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 8 PM pour donner à la cible de 4 PM. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 8 PM pour donner à la cible de 4 PM. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 10 PM pour donner à la cible de 5 PM. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit.",
                "Permet de souffrir de 10 PM pour donner à la cible de 5 PM. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit. Permet de transférer une malédiction du lanceur à la cible si l'élément selectionné est maudit.",
                "Permet de souffrir de 12 PM pour donner à la cible de 6 PM. Permet de transférer une maladie du lanceur à la cible si l'élément sélectionné est maudit. Permet de transférer une malédiction du lanceur à la cible si l'élément selectionné est maudit."
            ]),
        ];
        SaveArcaneEffectsToFile();
    }

    private void InitializeShapeWords()
    {
        ShapeWords =
        [
            new ShapeWord("Tangere", "Touché", 1, School.Abjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Touché"))!),
            new ShapeWord("Or", "Projectile", 1, School.Conjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Projectile"))!),
            new ShapeWord("Dagal-Tag", "Touché", 1, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Touché"))!),
            new ShapeWord("Taka", "Touché", 1, School.Enchantment, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Touché"))!),
            new ShapeWord("Cacali", "Projectile", 1, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Projectile"))!),
            new ShapeWord("Nehte", "Projectile", 1, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Projectile"))!),
            new ShapeWord("Azien", "Touché", 1, School.Necromancy, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Touché"))!),
            new ShapeWord("Ipse", "Personnel", 2, School.Abjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Personnel"))!),
            new ShapeWord("Skjoldr", "Barrière", 2, School.Conjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Barrière"))!),
            new ShapeWord("Karmakaraganah", "Personnel", 2, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Personnel"))!),
            new ShapeWord("Ibil", "Émanation", 2, School.Enchantment, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Émanation"))!),
            new ShapeWord("Matoca", "Touché", 2, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Touché"))!),
            new ShapeWord("Sandastan", "Barrière", 2, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Barrière"))!),
            new ShapeWord("Xazong", "Émanation", 2, School.Necromancy, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Émanation"))!),
            new ShapeWord("Obice", "Barrière", 3, School.Abjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Barrière"))!),
            new ShapeWord("Veggr", "Mur", 3, School.Conjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Mur"))!),
            new ShapeWord("Kulam", "Assemblée", 3, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Assemblée"))!, true),
            new ShapeWord("Ti", "Projectile", 3, School.Enchantment, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Projectile"))!),
            new ShapeWord("Monenepiltie", "Pointé", 3, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Pointé"))!),
            new ShapeWord("Fuaorosta", "Émanation", 3, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Émanation"))!),
            new ShapeWord("Nosse", "Assemblée", 3, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Assemblée"))!, true),
            new ShapeWord("Rituali", "Rituel", 3, School.Abjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Rituel"))!, true),
            new ShapeWord("Sior", "Rituel", 3, School.Conjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Rituel"))!, true),
            new ShapeWord("Samskarah", "Rituel", 3, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Rituel"))!, true),
            new ShapeWord("Luh", "Rituel", 3, School.Enchantment, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Rituel"))!, true),
            new ShapeWord("Teocalli", "Rituel", 3, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Rituel"))!, true),
            new ShapeWord("Naham", "Rituel", 3, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Rituel"))!, true),
            new ShapeWord("Argedco", "Rituel", 3, School.Necromancy, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Rituel"))!, true),
            new ShapeWord("Pactum", "Contrat", 3, School.Abjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Contrat"))!, true),
            new ShapeWord("Bindanafn", "Contrat", 3, School.Conjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Contrat"))!, true),
            new ShapeWord("Prasamvida", "Contrat", 3, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Contrat"))!, true),
            new ShapeWord("Tesasike", "Contrat", 3, School.Enchantment, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Contrat"))!, true),
            new ShapeWord("Nenonotzalli", "Contrat", 3, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Contrat"))!, true),
            new ShapeWord("Esse-Sanye", "Contrat", 3, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Contrat"))!, true),
            new ShapeWord("Allardooain", "Contrat", 3, School.Necromancy, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Contrat"))!, true),
            new ShapeWord("Donatio", "Communion", 3, School.Abjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Communion"))!, true),
            new ShapeWord("Gipt", "Communion", 3, School.Conjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Communion"))!, true),
            new ShapeWord("Danam", "Communion", 3, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Communion"))!, true),
            new ShapeWord("Nigan-ba", "Communion", 3, School.Enchantment, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Communion"))!, true),
            new ShapeWord("Macoca", "Communion", 3, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Communion"))!, true),
            new ShapeWord("Anna", "Communion", 3, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Communion"))!, true),
            new ShapeWord("Daluga", "Communion", 3, School.Necromancy, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Communion"))!, true),
            new ShapeWord("Sphaera", "Dôme", 4, School.Abjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Dôme"))!),
            new ShapeWord("Dhyana", "Méditation", 4, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Méditation"))!),
            new ShapeWord("Yatra", "Voyage astral", 4, School.Divination, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Voyage astral"))!, true),
            new ShapeWord("Ixtlapal", "Ligne", 4, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Ligne"))!),
            new ShapeWord("Tepozmecayo", "Chaine", 4, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Chaîne"))!, true),
            new ShapeWord("Piocombe", "Essaim", 4, School.Illusion, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Essaim"))!, true),
            new ShapeWord("Ax", "Dôme", 4, School.Necromancy, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Dôme"))!),
            new ShapeWord("Bagielevithmong", "Essaim", 4, School.Necromancy, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Essaim"))!, true),
            new ShapeWord("Hlif", "Dôme", 5, School.Conjuration, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Dôme"))!),
            new ShapeWord("Tonam", "Faisceau", 5, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Faisceau"))!),
            new ShapeWord("Huel", "Intensification", 5, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Intensification"))!),
            new ShapeWord("Rinde", "Cercle", 5, School.Evocation, 1, 1, 1, ArcaneShapes.FirstOrDefault(s => s.Name.Equals("Cercle"))!),
        ];
        
        SaveShapeWordsToFile();
    }

    private void InitializeModifierWords()
    {
        ModifierWords =
        [
            new ModifierWord("Abiuratio", "Abjuration", 1, School.Abjuration, 1, 1, 1, null, false, true),
            new ModifierWord("Vitta", "Conjuration", 1, School.Conjuration, 1, 1, 1, null, false, true),
            new ModifierWord("Bhavisyavani", "Divination", 1, School.Divination, 1, 1, 1, null, false, true),
            new ModifierWord("Nam-sub", "Enchantement", 1, School.Enchantment, 1, 1, 1, null, false, true),
            new ModifierWord("Nahualhuia", "Évocation", 1, School.Evocation, 1, 1, 1, null, false, true),
            new ModifierWord("Sairinaemma", "Illusion", 1, School.Illusion, 1, 1, 1, null, false, true),
            new ModifierWord("Tempa", "Nécromancie", 1, School.Necromancy, 1, 1, 1, null, false, true),
            new ModifierWord("Terra", "Terre", 2, School.Abjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalAcide"))),
            new ModifierWord("Bal", "Feu", 2, School.Conjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalFeu"))),
            new ModifierWord("A", "Glace", 2, School.Enchantment, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalGlace"))),
            new ModifierWord("Tletl", "Feu", 2, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalFeu"))),
            new ModifierWord("Atl", "Glace", 2, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalGlace"))),
            new ModifierWord("Ehecameh", "Foudre", 2, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalFoudre"))),
            new ModifierWord("Cemanahuac", "Acide", 2, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalAcide"))),
            new ModifierWord("Vista", "Foudre", 2, School.Illusion, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalFoudre"))),
            new ModifierWord("Durationem", "Durée", 3, School.Abjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Durée"))),
            new ModifierWord("Lengra", "Distance", 3, School.Conjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Distance"))),
            new ModifierWord("Dhanya", "Béni", 3, School.Divination, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalBeni"))),
            new ModifierWord("Trijya", "Rayon", 3, School.Divination, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Rayon"))),
            new ModifierWord("Uz", "Distance", 3, School.Enchantment, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Distance"))),
            new ModifierWord("Tlamatiliz", "Rayon", 3, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Rayon"))),
            new ModifierWord("Amma", "Maudit", 3, School.Necromancy, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("ElementalMaudit"))),
            new ModifierWord("Amudas", "Sacrificiel", 3, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Sacrificiel"))),
            new ModifierWord("Reversal", "Inversion", 3, School.Abjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement")), true),
            new ModifierWord("Gagn", "Inversion", 3, School.Conjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement")), true),
            new ModifierWord("Viparyayam", "Inversion", 3, School.Divination, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement")), true),
            new ModifierWord("Ti-bala", "Inversion", 3, School.Enchantment, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement")), true),
            new ModifierWord("Kikepilie", "Inversion", 3, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement")), true),
            new ModifierWord("Nuquerna", "Inversion", 3, School.Illusion, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement")), true),
            new ModifierWord("Dlugalgemphl", "Inversion", 3, School.Necromancy, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement")), true),
            new ModifierWord("Vald", "Impact", 4, School.Conjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Impact"))),
            new ModifierWord("Avadhi", "Durée", 4, School.Divination, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Durée"))),
            new ModifierWord("Zur", "Sacrificiel", 4, School.Enchantment, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Sacrificiel"))),
            new ModifierWord("Huentica", "Sacrificiel", 4, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Sacrificiel"))),
            new ModifierWord("Alcarinde", "Rayon", 4, School.Enchantment, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Rayon"))),
            new ModifierWord("Coniunctio", "Combinaison", 5, School.Abjuration, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Combinaison"))),
            new ModifierWord("Viparitam", "Inversement", 5, School.Divination, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Inversement"))),
            new ModifierWord("Ipanti", "Cibles", 5, School.Evocation, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Cibles"))),
            new ModifierWord("Capimaon", "Durée", 5, School.Necromancy, 1, 1, 1, ArcaneModifiers.FirstOrDefault(m => m.Name.Equals("Durée")))
        ];
        
        SaveModifierWordsToFile();
    }

    private void InitializeEffectWords()
    {
        EffectWords =
        [
            new EffectWord("Tolerentia", "Tolérence", 1, School.Abjuration, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Endurance"))!),
            new EffectWord("Hitta", "Dégâts", 1, School.Conjuration, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dégâts physiques"))!),
            new EffectWord("Anvesanam", "Détection", 1, School.Divination, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Détection de la magie"))!),
            new EffectWord("Us", "Charme", 1, School.Enchantment, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Charme"))!),
            new EffectWord("Tlamati", "Dégâts", 1, School.Evocation, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dégâts magiques"))!),
            new EffectWord("Nurtale", "Dissimulation", 1, School.Illusion, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dissimulation"))!),
            new EffectWord("Saldteloch", "Revie", 1, School.Necromancy, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Relever les morts"))!),
            new EffectWord("Blans", "Inchangeant", 1, School.Necromancy, 1, 0.5f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Préservation"))!, true),
            new EffectWord("Dissipatio", "Dissipation", 2, School.Abjuration, 0.95f, 0.7f, 0.90f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dissipation de la magie"))!),
            new EffectWord("Sutura", "Suture", 2, School.Abjuration, 0.90f, 0.7f, 0.95f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Suture"))!),
            new EffectWord("Rota", "Enchevêtrement", 2, School.Conjuration, 1, 0.7f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Enchevêtrement"))!),
            new EffectWord("Marka", "Réparation", 2, School.Conjuration, 0.85f, 0.7f, 0.85f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Réparation"))!),
            new EffectWord("Purvajnanam", "Précognition", 2, School.Divination, 1.05f, 0.7f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Précognition"))!),
            new EffectWord("Suh", "Confusion", 2, School.Enchantment, 1.10f, 1, 0.7f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Confusion"))!),
            new EffectWord("Chicahualiztli", "Force", 2, School.Evocation, 1, 0.7f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Force"))!),
            new EffectWord("Unanwa", "Illusion", 2, School.Illusion, 1, 0.7f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Illusion"))!),
            new EffectWord("Ucaure", "Courage", 2, School.Illusion, 1.10f, 0.7f, 0.9f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Courage"))!),
            new EffectWord("Palve", "Drain", 2, School.Necromancy, 0.95f, 0.7f, 1.05f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Drain de vie"))!),
            new EffectWord("Zizopve", "Transfusion", 2, School.Necromancy, 1.05f, 0.7f, 1.20f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Transfusion"))!),
            new EffectWord("Cincinno", "Serrure", 3, School.Abjuration, 0.70f, 0.9f, 0.75f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Serrure Magique"))!, true),
            new EffectWord("Repgnantia", "Résistance", 3, School.Abjuration, 1f, 0.9f, 1.5f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Résistance à la magie"))!),
            new EffectWord("Alfhitta", "Dégâts", 3, School.Conjuration, 1.2f, 0.9f, 0.9f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dégâts physiques majeurs"))!, true),
            new EffectWord("Stefna", "Invocation", 3, School.Conjuration, 1.1f, 0.9f, 0.9f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Invocation"))!),
            new EffectWord("Avagamanam", "Compréhension", 3, School.Divination, 1, 0.9f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Compréhension des langues"))!),
            new EffectWord("Nig-sig-ga-umun", "Faiblesse", 3, School.Enchantment, 0.85f, 0.9f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Érosion de l'Esprit"))!),
            new EffectWord("Malafelme", "Dégâts", 3, School.Illusion, 1.2f, 0.9f, 1.1f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dégâts illusoires"))!),
            new EffectWord("Axa", "Maladie", 3, School.Necromancy, 0.95f, 0.9f, 1.05f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Maladie"))!),
            new EffectWord("Amudas", "Malédiction", 3, School.Necromancy, 1.05f, 0.9f, 0.8f, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Malédiction"))!),
            new EffectWord("Armatura", "Armure de Mage", 4, School.Abjuration, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Armure de mage"))!),
            new EffectWord("Paries", "Mur", 4, School.Abjuration, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Mur de vent"))!),
            new EffectWord("Bjooa", "Conjuration", 4, School.Conjuration, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Conjuration de ressources"))!, true),
            new EffectWord("Klofna", "Dissipation", 4, School.Conjuration, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dissipation"))!),
            new EffectWord("Naksatra", "Astres", 4, School.Divination, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Questionner les astres"))!),
            new EffectWord("Muru-umun", "Brouillard", 4, School.Enchantment, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Brouillard spirituel"))!),
            new EffectWord("Libir-umun", "Altération", 4, School.Enchantment, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Altération de la mémoire"))!, true),
            new EffectWord("Achitlamati", "Dégâts", 4, School.Evocation, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Dégâts magiques majeurs"))!),
            new EffectWord("Caure", "Peur", 4, School.Illusion, 1, 1 ,1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Peur"))!),
            new EffectWord("Furu", "Mensonge", 4, School.Illusion, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Mensonge"))!),
            new EffectWord("Atraah", "Armure", 4, School.Necromancy, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Armure d'os"))!),
            new EffectWord("Palzong", "Explosion", 4, School.Necromancy, 1, 1, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Explosion de Cadavres"))!, true),
            new EffectWord("Sjon", "Fixation", 5, School.Conjuration, 1, 1.2f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Fixation"))!),
            new EffectWord("Punarjanma", "Réincarnation", 5, School.Divination, 1, 1.2f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Réincarnation"))!),
            new EffectWord("An-ta-gal", "Domination", 5, School.Enchantment, 1, 1.2f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Domination"))!),
            new EffectWord("Mesmo", "Rage", 5, School.Evocation, 1, 1.2f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Rage des elements"))!),
            new EffectWord("Ulcasima", "Hallucination", 5, School.Illusion, 1, 1.2f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Hallucination"))!),
            new EffectWord("Drixugeg", "Flétrissement", 5, School.Necromancy, 1, 1.2f, 1, ArcaneEffects.FirstOrDefault(s => s.Name.Equals("Flétrissement"))!)
        ];
        
        SaveEffectWordsToFile();
    }

    private void InitializePowerWords()
    {
        PowerWords =
        [
            new PowerWord("Nox", "Nuit",2, School.Abjuration, 2, 2, 2),
            new PowerWord("Dies", "Jour", 2, School.Abjuration, 2, 2, 2),
            new PowerWord("Crepusculum", "Pénombre", 2, School.Abjuration, 2, 2, 2),
            new PowerWord("Initium", "Départ", 2, School.Abjuration, 2, 2, 2),
            new PowerWord("Ruber", "Rouge", 3, School.Abjuration, 3, 3, 3),
            new PowerWord("Flavus", "Jaune", 3, School.Abjuration, 3, 3, 3),
            new PowerWord("Caeruleum", "Bleu", 3, School.Abjuration, 3, 3, 3),
            new PowerWord("Nigreos", "Noir", 3, School.Abjuration, 3, 3, 3),
            new PowerWord("Alba", "Blanc", 3, School.Abjuration, 3, 3, 3),
            new PowerWord("Vita", "Vie", 4, School.Abjuration, 4, 4, 4),
            new PowerWord("Amare", "Amour", 4, School.Abjuration, 4, 4, 4),
            new PowerWord("Odium", "Haine", 4, School.Abjuration, 4, 4, 4),
            new PowerWord("Bibere",  "Boire", 4, School.Abjuration, 4, 4, 4),
            new PowerWord("Pueri", "Enfant", 4, School.Abjuration, 4, 4, 4),
            new PowerWord("Parentis", "Parent", 4, School.Abjuration, 4, 4, 4),
            new PowerWord("Edere", "Manger", 4, School.Abjuration, 4, 4, 4),
            new PowerWord("Corpus", "Corps", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Mens", "Esprit", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Animal", "Animal", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Morbus", "Maladie", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Sanguis", "Sang", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Lux", "Lumière", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Gravitas", "Gravité", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Mortem", "Mort", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Ignis", "Feu", 5, School.Abjuration, 5, 5, 5),
            new PowerWord("Elding", "Nuit", 2, School.Conjuration, 2, 2, 2),
            new PowerWord("Dagr", "Jour", 2, School.Conjuration, 2, 2, 2),
            new PowerWord("Eta", "Manger", 2, School.Conjuration, 2, 2, 2),
            new PowerWord("Supa", "Boire", 2, School.Conjuration, 2, 2, 2),
            new PowerWord("Reisa", "???", 2, School.Conjuration, 2, 2, 2),
            new PowerWord("Rauor", "Rouge", 3, School.Conjuration, 3,3,3),
            new PowerWord("Gull", "Jaune", 3, School.Conjuration, 3,3,3),
            new PowerWord("Blar", "Bleu", 3, School.Conjuration, 3,3,3),
            new PowerWord("Stena", "Couleur", 3, School.Conjuration, 3,3,3),
            new PowerWord("Hvitr", "Blanc", 3, School.Conjuration, 3,3,3),
            new PowerWord("Fjorlag", "Mort", 4, School.Conjuration, 4,4,4),
            new PowerWord("Aevi", "Vie", 4, School.Conjuration, 4,4,4),
            new PowerWord("Ljoss", "Lumière", 4, School.Conjuration, 4,4,4),
            new PowerWord("Kind", "Enfant", 4, School.Conjuration, 4,4,4),
            new PowerWord("Forellri", "Parent", 4, School.Conjuration, 4,4,4),
            new PowerWord("Kykvendi", "Animal", 4, School.Conjuration, 4,4,4),
            new PowerWord("Myrkr", "Pénombre", 4, School.Conjuration, 4,4,4),
            new PowerWord("Lik", "Corps", 5, School.Conjuration, 5,5,5),
            new PowerWord("Hyggiandi", "Esprit", 5, School.Conjuration, 5,5,5),
            new PowerWord("Standa", "Gravité", 5, School.Conjuration, 5,5,5),
            new PowerWord("Ast", "Amour", 5, School.Conjuration, 5,5,5),
            new PowerWord("Awnd", "Haine", 5, School.Conjuration, 5,5,5),
            new PowerWord("Sott", "Maladie", 5, School.Conjuration, 5,5,5),
            new PowerWord("Watn", "Eau", 5, School.Conjuration, 5,5,5),
            new PowerWord("Ratri", "Nuit", 2, School.Divination, 2, 2, 2),
            new PowerWord("Divasa", "Jour", 2, School.Divination, 2, 2, 2),
            new PowerWord("Godhuli", "Pénombre", 2, School.Divination, 2, 2, 2),
            new PowerWord("Khaditum", "Manger", 2, School.Divination, 2, 2, 2),
            new PowerWord("Patum", "Boire", 2, School.Divination, 2, 2, 2),
            new PowerWord("Aarambha","???", 2, School.Divination, 2, 2, 2),
            new PowerWord("Varna", "Couleur", 3, School.Divination, 3, 3, 3),
            new PowerWord("Rakta", "Rouge", 3, School.Divination, 3, 3, 3),
            new PowerWord("Pitam", "Jaune", 3, School.Divination, 3, 3, 3),
            new PowerWord("Nila", "Bleu", 3, School.Divination, 3, 3, 3),
            new PowerWord("Krishna", "Noir", 3, School.Divination, 3, 3, 3),
            new PowerWord("Svetah", "Blanc", 3, School.Divination, 3, 3, 3),
            new PowerWord("Amhati", "Maladie",4, School.Divination, 4, 4, 4),
            new PowerWord("Bala", "Enfant", 4, School.Divination, 4, 4, 4),
            new PowerWord("Matapitarau", "Parent", 4, School.Divination, 4, 4, 4),
            new PowerWord("Prema", "Amour", 4, School.Divination, 4, 4, 4),
            new PowerWord("Dvesti", "Haine", 4, School.Divination, 4, 4, 4),
            new PowerWord("Vayu", "Air", 4, School.Divination, 4, 4, 4),
            new PowerWord("Vadha", "Mort", 5, School.Divination, 5, 5, 5),
            new PowerWord("Ayu", "Vie", 5, School.Divination, 5, 5, 5),
            new PowerWord("Gurutvakarsanam", "Gravité", 5, School.Divination, 5, 5, 5),
            new PowerWord("Jala", "Eau", 5, School.Divination, 5, 5, 5),
            new PowerWord("Agni", "Feu", 5, School.Divination, 5, 5, 5),
            new PowerWord("Mahi", "Terre", 5, School.Divination, 5, 5, 5),
            new PowerWord("Dipika", "Lumière", 5, School.Divination, 5, 5, 5),
            new PowerWord("Pazu", "Animal", 5, School.Divination, 5, 5, 5),
            new PowerWord("Gig", "Nuit", 2, School.Enchantment, 2, 2, 2),
            new PowerWord("Uan", "Jour", 2, School.Enchantment, 2, 2, 2),
            new PowerWord("Gu","Manger", 2, School.Enchantment, 2, 2, 2),
            new PowerWord("Nag","Boire", 2, School.Enchantment, 2, 2, 2),
            new PowerWord("Dub-sag","???", 2, School.Enchantment, 2, 2, 2),
            new PowerWord("Nam-us", "Mort", 3, School.Enchantment, 3, 3, 3),
            new PowerWord("Nam-ti", "Vie", 3, School.Enchantment, 3, 3, 3),
            new PowerWord("Dumu", "Enfant", 3, School.Enchantment, 3, 3, 3),
            new PowerWord("Adda", "Parent", 3, School.Enchantment, 3, 3, 3),
            new PowerWord("Umamu", "Animal", 3, School.Enchantment, 3, 3, 3),
            new PowerWord("Sig", "Couleur", 4, School.Enchantment, 4, 4, 4),
            new PowerWord("Sa", "Rouge", 4, School.Enchantment, 4, 4, 4),
            new PowerWord("Ku", "Jaune", 4, School.Enchantment, 4, 4, 4),
            new PowerWord("Ni", "Bleu", 4, School.Enchantment, 4, 4, 4),
            new PowerWord("Ub-lil-la", "Noir", 4, School.Enchantment, 4, 4, 4),
            new PowerWord("Kug", "Blanc", 4, School.Enchantment, 4, 4, 4),
            new PowerWord("Zal", "Lumière", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Dim", "Maladie", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Gansis", "Pénombre", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Su", "Corps", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Gidim", "Esprit", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Dugud", "Gravité", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Nam-ki-aga", "Amour", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Hulgig", "Haine", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Izi", "Feu", 5, School.Enchantment, 5, 5, 5),
            new PowerWord("Toyoual", "Nuit", 2, School.Evocation, 2, 2, 2),
            new PowerWord("Tonali", "Jour", 2, School.Evocation, 2, 2, 2),
            new PowerWord("Cua", "Manger", 2, School.Evocation, 2, 2, 2),
            new PowerWord("Conia", "Boire", 2, School.Evocation, 2, 2, 2),
            new PowerWord("Peua", "???", 2, School.Evocation, 2, 2, 2),
            new PowerWord("Tlapalli", "Couleur", 3, School.Evocation, 3, 3, 3),
            new PowerWord("Chichiltic", "Rouge", 3, School.Evocation, 3, 3, 3),
            new PowerWord("Acoztic", "Jaune", 3, School.Evocation, 3, 3, 3),
            new PowerWord("Texotli", "Bleu", 3, School.Evocation, 3, 3, 3),
            new PowerWord("Catzahuac", "Noir", 3, School.Evocation, 3, 3, 3),
            new PowerWord("Iztatic", "Blanc", 3, School.Evocation, 3, 3, 3),
            new PowerWord("Ezatl", "Sang", 3, School.Evocation, 3, 3, 3),
            new PowerWord("Miquiliz", "Mort", 4, School.Evocation, 4, 4, 4),
            new PowerWord("Nemiliz", "Vie", 4, School.Evocation, 4, 4, 4),
            new PowerWord("Tlahuilli", "Lumière", 4, School.Evocation, 4, 4, 4),
            new PowerWord("Conepatini", "Pénombre", 4, School.Evocation, 4, 4, 4),
            new PowerWord("Pilli", "Enfant", 4, School.Evocation, 4, 4, 4),
            new PowerWord("Tatli", "Parent", 4, School.Evocation, 4, 4, 4),
            new PowerWord("Cocol", "Maladie", 5, School.Evocation, 5, 5, 5),
            new PowerWord("Yolcatl", "Animal", 5, School.Evocation, 5, 5, 5),
            new PowerWord("Nacayotl", "Corps", 5, School.Evocation, 5, 5, 5),
            new PowerWord("Yolilizo", "Esprit", 5, School.Evocation, 5, 5, 5),
            new PowerWord("Tomaloni", "Gravité", 5, School.Evocation, 5, 5, 5),
            new PowerWord("Altepermaitl", "Haine", 5, School.Evocation, 5, 5, 5),
            new PowerWord("Lome", "Nuit", 2, School.Illusion, 2, 2, 2),
            new PowerWord("Aure", "Jour", 2, School.Illusion, 2, 2, 2),
            new PowerWord("Mat", "Manger", 2, School.Illusion, 2, 2, 2),
            new PowerWord("Yulme", "Boire", 2, School.Illusion, 2, 2, 2),
            new PowerWord("Esse", "???", 2, School.Illusion, 2, 2, 2),
            new PowerWord("Quile", "Couleur", 3, School.Illusion, 3, 3, 3),
            new PowerWord("Aira", "Rouge", 3, School.Illusion, 3, 3, 3),
            new PowerWord("Malina", "Jaune", 3, School.Illusion, 3, 3, 3),
            new PowerWord("Luine", "Bleu", 3, School.Illusion, 3, 3, 3),
            new PowerWord("More", "Noir", 3, School.Illusion, 3, 3, 3),
            new PowerWord("Fana", "Blanc", 3, School.Illusion, 3, 3, 3),
            new PowerWord("Cale", "Lumière", 4, School.Illusion, 4, 4, 4),
            new PowerWord("Lilomea", "Pénombre", 4, School.Illusion, 4, 4, 4),
            new PowerWord("Hina", "Enfant", 4, School.Illusion, 4, 4, 4),
            new PowerWord("Nostar", "Parent", 4, School.Illusion, 4, 4, 4),
            new PowerWord("Qualme", "Mort", 4, School.Illusion, 4, 4, 4),
            new PowerWord("Coivie", "Vie", 4, School.Illusion, 4, 4, 4),
            new PowerWord("Caila", "???", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Hroa", "Corps", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Vilisse", "Esprit", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Saca", "Gravité", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Melme", "Amour", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Moc", "Haine", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Celva", "Animal", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Cemen", "Terre", 5, School.Illusion, 5, 5, 5),
            new PowerWord("Dosig", "Nuit", 2, School.Necromancy, 2, 2, 2),
            new PowerWord("Basgm", "Jour", 2, School.Necromancy, 2, 2, 2),
            new PowerWord("Arp", "Manger", 2, School.Necromancy, 2, 2, 2),
            new PowerWord("Talbo", "Boire", 2, School.Necromancy, 2, 2, 2),
            new PowerWord("Olpirt", "Lumière", 2, School.Necromancy, 2, 2, 2),
            new PowerWord("Iaod", "???", 2, School.Necromancy, 2, 2, 2),
            new PowerWord("Caosg", "Terre", 3, School.Necromancy, 3, 3, 3),
            new PowerWord("Zodinu", "Eau", 3, School.Necromancy, 3, 3, 3),
            new PowerWord("Malprg", "Feu", 3, School.Necromancy, 3, 3, 3),
            new PowerWord("Ovin", "Corps", 3, School.Necromancy, 3, 3, 3),
            new PowerWord("Gah", "Esprit", 3, School.Necromancy, 3, 3, 3),
            new PowerWord("Cnila", "Sang", 3, School.Necromancy, 3, 3, 3),
            new PowerWord("Lonsa", "???", 4, School.Necromancy, 4, 4, 4),
            new PowerWord("Med", "Rouge", 4, School.Necromancy, 4, 4, 4),
            new PowerWord("Iellou", "Jaune", 4, School.Necromancy, 4, 4, 4),
            new PowerWord("Gaiol", "Bleu", 4, School.Necromancy, 4, 4, 4),
            new PowerWord("Ual", "Noir", 4, School.Necromancy, 4, 4, 4),
            new PowerWord("Val", "Blanc", 4, School.Necromancy, 4, 4, 4),
            new PowerWord("Teloc", "Mort", 5, School.Necromancy, 5, 5, 5),
            new PowerWord("Gigipah", "Vie", 5, School.Necromancy, 5, 5, 5),
            new PowerWord("Xa", "Maladie", 5, School.Necromancy, 5, 5, 5),
            new PowerWord("Pash", "Enfant", 5, School.Necromancy, 5, 5, 5),
            new PowerWord("Exentaser", "Parent", 5, School.Necromancy, 5, 5, 5),
            new PowerWord("Levithmong", "Animal", 5, School.Necromancy, 5, 5, 5),
            new PowerWord("Ger", "Amour", 5, School.Necromancy, 5, 5, 5),
            new PowerWord("Gedger", "Haine", 5, School.Necromancy, 5, 5, 5)
        ];
        
        RandomizePowerWordValues();
        SavePowerWordsToFile();
    }
    
    private void RandomizePowerWordValues()
    {
        for (int i = 2; i <= 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                RandomizeTier(PowerWords.Where(p => p.Tier == i && p.School == (School)j).ToList());           
            }
        }

        int iterator = 0; 
        foreach (var word in PowerWords)
        {
            Console.WriteLine($"{iterator}) Word: {word.WordText}, Tier: {word.Tier}, Potentia: {word.Potentia}, Arcainum: {word.Arcainum}, Flux: {word.Flux}");
            iterator++;
        }
    }

    private void RandomizeTier(List<PowerWord> reducedList)
    {
        Random random = new Random();
        decimal potentiaSum = 0;
        decimal arcainumSum = 0;
        decimal fluxSum = 0;
        
        /*
        decimal rndPotentiaSum;
        decimal rndArcainumSum;
        decimal rndFluxSum;
        List<double> rndPotentia = new List<double>();
        List<double> rndArcainum = new List<double>();
        List<double> rndFlux = new List<double>();
        */
        
        for (int i = 0; i < reducedList.Count; i++)
        {
            reducedList[i].Potentia *= Math.Round((decimal)(random.NextDouble() * (1.4 - 0.6) + 0.6), 2);
            reducedList[i].Arcainum *= Math.Round((decimal)(random.NextDouble() * (1.4 - 0.6) + 0.6), 2);
            reducedList[i].Flux *= Math.Round((decimal)(random.NextDouble() * (1.4 - 0.6) + 0.6), 2);
        }
        
        /*
        foreach (var word in reducedList)
        {
            potentiaSum += word.Potentia;
            arcainumSum += word.Arcainum;
            fluxSum += word.Flux;
            rndPotentia.Add(random.NextDouble() * (1.3 - 0.7) + 0.7);
            rndArcainum.Add(random.NextDouble() * (1.3 - 0.7) + 0.7);
            rndFlux.Add(random.NextDouble() * (1.3 - 0.7) + 0.7);
        }
        
        rndPotentiaSum = (decimal)rndPotentia.Sum();
        rndArcainumSum = (decimal)rndArcainum.Sum();
        rndFluxSum = (decimal)rndFlux.Sum();
        
        for (int i = 0; i < reducedList.Count; i++)
        {
            reducedList[i].Potentia = Math.Round((decimal)rndPotentia[i] / rndPotentiaSum * potentiaSum, 2);
            reducedList[i].Arcainum = Math.Round((decimal)rndArcainum[i] / rndArcainumSum * arcainumSum, 2);
            reducedList[i].Flux = Math.Round((decimal)rndFlux[i] / rndFluxSum * fluxSum, 2);
        }
        */
    }

    private void ImportSpellsFromJson()
    {
        string jsonText = File.ReadAllText(JsonSpellInput);
        List<RawSpell> RawSpells = JsonConvert.DeserializeObject<List<RawSpell>>(jsonText);
        List<Spell> FullSpells = new List<Spell>();
        foreach (RawSpell spell in RawSpells)
        {
            Spell tempSpell = CreateNewSpell(spell); 
            FullSpells.Add(tempSpell);
        }
    }

    private void ImportSpellsFromString(string json)
    {
        List<RawSpell> RawSpells = JsonConvert.DeserializeObject<List<RawSpell>>(json);
        foreach (RawSpell spell in RawSpells)
        {
            Spell tempSpell = CreateNewSpell(spell);
            Spells.Add(new FormattedSpell(tempSpell));
        }
    }
    
    private Spell CreateNewSpell(RawSpell spell)
    {
        Spell newSpell = new Spell();
        try
        {
            foreach (string wordText in spell.Words)
            {
                Word actualWord = SearchWord(wordText);
                newSpell.Incantation.Add(actualWord);
            }

            newSpell.VerifyStructure(ShapeWords, EffectWords, PowerWords, ModifierWords);
        }
        catch (Exception ex)
        {
            newSpell.AdverseEffect = RandomizeAdverseEffect();
            newSpell.AdverseEffectReason = ex.Message;
            newSpell.Shape = new ArcaneShape("None", [], ["Spell failure // No shape"]);
            newSpell.ShapeTier = 0;
            newSpell.SpellDescription = $"{newSpell.AdverseEffect}: {newSpell.AdverseEffectReason}";
        }
        
        return newSpell;
    }

    private Word SearchWord(string text)
    {
        Word? currentWord;
        currentWord = PowerWords.Find(t => t.WordText == text);
        if (currentWord != null)
        {
            return currentWord;
        }
        currentWord = ShapeWords.Find(t => t.WordText == text);
        if (currentWord != null)
        {
            return currentWord;
        }
        currentWord = EffectWords.Find(t => t.WordText == text);
        if (currentWord != null)
        {
            return currentWord;
        }
        currentWord = ModifierWords.Find(t => t.WordText == text);
        if (currentWord != null)
        {
            return currentWord;
        }

        throw new FileNotFoundException("Word not found in current dictionary");
    }

    private string RandomizeAdverseEffect()
    {
        return "A mishap happened, please update method later";
    }
}