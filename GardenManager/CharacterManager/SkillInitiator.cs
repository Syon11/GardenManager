using GardenManager.Model;

namespace GardenManager.CharacterManager;

public class SkillInitiator
{
    public List<Competence> MartialT1 { get; set; }
    public List<Competence> MartialT2 { get; set; }
    public List<Competence> SpecialistT1 { get; set; }
    public List<Competence> SpecialistT2 { get; set; }
    public List<Competence> ArcaneT1 { get; set; }
    public List<Competence> ArcaneT2 { get; set; }
    public List<Competence> WeaponMasterT3 { get; set; }
    public List<Competence> WeaponMasterT4 { get; set; }
    public List<Competence> WeaponMasterT5 { get; set; }
    public List<Competence> DefenderT3 { get; set; }
    public List<Competence> DefenderT4 { get; set; }
    public List<Competence> DefenderT5 { get; set; }
    public List<Competence> ArcherT3 { get; set; }
    public List<Competence> ArcherT4 { get; set; }
    public List<Competence> ArcherT5 { get; set; }
    public List<Competence> TacticianT3 { get; set; }
    public List<Competence> TacticianT4 { get; set; }
    public List<Competence> TacticianT5 { get; set; }
    public List<Competence> SamuraiT3 { get; set; }
    public List<Competence> SamuraiT4 { get; set; }
    public List<Competence> SamuraiT5 { get; set; }
    public List<Competence> GunnerT3 { get; set; }
    public List<Competence> GunnerT4 { get; set; }
    public List<Competence> GunnerT5 { get; set; }
    public List<Competence> BarbarianT3 { get; set; }
    public List<Competence> BarbarianT4 { get; set; }
    public List<Competence> BarbarianT5 { get; set; }
    public List<Competence> BardT3 { get; set; }
    public List<Competence> BardT4 { get; set; }
    public List<Competence> BardT5 { get; set; }
    public List<Competence> TrapperT3 { get; set; }
    public List<Competence> TrapperT4 { get; set; }
    public List<Competence> TrapperT5 { get; set; }
    public List<Competence> RogueT3 { get; set; }
    public List<Competence> RogueT4 { get; set; }
    public List<Competence> RogueT5 { get; set; }
    public List<Competence> TechnicianT3 { get; set; }
    public List<Competence> TechnicianT4 { get; set; }
    public List<Competence> TechnicianT5 { get; set; }
    public List<Competence> CharlatanT3 { get; set; }
    public List<Competence> CharlatanT4 { get; set; }
    public List<Competence> CharlatanT5 { get; set; }
    public List<Competence> InquisitorT3 { get; set; }
    public List<Competence> InquisitorT4 { get; set; }
    public List<Competence> InquisitorT5 { get; set; }
    public List<Competence> ArcaneCommonsT3 { get; set; }
    public List<Competence> ArcaneCommonsT4 { get; set; }
    public List<Competence> ArcaneCommonsT5 { get; set; }
    public List<Competence> ArchmageT3 { get; set; }
    public List<Competence> ArchmageT4 { get; set; }
    public List<Competence> ArchmageT5 { get; set; }
    public List<Competence> SorcererT3 { get; set; }
    public List<Competence> SorcererT4 { get; set; }
    public List<Competence> SorcererT5 { get; set; }
    public List<Competence> EcclesiasticT3 { get; set; }
    public List<Competence> EcclesiasticT4 { get; set; }
    public List<Competence> EcclesiasticT5 { get; set; }
    public List<Competence> ArtificerT3 { get; set; }
    public List<Competence> ArtificerT4 { get; set; }
    public List<Competence> ArtificerT5 { get; set; }
    public List<Competence> MonkT3 { get; set; }
    public List<Competence> MonkT4 { get; set; }
    public List<Competence> MonkT5 { get; set; }
    public List<Competence> ShamanT3 { get; set; }
    public List<Competence> ShamanT4 { get; set; }
    public List<Competence> ShamanT5 { get; set; }

