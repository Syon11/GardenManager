using System.ComponentModel;
using System.Runtime.CompilerServices;
using GardenManager.Model;
using GardenManager.Model.Arcane;
using Newtonsoft.Json;

namespace GardenManager.SpellMaker;

public class SpellManager
{
    public List<PowerWord> PowerWords { get; set; }
    public List<EffectWord> EffectWords { get; set; }
    public List<ModifierWord> ModifierWords { get; set; }
    public List<ShapeWord> ShapeWords { get; set; }
    public List<ArcaneEffect> ArcaneEffects { get; set; }
    public List<ArcaneShape> ArcaneShapes { get; set; }
    public List<ArcaneModifier> ArcaneModifiers { get; set; }

    public const string JsonShapes = "Shapes.json";
    public const string JsonEffects = "Effects.json";
    public const string JsonModifiers = "Modifiers.json"; 
    public const string JsonPowerWord = "PowerWord.json"; 
    public const string JsonEffectWord = "EffectWord.json"; 
    public const string JsonShapeWord = "ShapeWord.json"; 
    public const string JsonModifierWord = "ModifierWord.json";

    public SpellManager()
    {
        PowerWords = new List<PowerWord>();
        EffectWords = new List<EffectWord>();
        ModifierWords = new List<ModifierWord>();
        ShapeWords = new List<ShapeWord>();
        ArcaneEffects = new List<ArcaneEffect>();
        ArcaneShapes = new List<ArcaneShape>();
        ArcaneModifiers = new List<ArcaneModifier>();
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
            new ArcaneModifier("Rayon", [1, 10, 100],             
            [
                "Pas assez de potentia investie", 
                "Efficacité 1 PV pour 1 PM",
                "Efficacité 1 PV pour 2 PM",
                "Efficacité 1 PV pour 5 PM",
            ]),
        ];
    }

    private void InitializeArcaneEffects()
    {
        List<int> thresholds = new List<int>() {1, 2, 4, 8, 16, 32, 64, 128, 256, 512};
        ArcaneEffects =
        [
            new ArcaneEffect("Altération de la mémoire", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Armure du mage", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Armure d'os", thresholds, new List<string>([
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
                "L'effet Armure d'os permet d'encaisser la totalité des dégâts d'un coup. Maximum de 3 de coup encaissé, doit être joint avec le modificateur Durée.",
            ])),
            new ArcaneEffect("Brouillard spirituel", thresholds, new List<string>([
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
                "Donnes 4 instance de protection mentale.",
            ])),
            new ArcaneEffect("Charme", thresholds, new List<string>([
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
                "Cause un effet de Charme sur la cible. La cible est obsédée par le lanceur et boit ses mots.",
            ])),
            new ArcaneEffect("Communion avec les esprits", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Compréhension des langues", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Compulsion", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Confusion", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Conjuration de ressources", thresholds, new List<string>([
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
            ])),
        ];
    }

    private void InitializeShapeWords()
    {

    }

    private void InitializeModifierWords()
    {

    }

    private void InitializeEffectWords()
    {

    }

    private void InitializePowerWords()
    {

    }
}