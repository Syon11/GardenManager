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
            new ArcaneEffect("Courage", thresholds, new List<string>([
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
                "Protèges contre les 4 prochaines instance de la condition Peur",
            ])),
            new ArcaneEffect("Dégâts illusoires", thresholds, new List<string>([
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
                "Cause encore 37 dégât dans les PVTs de la cible, vous avez atteint la limite de l'effet",
            ])),
            new ArcaneEffect("Dégâts magiques", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Dégâts magiques majeurs", thresholds, new List<string>([
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
                "Cause encore 20 dégât de type magique à la cible, vous avez atteint la limite de l'effet",
            ])),
            new ArcaneEffect("Dégâts physiques", thresholds, new List<string>([
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
                "Cause encore 11 dégât de non typés à la cible, vous avez atteint la limite de l'effet",
            ])),
            new ArcaneEffect("Dégâts physiques majeurs", thresholds, new List<string>([
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
                "Cause encore 20 dégât non typés à la cible, vous avez atteint la limite de l'effet",
            ])),
            new ArcaneEffect("Détection de la magie", thresholds, new List<string>([
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
                "Permet de détecter la magie environnante, ainsi que d'identifier des artefacts magique de puissance incroyable", 
            ])),
            new ArcaneEffect("Dissimulation", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Dissipation", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Dissipation de la magie", thresholds, new List<string>([
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
                "Causes la condition Disjonction à la cible, celle-ci dissipe TOUS les effets magiques sur la cible, et décharges TOUS ses objets magiques, sauf les artefacts. Si lancé sur un artefact, voir l'animation",
            ])),
            new ArcaneEffect("Domination", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Drain de vie", thresholds, new List<string>([
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
                "Causes 8 de dégât non réductible à la cible et restaures 8 de vie à l'utilisateur",
            ])),
            new ArcaneEffect("Envhevêtrement", thresholds, new List<string>([
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
                "Causes la condition \"Paralysie\" à la cible",
            ])),
            new ArcaneEffect("Endurance", thresholds, new List<string>([
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
                "Octroie à la cible 15 PVT",
            ])),
            new ArcaneEffect("Érosion de l'Esprit", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Explosion de Cadavres", thresholds, new List<string>([
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
                "Cause 3 de dégâts par cadavres aux personnage à portée de 5 pieds d'un des cadavres ciblés, maximum 11 cadavres",
            ])),
            new ArcaneEffect("Fixation", thresholds, new List<string>([
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
                "Si la cible est un extraplanaire, cause la condition \"Fixation 10\"",
            ])),
            new ArcaneEffect("Flétrissement", thresholds, new List<string>([
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
                "Cause à la cible la perte de 4 niveau de force et de 3 dégât physique",
            ])),
            new ArcaneEffect("Force", thresholds, new List<string>([
                "Avec un modificateur élémental: Cause un déplacement de 1 pas chez la cible. Sans: Aucun effet, pas assez de puissance",
                "Avec un modificateur élémental: Cause un déplacement de 2 pas chez la cible. Sans: Aucun effet, pas assez de puissance",
                "Avec un modificateur élémental: Cause un déplacement de 3 pas chez la cible. Sans: Aucun effet, pas assez de puissance",
                "Avec un modificateur élémental: Cause un déplacement de 4 pas chez la cible. Sans: Aucun effet, pas assez de puissance",
                "Avec un modificateur élémental: Cause un déplacement de 5 pas chez la cible. Sans: Cause la condition \"Renversement\" chez la cible",
                "Avec un modificateur élémental: Cause un déplacement de 6 pas chez la cible. Sans: Cause la condition \"Renversement\" chez la cible",
                "Avec un modificateur élémental: Cause un déplacement de 7 pas chez la cible. Sans: Cause la condition \"Renversement\" chez la cible",
                "Avec un modificateur élémental: Cause un déplacement de 8 pas chez la cible. Sans: Cause la condition \"Renversement\" chez la cible",
                "Avec un modificateur élémental: Cause un déplacement de 9 pas chez la cible. Sans: Cause la condition \"Renversement\" chez la cible",
                "Avec un modificateur élémental: Cause un déplacement de 10 pas chez la cible. Sans: Cause la condition \"Renversement\" et \"Enchevêtrement\" chez la cible",
                "Avec un modificateur élémental: Cause un déplacement de 11 pas chez la cible. Sans: Cause la condition \"Renversement\" et \"Enchevêtrement\" chez la cible",
            ])),
            new ArcaneEffect("Fureur des Éléments", thresholds, new List<string>([
                "La potentia n'a aucune incidence sur cet effet. Voir l'effet du modificateur élémentaire",
            ])),
            new ArcaneEffect("Hallucination", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Illusion", thresholds, new List<string>([
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
                "L'utilisateur crée une représentation visuelle de ce qu'il imagines et l'appose à la réalité. Seules les cibles du sort peuvent voir cette illusion",
            ])),
            new ArcaneEffect("Invocation", thresholds, new List<string>([
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
                "Permet d'invoquer une créature d'un plan inconnu, et étrange qui pourrait causer bien des effets à l'utilisateur. [Effet défini par l'animation au moment de la création du sort]",
            ])),
            new ArcaneEffect("Maladie", thresholds, new List<string>([
                "Afflige la cible avec une maladie Tier 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 1 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 2 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 3 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 3 [Maladie aléatoire choisie au moment de la création du sort]",
                "Afflige la cible avec une maladie Tier 3 [Maladie aléatoire choisie au moment de la création du sort]"
            ])),
            new ArcaneEffect("Malédiction", thresholds, new List<string>([
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 0 écus)",
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",               
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",               
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",               
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",               
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",               
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",               
                "Permet de maudire une cible, lui créant un effet mondain, roleplay uniquement avec une clause de libération matérielle seulement (Dépense, bris d'un matériel, somme monayable max 15 écus)",               
                "Permet de maudire une cible de manière insidieuse, lui créant un effet légèrement nuisible (-1 à une caractéristique choisie) et manifestant des éléments roleplay du choix de l'utilisateur. La clause n'est plus que matérielle, mais peut être fonctionnelle aussi. Ex: Aller vendre quelque chose, mentir à quelqu'un... Tant que ça ne blesse personne physiquement.",
                "Permet de maudire une cible de manière insidieuse, lui créant un effet légèrement nuisible (-1 à une caractéristique choisie) et manifestant des éléments roleplay du choix de l'utilisateur. La clause n'est plus que matérielle, mais peut être fonctionnelle aussi. Ex: Aller vendre quelque chose, mentir à quelqu'un... Tant que ça ne blesse personne physiquement.",
                "Permet de manifester une malédiction unique et ancienne, créant un effet distinct et handicapant à discuter avec l'animation après l'obtention du sort. La clause peut maintenant être une clause de vie, ex: La cible doit sacrifier un être cher, ou soi même, même. Peut nécessiter de tuer quelqu'un."
            ])), 
            new ArcaneEffect("Mensonge", thresholds, new List<string>([
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",               
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides et les esprits",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides, les esprits et les extraplanaires",
                "La cible de l'utilisateur est obligé de mentir lors de la prochaine question qu'on lui posera, n'affecte que les humanoides, les esprits et les extraplanaires"
            ])),
            new ArcaneEffect("Mur de force", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Peur", thresholds, new List<string>([
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
                "Cause la condition \"Mprt de Peur\" chez la cible, cette condition cause l'agonie si elle n'est pas évitée par une résistance a la peur",
            ])),
            new ArcaneEffect("Précognition", thresholds, new List<string>([
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
                "Permet d'esquiver l'apocalypse?",
            ])),
            new ArcaneEffect("Préservation", thresholds, new List<string>([
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
                "Le tier de pouvoir agit comme un exposant sur la durée. Tiers 10, permet d'éviter un effet de décomposition/compostage",
            ])),
            new ArcaneEffect("Questionner les astres", thresholds, new List<string>([
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
                "Le sort doit être lancé en présence d'animation, et ne peut être lancé en plein jour, qu'il pleuves ou non. Permet d'obtenir des réponses a ses questions en questionnant les astres avec une méthode de divination (Runes, tarot, etc...)",
            ])),
            new ArcaneEffect("Réincarnation", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Relever les morts", thresholds, new List<string>([
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
                "Permet de relever un mort vivant avec une fiche a 32 points",
            ])),
            new ArcaneEffect("Réparations", thresholds, new List<string>([
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
                "L'objet magique majeur ciblé sera réparé pour la durée du sort, un seul sort de réparation ne peut être actif en même temps par le même lanceur de sort. Peut aussi être utilisé lors du réel processus de réparation afin de retirer 11 minute du temps de réparation",
            ])),
            new ArcaneEffect("Résistance à la magie", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Serrure Magique", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Stimulant", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Suture", thresholds, new List<string>([
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
            ])),
            new ArcaneEffect("Transfusion", thresholds, new List<string>([
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

    private void RandomizeWordValues()
    {
        
    }
}