    public SkillInitiator()
    {
        MartialT1 =
        [
            new Competence(0, "Athlète",
                "Après chaque repas, le personnage récupère un total de 4 PV. Cette compétence est utilisable un maximum de trois (3) fois par jour. Le repas est désigné par un moment d'au moins 15 minutes au repos pour s'alimenter.",
                [
                    new Variant(
                        " L’utilisateur peut maintenant prendre un repas en 5 minutes, mais ne récupère que 2 PV. "),
                    new Variant(
                        "L’utilisateur peut partager son repas avec un autre joueur. Si les délais sont respectés, les deux joueurs se soignent de 3 PV. Il n'est pas possible de prendre part à plusieurs repas en même temps si plusieurs joueurs ont cette variante."),
                    new Variant(
                        "En plus, l’utilisateur peut, trois (3) fois par jour, prendre une pause d’une minute afin de boire de l'eau. Après la pause et le breuvage, il récupère 1 PV. ")
                ]),
            new Competence(1, "Attaque en puissance",
                "L'utilisateur peut, une fois par combat, donner un coup puissant. Ce coup inflige +2 dégâts (actifs). Ne fonctionne qu'avec des armes de corps à corps.",
                [
                    new Variant("Permet d'utiliser la compétence (deux) 2 fois par combat."),
                    new Variant("Permet d'utiliser la compétence (deux) 2 fois par combat."),
                    new Variant(
                        "Si l'attaque en puissance touche une jambe ou un bras, le coup cause un Engourdissement de 10 secondes. ")
                ],
                "« Attaque en puissance X, [Engourdissement (Si Variante 3)] »"),
            new Competence(2, "Dégagement",
                "L’utilisateur peut, une fois par combat, utiliser son bouclier pour repousser un ennemi qui est à sa portée, le forçant ainsi à reculer de 5 pas. L’utilisateur doit simuler l’action.",
                [
                    new Variant("Permet d'utiliser la compétence deux (2) fois par combat. "),
                    new Variant(
                        "En plus d'être repoussée de 5 pas, la cible subit un Renversement (voir Renversement.)"),
                    new Variant("Une fois la compétence utilisée, l'utilisateur gagne 3 PVT pour la durée du combat.")
                ],
                "Citer « Dégagement X pas, [Renversement (Variante 2)] »"),
            new Competence(3, "Désarmement",
                "L'utilisateur peut, une fois par combat, désarmer sa cible. Si la frappe touche une arme tenue par un joueur, ce dernier doit laisser tomber l'arme en question. La compétence est utilisable par les armes à projectile.",
                [
                    new Variant(
                        "Le « Désarmement » peut affecter un bouclier. L’utilisateur doit citer « Désarmement de Bouclier »"),
                    new Variant("Permet d'utiliser la compétence deux (2) fois par combat."),
                    new Variant(
                        "Après un désarmement, réussi ou non, la prochaine attaque faite par l’utilisateur cause +1 dégât actif.")
                ],
                "Citer « Désarmement » "),
            new Competence(4, "Entretien d’armure",
                "L’utilisateur peut prendre 30 secondes, sans être dérangé, afin de réparer sommairement une pièce d'armure qui possède le statut « Brisée ». Ceci retire le statut « Brisé » jusqu'à la prochaine fin de combat. Cette compétence ne permet pas à l'armure de récupérer ses propriétés magiques. La pièce sommairement réparée donne seulement une 1 x DR1, peu importe le type d’armure. Ainsi, un torse d'armure lourde ne va donner qu'une seule DR1. Une pièce d'armure peut être sommairement réparée une seule fois ; après, elle doit obtenir une véritable réparation.",
                [
                    new Variant(
                        "De plus, l’utilisateur peut réparer lui-même son armure sans posséder de compétence de Forgeron. Par contre, cela lui prendra le double du temps et 2 unités de réparation d’armure (voir compétence Forge). Fonctionne seulement pour les pièces d’armure faites avec des matériaux de tiers 2 et moins."),
                    new Variant(
                        "Une pièce d'armure peut être sommairement réparée 1 fois de plus (total de 2) avant de nécessiter une vraie réparation. "),
                    new Variant(
                        "Les pièces sommairement réparées conservent leur DR d'origine. La DR d’origine est telle que si la pièce d’armure était faite de fer (voir compétence Forge). Les effets magiques ne se réactivent pas suivant cette variante.")
                ]),
            new Competence(5, "Maintenance de combat",
                "L’utilisateur peut prendre 15 secondes, sans être dérangé, afin d’effectuer sommairement une réparation sur une arme qui possède le statut « Brisée ».  Ceci retire le statut « Brisé » jusqu'à la prochaine fin de combat. Cette compétence ne permet pas à l'arme de récupérer ses propriétés magiques. L’arme ainsi entretenue inflige 1 dégât de moins (minimum 1).  L’arme peut être sommairement réparée une seule fois ; après, elle doit obtenir une véritable réparation.",
                [
                    new Variant("L’arme sommairement réparée conservent ses dégâts de base."),
                    new Variant(
                        "L’arme continue de bénéficier de ses propriétés magiques lorsque sommairement réparée par cette compétence et maintient le niveau de charge qu’elle avait avant la brisure."),
                    new Variant(
                        "La réparation peut être effectuée en 3 secondes et en combat (l’utilisateur doit mimer l’action).")
                ]),
            new Competence(6, "Poigne de fer", "L'utilisateur peut, une fois par combat, résister à un désarmement.",
                [
                    new Variant(
                        "De plus, une fois par scénario, l'utilisateur peut être immunisé aux désarmements durant toute la durée d’un combat. L’utilisation de la compétence doit être déclarée par l’utilisateur."),
                    new Variant(
                        "L'utilisateur peut utiliser « Poigne de fer » une fois de plus par combat pour un total de 2 fois."),
                    new Variant(
                        "En addition, 3 fois par scénario, le détenteur de la compétence « Poigne de fer » peut décider de ne pas relâcher sa prise sur un objet tenu dans sa main, peu importe l'effet physique qui lui ferait lâcher/donner l'objet en question. Cette résistance fonctionne aussi sur les effets mentaux.")
                ],
                "« Poigne de fer, [Désarmement (Variante 1)] »"),
            new Competence(7, "Premiers soins",
                "Permet à l'utilisateur de consommer un kit de premiers soins afin de stabiliser une personne agonisante. L'application prend 2 minutes et remet le joueur à 1 PV. Cette habileté donne aussi au joueur 3 kits de premiers soins au début du premier scénario suivant l’obtention de la compétence.",
                [
                    new Variant("Le temps de convalescence de la cible est réduit de 10 minutes."),
                    new Variant(
                        "Donne à la cible 3 PV à la fin de sa convalescence. Ce bonus n’est pas applicable si la cible retombe à l’agonie ou meurt à nouveau."),
                    new Variant(
                        "Les premiers soins prodigués par l'utilisateur permettent à sa cible d'effectuer UNE action difficile durant un maximum de 2 minutes pendant sa convalescence sans provoquer l’agonie. En situation de combat, la personne en convalescence doit mentionner qu'elle a reçu cette variante de premiers soins.")
                ],
                "Aviser le joueur des conditions de sa convalescence."),
            new Competence(8, "Préparatifs",
                "Permet à l'utilisateur de prendre 5 minutes afin de préparer une arme de corps-à-corps. Une arme préparée inflige +1 dégât de base pour les 2 premiers coups lors du prochain combat. Un joueur peut utiliser cette compétence autant de fois qu'il le désire, mais ne peut pas avoir plus de 2 armes préparées en même temps. Il est possible d'utiliser « Préparatifs » sur une arme et que celle-ci soit utilisée par un autre joueur, mais cette arme fait partie du maximum de 2 armes préparées en même temps. Une arme perd son statut  « Préparée » à la fin du combat où l'arme a été utilisée.",
                [
                    new Variant(
                        "Les armes préparées ont aussi une résistance contre un (1) brise-arme pour la durée du combat où elle est utilisée. "),
                    new Variant("Permet d'utiliser la compétence « Préparatifs » en 1 minute."),
                    new Variant("Permet d'avoir 2 armes préparées de plus que le maximum de base, soit un total de 4.")
                ]),
            new Competence(9, "Robustesse", "Bonus de + 1 PV Max.",
            [
                new Variant(
                    "De plus, l’utilisateur peut, une fois par scénario, prendre une heure au repos (sans combat, activité complexe ou création d’objet) pour se soigner de la moitié de ses max PV."),
                new Variant("Le bonus passe de +1 PV max  à +2 max PV."),
                new Variant(
                    "De plus, l’utilisateur peut, une fois par scénario, décider de DOUBLER la quantité de soin reçu venant d'une source quelconque.")
            ]),
        ];
        MartialT2 =
        [
            new Competence(10, "Alerte",
                "L’utilisateur peut, une fois par jour, utiliser la compétence « Presquive » sans variante. De plus, l’utilisateur peut, deux (2) fois par scénario, réduire de moitié les dégâts reçus par un piège.",
                [
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par jour, esquiver complètement un piège. Il peut également donner ce bénéfice à une autre cible. Ainsi, la cible ne recevra aucun dégât, et l’utilisateur recevra les dégâts réduits de moitié."),
                    new Variant("Permet d'utiliser la compétence « Presquive » deux (2) fois par jour."),
                    new Variant(
                        "La « Presquive » est utilisable sur les catalyseurs de sorts pour en réduire les dégâts de 3 (minimum 0). Les effets associés à l’attaque par « Presquive » s’appliquent même si l’attaque n’inflige pas de dégâts.")
                ], "Citer « Esquive, [Résiste (Variante 3)] »"),
            new Competence(11, "Apprenti Fusilier",
                "Permet à un utilisateur d’arme à feu de garder quelques balles d’une arme enregistrée afin de les utiliser lors du début d’un prochain scénario. Le fusilier pourra ainsi utiliser son arme lors du premier jour de l’évènement (jusqu’à samedi matin 8h) même si elle n’est pas enregistrée, tant qu’elle l’ait été lors du scénario précédent. S’il désire l’utiliser par la suite, il devra l’enregistrer auprès du magasinier.",
                [
                    new Variant(
                        "De plus, l’utilisateur peut, UNE SEULE FOIS, s’endetter du coût total de l’enregistrement pour utiliser son arme à feu standard. Il devra rembourser cette dette avant de pouvoir à nouveau utiliser une arme à feu au scénario suivant, ou de contracter une nouvelle dette."),
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, augmenter les dégâts de son arme à feu de +1 dégâts passifs pour la durée d’un combat. À la fin de ce dernier, l’arme à feu devient « Brisée » et perd son enregistrement."),
                    new Variant(
                        "L’utilisateur peut, une fois par jour, obtenir un bonus de +2 dégâts actifs pour 1 coup. Ce tir sera aussi perce-armure.  L’utilisateur doit citer « Perce-Armure » suite à ses dégâts.")
                ], "Citer « Perce-armure (Variante 3) »"),
            new Competence(12, "Brise-arme",
                "L'utilisateur peut, trois (3) fois par scénario, lorsqu'il frappe, déclarer un « Brise-arme ».  Si la frappe touche l’arme, cette dernière gagne la condition « Brisée » et devient inutilisable. La compétence est utilisable par les armes à projectiles.",
                [
                    new Variant(
                        "L'utilisateur peut utiliser « Brise-arme » une (1) fois de plus par scénario, pour un total de 4 fois. De plus, l’utilisateur peut tronquer un (1) de ses usages pour contrer un « brise-arme » reçu."),
                    new Variant("Le nombre d'utilisations devient maintenant d'une (1) fois par combat."),
                    new Variant(
                        "Lors de l'utilisation de la compétence, si le joueur rate sa cible, il ne perd pas l'utilisation. Si la frappe ne fonctionne pas, car l'objet est indestructible ou que le coup est résisté, l'utilisateur perd une utilisation.")
                ], "Citer « Brise-Arme »"),
            new Competence(13, "Brise-armure",
                "L'utilisateur peut, 6 fois par scénario, lorsqu'il frappe avec une arme de corps-à-corps, déclarer un « Brise-Armure » ainsi que ses dégâts. Si la frappe touche une section d'armure de la cible (Tête/bras, Torse, Jambe), la pièce d'armure couvrant cette section gagne la condition « Brisée ».",
                [
                    new Variant(
                        "La frappe faite lors d’une utilisation de « Brise-armure » a un bonus de dégât +1 actif. "),
                    new Variant(
                        "Le nombre d'utilisations passe à deux (2) fois par combat, au lieu de 6 fois par scénario."),
                    new Variant(
                        "L'utilisateur peut troquer une (1) des ses utilisations de « Brise-armure » pour assommer une victime avec le pommeau de son arme et la rendre inconsciente. La manœuvre ne peut être utilisée que hors-combat ou sur une victime ne pouvant se défendre. La condition Assommement dure 15 minutes, ou jusqu’à ce que la cible soit à nouveau frappée, ou réveillée.")
                ], "Citer « Brise-armure »"),
            new Competence(14, "Brise-bouclier",
                "L'utilisateur peut, cinq (5) fois par scénario, déclarer un « Brise-bouclier » lorsqu'il frappe avec une arme de corps-à-corps. Si la frappe touche un bouclier, ce dernier gagne la condition « Brisé » et devient inutilisable.",
                [
                    new Variant(
                        "Permet à l'utilisateur d'utiliser « Brise-Bouclier » avec une arme à projectile (fusil, arc, arbalète, etc.)."),
                    new Variant(
                        "Le nombre d'utilisations passe de cinq (5) fois par scénario à sept (7) fois par scénario."),
                    new Variant(
                        "Lorsque l'utilisateur réussit à briser un bouclier, il gagne 2 PVT pour la durée du combat.")
                ], "Citer « Brise-bouclier »"),
            new Competence(15, "Colère",
                "L’utilisateur peut, une (1) fois par jour ET lorsque ses PV sont en dessous de 3, utiliser la compétence « Colère ». Il gagne 3 PVT pour la durée du combat et peut se sortir d’un effet entravant ses mouvements. Attention, le fait d’être physiquement attaché ou entravé par un objet tangible n’est pas un effet.",
                [
                    new Variant("L'effet peut être utilisé en dessous de 6 PV plutôt que 3."),
                    new Variant("L'utilisateur gagne 4 PVT plutôt que 3."),
                    new Variant(
                        "Le nombre d’utilisations par jour passe de une (1) fois à deux (2) fois. Un délai d’une (1) heure doit être alloué entre les deux utilisations.")
                ]),
            new Competence(16, "Frappe agile",
                "L'utilisateur peut, une (1) fois par combat, réaliser une frappe « Perce-Armure » et elle ne peut pas être esquivée.",
                [
                    new Variant(
                        "Si l'utilisateur a une arme à une main et que sa seconde main est vide, l'utilisation de « Frappe agile » inflige un bonus de +2 dégâts actifs."),
                    new Variant("Le nombre d’utilisations passe d'une (1) fois par combat à deux (2) fois par combat."),
                    new Variant(
                        "Si la « Frappe Agile » touche sa cible, l'utilisateur gagne un (1) usage de la compétence « Presquive », sans variante, pour la durée du combat.")
                ], "Citer « Perce-armure, inesquivable »."),
            new Competence(17, "Résistance",
                "L’utilisateur peut, deux (2) fois par scénario, résister partiellement à une condition entravant son mouvement (Paralysie, Ralentissement, Tremblement, etc). L'utilisation d'une charge permet de réduire de moitié la durée de l'effet. L'utilisation des deux charges permet d’arrêter complètement l’effet. Attention, le fait d’être physiquement attaché ou entravé par un objet tangible n’est pas un effet. De plus, la compétence n’annule aucun dégât ou effet n’entravant pas le mouvement.",
                [
                    new Variant("Le nombre d’utilisations par scénario passe de deux (2) fois à quatre (4) fois. "),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par scénario, recevoir un bonus de 5 PVT jusqu’à la prochaine fin de combat."),
                    new Variant("De plus, le maximum de PV du joueur augmente de +1 PV. ")
                ], "Citer « Résiste »"),
            new Competence(18, "Rituel du guerrier",
                "L'utilisateur peut faire un « Rituel du guerrier ». Ce rituel est une procédure rattachée au jeu de rôle, qui amène l'utilisateur à atteindre un état d'esprit le préparant au combat. Le rituel doit durer un minimum de 5 minutes durant lesquelles l'utilisateur effectue une action afin d’atteindre l’état d’esprit désiré. Ainsi, un pourrait méditer afin d’atteindre un niveau de concentration hors-pair, alors qu'un autre pourrait faire la fête pour se dégourdir. L'important est que le rituel se déroule à l’extérieur d’un combat, est joué adéquatement et qu’il mène à un état d’esprit autre que celui initial. Lorsque l'utilisateur termine son rituel, il gagne, pour la prochaine heure OU jusqu'à ce qu'il perde son état d'esprit (par exemple, s’il reçoit un effet mental), l'un des bonus suivants : \nImmunité à UNE (1) effet mental ou de Peur ;\nImmunité à la douleur (mais pas aux dégâts) pour les coups de 1 dégât ; \nLa possibilité d’esquiver complètement UNE (1) attaque physique.",
                [
                    new Variant("Double la quantité d'usage d'un effet du « Rituel du guerrier »."),
                    new Variant("Permet de prendre deux (2) effets, plutôt qu'un seul."),
                    new Variant(
                        "Permet de faire le rituel avec deux autres personnes pour que celles-ci bénéficient du même bonus que l'utilisateur.")
                ]),
            new Competence(19, "Tir précis",
                "L’utilisateur peut, une (1) fois par combat, prendre 3 secondes afin de poser le genou au sol et viser avant de décocher un « Tir précis ». Le « Tir précis »  inflige un bonus de +2 dégâts actifs.",
                [
                    new Variant("Le « Tir Précis » n'est pas esquivable par une compétence."),
                    new Variant("Le « Tir Précis » inflige +4 dégâts au lieu du +2 actifs."),
                    new Variant(
                        "De plus, l’utilisateur peut, une (1) fois par scénario, utiliser « Tir Précis » sans mettre le genou au sol et attendre 3 secondes.")
                ], "Citer « Inesquivable (Variante 1) »"),
            new Competence(20, "Vigueur", "Le nombre maximum des PV du joueur sont augmentés de +2 PV.",
            [
                new Variant("L’utilisateur obtient un bonus de +1 PV Max pour un total de 3."),
                new Variant(
                    "De plus, l’utilisateur peut, une fois par scénario, résister à un effet négatif reçu par une potion."),
                new Variant("De plus, l’utilisateur obtient un bonus de +3 PVT Max.")
            ], 9)
        ];
        WeaponMasterT3 =
        [
            new Competence(21, "Arme de prédilection",
                "Lors de l'acquisition de cette compétence, le joueur désigne une (1) arme spécifique qui va devenir son arme de prédilection. Une fois ce choix fait, le joueur doit attendre le prochain scénario s’il souhaite modifier son choix. Lorsque le joueur combat avec l’arme choisie, ce dernier peut sacrifier 1 PV à chaque fois qu'il subit un effet « Désarmement » ou « Brise-arme » sur son arme de prédilection afin d’ignorer l'effet. Le joueur ne peut sacrifier de PVT pour activer cet effet.",
                [
                    new Variant(
                        "De plus, si l’arme choisie reçoit un « Brise-arme », l’arme de l’adversaire subit un « Brise-arme » aussi."),
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, sacrifier la moitié de son maximum de PV pour changer d'arme de prédilection instantanément. Ces PV sont récupérés après une nuit de sommeil seulement."),
                    new Variant(
                        "Chaque fois que l’utilisateur sacrifie 1 PV pour résister à un effet « Désarmement » ou « Brise-arme » sur son arme de prédilection, ce dernier gagne 1 PVT pour la durée du combat.")
                ], "Arme de prédilection, [Brise-arme (Si variante 1)]"),
            new Competence(22, "Force", "L'utilisateur gagne 1 niveau de force.",
            [
                new Variant("Bonus de + 1 PV Max."),
                new Variant("De plus, l’utilisateur peut, une fois par jour, résister à un « Désarmement »."),
                new Variant(
                    "De plus, l’utilisateur peut, une fois par jour, lors d’une situation hors-combat, briser une pièce d'équipement non-magique de façon en le jouant.")
            ], "Citer « Résiste Désarmement (Variante 2) »"),
            new Competence(23, "Parade",
                "L'utilisateur peut, une fois par combat, déclarer une parade avec une arme. Une parade permet de bloquer avec l'arme en main un coup physique (arme, flèche, balle d'arme à feu). Cependant, un effet visant l’arme en main (un  « Brise-arme » par exemple) va fonctionner même si le coup porteur est paré. La compétence doit être citée lors de l’utilisation. Un mouvement doit être tenté même s’il ne parade pas réellement l’attaque.",
                [
                    new Variant(
                        "Bonus de + 2 PVTs pour la durée du combat si la parade est réellement tentée avec succès."),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par jour, parer un sort qui occasionne des dégâts, les effets s’appliquent tout de même."),
                    new Variant("Permet de bloquer les effets visant l'arme aussi (un « Brise-arme » par exemple).")
                ], "Citer « Parade »"),
            new Competence(24, "Second Souffle",
                "L’utilisateur peut, une fois par scénario, réduire son temps de convalescence à 5 minutes totales.",
                [
                    new Variant("De plus, suite à cette convalescence, le joueur se soigne de 2 PV."),
                    new Variant(
                        "Les PV Max de l’utilisateur durant sa convalescence augmentent de 2, même si ses PV actuels restent à 1."),
                    new Variant(
                        "L’utilisateur peut, une fois par scénario et dans une situation hors-combat, jouer de prendre 5 minutes de repos afin de se soigner de 3 PV.")
                ])
        ];
        WeaponMasterT4 =
        [
            new Competence(25, "Flexibilité en combat",
                "L’utilisateur peut, trois (3) fois par jour, dépenser de la mana (PM) pour récupérer un usage de compétence martiale de tiers 3 ou moins qui a une limitation « par combat » ou « par jour ». Récupérer UNE utilisation « par combat » d'une compétence coûte 2 PMs. Récupérer UNE utilisation « par jour » coûte 4 PMs. L'effet est instantané. Il n'est pas possible de récupérer d'utilisation de la compétence « Flexibilité de combat ».",
                [
                    new Variant("Bonus de +1 PM Max."),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par scénario, dépenser 8 PMs pour récupérer une compétence « par scénario »."),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par jour, récupérer un usage de compétence « par jour » de n'importe quel arbre de tiers 1 ou 2 gratuitement.")
                ]),
            new Competence(26, "Brise-membre",
                "L’utilisateur peut, 2 fois par jour mais une (1) seule fois par combat, déclarer un brise-membre et briser le membre touché par une touche.",
                [
                    new Variant("Permet d'utiliser la compétence 3 fois par jour."),
                    new Variant(
                        "Lorsque l'utilisateur reçoit un soin de 5 PVs ou plus, il se soigne aussi de la brisure qui lui est infligée."),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par scénario, utiliser cette compétence hors-combat. La victime aura alors le choix de répondre la vérité au meilleur de ses connaissances, ou de recevoir 2 brisures d'un ou des membre(s) choisi(s) par l'utilisateur.")
                ], "Citer « Brise-membre »"),
            new Competence(27, "Coup critique",
                "L'utilisateur peut, une fois par combat, donner un coup visant un point sensible sur sa cible. Le coup inflige ses dégâts de base, + 3 dégâts en bonus actif. RAPPEL : LES COUPS À LA TÊTE ET AUX PARTIES GÉNITALES SONT INTERDITS EN TOUT TEMPS.",
                [
                    new Variant(
                        "L’utilisateur peut choisir entre la compétence initiale ou, s’il utilise une arme de corps-à-corps, avoir un bonus de dégât +1 et engendrer un effet d'Engourdissement de 5 secondes à sa cible."),
                    new Variant(
                        "De plus, le coup inflige la condition Muet à la cible, jusqu'à l'obtention de points de vie."),
                    new Variant(
                        "De plus,  le coup inflige la condition Blessure grave jusqu'à ce que la cible reçoive des soins.")
                ], "Citer « Coup critique »"),
            new Competence(28, "Éveil de l'arme de prédilection",
                "L'utilisateur devient un maître de l'utilisation de son arme de prédilection ; un lien commence à se former entre les deux.  L'utilisateur gagne un bonus de +1 dégât lorsqu'il utilise son arme de prédilection.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, résister à une destruction de son arme de prédilection (« Brise-arme », etc.)."),
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, prendre 5 minutes afin de lui-même réparer son arme de prédilection, en payant le prix de réparation standard (1 élément du matériel de l'arme)."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, payer 4 PM pour faire une frappe qui coupera la connexion de sa cible à sa magie. Si la cible est touchée, le coup lui inflige l’effet « Disjonction » pendant 5 minutes (voir Disjonction).")
                ], 21)
        ];
        DefenderT3 =
        [
            new Competence(29, "Reflet",
                "L’utilisateur peut, une fois par combat, utiliser son bouclier afin de résister aux dégâts occasionnés par un sort. Cette compétence ne fonctionne pas sur les sorts à effet de zone (Cercle, Cône, etc.) ou les sorts ne causant pas de dégâts. Les effets d’un sort ne sont pas bloqués.",
                [
                    new Variant(
                        "De plus, lorsque l’utilisateur reflète un sort, il peut le rediriger vers une nouvelle cible. Le sort ne peut pas être reflété à la personne qui a lancé le sort."),
                    new Variant(
                        "De plus, lorsque l'utilisateur reflète un sort, il peut le renvoyer au lanceur du sort."),
                    new Variant(
                        "De plus, l’utilisateur peut utiliser la compétence sur un allié qui est à un maximum de 2 mètres de lui, le protégeant du sort.")
                ], "Citer « Reflet »"),
            new Competence(30, "Résilience",
                "L’utilisateur gagne 3 points de \"Résilience\" qui servent de ressources pour le personnage. Les points se régénèrent à chaque nuit de sommeil. Le personnage peut dépenser ses points de résilience afin d’activer des compétences spécifiques.\nET\nIl peut dépenser 1 point de Résilience afin de réduire les dégâts reçus de 1 (Minimum 0). Utilisable une seule fois par attaque reçue.",
                [
                    new Variant(
                        "L'utilisateur peut utiliser 1 point de Résilience afin d’intercepter un coup ou un sort visant une cible qui est à portée de bras. L'utilisateur reçoit les dégâts et les effets à la place de la personne défendue."),
                    new Variant("Le personnage gagne 2 points de résilience de plus."),
                    new Variant(
                        "Le personnage peut utiliser 3 points de Résilience pour se guérir d'un effet nuisible, qu'il soit mental, physique ou magique.")
                ]),
            new Competence(31, "Spécialisation armure légère",
                "Si le joueur porte deux pièces d'armure légère (Torse + Haut OU Torse + Bas), ce dernier bénéficie d'une « Presquive » (Variante 1) par combat. Les bénéfices sont perdus dès que la condition n'est plus remplie et revient dès que remplit à nouveau. Si une des pièces de l'armure est « Brisée », la compétence ne s'active pas.",
                [
                    new Variant("L'armure de torse gagne une charge de DR de plus (Passe de 2\u00d7DR1 à 3\u00d7DR1)."),
                    new Variant("Le nombre de PVT maximum du joueur augmente de 2."),
                    new Variant(
                        "À chaque début de combat, si le joueur porte deux pièces d'armure légère (Torse + Haut OU Torse + Jambes), le joueur gagne 1 PVT pour la durée du combat.")
                ], "Citer « Presquive »"),
            new Competence(32, "Spécialisation armure lourde",
                "Si le joueur porte deux pièces d'armure lourde (Torse + Haut OU Torse + Bas), le torse de son armure gagne une charge de DR2 de plus (Passe de 2xDR2 à 3XDR2). Afin de bénéficier du bonus de toutes les variantes, l’armure doit être portée.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, résister à un effet de déplacement (Dégagement, Renversement, etc.)."),
                    new Variant("L'utilisateur voit son maximum de PV augmenter de + 2."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, éviter un effet visant à donner la condition « Brisée » à son armure.")
                ])
        ];
        DefenderT4 =
        [
            new Competence(33, "Coup fortifiant",
                "L'utilisateur peut, au coût de (1) point de résilience,  frapper et déclarer un « Coup Fortifiant ». Si le coup réussit, l'utilisateur gagne 3 PVT pour la durée du combat.",
                [
                    new Variant("L’utilisateur obtient 5 PVT  au lieu de 3 PVT."),
                    new Variant(
                        "L’utilisateur obtient une recharge de DR par pièce d’armure portée (peu importe le type) au lieu du bonus de PVT."),
                    new Variant(
                        "L’utilisateur obtient 3 PVT en bloquant une touche avec son bouclier au lieu de la compétence initiale.")
                ]),
            new Competence(34, "Défi du défenseur",
                "L’utilisateur peut, au coût de (1) point de résilience ET une fois par combat, défier une cible en lui déclarant une condition d’Agacement d'une durée de deux (2) minutes. Pendant que la cible est agacée, l’utilisateur bénéficie d’une DR1 contre tous les coups de sa cible, minimum 0 dégât.",
                [
                    new Variant(
                        "La condition d'agacement de la cible se prolonge de 3 minutes, pour faire effet pendant un total de 5 minutes. Par contre, le minimum de dégâts est de 1."),
                    new Variant("L’utilisateur obtient 5 x DR2 contre sa cible au lieu de DR1 à chaque coup."),
                    new Variant(
                        "L’armure de l’utilisateur devient magique lors du défi. Elle résiste maintenant à des dégâts élémentaires de types Feu, Foudre, Acide, Glace et Magique.")
                ], "Citer « Agacement »"),
            new Competence(35, "Pied ferme",
                "L’utilisateur peut, au coût d'un (1) point de résilience, résister à un effet qui le forcerait à être déplacé ou renversé.",
                [
                    new Variant(
                        "L’utilisateur peut, lorsque la compétence est utilisée, repousser un assaillant de 5 pas."),
                    new Variant(
                        "L’utilisateur peut aussi, au coût de 2 points de résilience supplémentaires, repousser tous ses ennemis à 10 pas de lui lorsque la compétence est utilisée."),
                    new Variant(
                        "L'utilisateur peut faire bénéficier cette compétence à un allié à portée de bras. Si l’utilisateur et son protégé sont frappés par une compétence causant un déplacement ou un renversement, il doit payer 2 points de résilience.")
                ], "Citer: « Pied ferme »"),
            new Competence(36, "Spécialisation d'armure avancée",
                "L’utilisateur obtient un bonus s'il porte une armure complète du même type. Ses DR augmentent de 1. Ainsi,  l’utilisateur qui porte une armure lourde aura une DR de 3.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par combat, bloquer le premier tir d’arc s’il porte une armure légère."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, bloquer le premier tir d’arme à feu s’il porte une armure lourde."),
                    new Variant("Bonus de + 2 PV Max.")
                ])
        ];
        ArcherT3 =
        [
            new Competence(37, "Munitions électriques",
                "L'utilisateur peut, au coût de 1 PM, frotter une flèche sur une pièce de vêtement pour la charger d'électricité statique. Si le joueur frotte la munition durant 5 secondes, cette dernière fera des dégâts de foudre. Si le joueur la frotte 5 secondes de plus, pour un total de 10 secondes, la munition fera +1 dégât actif. Le joueur doit utiliser la munition dans les 10 secondes suivant l’arrêt du frottement, sinon le PM est utilisé et l'effet est perdu. La munition peut être utilisée seulement par l’utilisateur de la compétence. Puisque les 10 secondes de délai pour utiliser la munition commencent une fois que le frottement est terminé, il est possible de continuer de frotter la flèche continuellement avant de lancer la munition.",
                [
                    new Variant(
                        "Lorsque le joueur frotte la munition durant 5 secondes, la munition gagne le changement d'élément ET le +1 dégât. Elle ne gagne pas de +1 dégât supplémentaire après 5 secondes de plus."),
                    new Variant(
                        "Le bonus actif de dégâts est maintenant cumulable avec celui de Tir Précis, tout en restant un bonus actif."),
                    new Variant(
                        "L'utilisateur peut investir 1 PM de plus dans la compétence « Munition Électrique », lui permettant de frotter la munition 5 secondes de plus, pour un total de 15 secondes. Ceci ajoute à la flèche +2 dégâts, pour un total de +3 dégâts actifs.")
                ], "Citer « [nombre] dégât de foudre »."),
            new Competence(38, "Munitions lestées",
                "L’utilisateur peut, après avoir joué une scène de 2 minutes dans une situation hors combat, créer une (1) munition lestée. Cette dernière ajoute un effet de Dégagement en plus des dégâts normaux. Seulement une munition lestée peut exister à la fois. Il n’est pas possible de donner sa munition à un autre joueur ou d’avoir plus d'une (1) munition de ce type sur soi.",
                [
                    new Variant("La munition lestée fait un bonus de  +1 dégât passif."),
                    new Variant("L'utilisateur obtient une (1) munition lestée supplémentaire, pour un total de 2."),
                    new Variant(
                        "La création d'une munition lestée prend maintenant 15 secondes et peut être faite en combat.")
                ]),
            new Competence(39, "Pieu",
                "L’utilisateur peut, une fois par combat, effectuer un tir qui, en plus de faire ses dégâts normaux, cause l’effet Enchevêtrement pendant 10 secondes.",
                [
                    new Variant(
                        "L’utilisateur peut dépenser 2 PM pour récupérer une charge de cette compétence pendant le combat."),
                    new Variant("L’enchevêtrement dure 30 secondes, mais ne cause aucun dégât."),
                    new Variant("Le tir est perce-armure.")
                ]),
            new Competence(40, "Rite de précision",
                "L’utilisateur peut, une fois par jour, passer 10 minutes afin de se préparer à son prochain combat. Ce temps est un moment de méditation afin d’atteindre un état de concentration et de lucidité hors-pair. Une fois le rite complété, le joueur récupère 3 PM. Les PM excédant son nombre maximum de PM sont perdus. De plus, le joueur gagne 2 charges de « résistance à un effet mental ».",
                [
                    new Variant(
                        "L'utilisateur peut utiliser des compétences de création de munitions durant le « Rite de Précision. »"),
                    new Variant(
                        "Les 3 prochains tirs de munitions ne sont pas esquivables ou parables. Il faut tout de même que la munition touche la cible. Citer « Inesquivable » à la fin de l’effet de la munition."),
                    new Variant(
                        "La prochaine compétence MARTIALE utilisée ne coûte pas de PM. Dans le cas d’une compétence utilisable « une fois par combat », l’utilisateur gagne une charge supplémentaire durant le combat en question.")
                ], "Citer « Inesquivable (Variante 2) »")
        ];
        ArcherT4 =
        [
            new Competence(41, "Flèche météorologique",
                "L’utilisateur peut, une fois par jour, changer l’élément principal de ses flèches selon la température extérieure. S’il fait soleil, ce sera des dégâts de feu. Si le ciel est couvert (ciel gris), les dégâts seront d’acide. Si une averse a lieu, ce sera des dégâts de glace. En cas de vents forts, les flèches feront des dégâts de foudre. Cette compétence perdure jusqu'à la fin du scénario. NOTE: En cas de doute, allez voir l'animation ou questionnez un PNJ sur le temps qu'il fait aujourd'hui.",
                [
                    new Variant(
                        "L'utilisateur peut changer son élément lors d'une expédition si la température est différente de celle en jeu."),
                    new Variant(
                        "L'utilisateur choisit un élément favori et un élément proscrit lors de l’acquisition de la compétence. Si les flèches sont de l’élément choisi, un bonus de +1 dégât passif est octroyé. Si les flèches sont de l’élément proscrit, un malus de -1 dégât (non typé) est octroyé."),
                    new Variant(
                        "L’utilisateur peut, en pleine nuit, modifier son élément selon la visibilité de la lune. Si la lune est visible, l’élément sera Béni. Inversement, si la lune est cachée ou invisible, l’élément sera Maudit.")
                ], "Citer « [Nombre de dégâts + l'élément] » "),
            new Competence(42, "Grappin",
                "L'utilisateur peut jouer d'attacher une corde à sa flèche et, lorsque celle-ci est lancée et touche un ennemi (même si elle bloquée), l'utilisateur peut attirer sa cible vers lui de 10 pas.  Cette compétence ne cause aucun dégât.",
                [
                    new Variant(
                        "De plus, si la flèche touche un bouclier, la cible est désarmée de son bouclier. (« Désarmement Bouclier »)"),
                    new Variant("De plus, suivant le déplacement, la cible est renversée. (« Renversement »)"),
                    new Variant(
                        "De plus, lors d'un donjon/événement d’exploration, peut être utilisé pour éviter un piège.")
                ], "Citer « Approche de 10 pas »"),
            new Competence(43, "Munition enflammée",
                "L'utilisateur peut, suivant une action de 1 minute, attacher un (1) kit de premier soins à sa flèche. Il devra faire le jeu d'action d'allumer sa flèche avant de la tirer. Une flèche ainsi parée causera +1 dégât (actif) et causera des dégâts de type Feu. Si l'utilisateur décide d'utiliser une ressource d'huile, les dégâts qu'il causera seront des dégâts de zone à 10 pieds de rayon autour du point d'impact de la flèche.\nNote : Ces munitions peuvent être préparées d'avance et être conservées sur l'utilisateur, mais ne peuvent pas être données à quelqu'un d'autre. De plus, l'utilisateur ne peut posséder qu'une seule munition enflammée à la fois.",
                [
                    new Variant(
                        "De plus, si l’utilisateur se sert d'une ressource de Naphta, plutôt que de l'huile, la flèche fera +5 de dégâts pour un total de +6 dégâts actifs, mais seulement sur la cible touchée et non sur toute la zone."),
                    new Variant(
                        "L’utilisateur utilise plutôt une (1) ressource d’alcool au lieu de l’huile : la flèche cause +2 dégâts actifs sur une zone de 5 pieds."),
                    new Variant(
                        "L'utilisateur peut, à la place d’un kit de premier soins, utiliser une ressource de fibres.")
                ], "Citer « [Nombre de dégâts] de feu, [nombre de pieds] autour de ma flèche »"),
            new Competence(44, "Tir vital",
                "L’utilisateur peut, hors d’une situation de combat, tirer une flèche dans le dos d’une cible. Ce tir causera +3 dégâts (passif).",
                [
                    new Variant(
                        "De plus, l'utilisateur gagne l'effet Camouflage pendant 30 secondes suivant le tir, qu'il soit réussi ou non."),
                    new Variant(
                        "De plus, la cible subit une condition d'Agacement envers l'utilisateur pendant 30 secondes suivant le tir, qu'il soit réussi ou non."),
                    new Variant(
                        "De plus, la cible subit l'effet Peur pendant 30 secondes suivant le tir, qu'il soit réussi ou non.")
                ])
        ];
        TacticianT3 =
        [
            new Competence(45, "Appel à la vigueur",
                "L’utilisateur peut, deux fois par jour, mais qu’une seule fois par combat, faire un cri de ralliement (voir la composante vocale). La portée du sort est auditive : si un joueur l'entend et se considère l'allié de l'utilisateur, ce dernier bénéficiera des points de vie temporaires.",
                [
                    new Variant("Les 2 charges quotidiennes sont utilisables dans le même combat."),
                    new Variant("Le bonus passe de 2 PVT à 3 PVT."),
                    new Variant("Le nombre d'utilisations passe de 2 fois par jour à 3 fois par jour.")
                ], "Citer « Tous mes alliés qui m’entendent, +2 PV temporaires »"),
            new Competence(46, "Secouer !!",
                "L’utilisateur peut, 3 fois par scénario, « secouer » vivement une cible afin de la ramener à ses sens, retirant ainsi un effet mental négatif.",
                [
                    new Variant("L'utilisateur peut se secouer lui-même."),
                    new Variant(
                        "Une personne secouée est immunisée au prochain effet mental reçu dans les 15 prochaines minutes."),
                    new Variant(
                        "L'utilisateur peut, lorsqu'il secoue une autre personne, identifier l'effet mental qu'il enlève ainsi que son origine.")
                ]),
            new Competence(47, "Tactique mineure",
                "L’utilisateur peut devenir le chef d’une escouade. Il gagne alors un nombre de points de tactique égal au plus haut tiers de compétence acquise dans le tronc martial, multiplié par 2 (exemple: tiers 3 x 2 = 6 points). Le nombre de membres maximum dans une escouade est égal à 2 plus le tiers de compétence martial le plus haut atteint par le leader (Exemple: 2 + tiers 3 = 5 membres). La formation de l'escouade doit être jouée pendant au moins 5 minutes. Attention, une personne NE PEUT PAS ÊTRE MEMBRE DE PLUSIEURS ESCOUADES à la fois. \n\nLes points de tactique sont utilisables afin d'offrir des bonus à certains membres de l’escouade. \n\nLa liste des bonus ainsi que leurs paramètres est décrite dans l’annexe associée. \n\nL’escouade est dissoute si le leader va dormir, mais un effet de sommeil ne dissout pas l’escouade. Un membre allant dormir se voit retiré de l’escouade. Un leader peut décider de retirer un membre de l’escouade de façon instantanée, simplement en lui annonçant. Un membre peut également quitter l'escouade à tout moment, mais il doit en aviser le leader.\nLe leader ne peut pas utiliser de point de tactique sur lui-même, mais il peut ajuster le coût de la compétence et la donner à plusieurs membres en même temps (coût x nb de membres désirés). Attention, un joueur peut être affecté par plusieurs tactiques en même temps, mais il ne peut pas bénéficier de la même 2 fois.",
                [
                    new Variant(
                        "Réduit la grosseur de l'escouade à 0+ plus le tiers de compétence martial le plus haut. Il peut, par contre, recruter instantanément un membre sans le délai de 5 minutes roleplay."),
                    new Variant("L’utilisateur obtient un bonus de +3 points de tactique."),
                    new Variant(
                        "L'utilisateur ne peut avoir qu'UN (1) membre dans son escouade. Le nombre de points de tactique de l'utilisateur est réduit de moitié. Le temps d’application des points de tactique est réduit (voir les Temps d'application) et le leader bénéficie aussi du bonus donné au membre de son escouade.\nTemps d’application (Variante 3) :\n30 secondes devient 10 secondes\n5 minutes devient 1 minute 30 secondes\n10 minutes devient 3 minutes")
                ]),
            new Competence(48, "Triage",
                "L'utilisateur peut, dans une situation hors combat, prendre 1 minute pour jouer de faire l'évaluation de l'état de santé d'une autre personne, pour ensuite faire une recommandation sur les soins à lui prodiguer. Suite à cette recommandation, le prochain soin reçu par la cible lui donnera +3 PV et va réparer un membre brisé. Pour utiliser cette compétence une seconde fois sur la même cible, un délai d’une heure doit être respecté et elle doit avoir reçu une nouvelle blessure. La personne qui effectue le triage ne peut pas déclencher le bonus donné par triage. L’utilisateur peut, suite au jeu d'évaluation, demander au joueur dont il s'occupe de son nombre de PV actuel.",
                [
                    new Variant(
                        "De plus, le prochain soin que la cible recevra annulera aussi les effets d’une potion."),
                    new Variant("L'utilisateur peut maintenant déclencher les effets de ses triages."),
                    new Variant("L'évaluation ne dure maintenant que 20 secondes.")
                ])
        ];
        TacticianT4 =
        [
            new Competence(49, "Conscription",
                "L’utilisateur peut, durant un combat, obliger un (1) PNJ neutre ou allié de se battre à ses côtés. Ce personnage va aider l’utilisateur au meilleur de ses capacités. À noter que certains PNJ peuvent résister à cet effet. De plus, si celui-ci croit que la bataille est perdue d’avance et que les joueurs n’ont aucune chance, il peut refuser de participer.",
                [
                    new Variant("Le personnage recruté pourra effectuer des dégâts de +1 (base)."),
                    new Variant("Le personnage recruté aura 5 PV de plus. "),
                    new Variant("Le personnage recruté sera plus enclin à utiliser ses objets.")
                ],
                "Citer « Conscription [Effet de variante] »"),
            new Competence(50, "Héroïsme",
                "L’utilisateur peut, une fois par scénario, immuniser une cible à tous les effets (incluant les malédictions, bris, désarmements, etc...) pendant la durée d'un combat. L’utilisateur ne peut pas utiliser cette compétence sur lui-même. Si un effet perdure après le combat, il revient. Les effets déjà actifs avant l’utilisation de la compétence Héroïsme sont mis sur pause pendant la durée de la compétence. Note : L'agonie et la mort sont les seules exceptions à cette compétence.",
                [
                    new Variant("Bonus de 5 PVT à la cible."),
                    new Variant("Bonus de la moitié des PM manquants de la cible."),
                    new Variant(
                        "Lorsque la compétence est utilisée, l’utilisateur a une (1) résistance au prochain effet lancé sur lui.")
                ],
                "Citer  « Héroïsme, immunité à tous les effets »."),
            new Competence(51, "Jeux de guerre",
                "L’utilisateur peut, une fois par jour, recharger 5 points de tactique suite à une partie complète d'un jeu de guerre (échecs, go, Risk, etc.) avec un adversaire au jeu.",
                [
                    new Variant(
                        "L’utilisateur peut poser une question à son adversaire par rapport à son personnage ou ses intentions. L’adversaire doit répondre de manière honnête et ne sait pas qu'il a été questionné."),
                    new Variant(
                        "L’utilisateur n’a plus besoin d’un adversaire et peut jouer seul. Note : Une partie doit quand même être complétée afin d'en obtenir les bénéfices."),
                    new Variant(
                        "À la place d'un jeu de guerre, l'utilisateur peut passer 15 minutes à étudier une carte afin d'avoir les bénéfices de cette compétence, l’utilisateur doit avoir un compagnon de conversation pendant la période complète.")
                ]),
            new Competence(52, "Tactique supérieure",
                "L’utilisateur a maintenant accès aux tactiques Tiers 2 ET peut se donner les bénéfices d’une tactique Tiers 1 gratuitement lorsqu’il active les tactiques de son escouade.",
                [
                    new Variant(
                        "Toutes les tactiques Tiers 1 assignées à l'escouade deviennent en durée « par combat » sans coût additionnel."),
                    new Variant("L'utilisateur obtient un bonus de  +3 points de tactique."),
                    new Variant("L'utilisateur obtient un bonus de +1 membre maximum dans son escouade.")
                ])
        ];
        SamuraiT3 =
        [
            new Competence(53, "Iai",
                "L’utilisateur peut charger sa prochaine attaque avec une arme (excluant les armes à feu) en utilisant ses PM. L’utilisateur doit charger sa mana pendant deux secondes avant de l’effectuer.\nEn dépensant 1 PM : La frappe devient magique. \nEn dépensant 2 PM : La frappe fait +1 dégât (base) ou brise l’arme/bouclier qui bloque le coup.",
                [
                    new Variant(
                        "L'utilisateur a la possibilité d'investir 3 PMs dans une frappe pour faire une attaque de  +2 dégâts magiques (actif)."),
                    new Variant(
                        "Si l'utilisateur investit 1 PM, il peut décider de frapper dans l’élément suivant : feu, glace, foudre ou acide."),
                    new Variant(
                        "L'utilisateur peut payer un supplément de +1 PM sur l'option 1 et 2 pour que le bonus affecte les 3 prochaines frappes.")
                ],
                "Citer  « Perce-armure, [nombre de] dégâts magiques ou brise-arme/brise-bouclier »"),
            new Competence(54, "Méditation du Guerrier",
                "L'utilisateur peut méditer afin de régénérer sa mana. Il récupère ainsi 1 PM par 3 minutes de méditation. La régénération de mana de cette compétence ne fonctionne pas si l'utilisateur a 5 PM Max et plus.",
                [
                    new Variant("L'utilisateur gagne +1 PM Max. "),
                    new Variant(
                        "L'utilisateur peut inviter un autre joueur dans sa médiation. Ce dernier bénéficiera du bonus de régénération. L’invité ne peut pas récupérer de PMs s’il possède 5 PM et plus."),
                    new Variant(
                        "La régénération de mana de cette compétence ne fonctionne pas si l'utilisateur a 7 PM ou plus plutôt que 5, mais il régénère à un rythme de 1 PM par 5 minutes. ")
                ]),
            new Competence(55, "Renforcement d’arme",
                "L'utilisateur peut, en jouant la scène pendant 2 minutes, réserver 3 PM Max afin de renforcer une de ses armes. Renforcer une deuxième arme coûte le double, une troisième, le triple, etc.  L'arme renforcée peut alors résister à une (1) tentative de brise-arme par combat. Pour retirer la réservation et récupérer ses PM Max, l’utilisateur devra méditer durant 2 minutes.",
                [
                    new Variant("L'arme peut résister à 2 brise-arme par combat."),
                    new Variant("La réserve coûte 2 PM Max plutôt que 3."),
                    new Variant(
                        "Le joueur peut, lorsqu’il attaque avec son arme renforcée, déclarer des dégâts magiques.")
                ]),
            new Competence(56, "Renforcement d’armure",
                "L'utilisateur peut, en jouant la scène pendant 2 minutes, réserver 3 max PM afin de renforcer son armure. L'armure renforcée fait bénéficier à l’utilisateur d’une utilisation de la compétence Presquive (Variante 2) par combat. Pour retirer la réservation, l’utilisateur devra méditer durant 2 minutes.",
                [
                    new Variant(
                        "La réserve coûte 4 PMs Max plutôt que 3, mais permet deux utilisations ‘’Presquive Variante 2” par combat."),
                    new Variant("La réserve coûte 2 PMs Max plutôt que 3."),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par combat, réduire de 3 les dégâts du PREMIER sort à dégâts reçu lors de l'affrontement. Toutefois, les autres effets du sort fonctionnent tout de même.")
                ])
        ];
        SamuraiT4 =
        [
            new Competence(57, "Arme scintillante",
                "L'utilisateur peut, en prenant 2 minutes de jeu, réserver 4 PM Max pour rendre son arme scintillante. Celle-ci pourra alors percer les armures avec chacun de ses coups. Pour retirer la réservation et récupérer ses PM Max, l’utilisateur devra méditer durant 2 minutes.  Note : Cette compétence ne peut pas être appliquée à une arme à feu.",
                [
                    new Variant(
                        "De plus, l’utilisateur peut, trois fois par combat, lorsqu’un coup touche un bouclier, déclarer sa frappe comme « Imparable »."),
                    new Variant(
                        "L'utilisateur peut consommer ses PM réservés, terminant la compétence, pour ce combat afin de donner l'effet disjonction de manière instantanée à la touche."),
                    new Variant("L’utilisateur effectue des dégâts bénis avec son arme scintillante.")
                ],
                "Citer « Perce armure [Imparable (si variante 1)][Disjonction (si variante 2)][Béni (si variante 3)] »"),
            new Competence(58, "Force de volonté",
                "L'utilisateur peut méditer afin de régénérer sa vie au coût de 1 PM pour 1 PV par 3 minutes de méditation. Cette compétence ne fonctionne pas si l'utilisateur a plus de son maximum de PVT alloués en PV.",
                [
                    new Variant(
                        "De plus, suivant une méditation où l’utilisateur a atteint son maximum de régénération possible, il obtient 3 PVT jusqu’à la fin du prochain combat."),
                    new Variant(
                        "L'utilisateur peut inviter un autre joueur dans sa méditation. Ce dernier va aussi bénéficier du bonus de régénération, tant qu'il possède la mana nécessaire. L'invité ne régénère qu'au maximum de SES max PVT."),
                    new Variant("L'utilisateur gagne +2 Max PVT.")
                ]),
            new Competence(59, "Onde de choc",
                "L'utilisateur peut investir 2 PM afin d'effectuer une attaque à une distance maximale de 15 pieds avec son arme de mêlée. Cette attaque peut être combinée avec les effets de la compétence Tiers 3 Iai.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par combat, faire plutôt un cône de 10 pieds (90 degrés) devant lui. Si combinée avec Iai, même si plusieurs cibles sont touchées, la compétence Iai n’est payée qu’une fois."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, plutôt faire un cercle autour de lui (360 degrés) à 5 pieds de rayon. Si combinée avec Iai, même si plusieurs cibles sont touchées, la compétence Iai n’est payée qu’une fois."),
                    new Variant("L’onde de choc de base (15 pieds) effectue +1 dégât (base), mais coûte 2 PM de plus.")
                ],
                "Citer « Onde de choc, [nombre de] dégâts »"),
            new Competence(60, "Réserve vitale",
                "L'utilisateur peut, en prenant 2 minutes de jeu, réserver une de ses compétences sur ses PV Max plutôt que ses PM Max. Pour retirer la réservation et récupérer ses PV Max, l’utilisateur devra méditer durant 2 minutes.",
                [
                    new Variant("L'utilisateur obtient un bonus de +1 PV max."),
                    new Variant(
                        "Si l'utilisateur tombe au combat, il peut résilier sa réserve afin de survivre. Par contre, il ne lui reste qu’un (1) PV."),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par combat, obtenir sa réserve de PV Max en PVT.")
                ])
        ];
        GunnerT3 =
        [
            new Competence(61, "Spécialisation d’armes à feu standard",
                "Le premier tir que l'utilisateur effectue dans un combat avec une arme à feu standard obtient un bonus de  +2 dégâts (Actif).",
                [
                    new Variant(
                        "Au lieu de la compétence initiale, les 3 premiers tirs effectués dans un combat font +1 dégât (Actif)."),
                    new Variant(
                        "Si l'utilisateur a une arme à feu standard dans une main et une autre arme dans l'autre ET qu'il est victime d'un « brise-arme » ou d'un « désarmement », l'utilisateur peut décider laquelle de ses armes est touchée."),
                    new Variant(
                        "Au lieu de la compétence initiale, l’utilisateur peut choisir à quel moment du combat utiliser son bonus.")
                ]),
            new Competence(62, "Spécialisation du pistolet magique",
                "L'utilisateur peut maintenant enregistrer un pistolet magique. Plutôt que de coûter des munitions et de la poudre, le pistolet magique doit être enregistré avec un cristal de mana. La qualité du cristal de mana définit le nombre de charges magiques (mineur = 2 charges, intermédiaire = 5 charges,  majeur = 10 charges). Au coût d’une charge, l'utilisateur peut changer l’élément de son pistolet magique dans l’un des éléments suivants : Magique, Feu, Glace, Électrique et Acide. Les dégâts faits par le pistolet magique seront ceux de l'élément du pistolet.",
                [
                    new Variant("De plus, l'utilisateur peut choisir l'élément Béni et Maudit."),
                    new Variant(
                        "L'utilisateur peut aussi utiliser sa propre mana pour changer l'élément de l'arme au coût de 2PM."),
                    new Variant("Le cristal de mana utilisé par le joueur obtient un bonus de  +1 charge.")
                ]),
            new Competence(63, "Spécialisation du pistolet PiezzoFire",
                "L'utilisateur peut maintenant enregistrer un pistolet PiezzoFire. Ces armes utilisent des munitions standard, mais aussi les propriétés des gemmes pour ajouter des effets aux tirs. Les dégâts de base de l'arme sont de 1. Le coût pour enregistrer le pistolet PiezzoFire est le même que celui du pistolet standard. Le Pistolet PiezzoFire se différencie par sa capacité à utiliser des gemmes de niveau « Taillé » ou plus (« Précieuse » ou « Parfaite ») afin de créer des effets en combat. Un pistolet PiezzoFire ne peut contenir qu'une gemme à la fois. Mettre une gemme dans un pistolet prend 30 secondes. Si le joueur essaie de mettre une gemme dans le pistolet PiezzoFire alors qu'il en contient déjà une, la nouvelle remplace l'ancienne et l'ancienne sera détruite.  Les effets et le nombre d'utilisations sont définis par la gemme utilisée. Ces effets sont décrits dans l’annexe 5.",
                [
                    new Variant("Le joueur peut mettre une gemme dans le Pistolet PiezzoFire en 5 secondes."),
                    new Variant(
                        "Lorsque le joueur enregistre son arme à l'inscription, l'arme est chargée avec une gemme « Taillée » aléatoire."),
                    new Variant(
                        "L’utilisateur peut, une fois par jour, décider d'utiliser l'effet d'une gemme dans son Pistolet PiezzoFire sans que la charge ne soit consommée.")
                ]),
            new Competence(64, "Bang!",
                "L’utilisateur peut, trois fois par jour ET un maximum d’une fois par combat, déclarer « BANG! » à haute voix en pointant un pistolet enregistré et fonctionnel sur une cible à moins de 15 pieds. L'action n'est utilisable que lorsque l'arme est « déchargée » (après un vrai tir par exemple). L'utilisateur inflige les dégâts de base de son arme à sa cible. Concrètement, cela permet à un fusilier de faire un tir une fois sans qu'il ait le temps de charger son arme.",
                [
                    new Variant(
                        "De plus, si utilisé hors combat, l'utilisateur peut créer un effet de « peur » sur une cible pour 20 secondes et décide si « BANG! » fait du dégât ou non."),
                    new Variant("Si utilisé hors combat, les dégâts sont augmentés de +1 (actif)."),
                    new Variant(
                        "Si utilisé en combat, l'utilisateur gagne une utilisation de la compétence « Presquive ».")
                ]),
        ];
        GunnerT4 =
        [
            new Competence(65, "Décharge arcanique",
                "L'utilisateur peut surcharger un tir de son pistolet magique en utilisant deux (2) charges de son cristal de mana. Le tir aura un bonus de +2 dégâts (Actif).",
                [
                    new Variant(
                        "De plus, l'utilisateur peut modifier l'élément de son pistolet au moment du tir sans coût supplémentaire."),
                    new Variant(
                        "Le pistolet cause +1 dégâts (actif), mais fera reculer sa cible de cinq pas. Cela affecte les 3 prochains tirs."),
                    new Variant(
                        "L'utilisateur peut choisir d'utiliser cette technique sur un allié, ne causant pas de dégâts, mais lui offrant un montant de 3 PMs.")
                ],
                62),
            new Competence(66, "Maîtrise du pistolet PiezzoFire",
                "L'utilisateur peut maintenant placer trois gemmes dans un pistolet PiezzoFire. Il ne peut pas utiliser l'effet de gemmes différentes simultanément dans le pistolet, mais les gemmes de même type ont des effets cumulables. Afin d'obtenir l'effet Tiers 2 des gemmes, l'utilisateur doit se servir de 3 gemmes similaires.",
                [
                    new Variant("L'effet Tiers 2 des gemmes ne peut être activé qu’avec 2 gemmes similaires."),
                    new Variant("Deux effets Tiers 1 peuvent être activés en même temps."),
                    new Variant(
                        "L'utilisateur choisit une gemme (sauf diamant) préférée. Maintenant, toutes les gemmes, excepté le diamant, donneront l'effet de la gemme préférée.")
                ],
                63),
            new Competence(67, "Pistolero",
                "L’utilisateur a maintenant accès aux pistolets de type revolver (barillet de 6 balles maximum).  Une fois rechargé à plein, la dernière balle fera un bonus de +2 dégâts (actif).",
                [
                    new Variant("L’utilisateur obtient un bonus de +1 dégât pour un total de +3 dégâts (actif)."),
                    new Variant("Le type de bonus devient « passif » au lieu d’actif."),
                    new Variant(
                        "Après avoir déchargé au minimum un barillet complet (6 tirs), les tirs subséquents font des dégâts de type feu pour la durée du combat.")
                ],
                61),
            new Competence(68, "Ricochet",
                "L’utilisateur peut, une fois par combat ET suivant un tir réussi, pointer une seconde cible qui subira le même effet. Ceci est cumulable avec n'importe quelle compétence du Fusilier.",
                [
                    new Variant("De plus, l’utilisateur peut, une fois par jour,  désigner une cible additionnelle."),
                    new Variant("Le tir du ricochet causera +1 dégât (base)."),
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, faire un ricochet de manière non-conventionnelle. Par exemple, au travers d’un mur, à une distance impensable, etc.")
                ])
        ];
        BarbarianT3 =
        [
            new Competence(69, "Coriace",
                "Le corps de l’utilisateur est renforcé, il gagne 2x DR1 qui se récupèrent entre les combats. Ces points ne se cumulent PAS avec les points de DR obtenus par les pièces d'armure de torse.",
                [
                    new Variant(
                        "En plus, une fois par scénario, le joueur peut ignorer la toxicité d'un produit alchimique."),
                    new Variant(
                        "L’utilisateur peut, durant 5 minutes ET une fois par jour, mettre en pause les effets d’un produit alchimique. Le temps et les effets seront alors suspendus et reprennent leur progression après 5 minutes."),
                    new Variant("Le joueur peut résister à une (1) brisure de membre par jour.")
                ]),
            new Competence(70, "Rage",
                "L’utilisateur peut, une fois par combat, sacrifier 3 PV Max qui seront récupérés suivant une nuit de sommeil ou au prochain scénario. En échange, cela maximise ses PVT (la baisse des max PV n’affecte pas ce nombre). Durant le combat, l’utilisateur ne pourra pas faire d’action nécessitant de la concentration ou lancer des sorts. Suivant la fin du combat, il aura l’effet « fatigue » pour une durée égale au nombre de PV Max manquants, multiplié en minutes. Note : Dans le cas où la compétence est utilisée par un utilisateur ayant moins de 3 PV Max, les PV seront de 1 + PVT pour la durée du combat. Toutefois, l’utilisateur va mourir à la fin de ce-dit combat. Il devra alors passer devant la Mort ou recevoir une résurrection.",
                [
                    new Variant(
                        "La compétence est utilisable deux (2) fois par combat, mais la seconde utilisation coûte 4 PV Max plutôt que 2."),
                    new Variant(
                        "De plus, l'utilisateur peut sacrifier 3 PV Max pour se stabiliser s'il tombe agonisant. Il tombe à 1 PV et en convalescence pour 30 minutes."),
                    new Variant("L'utilisateur obtient un bonus de  +1 PVT Max.")
                ]),
            new Competence(71, "Sauvage",
                "L’utilisateur obtient un bonus de +1 PV Max et peut, une fois par jour, résister à un effet de poison ou de maladie.",
                [
                    new Variant(
                        "De plus, le joueur peut, une fois par combat, décider de briser son arme en attaquant quelqu'un, obtenant un bonus de +2 dégâts (actif). L’arme gagne l’effet « brisé » suivant l’utilisation. Dans le cas d’une arme naturelle, il va souffrir d'un brise-membre et ne pourra pas se servir de celle-ci avant d'être soigné. Note : Non utilisable avec les armes à feu."),
                    new Variant("L’utilisateur obtient un bonus de +1 PV Max, pour un total de +2 PV Max."),
                    new Variant("L’utilisateur obtient une régénération naturelle de +1 PV par heure.")
                ]),
            new Competence(72, "Tribalisme",
                "Le joueur peut payer 2 PV Max afin de créer, sur une cible, un symbole tribal. Les PV Max utilisés pour créer ces symboles ne peuvent être récupérés que lorsque le symbole est enlevé ou utilisé. L'application du symbole prend 15 minutes et est dessinée sur sa cible (peinture, cicatrice, tatoo, etc.). Le symbole n'est aucunement altérable SAUF par son créateur, qui peut prendre 10 minutes afin de le retirer. L’utilisateur peut instantanément reconnaître une cible portant le symbole, même si son apparence est modifiée ou transmutée. La cible portant le symbole ne peut achever le créateur du symbole, car elle le suivra dans la mort. Lorsque la cible tombe à 0 PV, elle est automatiquement stabilisée et son symbole s'efface. 5 minutes suivant le début de sa convalescence, la cible gagne une régénération de 1 PV par minute jusqu'à ce qu'elle atteigne 5 PV et son max PV est de 5. Sa convalescence durera jusqu’à la fin de la régénération. Ces PV Max sont récupérés lors du prochain événement après qu’un symbole soit retiré.",
                [
                    new Variant(
                        "L’utilisateur peut faire un rituel de 30 minutes afin d’appliquer un symbole à autant de joueurs qu'il le décide d’un coup. Il devra tout de même payer 2 PV Max par symbole."),
                    new Variant(
                        "L’utilisateur peut instantanément identifier les effets mentaux affectant une personne avec son symbole."),
                    new Variant("La cible arborant le symbole peut résister à un effet mental, une fois par jour.")
                ])
        ];
        BarbarianT4 =
        [
            new Competence(73, "Attaque bestiale",
                "L'utilisateur a un bonus de +3 dégâts (Actif) sur 5 touches par jour.",
                [
                    new Variant("Permet d'utiliser la compétence 2 fois par combat à la place de 5 touches par jour."),
                    new Variant(
                        "De plus, la cible subit l’effet « Engourdissement » du membre touché pendant 30 secondes."),
                    new Variant("La frappe devient imparable, mais limitée à 3 touches par jour.")
                ],
                "Citer « Attaque bestiale X [Engourdissement 30 secondes (Si Variante 2))] [Imparable Variante 3] »"),
            new Competence(74, "Chef tribal",
                "L’utilisateur peut maintenant payer 1 PV Max afin de créer un symbole tribal sur une cible, seulement pour les 5 premiers tatoués dans le scénario.",
                [
                    new Variant(
                        "L'utilisateur peut, une fois par jour, guérir chacun des porteurs de son symbole du total des PVs Max manquant de l’utilisateur. Cette guérison doit être jouée pendant 5 minutes."),
                    new Variant(
                        "De plus, la cible portant un symbole peut ignorer les dégâts du premier projectile par combat. Attention, les projectiles d’arme de siège ne sont pas inclus."),
                    new Variant(
                        "De plus, la cible portant un symbole peut, une fois par jour,  résister à un effet physique de son choix.")
                ],
                72),
            new Competence(75, "Sceptique",
                "L'utilisateur gagne un bonus de +2 PV Max, mais ne possède plus aucun PM, et ne pourra plus jamais les augmenter au-delà de 0.",
                [
                    new Variant(
                        "De plus, l’utilisateur peut choisir un élément (feu, foudre, glace ou acide) contre lequel il aura une DR2 infinie. Il obtient aussi cette DR2 contre les dégâts magiques."),
                    new Variant("L’utilisateur obtient un bonus de +1 PV Max, pour un total de +3 PV Max."),
                    new Variant(
                        "Le barbare peut régénérer ses PV en mangeant des parchemins sur le(s)quel(s) sont inscrits des sorts. La régénération sera égale au niveau de sort du parchemin. NOTE: Un parchemin avec la forme Contrat sera considéré comme signé, le cas échéant.")
                ]),
            new Competence(76, "Voile rouge",
                "Lorsqu'il est en rage, l'utilisateur devient immunisé à tous les nouveaux effets mentaux.",
                [
                    new Variant("L'utilisateur peut, au début de sa rage, ignorer un effet mental déjà actif."),
                    new Variant("L'utilisateur est considéré en rage tant qu'il possède des PVT."),
                    new Variant("L'utilisateur obtient un bonus de  +2 PVT Max.")
                ])
        ];
        SpecialistT1 = [];
        SpecialistT2 = [];
        BardT3 = [];
        BardT4 = [];
        TrapperT3 = [];
        TrapperT4 = [];
        RogueT3 = [];
        RogueT4 = [];
        TechnicianT3 = [];
        TechnicianT4 = [];
        CharlatanT3 = [];
        CharlatanT4 = [];
        InquisitorT3 = [];
        InquisitorT4 = [];
        ArcaneT1 =
        [
            new Competence(77, "Novice de l'Arcane (Abjuration)", "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.", 
            [
                new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
            ]),
            new Competence(78, "Novice de l'Arcane (Conjuration)", "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.", 
            [
                new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
            ]),
            new Competence(79, "Novice de l'Arcane (Divination)", "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.", 
            [
                new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
            ]),
            new Competence(80, "Novice de l'Arcane (Enchantement)", "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.", 
            [
                new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
            ]),
            new Competence(81, "Novice de l'Arcane (Évocation)", "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.", 
            [
                new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
            ]),
            new Competence(82, "Novice de l'Arcane (Illusion)", "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.", 
            [
                new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
            ]),
            new Competence(83, "Novice de l'Arcane (Nécromancie)", "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.", 
            [
                new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
            ]),
            new Competence(84, "Concentration mineure", "L’utilisateur peut, à chaque incantation, endurer UNE frappe faisant 3 dégâts et moins avant de perdre sa concentration. Toutefois, il subit les dégâts reçus.", 
                [
                    new Variant("L’utilisateur obtient un bonus de  +1 PM Max."),
                    new Variant("La frappe que l’utilisateur peut endurer est maintenant de 4 dégâts et moins."),
                    new Variant("L’utilisateur peut endurer une frappe de plus, pour un total de deux frappes, accumulant un total de 3 dégâts maximum.")
                ]),
            new Competence(85, "Électrochocs", "L’utilisateur peut stabiliser une cible en agonie en payant en PM la moitié (50% à la baisse) de ses PM Max. La cible sera alors à 1 PV et entrera en convalescence. L’utilisateur ne peut plus récupérer de PM pour les 15 prochaines minutes. Le coût minimum de mana est de 1 en tout temps.", 
                [
                    new Variant("L’utilisateur crée un bouclier intangible pour sa cible. Il pourra absorber une quantité de dégâts égal à 1 dégât par tranche de 5 PM utilisés par l’utilisateur."),
                    new Variant("Le coût de mana de la compétence est maintenant équivalent au quart des PM Max de l'utilisateur."),
                    new Variant("Le coût de mana de la compétence est maintenant équivalent aux trois quarts des PM Max de l'utilisateur. La cible revient immédiatement à la vie comme si sa convalescence était complétée. Elle revient à elle avec 1 PV, et + 1 PV par tranche de 10 PM utilisés.")
                ],
                "Aviser le joueur des conditions de sa convalescence."),
            new Competence(86, "Études novices", "Cette compétence peut être acquise une fois par école. Elle permet de connaître les valeurs de tous ses mots de Tiers 1 de l’école choisie.", 
                [
                    new Variant("L’utilisateur obtient +0.25 PM Max."),
                    new Variant("L’utilisateur obtient les valeurs d’une deuxième école de son choix."),
                    new Variant("L’utilisateur obtient + 0.5 sort actif par scénario (arrondi à l’entier inférieur).")
                ]),
            new Competence(87, "Frappe ensorcelée", "L’utilisateur peut, au coût de 2 PM, infuser son arme de mana après une méditation de 15 secondes non interrompue. Cela lui permet de gagner un bonus de +1 dégâts magique (actif) sur sa prochaine frappe. L’énergie se décharge après 5 minutes et la compétence ne peut être effectuée sur une arme portée par quelqu’un d’autre.", 
                [
                    new Variant("Suivant la méditation de 15 secondes, l’utilisateur gagne une charge de DR2 applicable seulement s’il ne porte aucune source de DR (armure, objet magique, etc.)."),
                    new Variant("L’utilisateur peut infuser plus de PM pour gagner un bonus additionnel de +1 dégât (actif) par tiers d'ensorcellement. En contrepartie, la frappe coûte 2 PM additionnels par tiers d’ensorcellement. (Les tiers d’ensorcellement vont de 0 à 3 selon le matériel de l’arme.)"),
                    new Variant("L’utilisateur peut, en situation hors combat et une fois par jour, effectuer un assommement de 5 minutes avec sa frappe ensorcelée. La cible doit être surprise. Si la frappe échoue, l’arme est déchargée.")
                ],
                "Variante 3 : citer « Assommement 5 minutes »"),
            new Competence(88, "Méditation", "L’utilisateur peut méditer afin de regagner des PMs. Le taux de régénération de base est de 1 PM par 10 de PM Max. (minimum 1).", 
                [
                    new Variant("Le temps de méditation n’est que de 15 minutes, mais si l’utilisateur est interrompu, il doit recommencer les 15 minutes de méditation. La méditation demande un effort de concentration active, mais elle peut être accompagnée d’une activité calme telle que le yoga."),
                    new Variant("Le temps de méditation est de 30 minutes. La méditation est relaxante, elle ne demande pas de concentration, mais ne peut pas être accompagnée d’effort physique."),
                    new Variant("Le temps de méditation est de 1 heure. L’utilisateur n’a aucune restriction sur ses activités.")
                ])
        ];
        ArcaneT2 =
        [
            new Competence(89, "Apprenti de l’Arcane (Abjuration)", "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.", 
            [
                new Variant("L’utilisateur gagne +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
            ]),
            new Competence(90, "Apprenti de l’Arcane (Conjuration)", "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.", 
            [
                new Variant("L’utilisateur gagne +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
            ]),
            new Competence(91, "Apprenti de l’Arcane (Divination)", "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.", 
            [
                new Variant("L’utilisateur gagne +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
            ]),
            new Competence(92, "Apprenti de l’Arcane (Enchantement)", "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.", 
            [
                new Variant("L’utilisateur gagne +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
            ]),
            new Competence(93, "Apprenti de l’Arcane (Évocation)", "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.", 
            [
                new Variant("L’utilisateur gagne +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
            ]),
            new Competence(94, "Apprenti de l’Arcane (Illusion)", "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.", 
            [
                new Variant("L’utilisateur gagne +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
            ]),
            new Competence(95, "Apprenti de l’Arcane (Nécromancie)", "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.", 
            [
                new Variant("L’utilisateur gagne +0.25 PM Max."),
                new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
            ]),
            new Competence(96, "Apoptose", "L’utilisateur peut consommer ses PV afin de récupérer la même quantité de PM. Cette action prend 10 secondes par PV consommé.", 
                [
                    new Variant("L’utilisateur peut, une fois par cible (morte) et suivant une scène de 10 secondes, consommer une partie de son essence afin de regagner 1 PM. L’utilisateur doit être à moins de 5 pieds du corps."),
                    new Variant("L’utilisateur peut, une fois par combat, consommer 3 PV pour récupérer 4 PM instantanément."),
                    new Variant("L’utilisateur peut, lors d’une incantation et s’il manque de PM afin de lancer le sort, substituer ses PM manquants par le double en PV. Utilisable seulement pour des sorts. Si l’utilisateur tombe à 0 PV par cette méthode, il meurt et doit soit aller voir la Mort, soit obtenir une résurrection.")
                ]),
            new Competence(97, "Bâton de pouvoir", "L’utilisateur peut entreposer un sort de portée « Touché » dans son bâton, lui permettant de décharger le sort avec une frappe du bâton. Le sort entreposé est perdu après un délai de 5 minutes. Le bâton ne peut pas faire de dégât ou être utilisé par une autre compétence tant qu’il entrepose un sort. Le sort entreposé doit être de Tiers 3 ou moins.", 
                [
                    new Variant("L’utilisateur obtient un bonus de +1 PM Max."),
                    new Variant("Le sort entreposé coûtera +2 PM, mais aura son tiers de pouvoir augmenté de 1."),
                    new Variant("Le sort entreposé dans le bâton est perdu après un délai de 30 minutes au lieu de 5.")
                ]),
            new Competence(98, "Études apprenties", "L'utilisateur peut, lors de l'acquisition de la compétence, étudier les valeurs de ses mots connus (Tiers 3 maximum). Cette compétence est achetable à l'infini et il est possible de changer de variante à chaque achat de la compétence.", 
                [
                    new Variant("L’utilisateur obtient la liste complète des valeurs d’un (1) mot de son choix."),
                    new Variant("L’utilisateur choisit trois (3) mots, mais qu'une valeur inconnue aléatoire (Hasard) par mot."),
                    new Variant("L'utilisateur choisit deux (2) mots, mais n'obtient qu’une valeur de son choix entre Potentia, Flux et Arcainum pour ses deux mots.")
                ]),
            new Competence(99, "Repositionnement", "L’utilisateur peut, une fois par combat, effectuer jusqu’à 3 pas consécutifs lors d’une incantation sans perdre sa concentration. Par contre, durant le déplacement, l’utilisateur ne peut pas continuer d’incanter et le déplacement doit durer 5 secondes maximum.", 
                [
                    new Variant("Lors du repositionnement, l'utilisateur devient intangible et résiste au premier coup physique."),
                    new Variant("Suite au repositionnement, l'utilisateur se voit octroyer un bouclier arcanique qui le protège des 3 prochains points de dégâts magiques (non élémentaux). Le bouclier se décharge à la fin du combat."),
                    new Variant("L’utilisateur peut maintenant effectuer jusqu’à 5 pas consécutifs.")
                ],
                "Variante 1 : citer « Résiste »"),
            new Competence(100, "Sorts bi-disciplinaires", "L’utilisateur apprend à combiner les mots de deux écoles différentes. L’utilisation d’une seconde école ajoute un multiplicateur de 20% à la valeur de Flux globale.", 
                [
                    new Variant("L’utilisateur gagne +3 PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +2 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un bonus de +5 résistance à l’Arcainum.")
                ])
        ];
    }
}