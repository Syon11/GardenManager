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
        SpecialistT1 = 
        [
            new Competence(164, "Assommement", "L’utilisateur peut, une fois par jour, effectuer une attaque sans dégât afin de rendre inconsciente une cible durant 5 minutes. L’inconscience est interrompue si la cible reçoit des dégâts. L’action doit être effectuée hors combat et surprendre sa cible. La compétence doit être utilisée avec une arme.",
                [
                    new Variant("L’action peut être faite deux fois par jour et en combat (doit surprendre la cible)."),
                    new Variant("La cible oublie les 5 minutes avant son assommement. "),
                    new Variant("L’utilisateur peut effectuer l’assommement sans arme.")
                ],
                "Citer « Assommement 5 minutes »"),
            new Competence(165, "Charme naturel", "L’utilisateur peut, une fois par jour, se rendre insignifiant aux yeux d’une cible. Durant les 5 prochaines minutes, la cible ne sera plus encline à attaquer ou agresser l’utilisateur. Si ce dernier devient agressif envers la cible, l’effet est immédiatement terminé. La demande doit être faite en situation hors-combat.", 
                [
                    new Variant("De plus, l’utilisateur peut, 3 fois par scénario mais pas plus d’une fois par cible, quêter dans l’espoir d’avoir un gain. L’utilisateur devra tirer à pile ou face (hasard) pour déterminer si la victime doit lui offrir une ressource ou non. Si cela fonctionne, la cible peut choisir entre offrir une plume ou une ressource. Cet effet est un effet mental."),
                    new Variant("De plus, l’utilisateur peut demander clémence durant un combat, mais la durée est de 15 secondes."),
                    new Variant("De plus, l’utilisateur peut, une fois par jour, diriger la haine de son opposant vers une autre entité.")
                ],
                "Citer « Clémence »"),
            new Competence(166, "Connaissance de la rue", "L’utilisateur peut, une fois par scénario, effectuer une enquête sur le sujet de son choix afin d’en retirer des informations et des rumeurs. L’utilisateur devra se présenter à l’animation et il recevra un délai. Il devra alors jouer de faire une enquête et, une fois celle-ci terminée, il pourra revenir à l’animation afin de recevoir certaines informations. L’utilisateur peut choisir de payer un nombre de plumes de son choix pour obtenir plus d’informations, ou des délais moins grands.", 
                [
                    new Variant("De plus, l’utilisateur peut, à l’inscription, recevoir trois rumeurs du scénario précédent."),
                    new Variant("La somme payée par l’enquêteur vaut 25% de plus."),
                    new Variant("De plus, l’utilisateur peut, une fois par scénario, forcer une cible à répondre à une question au meilleur de ses connaissances (effet mental).")
                ],
                "Citer « Connaissance de la rue, réponds à la question au meilleur de tes compétences. (Variante 3) »"),
            new Competence(167, "Double fond", "L’utilisateur peut, en cas d’un vol à la tire, préserver 10 plumes.", 
                [
                    new Variant("Plutôt que de préserver 10 plumes, lorsque vous subissez un vol à la tire, vous occasionnez 1 dégât automatiquement au voleur, sachant ainsi qui vous a volé."),
                    new Variant("L’utilisateur peut choisir entre 10 plumes ou un objet de son choix."),
                    new Variant("L’utilisateur peut choisir entre 10 plumes ou trois cartes-ressource.")
                ]),
            new Competence(168, "Presquive", "L’utilisateur peut, une fois par combat, effectuer une « Presquive » pour réduire les dégâts d’une attaque physique reçue. Une attaque « Presquivée » inflige 3 dégâts de moins (minimum 0). Les effets associées à l’attaque « Presquivée » s’appliquent même si l’attaque n’inflige pas de dégâts.", 
                [
                    new Variant("« Presquive » est utilisable sur les catalystes de sort pour en réduire les dégâts de 3 (minimum 0). Les effets associées à l’attaque « Presquivée » s’appliquent même si l’attaque n’inflige pas de dégâts."),
                    new Variant("« Presquive » réduit maintenant les dégâts reçus de 3 dégâts (MINIMUM 1), mais annule aussi les effets associées à l’attaque."),
                    new Variant("Au lieu de la compétence initiale, l’utilisateur gagne 3 utilisations de la compétence « Presquive » qu’il peut utiliser en ignorant la restriction d'une fois par combat. Ces utilisations se récupèrent après une nuit de sommeil.")
                ],
                "Citer « Presquive »"),
            new Competence(169, "Sabotage", "L’utilisateur peut, dans une situation hors-combat, saboter une arme de son choix. Pour se faire, il devra attacher un morceau de tissu (fourni par l’animation) sur l’arme et la toucher durant 30 secondes. L’arme sabotée obtient le statut « Brisé » après sa prochaine utilisation.", 
                [
                    new Variant("L’utilisateur peut, une fois par jour, prendre 5 secondes au lieu de 30 secondes pour saboter une arme."),
                    new Variant("L’utilisateur peut saboter une armure au lieu d’une arme."),
                    new Variant("Donne accès aux projets de sabotage, limite 1 par scénario. (Géopolitique)")
                ]),
            new Competence(170, "Sixième sens", "L’utilisateur peut, une fois par jour, connaître la puissance d’une cible. Doit être effectué en situation hors combat. Si utilisé chez un joueur, il devra mentionner son tiers de compétence le plus élevé. Cette compétence n'indique en rien l’agressivité de la cible.", 
                [
                    new Variant("Le nombre d'utilisation passe de 1 fois par jour à 2 fois par jour."),
                    new Variant("De plus, l’utilisateur peut, une fois par jour, savoir combien d’armes possède une cible sur elle au moment présent."),
                    new Variant("De plus, l’utilisateur peut, une fois par jour, esquiver les dégâts infligés par un piège.")
                ],
                "Citer « Sixième sens »"),
            new Competence(171, "Stabilisation", "Permet à l'utilisateur de consommer un kit de premiers soins afin de stabiliser une personne agonisante. L'application prend 2 minutes et remet le joueur à 1 PV. Donne aussi au joueur 3 kits de premiers soins au premier scénario suivant l’obtention de cette compétence.", 
                [
                    new Variant("Les PV Max de la cible, lors de la convalescence, sont augmentés de +3. Une régénération de 1 PV par tranche de 10 minutes durant sa convalescence lui est octroyée."),
                    new Variant("La durée de convalescence est réduite de 10 minutes. La cible gagne +1 PV Max pour sa convalescence et se soigne de 1 PV immédiatement."),
                    new Variant("La durée de la convalescence est réduite de 20 minutes. La cible restera inconsciente durant toute sa convalescence. Au terme de cette période, la cible se soigne de 2 PV.")
                ],
                "Aviser le joueur des conditions de sa convalescence."),
            new Competence(172, "Vol à la tire", "L’utilisateur peut voler une partie des avoirs d'une cible selon l’une des variantes ci-dessous. Une fois le vol réussi, l’utilisateur doit attendre une heure avant de retenter le coup. L’utilisateur doit sélectionner un endroit ou contenant sur sa cible qu’il dépouille. Il est possible de voler l’argent et tout ce qui est représenté par une carte d’objet, tout ce qui est un objet physique n’est pas obtenable par cette compétence.", 
                [
                    new Variant("L’utilisateur devra toucher la bourse de sa cible durant 10 secondes sans que cette dernière ne s’en rende compte. Il volera alors l’intégralité du contenu de cette bourse. La cible ne saura pas ce qui s’est passé."),
                    new Variant("L’utilisateur peut déclarer un vol à la tire instantané. Il pourra annoncer quelle bourse sera dérobée. Cette action est remarquable par tous."),
                    new Variant("L’utilisateur devra déposer discrètement un objet de petite taille (doit être approuvé au préalable) dans la bourse de sa cible pour que le vol soit réussi.")
                ],
                "Citer « Vol à la tire »")
        ];
        SpecialistT2 = 
        [
            new Competence(173, "Balistique", "L’utilisateur peut faire, une fois par combat, une frappe spéciale avec une arme de jet ou une arme de lancer (excluant les armes à feu). La première frappe lors d’un combat avec une arme de ce type effectue +1 dégâts (Actif).", 
                [
                    new Variant("En présence de deux autres utilisateurs de la compétence « Balistique » et qui utilisent des arcs,  l'utilisateur peut coordonner une nuée de flèches en prenant 5 secondes pour viser. La nuée de flèches est un effet de zone centrée sur une cible principale avec un diamètre de 10 pieds qui causera 3 dégâts sur toutes cibles à l’intérieur. Nul besoin de tirer réellement les flèches pour se faire. Tous les joueurs impliqués perdent leur utilisation de «  Balistique » pour la durée du combat."),
                    new Variant("De plus, l’attaque a l’effet « Renversement »."),
                    new Variant("L’utilisateur obtient un bonus de +1 dégât actif pour un total de +2 dégâts (actif).")
                ],
                "Citer « Nuée de flèches ! » et pointer les cibles et annoncer les dégâts (Variante 1), Renversement (Variante 2)"),
            new Competence(174, "Crochetage", "Permet à l’utilisateur de déverrouiller les serrures de niveau 1. Si aucun temps n’est mentionné sur le verrou, le temps par défaut est de 5 minutes.", 
                [
                    new Variant("De plus, l'utilisateur peut, une fois par jour, éviter les pièges d’un coffre. Par contre, l’effet se propage sur la cible la plus proche (ou les autres si un effet de zone est applicable)."),
                    new Variant("L'utilisateur doit jouer à pile ou face (hasard) lorsqu'il crochète un coffre pour la première fois du scénario. Si le joueur gagne, il gagne la condition « Chance » pour la prochaine instance de hasard. Par contre, s'il perd, il gagne la condition « Malchance » pour la prochaine instance de hasard."),
                    new Variant("L’utilisateur peut ramener son coffre crocheté avec une serrure de niveau 1 à l’animation pour quelques ressources.")
                ]),
            new Competence(175, "Détection d’intention", "Cette compétence n’est pas utilisable sur un joueur. L’utilisateur peut, deux fois par jour, sonder l’intention d’une créature. La réponse variera selon le degré d’intelligence de la créature.", 
                [
                    new Variant("De plus, l’utilisateur peut, dans une situation hors combat et deux fois par jour, déceler si une créature présente sa réelle apparence."),
                    new Variant("De plus, l’utilisateur peut, dans une situation hors combat et deux fois par jour, déceler si une créature est en détresse."),
                    new Variant("De plus, l’utilisateur peut, dans une situation hors combat et deux fois par jour, détecter un besoin essentiel inassouvi chez une créature.")
                ]),
            new Competence(176, "Frappe éclair", "La première frappe en combat de l’utilisateur fait +2 dégâts (Actif).", 
                [
                    new Variant("De plus, la frappe cause l’effet « Ralentissement » pour 15 secondes."),
                    new Variant("L’utilisateur obtient un bonus de +1 dégât (passif)."),
                    new Variant("De plus, la frappe cause l’effet « Silence » pendant 1 minute.")
                ]),
            new Competence(177, "Ingénierie", "Lorsqu’il contribue à un projet au village, l’utilisateur compte pour deux hommes! De plus, il obtient les recettes de fabrication de la variante choisie.", 
                [
                    new Variant("Poudre noire, munitions."),
                    new Variant("Kit de premiers soins, attelle."),
                    new Variant("L’utilisateur peut consommer une ressource contenant l’effet « Stimulant » et compter pour trois hommes lors d’un projet de son choix.")
                ]),
            new Competence(178, "Rafistolage", "L’utilisateur peut prendre 5 minutes pour improviser une réparation sur son arme. L’arme rafistolée perd temporairement sa condition « Brisée », mais ne récupère pas ses propriétés magiques. L’arme rafistolée regagne sa condition « Brisée » à la fin du prochain combat dans lequel elle est utilisée. Une arme ne peut être rafistolée qu’une seule fois avant de nécessiter de véritables réparations.", 
                [
                    new Variant("L'arme rafistolée ne dure que trois coups, mais octroie un bonus de +1 dégâts (actif)."),
                    new Variant("L'arme rafistolée peut encaisser un « brise-arme », mais si elle en subit un deuxième avant d’avoir reçu une réparation, elle gagnera la condition « Détruite »."),
                    new Variant("L’arme rafistolée peut, une fois par jour, désarmer son opposant lorsque la frappe touche l’arme de la cible. L’arme rafistolée récupérera la condition « Brisée » après cette action.")
                ],
                "pour la variante 3, citer « Désarmement »"),
            new Competence(179, "Réflexes", "L’utilisateur peut, pour le premier effet de zone dans un combat, éviter 2 dégâts. Il doit effectuer un mouvement pour l’éviter.", 
                [
                    new Variant("Si l’utilisateur évite TOUS les dégâts de l’effet de zone, il ignore aussi ses effets."),
                    new Variant("L’utilisateur évite 3 dégâts plutôt que 2."),
                    new Variant("L’utilisateur peut appliquer l’effet Réflexes à lui et une cible à portée de bras.")
                ],
                "Citer « Réflexe »"),
            new Competence(180, "Sutures", "L’utilisateur peut, suivant une scène de jeu de 2 minutes, infliger 2 de dégâts à une cible autre que lui-même pour lui permettre de se soigner de 5 PV, 15 minutes plus tard. Si la cible reçoit des dégâts durant le délai de 15 minutes, l’effet est terminé et la cible ne recevra pas la guérison. Cette compétence nécessite la consommation d'un kit de premiers soins. La cible doit être consentante ou inconsciente.", 
                [
                    new Variant("Suivant l’attente de 15 minutes, la cible se soigne maintenant de 6 PV."),
                    new Variant("Si la cible est sous l’effet « Hémorragie », l'utilisateur peut la soigner et interrompre cet effet dès que le jeu de rôle est amorcé. À la fin des 15 minutes, la cible est guérie."),
                    new Variant("L’utilisateur peut utiliser « Sutures » sur lui-même.")
                ]),
            new Competence(181, "Piège à ours", "L'utilisateur peut, trois fois par jour, prendre 2 minutes afin d’installer un piège. Ce dernier, lorsque activé par une cible marchant dessus, causera 2 points de dégâts et 30 secondes d’enchevêtrement. Le piège est caché et l’utilisateur devra déclarer l’effet à la victime qui tombe dessus. Lors de l’installation du piège, l’utilisateur doit être concentré, sinon il recevra 1 dégât physique de son piège, mais ne perdra pas l’utilisation de sa compétence.", 
                [
                    new Variant("La cible recevant les dégâts du piège à ours subit l’effet « Brise-Membre » sur la jambe de son choix."),
                    new Variant("Le piège fait maintenant un effet « Paralysie » 30 secondes plutôt que « Enchevêtrement »."),
                    new Variant("Votre piège peut être utilisé une seconde fois. L'utilisateur peut le prendre et le lancer à un autre endroit après son déclenchement. Si l’utilisateur possède un catalyseur ou une arme de lancer, il peut simuler le lancer du piège et si celui-ci touche une cible, il peut déclarer l’effet de manière instantanée. Vous pouvez vous déplacer avec le piège, mais si vous êtes victime de dégâts ou de déconcentration, le piège se déclenche sur vous.")
                ])
        ];
        BardT3 = 
        [
            new Competence(182, "Performance bardique", "L’utilisateur a 3 points de « Performance bardique ». Les points de « Performance bardique » se récupèrent après une nuit de sommeil. Ces points lui serviront principalement à utiliser la compétence, instaurant plusieurs effets à son public. Ces points peuvent aussi être utilisés afin d’activer des compétences connexes. Afin d’initier la compétence « Performance bardique », l’utilisateur devra commencer à chanter, danser, faire un discours, jouer d'un instrument, faire des blagues, etc. Après les premières 30 secondes de performance continue, l’utilisateur nommera l'effet de sa compétence, et pourra la continuer par la suite. L’effet dure jusqu’à la fin du prochain combat. Même s’il ne continue plus sa performance lors d’un combat, il peut tout de même rafraîchir cette compétence lors d’un combat.", 
                [
                    new Variant("La « Performance bardique » permet à l’utilisateur de donner à ses alliés l’entendant 3 PVT. L’utilisateur peut, au coût d’un point de Performance bardique,  rappliquer le bonus de 3 PVT en criant: « Rafraîchissement 3 PVT ! »."),
                    new Variant("Augmente le coût de démarrage de la « Performance bardique » à 2 points. Celle-ci fait participer l'entourage du barde, et les membres de celui-ci se verront attribuer une esquive pour la durée de la performance."),
                    new Variant("La « Performance bardique » permet à l’utilisateur d'octroyer une résistance contre le prochain effet de peur. L’utilisateur peut, au coût d’un point de Performance bardique, rappliquer cette résistance en criant : « Rafraîchissement Courage ! ».")
                ],
                "La performance bardique"),
            new Competence(183, "Crescendo", "Suite à une performance d’au moins 5 minutes où l’utilisateur à dépensé au moins 1 point de performance, il obtient une utilisation de Crescendo pour le prochain combat. Un effet positif  affecte les cibles ayant écouté la performance initiale tandis qu’un effet négatif affecte tous ceux qui n’ont pas écouté la performance initiale.", 
                [
                    new Variant("Crescendo Stabilisant : Supprime tous les effets mentaux néfastes sur ses alliés dans une situation de combat."),
                    new Variant("Crescendo Énergisant : Donne aux alliés un nombre de PM équivalent au sien au moment du crescendo (Maximum 5)."),
                    new Variant("Crescendo Angoissant : Décourage ses ennemis en donnant un malus de -1 (Passif) aux dégâts pour les cinq prochains coups portés, minimum 1.")
                ],
                "Citer « Tous ceux qui (n’)ont (pas) mon effet de performance, [Effet] »"),
            new Competence(184, "Fascination", "L’utilisateur peut utiliser un point de « Performance Bardique » afin de captiver son audience avec une performance. Les membres de l'audience ne pourront détourner leur regard de l'utilisateur pendant la performance, jusqu’à un maximum de 5 minutes. Une victime recevant des dégâts est libérée de cet effet (effet mental).", 
                [
                    new Variant("L'audience du barde sera pacifiée. Les cibles gagneront l’effet « Calme » durant la performance et les 5 minutes suivantes."),
                    new Variant("L'audience du barde sera confuse. Les cibles gagneront l’effet « Confusion » durant les 5 minutes suivant la performance."),
                    new Variant("L’audience du barde sera ralliée d'une pulsion révolutionnaire ! Les cibles auront envie de combattre la corruption et les institutions gouvernementales.")
                ],
                "Citer « Fascination »", 182),
            new Competence(185, "Fausse Note", "L’utilisateur peut, une fois par jour,  effectuer une fausse note particulièrement douloureuse. Cela peut être fait avec un instrument ou avec sa voix. Il causera alors 3 dégâts sur une zone de 10 pieds de rayon autour d’une cible à portée de voix.", 
                [
                    new Variant("De plus, l’utilisateur cause l’effet “paralysie” durant 5 secondes sur les cibles."),
                    new Variant("La fausse note déstabilise les auditeurs et désajuste leur armure. Le torse de l’armure des victimes perd toutes leurs charges de DR."),
                    new Variant("La fausse note ne cause que 2 dégâts, mais le fera à tous ceux qui prennent part au combat à portée de voix. Peut être utilisé en situation hors combat, dans ce cas, touchera tous ceux qui sont à portée de voix.")
                ],
                "Une fausse note bien désagréable suivie de (Variante 1) Paralysie 5 secondes! (Variante 2) Désajustement d’armure, ton torse te donne plus de bonus pour le combat! (Variante 3) 2 de dégâts à tout le monde qui m’entendent dans le combat!")
        ];
        BardT4 = 
        [
            new Competence(186, "Accelerando", "Après 5 minutes de performance continue, le barde obtient l'habileté d'utiliser un Accelerando lorsqu'il le veut lors du prochain combat. Les effets positifs ciblent les personnes qui ont écouté sa performance, les effets négatifs ciblent les gens qui n'ont pas écouté la performance. Note: Cet effet n’annule pas l’utilisation de Crescendo.", 
                [
                    new Variant("Accelerando Revivifiant : le barde qui utilise cette variante guérit alors ses alliés d'un montant de 3 PV instantanément."),
                    new Variant("Accelerando Tempétueux : le barde qui utilise cette variante commande la force des vents et possède maintenant 3 coups de vent. Ces coups de vents lui permettent de repousser tous les gens,  à l'intérieur d'un cône de 15 pieds, 90 degrés, de 10 pas dans la direction de son choix."),
                    new Variant("Accelerando Agonisant : le barde qui utilise cette variante cause un effet de douleur à toutes les cibles ennemies, leur causant 2 dégâts, les paralysant 5 secondes et leur faisant subir un effet d'engourdissement.")
                ],
                "Citer : (Variante 1) « Accelerando: Tous mes alliés guérissent de 3 pv.  » ; (Variante 2) « Accelerando : **Pointes cibles** Bouge 10 pas dans X direction ! » ; (Variante 3) « Accelerando : Tous mes ennemis qui m’entendent, 2 de dégâts »", 183),
            new Competence(187, "Marche funeste", "L’utilisateur, au coût d’un point de performance bardique, peut relever les morts, les mettre en file et les guider vers l'emplacement de son choix. Dès que la performance est terminée, les morts retombent. Les joueurs morts peuvent faire l'objet d'une résurrection pour être ramenés à la vie.", 
                [
                    new Variant("Le barde ne peut relever qu'un seul mort, mais celui-ci lui servira de garde du corps jusqu'à la fin de sa performance. Il ne peut utiliser sa performance normale conjointement avec cette variante. Ce mort vivant possède 10 points de vie, s’il tombe au combat: se relève après une minute d’agonie au maximum de ses PV tant qu’il est sous l’effet de Marche funeste, frappe de 2 et écoute les ordres de son utilisateur."),
                    new Variant("La marche funeste cause un effet de « Peur »  à tous ceux qui la croisent à moins de 10 pieds. La marche doit être en position afin que cette compétence soit fonctionnelle."),
                    new Variant("La marche funeste est festive et cause un effet de « Courage » à tous ceux qu'elle rencontre. Les marcheurs sont encouragés à garder une mise en scène festive, comme danser et festoyer.")
                ],
                182),
            new Competence(188, "Performance avancée", "L’utilisateur gagne un bonus permanent de points bardique de 2 pour un total de 5. L’utilisateur peut choisir une variante avancée, ou les deux autres variantes de la compétence Performance Bardique (T3) . Tous les effets de la Performance Bardique et de la Performance avancée s'activent en même temps.", 
                [
                    new Variant("Marche de Guerre : L'entourage du barde se verra octroyer un bonus de +1 (Non-typé, cumulatif) à toutes les sources de dégâts effectués (physiques, magiques, etc.) pour le combat suivant la performance."),
                    new Variant("Indomptable : L'entourage du barde se verra octroyer une (1) résistance aux effets mentaux. Le barde peut rafraîchir cette résistance au coût de 1 performance bardique en criant  « Rafraîchissement Indomptable ! » pendant le prochain combat, suite à sa performance."),
                    new Variant("Concentration : L'entourage du barde se verra octroyer une charge pour éviter d’être déconcentré. Le barde peut rafraîchir cette résistance au coût d'un point de performance bardique en criant « Rafraîchissement Concentration ! »")
                ],
                "La performance", 182),
            new Competence(189, "Trio", "Permet à un ensemble comptant 3 bardes minimum de s'agencer ensemble et de donner tous leurs bonus combinés à leur entourage. Tous les bardes faisant partie du trio doivent utiliser leur point de performance bardique. NOTE: Les compétences Crescendo (T3), Accelerando (T4) et Apogée (T5) ne s'activent que pour un seul membre du groupe, décidé au préalable. Le membre choisi par compétences peut être différent.", 
                [
                    new Variant("Si la même variante d’une des compétences « Performances » est prise par tous les membres du groupe, le groupe peut décider de ne donner uniquement que ce bonus, mais le doubler. Cette variante doit être prise par au moins trois membres du groupe."),
                    new Variant("Si toutes les variantes d'une des compétences « Performances » sont couvertes par les membres du groupe, le barde qui possède cette variante de « Trio » est immunisé à la déconcentration lorsqu'il donne la performance. De plus, au départ de sa performance de groupe, il possède 1 PVT par compétence « Performance Bardique » entièrement couverte."),
                    new Variant("L’utilisateur peut, pendant une performance de groupe ET seulement une fois durant cette dernière, causer une onde sonore qui repoussera un assaillant de 10 pas. Cette onde sonore a une portée de 20 pieds et ne touche que sa cible.")
                ],
                "La performance", 182)
        ];
        TrapperT3 = 
        [
            new Competence(190, "Crochetage du trappeur", "Permet à l’utilisateur de déverrouiller les serrures de niveau 2. Si aucun temps n’est mentionné sur le verrou, le temps par défaut est de 5 minutes.", 
                [
                    new Variant("Permet de détecter la présence d’un piège avant de le déclencher. (Permet de refermer le coffre sans activer le piège ni prendre les récompenses s’il est piégé.)"),
                    new Variant("L’utilisateur peut, une fois par jour, éviter les effets / dégâts d’une serrure piégée."),
                    new Variant("L’utilisateur peut, une fois par scénario, ne pas activer le piège d’une serrure piégée.")
                ]),
            new Competence(191, "Détection de piège", "L'utilisateur peut, trois fois par jour, détecter un piège qu'il soit caché ou non.  En donjon, l'utilisateur devra énoncer sa compétence au maître du donjon présent en entrant dans celui-ci. Suite à l'activation il devra mentionner s’il utilise une prochaine charge ou non.", 
                [
                    new Variant("L'utilisateur peut troquer une utilisation de cette compétence pour esquiver un piège."),
                    new Variant("Lors d'un donjon, l'utilisateur troque une utilisation de sa compétence pour un indice concernant une énigme. La compétence hors donjon reste la même."),
                    new Variant("La compétence est strictement utilisable en donjon et en exploration. Elle permet de faire esquiver l'utilisateur et son groupe au complet d'un piège déclenché. Utilisable qu'une fois par scénario.")
                ]),
            new Competence(192, "Piège de combat", "L'utilisateur peut utiliser des pièges en combat. Beaucoup plus simple que les pièges standards, les pièges de combat s'utilisent en lançant un « jeton de piège » (approuvé par l'animation). Si le jeton est lancé sur un joueur, le jeton et l'utilisation sont perdus. Chaque jeton de piège prend 5 minutes à préparer. L'utilisateur peut avoir un maximum de 2 jetons de piège sur lui et ne peut pas les donner à autrui. Lorsque le jeton de piège est déclenché par la cible, le trappeur décide de l'effet du piège entre les effets suivants : 2 dégâts OU renversement OU désarmement. Une fois le jeton déclenché, il ne peut plus être réutilisé. L’utilisateur peut désamorcer son piège en tout temps s’il n’a pas été utilisé moyennant un temps de 5 minutes, récupérant ses points.", 
                [
                    new Variant("L'utilisateur obtient un bonus de +1 jeton de piège sur lui pour un maximum de 3."),
                    new Variant("L'effet des dégâts devient 3 dégâts."),
                    new Variant("La création de jeton prend 2 minutes au lieu de 5.")
                ]),
            new Competence(193, "Piège novice", "L’utilisateur peut confectionner des pièges standards. Ils servent à protéger des objets tels que des coffres, des portes ou des passages. La liste des effets utilisables pour les pièges standards est décrite dans l’annexe 1. Cette compétence donne à l'utilisateur 3 points de trappe qui lui servent à les créer. Poser un piège standard prend 15 minutes pouvant être interrompues et reprises par la suite, si l'objet sur lequel le piège est posé n'a pas été bougé, utilisé ou endommagé. Dans le cas contraire, le  temps de 15 minutes recommence. Piège novice ne permet d'avoir qu'un seul piège standard actif à la fois. Un piège persiste jusqu'à la fin d'un scénario ou jusqu'à ce qu'il soit utilisé et/ou vidé de ses charges. Il est la responsabilité du trappeur d'inscrire les effets du piège s'il veut que celui-ci fonctionne durant son absence. Les points sont récupérés une fois que le piège est rendu inutilisable. (Brisé, désarmé, vidé, etc).", 
                [
                    new Variant("Le délai de pose est réduit de 10 minutes pour un total de 5 minutes."),
                    new Variant("L'utilisateur obtient un bonus de 1 point de trappe pour un total de 4."),
                    new Variant("L’utilisateur peut investir 2 points de trappe dans un piège standard pour avoir l'option de la déclencher à distance. Pour ce faire, il doit avoir un moyen d'avertir les cibles.")
                ])
        ];
        TrapperT4 = 
        [
            new Competence(194, "Amélioration de piège", "L'utilisateur peut ajouter un effet de piège sur un piège qu'il n'a pas créé lui-même. Il doit payer le coût en points de trappe et inscrire l'effet ajouté sur la carte du piège. Le temps d'application est de 5 minutes par point de piège dépensé à cet effet. Un piège modifié ne peut pas être modifié de nouveau par cette compétence.", 
                [
                    new Variant("Le piège gagne un effet de zone de 10 pieds autour d’elle."),
                    new Variant("L'utilisateur obtient la possibilité d’ajouter un second effet moyennant le coût en point de trappe sur le piège en question."),
                    new Variant("La piège obtient, si elle effectuait des dégâts instantanés, des dégâts « perce-armure ».")
                ],
                193),
            new Competence(194, "Déclenchement automatique", "L’utilisateur peut déclencher un piège installé OU déplacé par lui-même. Ainsi, il peut piéger une cible qui se trouve dans un rayon de 10 pieds autour du piège en question.", 
                [
                    new Variant("L'utilisateur doit se trouver dans un rayon de 20 pieds autour de son piège pour l'activer."),
                    new Variant("Le piège peut affecter 2 individus (ou créatures) dans un rayon de 10 pieds autour du piège. L'utilisateur doit être à portée de bras du piège."),
                    new Variant("Le piège peut affecter 1 individu ou une créature dans un rayon de 20 pieds autour du piège. L'utilisateur doit être à portée de bras du piège pour agir.")
                ],
                193),
            new Competence(195, "Désamorcer", "L’utilisateur peut désamorcer un piège. Si la durée du désamorçage n'est pas affichée sur le piège, cette action dure 5 minutes durant lesquelles l'utilisateur ne doit pas être dérangé. En cas de déconcentration, il déclenchera le piège.", 
                [
                    new Variant("L’utilisateur peut recevoir un effet ou un dégât une fois durant le désamorçage, mais ceci augmente l'action de 10 minutes."),
                    new Variant("Si le piège est correctement désamorcé, l’utilisateur obtient un bonus de +2 PVTs jusqu'à la fin du prochain combat."),
                    new Variant("Si le piège est correctement désamorcé, il peut être échangé contre des points de trappe (novice = 1 point, intermédiaire = 2 points, avancé = 3 points).")
                ]),
            new Competence(196, "Piège intermédiaire", "L’utilisateur obtient un bonus de +2 points de trappe. Il peut maintenant créer des pièges possédant les effets de niveau intermédiaire.", 
                [
                    new Variant("Si le piège effectue des dégâts, ceux-ci sont augmentés de +2 (passif)."),
                    new Variant("Si le piège effectue un effet avec une durée, celle-ci est augmentée de +5 de son dénominateur (+5 secondes pour un piège en secondes, 5 minutes pour un piège en minutes…)"),
                    new Variant("Le trappeur peut utiliser 2 points de trappe pour obtenir l'effet « Chance » sur la prochaine instance de récolte de chasse.")
                ])
        ];
        RogueT3 = 
        [
            new Competence(197, "Camouflage", "L'utilisateur peut gagner l’effet « Invisible ». Si l’utilisateur dégaine, attaque, parle ou court, l'invisibilité est terminée. NOTE : l’utilisateur peut se faire entendre malgré son camouflage. Afin de débuter la compétence, l'utilisateur ne doit avoir aucun regard sur lui.", 
                [
                    new Variant("La compétence « Camouflage » peut être utilisée 3x par nuit. L’utilisateur doit se déplacer d'ombre en ombre. Son invisibilité termine s’il est à une distance de moins de 10 pieds d’une source lumineuse (feu de camp, torche, etc.)."),
                    new Variant("Utilisable 1 fois par jour. L’utilisateur n’est pas limité dans ses déplacements. L’invisibilité se termine suivant un délai de 30 minutes ou si l’utilisateur le rompt."),
                    new Variant("Utilisable 3 fois par jour. L’utilisateur n’est pas limité dans ses déplacements. L’invisibilité se termine suivant un délai de 5 minutes ou si l’utilisateur le rompt.")
                ]),
            new Competence(198, "Coup sournois", "L’utilisateur peut, une fois par jour ET dans une situation hors combat, asséner un coup dans le dos d’une cible, occasionnant un bonus de +4 dégâts (actif). La touche doit être faite avec une arme de moins de 50 cm.", 
                [
                    new Variant("L'action peut être effectuée 3 fois par jour."),
                    new Variant("Pour la durée du combat, l’arme de l’utilisateur gagne l’effet « Perce-armure » contre sa cible."),
                    new Variant("L’action peut être effectuée avec tous types d’armes de corps à corps.")
                ],
                "Citer « Perce-armure (Variante 2) »"),
            new Competence(199, "Crochetage avancé", "Permet à l’utilisateur de déverrouiller les serrures de tiers 2. Si aucun temps n’est mentionné sur le verrou, le temps par défaut est de 5 minutes.", 
                [
                    new Variant("Si l’utilisateur apporte le coffre déverrouillé avec une serrure de tiers 2 à l'animation, il pourra obtenir une ressource minérale aléatoire de tiers 3 et moins."),
                    new Variant("Si l’utilisateur apporte le coffre déverrouillé avec une serrure de tiers 2 à l'animation, il pourra obtenir une ressource naturelle aléatoire de tiers 3 et moins."),
                    new Variant("Si l’utilisateur apporte le coffre déverrouillé avec une serrure de tiers 2 à l'animation, il pourra obtenir une ressource animale aléatoire de tiers 3 et moins.")
                ],
                174),
            new Competence(200, "Déconcentration", "L’utilisateur peut briser la concentration d’une cible en lui lançant un catalyseur. Le catalyseur doit toucher la cible afin de la déconcentrer. La compétence peut être utilisée en boucle tant que l’utilisateur se déplace pour aller récupérer son catalyseur avant de retenter. Cette compétence ne peut être modifiée par une autre compétence.", 
                [
                    new Variant("Au lieu d'utiliser un catalyseur, l’utilisateur peut effectuer une action loufoque (pas de danse, crier une blague, etc.),  mais doit avoir un contact visuel (yeux dans yeux) avec son opposant. Cette variante ne peut être utilisée qu’une fois par combat par cible."),
                    new Variant("Cette compétence peut aussi être utilisée pour interrompre un sort nécessitant une concentration soutenue (Canalisation)."),
                    new Variant("Utilisable avec une arme de jet : dans ce cas, les dégâts sont applicables. ")
                ],
                "Citer « Déconcentration »")
        ];
        RogueT4 = 
        [
            new Competence(201, "Égorgement", "L'utilisateur peut, trois fois par jour, faire une attaque surprise à une cible. Il devra alors lui mettre une arme tranchante sous la gorge. La frappe aura un bonus de +4 dégâts (actif), sera « perce-armure » et la cible sera sous l’effet « silence » jusqu’à guérison. La frappe doit être faite avec une arme de moins de 50 cm.", 
                [
                    new Variant("L'attaque ne fait que +2 dégâts (actif), mais cause l'effet « blessure grave »."),
                    new Variant("L'égorgement inflige des dégâts magiques."),
                    new Variant("L'utilisateur paralyse sa cible tant qu'il a sa lame sous la gorge de celle-ci, s'il la tient pendant une minute sans être remarqué par quelqu’un d’autre que la cible, l'égorgement est fatal et la cible tombe à l'agonie immédiatement.")
                ],
                "Citer : Variante 1 : « Égorgement X, Blessure grave » ; Variante 2 : « Égorgement X magique » ; Variante 3 : « Égorgement, paralysie tant que je te tiens »"),
            new Competence(202, "Esquive", "L’utilisateur peut esquiver totalement les dégâts et les effets physiques d’une touche ou d’un sort. Attention, les esquives ne fonctionnent pas sur les effets mentaux.", 
                [
                    new Variant("L’utilisateur doit jouer le mouvement de l’esquive. Il peut esquiver une fois par combat."),
                    new Variant("L'utilisateur peut esquiver sans jouer le mouvement de l’esquive. Il peut esquiver trois fois par jour."),
                    new Variant("L'utilisateur déclare « Esquive ! » lorsqu'il le veut, et les dégâts non-typés qu'il reçoit sont diminués de 3 (minimum 1) pour la durée d'un combat. Le Roublard ne possède qu'une esquive par jour.")
                ],
                "Citer clairement « Esquive ! »"),
            new Competence(203, "Force de caractère", "L'utilisateur peut résister à un effet mental par jour.", 
                [
                    new Variant("De plus, l'utilisateur peut, trois (3) fois par jour, faire croire à un interrogateur qu'il dit la vérité, même s'il ment. Cette compétence fonctionne sous la torture et fonctionne sous les effets de vérité."),
                    new Variant("L’utilisateur peut maintenant résister à un effet mental par combat."),
                    new Variant("De plus, l'utilisateur peut, trois (3) fois par jour, ignorer les effets de la douleur.")
                ],
                "Citer « Force de caractère »"),
            new Competence(204, "Frappe incapacitante", "L'utilisateur peut, trois (3) fois par jour, effectuer une frappe qui causera +2 dégâts (actif) et un effet additionnel (voir variante).", 
                [
                    new Variant("Effet « Hémorragie » 10 minutes."),
                    new Variant("Effet « Brise membre » sur une jambe jusqu’à guérison."),
                    new Variant("Effet « Silence » 10 minutes.")
                ],
                "Citer l’effet additionnel, les dégâts et la durée.")
        ];
        TechnicianT3 = 
        [
            new Competence(205, "Arme personnalisée", "L’utilisateur peut modifier son arme à feu (1) selon les options suivantes : le fusil d’assaut ou le canon magnétique. Le fusil d’assaut est un fusil à poudre capable de prendre des balles avancées. Ces balles sont créées par des compétences de l’arbre du travailleur. Le canon magnétique est une arme pouvant tirer qu’une seule fois par combat, mais offre effectue des dégâts de 1  + le tiers de la ressource utilisée. Une ressource métallique est utilisée par tir.", 
                [
                    new Variant("Lors de l’enregistrement de son arme personnalisée, l’utilisateur recevra des ressources comme suit : pour un fusil d’assaut, il obtiendra un ingrédient de son kit de munition. Pour un canon magnétique, il obtiendra une ressource métallique déjà chargée dans l’arme (non réutilisable)."),
                    new Variant("Pour un canon magnétique, si la ressource métallique utilisée est de Tiers 3 ou moins, elle peut être utilisée pour un second tir lors d’un prochain combat. Le second tir est perdu si la ressource est changée."),
                    new Variant("Pour un fusil d’assaut, l’utilisateur possède un deuxième type de munitions. Il peut interchanger celles-ci lors d’un combat. Vous déciderez à la fin du combat quelles munitions vous gardez pour le reste de l’évènement.")
                ]),
            new Competence(206, "Audacieux", "L’utilisateur obtient 3 points d'audace. Il pourra utiliser ces points afin d'obtenir différents bonus. De plus, il peut utiliser 1 point d'audace afin d’effectuer une frappe « perce-armure ».", 
                [
                    new Variant("L'utilisateur peut, une fois par combat, récupérer 2 points d’audace lorsqu’il passe sous la moitié de ses PV."),
                    new Variant("L’utilisateur peut, une fois par heure passée en situation hors combat, regagner 1 point d’audace."),
                    new Variant("L’utilisateur peut récupérer 1 point d’audace lorsqu’il crée un objet via une compétence de l’arbre du Travailleur.")
                ],
                "Citer « Perce-armure »"),
            new Competence(207, "Cautérisation", "L’utilisateur peut, une fois par combat et tout de suite après avoir tiré un coup de feu, cautériser une plaie récente. Aucun PV ne sera gagné immédiatement, mais l’utilisateur gagnera le montant de PV perdu lors de la dernière touche précédant l’utilisation de la compétence à la fin du combat. Si l’utilisateur sombre dans l’agonie, aucun soin ne sera prodigué.", 
                [
                    new Variant("De plus, l’utilisateur peut dépenser 1 point d'audace pour avoir les bienfaits de manière instantanée."),
                    new Variant("De plus, l’utilisateur peut dépenser 1 point d'audace pour ajouter un bonus de +2 PV à la guérison. Il peut ajouter un maximum de 3 points d'audace pour avoir un bonus total de +6 PV."),
                    new Variant("De plus, l’utilisateur peut, suite à un tir et pour 1 point d’audace, canaliser pendant 10 secondes le pouvoir de son fusil afin d’effectuer un cône de flammes de 10 pieds devant lui, qui causera 3 points de dégâts de feu à toutes les cibles.")
                ],
                "Variante 3 : citer « Cône de flammes » , pointer les cibles et annoncer les dégâts."),
            new Competence(208, "Réparation de fortune", "L’utilisateur peut réparer n'importe quoi à un certain prix (voir variantes).", 
                [
                    new Variant("L’utilisateur peut réparer n'importe quelle arme brisée. La réparation ne prend que 30 secondes. Cette arme, pour la durée d'un combat, fera un bonus de +1 dégâts (base), par contre elle obtiendra la condition « Détruite » suite au combat. Cette capacité ne peut être utilisée que sur une cible consentante et sur une arme non-magique."),
                    new Variant("L’utilisateur peut réparer n'importe quelle armure brisée. La réparation ne prend que 30 secondes. Cette armure aura un bonus de +1 DR et regagne toutes ses utilisations.  Par contre l'armure ne sera plus réparable par la suite et, lorsque toutes ses utilisations seront utilisées, elle sera « Détruite ». Cette capacité ne peut être utilisée que sur une cible consentante et sur une armure non-magique."),
                    new Variant("L’utilisateur peut transformer un objet magique en bombe arcanique. Cette bombe est instable et brise lors d’un impact. Si un impact venait à arriver, la bombe arcanique fera un +2 de dégâts par ensorcellement différent sur l'objet, dans un rayon de 10 pieds autour de celui-ci, et l'objet sera détruit.")
                ],
                "Variante 3 : citer « Bombe arcanique » , pointer les cibles en annoncer les dégâts")
        ];
        TechnicianT4 = 
        [
            new Competence(209, "Arme personnalisée avancée", "L'utilisateur améliore son arme personnalisée. Fusil d'assaut : Celui-ci peut maintenant utiliser un chargeur de 6 balles ou moins. Canon magnétique : Ses dégâts augmentent à 3 + Tiers de la ressource utilisée.", 
                [
                    new Variant("De plus, l'utilisateur peut maintenant posséder une deuxième arme personnalisée, de l'autre type que celle qu'il possède déjà. Il pourra aussi choisir une seconde variante de la compétence « Arme Personnalisée »."),
                    new Variant("Pour un fusil d’assaut, chaque sixième balle tirée effectuera +3 dégâts (passif)."),
                    new Variant("Pour un canon magnétique, celui-ci accumule maintenant assez de charge pour tirer jusqu'à trois fois pendant un même combat.")
                ],
                205),
            new Competence(210, "Audace sans limite", "L’utilisateur obtient un bonus de 2 points d’audace pour un total de 5.", 
                [
                    new Variant("L’utilisateur peut, au coût d’un (1) point d’audace, utiliser son pistolet afin de faire une frappe ricochet. Lorsqu'il touche une première cible avec son pistolet, il peut déclarer deux autres cibles qui prendront autant de dégâts. Les trois cibles ne peuvent pas être à plus de 15 pieds l'une de l'autre."),
                    new Variant("L’utilisateur peut, au coût d’un (1) point d’audace, désarmer une cible. Cette attaque ne cause aucun dégât. La cible doit échapper ce qu'elle a dans les mains. Si la cible tient un objet explosif, celui-ci explosera. Si la cible tient une potion ou un autre objet fragile, celui-ci brisera."),
                    new Variant("L’utilisateur peut, au coût d’un (1) point d’audace, surcharger son arme et causer une frappe peu précise. Celle-ci ne causera pas de dégâts, mais causera un « Renversement » sur toutes les cibles dans un cône de 10 pieds, 90 degrés, derrière la cible initiale.")
                ],
                "Variante 1 : citer « Ricochet, toi, toi et toi, X ! » ; Variante 2 : « Désarmement ! » ; Variante 3 : citer « Vous tous, Renversement ! »"),
            new Competence(211, "Bravade", "L'utilisateur peut annuler à n'importe quel moment un effet de « Peur» sur lui-même, au coût d'un point d'audace. La variante est active uniquement lorsqu'il lui reste des points d'audace.", 
                [
                    new Variant("L’utilisateur est maintenant immunisé à la peur."),
                    new Variant("l’utilisateur, au coût d’un (1) point d’audace, est maintenant capable de mettre sur pause les effets de peur en faisant un discours, si le discours dure 30 secondes ou plus: il peut annuler tous les effets de peur autour de lui à une portée de 50 mètres."),
                    new Variant("L’utilisateur possède maintenant une résistance mentale par jour.")
                ],
                206),
            new Competence(212, "Surtension", "L’utilisateur peut, trois fois par jour ET sur des objets différents, améliorer temporairement quelque chose de manière dangereuse et potentiellement dommageable. Toutes les modifications prennent une minute à appliquer.", 
                [
                    new Variant("L’utilisateur modifie une arme à feu. Celle-ci fait maintenant +2 dégâts (base), mais cause à son utilisateur deux points de dégâts de feu par tir. Ce bonus est d’une durée d’un combat. Si l’arme est celle de quelqu’un d’autre, elle doit être consentante, sans quoi cette variante compte comme un bris et rien d’autre."),
                    new Variant("L’utilisateur modifie un objet magique à charge. Cet objet bénéficiera de quelques bonus : L’effet est augmenté de 1 tiers et l’objet possèdes deux (2) charges supplémentaires. Par contre, dès que l'objet est complètement déchargé, il sera détruit."),
                    new Variant("L’utilisateur modifie une concoction alchimique. Celui-ci peut électrolyser (doit la secouer vigoureusement durant 1 minute) une concoction afin d'en activer les éléments chimiques et augmenter l'effet de la concoction 1 (ex.: guérison +1, dégâts +1, etc.). Par contre, sa toxicité est doublée. Seul l'utilisateur peut boire une concoction augmentée d'une telle manière. Si elle est bue par quelqu'un d'autre, elle aura son effet normal.")
                ])
        ];
        CharlatanT3 = 
        [
            new Competence(213, "Diagnostic", "Suite à une scène de 5 minutes dans le but de diagnostiquer une cible, l’utilisateur peut connaître les effets négatifs sur sa cible ainsi que son nombre de PV restants. Si l’effet affligeant la cible est « Hémorragie », elle peut interrompre le charlatan afin de lui dire son mal au début de la scène.", 
                [
                    new Variant("De plus, permet de soigner un membre brisé avec une attelle à la suite du 5 minutes de diagnostic. La cible qui se voit avoir un membre réparé subit 2 dégâts perce-armure et inesquivables, ne peut utiliser ce membre pendant les 30 prochaines minutes, et si elle prend un coup sur ce membre pendant 30 minutes, il rebrise."),
                    new Variant("De plus, permet à l’utilisateur de connaître le nombre de PM restant à sa cible."),
                    new Variant("De plus, l’utilisateur peut, une fois par heure et par cible, faire consommer à une cible, dans une situation hors-combat, une ressource de plante pour lui donner 2 PV et 2 PM. Par contre, la cible subira l'effet secondaire de la plante pour les 5 prochaines minutes.")
                ],
                "Citer « Diagnostic »  et demander à la personne, hors jeu, ses maux."),
            new Competence(214, "Hypnose", "L’utilisateur peut, une fois par scénario, hypnotiser une cible consentante. La séance doit être faite dans un lieu sûr et sécurisé et l’utilisateur doit avoir un pendule. L’animation doit être avertie de préférence 4 heures au préalable de l'utilisation de la variante 1 et 2.", 
                [
                    new Variant("L’utilisateur peut aller visualiser les rêves de sa cible. Peut nécessiter l’animation."),
                    new Variant("L’utilisateur peut explorer l’esprit de la cible. Requiert l’animation."),
                    new Variant("L’utilisateur peut éliminer un effet mental spécifique.")
                ]),
            new Competence(215, "Imitateur", "L'utilisateur peut, une fois par jour, copier une compétence vue durant la dernière heure ainsi que sa variante. Ainsi, il pourra utiliser ladite compétence durant le reste du scénario. Seulement les compétences de tiers 3 et moins sont admissibles. Attention, ne fonctionne pas sur les créatures ni les personnages non-joueurs. Si l’utilisateur copie une compétence alors qu’il en a déjà copié une, il doit se départir d’une des deux compétences.", 
                [
                    new Variant("Permet de copier une compétence du Tronc Spécialiste."),
                    new Variant("Permet de copier une compétence du Tronc Martial."),
                    new Variant("Permet de copier une compétence du Tronc Arcane.")
                ]),
            new Competence(216, "Saignée", "L’utilisateur peut, suivant une scène de 2 minutes, ouvrir une plaie sur une cible. lui occasionnant 2 points de dégâts. Suivant un délai de 10 minutes, la cible sera guérie de 7 PV. S’il possède une ressource « Sangsue », l’utilisateur peut s’en servir pour enlever tous les effets alchimiques affectant la cible. Si la cible reçoit des dégâts durant le délai de 10 minutes, la guérison ne se produira pas et la sangsue meurt. Un joueur ne peut recevoir qu’une saignée par jour. L'utilisateur obtient aussi un lot de 3 sangsues lorsqu’il acquiert cette compétence.", 
                [
                    new Variant("L’utilisateur peut garder une sangsue qui a absorbé un effet alchimique pour l’utiliser comme ingrédient."),
                    new Variant("L’utilisateur peut garder une sangsue qui a absorbé un effet alchimique pour la consommer ou la faire consommer afin de donner tous les effets."),
                    new Variant("Plutôt que d’enlever les effets alchimiques, la sangsue vole, à la fin du 10 minutes, 10 PMs à la cible. La sangsue peut être consommée pour régénérer le consommateur de 5 PMs.")
                ])
        ];
        CharlatanT4 = 
        [
            new Competence(217, "Diagnostic erroné", "L’utilisateur peut instantanément échanger une maladie pour une autre. Voir Annexe 3.", 
                [
                    new Variant("De plus, l’utilisateur peut modifier le temps de la maladie au lieu de la modifier. Il peut la réduire ou l'augmenter de 50% de son temps maximal."),
                    new Variant("De plus, l'utilisateur peut modifier la maladie de sa cible pour une d'un tiers supérieur, empirant ainsi le diagnostic."),
                    new Variant("De plus, l'utilisateur peut utiliser une sangsue sur sa cible lors du diagnostic afin de garder une copie de sa condition et pouvoir la donner à quelqu'un d'autre. Doit être fait avant d'avoir changé le diagnostic. Afin d'appliquer la condition absorbée, il doit utiliser la sangsue en tant qu'un onguent dans un kit de premier soins.")
                ]),
            new Competence(218, "Frappe ensanglantée", "L'utilisateur peut, une fois par jour, faire une touche causant des dégâts létaux mais lents.", 
                [
                    new Variant("La touche n'effectue pas de dégât instantané, mais cause l'effet « Hémorragie » pendant 10 minutes à la cible, lui faisant perdre 1 PV par minute."),
                    new Variant("La touche n'effectue pas de dégât instantané, mais, dès la fin du combat, la cible subit 8 dégâts inesquivables et perce-armure."),
                    new Variant("La touche bloque toute tentative de soins (magiques ou non) pour la durée du combat. Si la cible tombe à l'agonie, l’effet se termine.")
                ]),
            new Competence(219, "Réparation sur mesure", "L'utilisateur peut maintenant réparer un membre brisé avec l’usage d’une attelle. Il devra effectuer une scène de cinq minutes afin de la poser. Le patient sera guéri après un délai de 10 minutes.", 
                [
                    new Variant("La guérison d'un membre est douloureuse, la cible subit 2 dégâts (inesquivables et perce-armure)."),
                    new Variant("Un membre récemment brisé demeure faible. Si la cible reçoit un coup sur le membre réparé moins de 20 minutes suivant la réparation, le membre brisera de nouveau."),
                    new Variant("Bien qu'il soit guéri, l'utilisateur souffre d'une faiblesse dans le membre réparé pendant 1 heure. Si le membre est un bras, il ne peut pas l’utiliser (porter de bouclier, porter des coups, fabriquer un objet, etc.). Si le membre est une jambe, celui-ci ne peut pas courir pendant la période de faiblesse.")
                ]),
            new Competence(220, "Soins longue durée", "L’utilisateur peut, suivant l’utilisation d’un kit de premier soins et une scène continue, guérir les plaies d'une cible sur une longue durée, occasionnant une régénération d'1 PV par minute. Il ne devra pas être déconcentré, sinon la compétence se termine.",
                [
                    new Variant("L’utilisateur peut maintenir les soins sur deux cibles en même temps, au coût de deux kits de premier soins, un pour chaque cible."),
                    new Variant("L’utilisateur peut effectuer les soins sur lui-même, dans le cas échéant la régénération sera d'1 PV par 5 minutes."),
                    new Variant("L’utilisateur double la régénération sur la cible (2 PVs par minute).")
                ])
        ];
        InquisitorT3 = 
        [
            new Competence(221, "Coroner", "L’utilisateur peut, une fois par jour ET par cible, savoir par quelle façon cette dernière a été tuée selon les causes suivantes : physique, magique ou de maladie.", 
                [
                    new Variant("L’utilisateur peut aussi identifier le type d’arme qui a causé le décès. Permet aussi d’identifier l’arme du crime s’il la voit. Si c’est un sort, il peut en déterminer l’élément."),
                    new Variant("L’utilisateur peut obtenir une description sommaire de l’attaquant (3 adjectifs seulement)."),
                    new Variant("Le mort peut donner, au meilleur de ses connaissances, l’identité d’un témoin de la scène.")
                ]),
            new Competence(222, "Interrogatoire", "L’utilisateur peut, une fois par scénario, par cible ET suivant une discussion soutenue de 5 minutes, poser une question en rapport au sujet discuté. La cible devra répondre au meilleur de ses capacités, sans mentir. Cette discussion doit être faite en seul à seul.",
                [
                    new Variant("De plus, l’utilisateur peut poser une question suite à une discussion de groupe à une seule cible faisant partie du groupe. La question et la réponse seront effectuées seul à seul, mais la totalité du groupe sera considéré comme « utilisé » dans le cadre de la compétence."),
                    new Variant("De plus, la cible ne se souvient pas d’avoir été questionnée."),
                    new Variant("Au lieu de la compétence initiale, l’utilisateur pourra poser 3 questions à sa cible, mais seulement à une cible par jour.")
                ],
                "Citer « Interrogatoire »"),
            new Competence(223, "Intimidation", "L’utilisateur peut, une fois par jour, administrer un effet sur une cible à portée de voix durant 5 minutes.", 
                [
                    new Variant("L’utilisateur crée un effet de peur."),
                    new Variant("L’utilisateur crée un effet de calme."),
                    new Variant("L'utilisateur crée un effet d'agacement.")
                ],
                "Variante 1:  citer « Peur » ; Variante 2 : citer « Calme » ; Variante 3 : citer « Agacement »"),
            new Competence(224, "Psychologie", "L’utilisateur peut, deux fois par jour, interagir durant 1 minute avec une cible pour déterminer si cette dernière est sous un effet affectant son comportement ou ses connaissances. L’utilisateur peut ensuite exécuter une scène de 5 minutes de afin de traiter un (1) effet qui a été identifié.", 
                [
                    new Variant("L’utilisateur peut connaître le nombre d'effets affectant le comportement de sa cible."),
                    new Variant("L’utilisateur peut connaître le nom de l’effet affectant le comportement le plus handicapant selon la cible."),
                    new Variant("La cible peut dire, au meilleur de ses connaissances en jeu, quelle a été la source du dernier effet affectant son comportement qu’elle a reçu. Cette variante ignore les effets d’amnésie.")
                ])
        ];
        InquisitorT4 = 
        [
            new Competence(225, "Deus Vult", "L'utilisateur peut, une fois par jour et durant 15 minutes continues, se rendre immunisé à tous les effets mentaux. Cette compétence peut être activée même sous l'effet d'un effet mental débilitant. Si les effets mentaux ont une durée supérieure à 15 minutes, ils reviendront à la suite de la durée de la compétence. Les effets obtenus lors de la compétence ne comptent pas dans ce délai puisqu’elles ne s’appliquent simplement pas.", 
                [
                    new Variant("De plus, lorsque la compétence est active ET que l’utilisateur subit un effet mental, il obtient 2 PVT."),
                    new Variant("De plus, l'utilisateur peut décider de sacrifier son utilisation de cette compétence pour l'appliquer sur un allié."),
                    new Variant("De plus, l'utilisateur peut sacrifier son utilisation de cette compétence pour détruire les résistances mentales d'un opposant durant un combat (toutes les résistances à utilisation sont inutilisables). Il devra le toucher avec sa main pour ce faire.")
                ]),
            new Competence(226, "Fureur", "L’utilisateur peut, trois fois par scénario, choisir une cible sur laquelle il aura un bonus de dégât de +1 (passif). Si la cible est vaincue, cela engendrera un effet selon la variante choisie.", 
                [
                    new Variant("Tous les alliés à 20 pieds autour de l’utilisateur obtiennent 2 PVT."),
                    new Variant("Tous les ennemis à 20 pieds autour de l’utilisateur auront un effet de « Peur » pendant 15 secondes."),
                    new Variant("L’utilisateur peut choisir une autre cible gratuitement (dans un autre combat pour un max de 1 fois par combat).")
                ]),
            new Competence(227, "Pris la main dans le sac", "L'utilisateur devient immunisé à la compétence « Vol à la Tire ». De plus, en cas de vol, cela engendrera un effet selon la variante choisie.", 
                [
                    new Variant("Le voleur perd l'usage d'une main tel l’effet Engourdissement durant 20 minutes."),
                    new Variant("Donne un bonus de +2 dégâts (passif) contre le voleur pour la durée d'un combat."),
                    new Variant("Si le voleur ment durant les 2 heures suivant la tentative de vol, il aura 2 dégâts. Ces dégâts se répètent à chaque mensonge.")
                ]),
            new Competence(228, "Torture", "L’utilisateur peut torturer une cible afin de lui faire avouer un méfait / action qu’elle a fait(e)… ou non. La cible aura la certitude d’avoir causé ce méfait. La scène de torture doit durer au moins 10 minutes ininterrompues.", 
                [
                    new Variant("Une résistance mentale permet de résister à cette torture. Une capacité pouvant retirer les effets mentaux permet à la cible de se départir de cette certitude."),
                    new Variant("Une résistance à la douleur permet de résister à cette torture. Une guérison de plus de 10 PV permet à la cible de se départir de cette certitude"),
                    new Variant("Une résistance au poison permet de résister à cette torture. Un antidote permet à la cible de se départir de cette certitude.")
                ])
        ];
        ArcaneT1 =
        [
            new Competence(77, "Novice de l'Arcane (Abjuration)",
                "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.",
                [
                    new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
                ]),
            new Competence(78, "Novice de l'Arcane (Conjuration)",
                "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.",
                [
                    new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
                ]),
            new Competence(79, "Novice de l'Arcane (Divination)",
                "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.",
                [
                    new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
                ]),
            new Competence(80, "Novice de l'Arcane (Enchantement)",
                "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.",
                [
                    new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
                ]),
            new Competence(81, "Novice de l'Arcane (Évocation)",
                "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.",
                [
                    new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
                ]),
            new Competence(82, "Novice de l'Arcane (Illusion)",
                "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.",
                [
                    new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
                ]),
            new Competence(83, "Novice de l'Arcane (Nécromancie)",
                "L'utilisateur apprend le lexique Tiers 1 d’une des 7 écoles de l’Arcane. Cette compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence. NOTE : les mots des autres lexiques ou des autres niveaux peuvent être appris par le biais d’autres joueurs, mais ne peuvent être utilisés qu’en possédant les compétences pré-requises. En cas de mots « hors lexique », un pré-requis sera indiqué.",
                [
                    new Variant("L’utilisateur obtient un bonus de +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +0.5 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire tiers 1 (hasard).")
                ]),
            new Competence(84, "Concentration mineure",
                "L’utilisateur peut, à chaque incantation, endurer UNE frappe faisant 3 dégâts et moins avant de perdre sa concentration. Toutefois, il subit les dégâts reçus.",
                [
                    new Variant("L’utilisateur obtient un bonus de  +1 PM Max."),
                    new Variant("La frappe que l’utilisateur peut endurer est maintenant de 4 dégâts et moins."),
                    new Variant(
                        "L’utilisateur peut endurer une frappe de plus, pour un total de deux frappes, accumulant un total de 3 dégâts maximum.")
                ]),
            new Competence(85, "Électrochocs",
                "L’utilisateur peut stabiliser une cible en agonie en payant en PM la moitié (50% à la baisse) de ses PM Max. La cible sera alors à 1 PV et entrera en convalescence. L’utilisateur ne peut plus récupérer de PM pour les 15 prochaines minutes. Le coût minimum de mana est de 1 en tout temps.",
                [
                    new Variant(
                        "L’utilisateur crée un bouclier intangible pour sa cible. Il pourra absorber une quantité de dégâts égal à 1 dégât par tranche de 5 PM utilisés par l’utilisateur."),
                    new Variant(
                        "Le coût de mana de la compétence est maintenant équivalent au quart des PM Max de l'utilisateur."),
                    new Variant(
                        "Le coût de mana de la compétence est maintenant équivalent aux trois quarts des PM Max de l'utilisateur. La cible revient immédiatement à la vie comme si sa convalescence était complétée. Elle revient à elle avec 1 PV, et + 1 PV par tranche de 10 PM utilisés.")
                ],
                "Aviser le joueur des conditions de sa convalescence."),
            new Competence(86, "Études novices",
                "Cette compétence peut être acquise une fois par école. Elle permet de connaître les valeurs de tous ses mots de Tiers 1 de l’école choisie.",
                [
                    new Variant("L’utilisateur obtient +0.25 PM Max."),
                    new Variant("L’utilisateur obtient les valeurs d’une deuxième école de son choix."),
                    new Variant("L’utilisateur obtient + 0.5 sort actif par scénario (arrondi à l’entier inférieur).")
                ]),
            new Competence(87, "Frappe ensorcelée",
                "L’utilisateur peut, au coût de 2 PM, infuser son arme de mana après une méditation de 15 secondes non interrompue. Cela lui permet de gagner un bonus de +1 dégâts magique (actif) sur sa prochaine frappe. L’énergie se décharge après 5 minutes et la compétence ne peut être effectuée sur une arme portée par quelqu’un d’autre.",
                [
                    new Variant(
                        "Suivant la méditation de 15 secondes, l’utilisateur gagne une charge de DR2 applicable seulement s’il ne porte aucune source de DR (armure, objet magique, etc.)."),
                    new Variant(
                        "L’utilisateur peut infuser plus de PM pour gagner un bonus additionnel de +1 dégât (actif) par tiers d'ensorcellement. En contrepartie, la frappe coûte 2 PM additionnels par tiers d’ensorcellement. (Les tiers d’ensorcellement vont de 0 à 3 selon le matériel de l’arme.)"),
                    new Variant(
                        "L’utilisateur peut, en situation hors combat et une fois par jour, effectuer un assommement de 5 minutes avec sa frappe ensorcelée. La cible doit être surprise. Si la frappe échoue, l’arme est déchargée.")
                ],
                "Variante 3 : citer « Assommement 5 minutes »"),
            new Competence(88, "Méditation",
                "L’utilisateur peut méditer afin de regagner des PMs. Le taux de régénération de base est de 1 PM par 10 de PM Max. (minimum 1).",
                [
                    new Variant(
                        "Le temps de méditation n’est que de 15 minutes, mais si l’utilisateur est interrompu, il doit recommencer les 15 minutes de méditation. La méditation demande un effort de concentration active, mais elle peut être accompagnée d’une activité calme telle que le yoga."),
                    new Variant(
                        "Le temps de méditation est de 30 minutes. La méditation est relaxante, elle ne demande pas de concentration, mais ne peut pas être accompagnée d’effort physique."),
                    new Variant(
                        "Le temps de méditation est de 1 heure. L’utilisateur n’a aucune restriction sur ses activités.")
                ])
        ];
        ArcaneT2 =
        [
            new Competence(89, "Apprenti de l’Arcane (Abjuration)",
                "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur gagne +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
                ],
                77),
            new Competence(90, "Apprenti de l’Arcane (Conjuration)",
                "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur gagne +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
                ], 78),
            new Competence(91, "Apprenti de l’Arcane (Divination)",
                "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur gagne +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
                ], 79),
            new Competence(92, "Apprenti de l’Arcane (Enchantement)",
                "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur gagne +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
                ], 80),
            new Competence(93, "Apprenti de l’Arcane (Évocation)",
                "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur gagne +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
                ], 81),
            new Competence(94, "Apprenti de l’Arcane (Illusion)",
                "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur gagne +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
                ], 82),
            new Competence(95, "Apprenti de l’Arcane (Nécromancie)",
                "L'utilisateur apprend le lexique Tiers 2 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois (une fois par école). Il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur gagne +0.25 PM Max."),
                    new Variant(
                        "L’utilisateur obtient un bonus de +1 sort actif par scénario (arrondi à l’entier inférieur)."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire du Tiers 2 (Hasard).")
                ], 83),
            new Competence(96, "Apoptose",
                "L’utilisateur peut consommer ses PV afin de récupérer la même quantité de PM. Cette action prend 10 secondes par PV consommé.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par cible (morte) et suivant une scène de 10 secondes, consommer une partie de son essence afin de regagner 1 PM. L’utilisateur doit être à moins de 5 pieds du corps."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, consommer 3 PV pour récupérer 4 PM instantanément."),
                    new Variant(
                        "L’utilisateur peut, lors d’une incantation et s’il manque de PM afin de lancer le sort, substituer ses PM manquants par le double en PV. Utilisable seulement pour des sorts. Si l’utilisateur tombe à 0 PV par cette méthode, il meurt et doit soit aller voir la Mort, soit obtenir une résurrection.")
                ]),
            new Competence(97, "Bâton de pouvoir",
                "L’utilisateur peut entreposer un sort de portée « Touché » dans son bâton, lui permettant de décharger le sort avec une frappe du bâton. Le sort entreposé est perdu après un délai de 5 minutes. Le bâton ne peut pas faire de dégât ou être utilisé par une autre compétence tant qu’il entrepose un sort. Le sort entreposé doit être de Tiers 3 ou moins.",
                [
                    new Variant("L’utilisateur obtient un bonus de +1 PM Max."),
                    new Variant("Le sort entreposé coûtera +2 PM, mais aura son tiers de pouvoir augmenté de 1."),
                    new Variant("Le sort entreposé dans le bâton est perdu après un délai de 30 minutes au lieu de 5.")
                ]),
            new Competence(98, "Études apprenties",
                "L'utilisateur peut, lors de l'acquisition de la compétence, étudier les valeurs de ses mots connus (Tiers 3 maximum). Cette compétence est achetable à l'infini et il est possible de changer de variante à chaque achat de la compétence.",
                [
                    new Variant("L’utilisateur obtient la liste complète des valeurs d’un (1) mot de son choix."),
                    new Variant(
                        "L’utilisateur choisit trois (3) mots, mais qu'une valeur inconnue aléatoire (Hasard) par mot."),
                    new Variant(
                        "L'utilisateur choisit deux (2) mots, mais n'obtient qu’une valeur de son choix entre Potentia, Flux et Arcainum pour ses deux mots.")
                ]),
            new Competence(99, "Repositionnement",
                "L’utilisateur peut, une fois par combat, effectuer jusqu’à 3 pas consécutifs lors d’une incantation sans perdre sa concentration. Par contre, durant le déplacement, l’utilisateur ne peut pas continuer d’incanter et le déplacement doit durer 5 secondes maximum.",
                [
                    new Variant(
                        "Lors du repositionnement, l'utilisateur devient intangible et résiste au premier coup physique."),
                    new Variant(
                        "Suite au repositionnement, l'utilisateur se voit octroyer un bouclier arcanique qui le protège des 3 prochains points de dégâts magiques (non élémentaux). Le bouclier se décharge à la fin du combat."),
                    new Variant("L’utilisateur peut maintenant effectuer jusqu’à 5 pas consécutifs.")
                ],
                "Variante 1 : citer « Résiste »"),
            new Competence(100, "Sorts bi-disciplinaires",
                "L’utilisateur apprend à combiner les mots de deux écoles différentes. L’utilisation d’une seconde école ajoute un multiplicateur de 20% à la valeur de Flux globale.",
                [
                    new Variant("L’utilisateur gagne +3 PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +2 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un bonus de +5 résistance à l’Arcainum.")
                ]),
            new Competence(101, "Techniques de respiration",
                "Après avoir lancé un sort, la prochaine instance de régénération de PM par une compétence de méditation sera augmentée de 4 PM.",
                [
                    new Variant("L’utilisateur obtient un bonus de +3 PM Max."),
                    new Variant(
                        "Lorsque l’utilisateur médite activement dans le but de récupérer des PM par le biais d’une compétence, il est sous l’effet de « Clémence » contre les créatures sauvages."),
                    new Variant(
                        "Une fois par jour, lorsque l’utilisateur gagne des PM par le biais d’une compétence de méditation, il peut se régénérer de 4 PV.")
                ],
                "Variante 2 : citer « Calme »", 88)
        ];
        ArcaneCommonsT3 =
        [
            new Competence(102, "Initié de l'Arcane (Abjuration)",
                "L'utilisateur apprend le lexique tiers 3 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant(
                        "L’utilisateur peut obtenir un bonus de +1 sur le Potentia du premier modificateur dans une incantation. Ce bonus peut être activé ou désactivé à la volonté du lanceur de sort lors de ses tissages."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire (Hasard) du Tiers 3.")
                ],
                89),
            new Competence(103, "Initié de l'Arcane (Conjuration)",
                "L'utilisateur apprend le lexique tiers 3 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant(
                        "L’utilisateur peut obtenir un bonus de +1 sur le Potentia du premier modificateur dans une incantation. Ce bonus peut être activé ou désactivé à la volonté du lanceur de sort lors de ses tissages."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire (Hasard) du Tiers 3.")
                ],
                90),
            new Competence(104, "Initié de l'Arcane (Divination)",
                "L'utilisateur apprend le lexique tiers 3 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant(
                        "L’utilisateur peut obtenir un bonus de +1 sur le Potentia du premier modificateur dans une incantation. Ce bonus peut être activé ou désactivé à la volonté du lanceur de sort lors de ses tissages."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire (Hasard) du Tiers 3.")
                ],
                91),
            new Competence(105, "Initié de l'Arcane (Enchantement)",
                "L'utilisateur apprend le lexique tiers 3 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant(
                        "L’utilisateur peut obtenir un bonus de +1 sur le Potentia du premier modificateur dans une incantation. Ce bonus peut être activé ou désactivé à la volonté du lanceur de sort lors de ses tissages."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire (Hasard) du Tiers 3.")
                ],
                92),
            new Competence(106, "Initié de l'Arcane (Évocation)",
                "L'utilisateur apprend le lexique tiers 3 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant(
                        "L’utilisateur peut obtenir un bonus de +1 sur le Potentia du premier modificateur dans une incantation. Ce bonus peut être activé ou désactivé à la volonté du lanceur de sort lors de ses tissages."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire (Hasard) du Tiers 3.")
                ],
                93),
            new Competence(107, "Initié de l'Arcane (Illusion)",
                "L'utilisateur apprend le lexique tiers 3 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant(
                        "L’utilisateur peut obtenir un bonus de +1 sur le Potentia du premier modificateur dans une incantation. Ce bonus peut être activé ou désactivé à la volonté du lanceur de sort lors de ses tissages."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire (Hasard) du Tiers 3.")
                ],
                95),
            new Competence(108, "Initié de l'Arcane (Nécromancie)",
                "L'utilisateur apprend le lexique tiers 3 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant(
                        "L’utilisateur peut obtenir un bonus de +1 sur le Potentia du premier modificateur dans une incantation. Ce bonus peut être activé ou désactivé à la volonté du lanceur de sort lors de ses tissages."),
                    new Variant("L’utilisateur obtient les valeurs d’un mot aléatoire (Hasard) du Tiers 3.")
                ],
                96),
        ];
        ArcaneCommonsT4 =
        [
            new Competence(109, "Maître de l'Arcane (Abjuration)",
                "L'utilisateur apprend le lexique tiers 4 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un malus de 1 Flux (cumulatif et non lié à l’école).")
                ], 102),
            new Competence(110, "Maître de l'Arcane (Conjuration)",
                "L'utilisateur apprend le lexique tiers 4 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un malus de 1 Flux (cumulatif et non lié à l’école).")
                ], 103),
            new Competence(111, "Maître de l'Arcane (Divination)",
                "L'utilisateur apprend le lexique tiers 4 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un malus de 1 Flux (cumulatif et non lié à l’école).")
                ], 102),
            new Competence(112, "Maître de l'Arcane (Enchantement)",
                "L'utilisateur apprend le lexique tiers 4 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un malus de 1 Flux (cumulatif et non lié à l’école).")
                ], 102),
            new Competence(113, "Maître de l'Arcane (Évocation)",
                "L'utilisateur apprend le lexique tiers 4 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un malus de 1 Flux (cumulatif et non lié à l’école).")
                ], 106),
            new Competence(114, "Maître de l'Arcane (Illusion)",
                "L'utilisateur apprend le lexique tiers 4 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un malus de 1 Flux (cumulatif et non lié à l’école).")
                ], 102),
            new Competence(115, "Maître de l'Arcane (Nécromancie)",
                "L'utilisateur apprend le lexique tiers 4 d’une des 7 écoles de l’Arcane. La compétence peut être acquise un maximum de 7 fois, une fois par école.",
                [
                    new Variant("L’utilisateur gagne +0.5  PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +1 sort actif par scénario."),
                    new Variant("L’utilisateur obtient un malus de 1 Flux (cumulatif et non lié à l’école).")
                ], 108),
        ];
        ArchmageT3 =
        [
            new Competence(116, "Concentration majeure",
                "L’utilisateur peut, à chaque incantation, endurer 3 frappes avant de perdre sa concentration. Il subit tout de même les dégâts reçus.",
                [
                    new Variant(
                        "L’utilisateur peut, lorsqu’il reçoit un coup pendant une incantation,  s’octroyer 3 PVT une fois par combat."),
                    new Variant(
                        "L’utilisateur peut, lorsqu’il reçoit un coup pendant une incantation, utiliser les PM qu’il aurait utilisés pour le sort afin de blesser automatiquement une cible, pour un total de 1 dégât par niveau de sort. Cette attaque ne peut être faite qu'à un assaillant au corps à corps. Cette action brise la concentration de l’utilisateur instantanément."),
                    new Variant(
                        "L’utilisateur peut, lorsqu’il reçoit un coup pendant une incantation, arrêter son incantation et convertir ses PMs utilisés afin de donner l’effet « magique » à ses frappes au corps-à-corps pour le reste du combat. Si l’incantation est de niveau 4 et plus, l’utilisateur gagne aussi un nombre de DR1 égal au niveau du sort. L’utilisateur perd les DR1 restantes à la fin du combat.")
                ], 84),
            new Competence(117, "Écoles mixtes",
                "L’utilisateur peut maintenant tisser des sorts avec 3 écoles différentes. L’addition d’une troisième école provoque tout de même un 20% additionnel au Flux global. NOTE : plus un sort contient d’écoles différentes, plus il coûtera cher en PM et il sera plus difficile à tisser.",
                [
                    new Variant(
                        "Si l'une des écoles utilisées est l’école spécialisée (voir École Spécialisée) de l'utilisateur, ce dernier n’aura pas de coût additionnel en Flux pour cette école."),
                    new Variant(
                        "Si l’utilisateur possède le lexique d’une école proscrite (voir École Spécialisée), il peut utiliser les mots de pouvoir sans le mot d’école. Note : l’utilisation d’un mot de cette école coûtera comme s’il avait ajouté 2 fois sa valeur de Flux."),
                    new Variant(
                        "Si l'une des écoles utilisées est l’école spécialisée (voir École Spécialisée), toutes les valeurs des mots de cette école subiront une augmentation de 25% de leur Potentia sur le multiplicateur global.")
                ], 100),
            new Competence(118, "École spécialisée",
                "L’utilisateur choisit une école, parmi les sept Écoles de l’Arcane, pour optimiser les valeurs des mots de cette école dans les sorts qu'il tisse. L’écart permis entre le Flux et la Potentia d’un sort ayant pour école principale l’école spécialisée sera doublé.",
                [
                    new Variant(
                        "L’utilisateur devra proscrire une école de magie. Il ne pourra pas utiliser les mots provenant de cette école à partir de maintenant."),
                    new Variant(
                        "L’utilisateur devra proscrire deux écoles de magie. Il pourra tout de même utiliser les mots provenant de ces écoles, mais leur coût en flux sera doublé."),
                    new Variant(
                        "L’utilisateur n’a pas d’école proscrite. Par contre, dans chacune de ses incantations, il devra utiliser au moins un mot de son école spécialisée.")
                ]),
            new Competence(119, "Méditation profonde",
                "Les compétences de méditation font gagner à l'utilisateur un bonus de +1 PM.",
                [
                    new Variant(
                        "Le taux de récupération gagne un bonus de +1 PM additionnel par période de méditation."),
                    new Variant("L’utilisateur gagne +3 PM Max."),
                    new Variant(
                        "Les séances de méditation peuvent maintenant être interrompues et reprises plus tard sans perdre le temps accumulé.")
                ],
                88),
        ];
        ArchmageT4 =
        [
            new Competence(120, "Arcane supérieure",
                "Permet l'obtention et l'incantation de sorts de Niveau 6 (si vous avez appris assez de lexiques pour être un lanceur de sorts Niveau 6).",
                [
                    new Variant("L’utilisateur gagne +2  PM Max."),
                    new Variant("+2 lexiques effectifs pour le déverrouillage de niveau de lanceur de sorts."),
                    new Variant("L’utilisateur obtient un bonus de +5 résistance à l'Arcainum.")
                ]),
            new Competence(121, "Canalisation de mana",
                "L’utilisateur peut, lors d’une séance de méditation sans durée définie mais pendant maximum 1h par jour, canaliser l’Arcane environnante pour gagner 1 PM par minute. Cette méditation doit être active pour que le bonus soit appliqué, peu importe la variante choisie de Méditation.",
                [
                    new Variant(
                        "La canalisation ajoute un PM par 5 minutes, mais il n’y a plus de restriction de temps. Cette variante remplace complètement l'effet de base."),
                    new Variant(
                        "Si les PM de l’utilisateur sont en dessous de 5 PM, il peut se connecter à un puits de mana environnant même s’il a dépassé son heure (1 PM/minute). Cette variante se termine lorsque l’utilisateur a plus de 5 PM."),
                    new Variant(
                        "L'utilisateur peut, une fois par jour, sacrifier 30 minutes de son heure pour obtenir 10 PM instantanément, et ce, même en combat.")
                ]),
            new Competence(122, "Études avancées",
                "L’utilisateur peut étudier des mots et en connaître les variables cachées. Cela ne fonctionne que sur les mots de Tier 4 et 5. Cette compétence peut être achetée un nombre de fois illimitée.",
                [
                    new Variant("L'utilisateur obtient la liste complète des attributs d'un mot de son choix."),
                    new Variant(
                        "L'utilisateur choisit trois (3) mots, mais obtient un attribut inconnu aléatoire par mot."),
                    new Variant(
                        "L'utilisateur choisit deux (2) mots, mais obtient la variable de son choix entre Potentia, Flux et Arcainum.")
                ]),
            new Competence(123, "Études impromptues",
                "L’utilisateur peut modifier son répertoire de sorts. Suivant une méditation d’une heure, il peut échanger un sort actif pour un sort passif de sa liste pour le reste de l’événement.",
                [
                    new Variant("L’utilisateur obtient un bonus de + 2 PM Max."),
                    new Variant("L'utilisateur peut changer jusqu'à trois sorts de sa liste par heure de méditation."),
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, sacrifier un de ses sorts actifs afin d’augmenter le tiers de pouvoir d’un de ses sorts de 1 au lieu de la compétence initiale.")
                ])
        ];
        SorcererT3 =
        [
            new Competence(124, "Armure efficace", "L’utilisateur peut maintenant incanter en armure légère.",
            [
                new Variant(
                    "L’utilisateur peut, une fois par scénario, prendre 15 secondes, sans être dérangé, afin de réparer une pièce d’armure possédant le statut « brisé ». Cette compétence ne permet pas à l'armure de récupérer ses propriétés magiques. Une pièce d'armure peut être réparée de cette façon qu’ une seule fois ; après, elle doit obtenir une véritable réparation."),
                new Variant(
                    "Les DR données par l'effet de sort « Armure du Mage » sont maintenant utilisables par l’utilisateur même si ce dernier porte une armure."),
                new Variant(
                    "Si l’armure de torse de l’utilisateur est ensorcelée par un ensorceleur, la pièce d’armure possède une (1) utilisation de DR de plus.")
            ]),
            new Competence(125, "Mage de guerre",
                "L’utilisateur peut maintenant incanter en pointant son arme vers le ciel plutôt que d’avoir une main de libre.",
                [
                    new Variant(
                        "L’utilisateur peut maintenant utiliser les sorts avec une portée « Touché » avec son arme. Si le sort occasionne des dégâts, ils seront additionnés aux dégâts de l’arme. Si l'arme est parée, le sort ne se décharge pas, mais il est perdu si l’utilisateur est déconcentré. Les dégâts du sort utilisé de cette manière ont l’étiquette « ACTIF »."),
                    new Variant(
                        "Si l’utilisateur lance un sort avec un modificateur élémentaire, il peut changer l’élément de ses frappes pour cet élément pour le reste du combat. Un sort utilisé ainsi n’aura aucun effet outre le changement d’élément. Cet effet ne fonctionne qu’avec les armes de corps à corps."),
                    new Variant("L’utilisateur obtient un bonus de +2 PV Max.")
                ]),
            new Competence(126, "Réserve inépuisable", "L’utilisateur obtient un bonus de +2 PM Max.",
            [
                new Variant(
                    "Chaque séance de régénération de PM obtenue par une compétence de Méditation (Tronc Arcane) est augmentée de 1."),
                new Variant(
                    "L’utilisateur peut effectuer un don de PM à une cible. Pour chaque 2 PM sacrifiés, la cible reçoit 1 PM. L’utilisateur doit toucher sa cible et attendre 15 secondes."),
                new Variant("L’utilisateur obtient +1 PM Max pour un total de +3.")
            ]),
            new Competence(127, "Sort favori mineur",
                "L’utilisateur peut simplifier un sort de niveau 1 (3 mots seulement) à un seul mot. Le sort doit être choisi au moment de l'acquisition de la compétence et ne peut pas être modifié. Le mot choisi doit faire partie de l’incantation et peut être utilisé jusqu’à trois fois par combat.",
                [
                    new Variant(
                        "De plus, une fois par combat, le sort favori obtient un bonus de +1 dégât (actif). Ceci n’affecte pas les sorts sans dégât."),
                    new Variant(
                        "De plus, le sort favori obtient un modificateur d’élément gratuitement. Le mot de l’élément en question doit être connu du joueur et doit être choisi au moment de l'acquisition de cette compétence."),
                    new Variant(
                        "De plus, le sort favori ne consomme aucun PM, mais n'est utilisable qu'une fois par combat. Si l’utilisation se fait hors combat, il n'est utilisable qu'une fois aux 15 minutes.")
                ])
        ];
        SorcererT4 =
        [
            new Competence(128, "Armure du sorcier", "Permet d'incanter en armure lourde.",
            [
                new Variant(
                    "L'armure portée par l’utilisateur a un bonus de +1 de capacité d’ensorcellement permanent. NOTE : si l’armure est portée par une cible, elle obtient un effet « Disjonction » sur la cible. L'armure doit être portée de nouveau par l’utilisateur pour retirer cette condition."),
                new Variant(
                    "L’utilisateur peut, une fois par jour, réparer son armure de manière instantanée. La réparation ne dure qu’un combat et elle retrouve sa condition « brisée » à la fin de ce dernier."),
                new Variant("L’armure de l’utilisateur peut, une fois par scénario, résister à une destruction.")
            ]),
            new Competence(129, "Frappe du sorcier",
                "L'utilisateur peut canaliser un sort de forme « Touché » à travers son arme de mêlée. Un sort canalisé peut être combiné à la frappe de l'arme, mais coûte 3 PM moins l’enchantabilité de l’arme (minimum 0).  Le sort doit être incanté et déchargé dans les 30 secondes sinon il sera perdu.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par combat, canaliser un sort de forme « Pointé » à travers l'arme, pointant la cible avec l'arme. Le sort aura l'enchantabilité de l'arme divisé par 2 ajoutée aux dégâts."),
                    new Variant(
                        "L’utilisateur peut, une fois par jour, canaliser un sort de forme « Cône » qui prendra effet à partir de la cible touchée avec l'arme. Le sort verra les dégâts de base de l'arme ajoutés."),
                    new Variant(
                        "L’utilisateur peut, une fois par jour, invoquer de manière instantanée un sort préparé de forme « Mur », sans incantation en dessinant le mur par terre avec son arme. Il doit tout de même nommer son effet.")
                ]),
            new Competence(130, "Mobilité mineure", "L’utilisateur peut se déplacer en marchant lorsqu'il incante.",
            [
                new Variant(
                    "Pour le coût de 5 PM, l’utilisateur peut, une fois par combat, effectuer une Esquive (voir compétence de Roublard (Aucune variante))  lors d'une incantation."),
                new Variant(
                    "Pour le coût de 3 PMs, l’utilisateur peut, une fois par combat, résister à un renversement."),
                new Variant("Pour le coût de 7 PMs, l’utilisateur peut, une fois par combat, éviter un effet de zone.")
            ]),
            new Competence(131, "Sort favori intermédiaire",
                "Permet de simplifier un sort de niveau 2 (7 mots ou moins) à deux mots. En plus de ce sort de niveau 2, vous possédez aussi un nouveau sort de niveau 1 simplifié avec la même variante que Sort Favori. Les deux sorts doivent être choisis au moment de l'acquisition de la compétence.",
                [
                    new Variant(
                        "Le sort possède +1 à son tiers d'effet suite aux calculs de Potentia au sort niveau 2 choisi."),
                    new Variant(
                        "Le sort possède +1 à son tiers de forme suite aux calculs de Potentia au sort niveau 2 choisi."),
                    new Variant(
                        "Le sort coûte 1PM, mais n'est utilisable que 1 fois par combat. Si utilisé hors combat, le sort peut être réutilisé à chaque heure pour le sort niveau 2 choisi.")
                ],
                127)
        ];
        ArtificerT3 =
        [
            new Competence(132, "Banque de mana",
                "L’utilisateur possède un objet (nommé banque) qui peut contenir un maximum de 10 PM. Il est possible d’améliorer cette banque en jeu. NOTE : elle sert uniquement à payer le coût des compétences de la branche de l’Artificier.",
                [
                    new Variant(
                        "La régénération de la banque se passe de manière ininterrompue à un taux de 2 PM à l’heure. À minuit, elle se régénère complètement."),
                    new Variant(
                        "La banque ne possède pas de régénération, mais l’utilisateur peut y infuser des PM manuellement. L’infusion demande une concentration de 15 secondes. Attention, le taux de change est de 2 PM infusés par l'utilisateur, pour 1 PM mis dans la banque."),
                    new Variant(
                        "Les PM générés par la déconstruction systématique (voir Déconstruction systématique) peuvent être complètement ou partiellement remis dans la banque de mana.")
                ]),
            new Competence(133, "Déconstruction systématique",
                "L’utilisateur peut recycler un objet magique afin d'en absorber les PM. Cela permet d’obtenir 5 PM pour un objet mineur, 15 PM pour un objet intermédiaire et 50 PM pour un objet majeur. L’objet magique est détruit suivant cette opération. L’utilisateur doit passer 5 minutes de travail actif avec un objet magique afin de le déconstruire. S’il est victime d’une déconcentration pendant ce procédé, il ne pourra pas déconstruire cet objet avant une heure de délai.",
                [
                    new Variant("L’utilisateur peut crocheter des serrures de tiers 1."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat et contre un automate, créer un effet de déconstruction lors d’une touche au corps à corps."),
                    new Variant(
                        "Lorsqu’il recycle un objet magique, l’utilisateur peut apporter cet objet à l'animation pour en retirer des matériaux.")
                ]),
            new Competence(134, "Gemme surchargée",
                "L’utilisateur peut dépenser 5 PM afin de déstabiliser une pierre précieuse et de la transformer en bombe. En lançant un catalyseur faisant office de la pierre, cette dernière explosera à son point d’impact et causera 4 dégâts non-typés à l'intérieur de 5 pieds de rayon. L’utilisateur ne peut avoir qu’une gemme surchargée en sa possession, et il est le seul à pouvoir la lancer de manière sécuritaire. Si la gemme est manipulée par autrui, elle explose instantanément.",
                [
                    new Variant("Les dégâts sont réduits à 3, mais le rayon est augmenté à 10 pieds."),
                    new Variant("De plus, la bombe cause l’effet « Aveuglement » pendant 15 secondes."),
                    new Variant(
                        "La pierre précieuse n'est plus déclenchée à l’impact. L'utilisateur peut la placer où bon lui semble et la déclencher lorsqu’il le souhaite avec une composante vocale. Attention, il doit être à portée de voix de l’emplacement de la pierre précieuse lors de l’activation.")
                ],
                "Citer « Gemme surchargée »"),
            new Competence(135, "Infusion élémentaire",
                "L’utilisateur peut, au coût de 1 PM, infuser son arme d’un élément (il doit en connaître et être apte à utiliser le mot et le réciter lors de l’infusion). L'infusion dure jusqu'à la fin du prochain combat. Cette compétence ne peut être utilisée que sur une arme à la fois.",
                [
                    new Variant(
                        "L’utilisateur devra choisir un élément favori et un élément proscrit. Il causera alors un bonus de +1 dégât (actif) avec son arme si elle est infusée par son élément favori et un malus de -1 dégât (non-typé minimum 1) si elle est infusée par son élément proscrit. Si l’utilisateur n’a qu’un mot d’élément, le deuxième mot d’élément qu’il découvrira deviendra son élément proscrit automatiquement."),
                    new Variant(
                        "L’utilisateur peut choisir de décharger son infusion dans un dernier tir décisif. Ce tir causera un bonus de +3 dégâts (actif) et frappera de l’élément choisi. L’infusion prend fin immédiatement après le tir. Ré-infuser une arme suite à son déchargement est impossible lors du même combat. NOTE : Cette variante ne fonctionne que sur une arme à feu."),
                    new Variant("L’utilisateur peut infuser l’arme de siège de son choix.")
                ])
        ];
        ArtificerT4 =
        [
            new Competence(136, "Banque surchargée!",
                "La banque de mana de l'utilisateur peut maintenant contenir un 10 PM de plus.",
                [
                    new Variant(
                        "De plus, l'utilisateur peut utiliser les PM stockés pour la production de cristaux de mana."),
                    new Variant("De plus, la régénération de la banque augmente de 1 PM à l’heure."),
                    new Variant(
                        "De plus, si l'utilisateur possède la compétence « Déconstruction systématique » et une autre variante que la 3, il obtient la variante 3 et peut recharger sa banque  à partir de cette compétence (ratio 1 PM investi par l'utilisateur pour 1 PM mis en banque).")
                ],
                132),
            new Competence(137, "Pistolet sous pression",
                "L'utilisateur ajoute un réceptacle qui produit un gaz sur son fusil qui augmente la force d'impact de la balle et lui ajoute potentiellement des effets. Le réceptacle se recharge entre les combats. L'utilisateur peut le recharger instantanément en consommant 2 PM de sa banque de mana. Tirer une balle consomme le contenu du réceptacle en totalité.",
                [
                    new Variant(
                        "Le gaz est un accélérant et explose, causant une propulsion de la balle. Bonus de +2 dégâts (passif)."),
                    new Variant(
                        "Le gaz est corrosif et imbibe la balle lors du déclenchement du pistolet. Bonus de +1 dégât (base) et sera « perce-armure »."),
                    new Variant(
                        "Le gaz est inerte et stabilise la balle. Bien que la balle n'ait pas d'effet additionnel, l'utilisateur peut résister à un (1) bris d'arme avec son pistolet pour le coût de cette compétence.")
                ]),
            new Competence(138, "Réparation magique",
                "L’utilisateur peut réparer des objets magiques brisés (pas les armes ni les armures). Cela lui permet aussi d'interchanger des parties de sa construction de Science étrange et de sa Banque de mana afin d'en changer les matériaux.",
                [
                    new Variant(
                        "L'utilisateur peut maintenant réparer les armes et les boucliers, suivant les mêmes règles qu'un forgeron ou un artisan ayant la compétence Maître Forgeron ou Maître Artisan."),
                    new Variant(
                        "L'utilisateur peut maintenant réparer les armures, suivant les mêmes règles qu'un forgeron ou un artisan ayant la compétence Maître Forgeron ou Maître Artisan."),
                    new Variant("L'utilisateur peut maintenant réparer les engins de siège.")
                ]),
            new Competence(139, "Science étrange",
                "L’utilisateur peut fabriquer des « objets » magiques capables de reproduire des sorts. L'utilisateur doit avoir déjà tissé les sorts qu'il veut matérialiser afin de pouvoir les utiliser. Pour construire ses choses, l'Artificier doit utiliser 4 unités de métal. Dépendamment des propriétés de ces métaux, la construction pourra contenir plus ou moins de sorts plus ou moins puissants. Dans tous les cas, les sorts utilisés par la machine utilisent la mana de la banque de mana de l'utilisateur. Aucune incantation n'est nécessaire pour utiliser une construction magique, mais un délai s'applique entre les coups, toujours selon les propriétés des matériaux utilisés pour la construire (voir Annexe 6). L'utilisateur doit passer 15 minutes à construire sa machine par niveau des sorts inscrits. Les parties de la machine comprennent : Coeur, Condensateur, Armure, Interprète (voir Annexe 6). L’utilisateur est le seul à pouvoir user de ses constructions. De base, une construction peut contenir 1 sort. Sans matériaux recherchés, elle ne peut lancer aucun sort.",
                [
                    new Variant(
                        "La construction de l'utilisateur est capable de contenir 1 sort de plus que ce que les matériaux lui permettent normalement."),
                    new Variant(
                        "La construction est capable de contenir des sorts plus puissants d'un niveau par rapport à ce que les matériaux permettent normalement."),
                    new Variant(
                        "La construction utilise la mana de manière plus efficace. Sur les sorts qui coûtent plus de 5 PM, ils coûtent 1 PM de moins. Pour les sorts qui coûtent plus de 10 PM, ils coûtent 2 PM de moins.")
                ],
                132)
        ];
        EcclesiasticT3 =
        [
            new Competence(140, "Connaissances occultes",
                "L’utilisateur peut, trois fois par jour et face à certains personnages non-joueurs, connaître certaines informations. Il devra poser sa question subtilement à l’animation.",
                [
                    new Variant("L'utilisateur sera en mesure de confirmer quelle est sa religion."),
                    new Variant(
                        "L’utilisateur saura quel est le plus haut niveau de sort dans son livre de sorts ainsi que sa spécialisation d’école s’il en a une. Cela concerne aussi les sorts inactifs."),
                    new Variant(
                        "L’utilisateur pourra poser une question face à un puzzle. L'animation se réserve le droit de ne pas répondre. Dans ce cas, l'utilisation ne sera pas gaspillée.")
                ]),
            new Competence(141, "Études continues",
                "Cette compétence ne peut être achetée qu'une seule fois. Lors de son inscription, l’utilisateur obtient une étude de mots pour les mots T3 et moins. Ce qu'il va découvrir dépend de la variante.",
                [
                    new Variant("L’utilisateur obtient la liste complète des valeurs d’un mot de son choix."),
                    new Variant(
                        "L’utilisateur choisit trois (3) mots, mais qu'une valeur inconnue aléatoire par mot(hasard)."),
                    new Variant(
                        "L'utilisateur choisit deux (2) mots, mais n'obtient qu’une valeur de son choix entre Potentia, Flux et Arcainum pour ses deux mots.")
                ]),
            new Competence(142, "Puits de mana", "L’utilisateur obtient un bonus de +2 PM Max.",
            [
                new Variant("L’utilisateur obtient un bonus de +1 PM Max pour un total de +3."),
                new Variant(
                    "L’utilisateur possède maintenant une réserve de mana. La réserve contient 3x tiers maximum de compétence arcanique de PM et peut être ajoutée à ses PM suivant une méditation de 15 minutes. La réserve peut être remplie à nouveau en sacrifiant des PM au ratio de 3 pour 1. Elle est rechargée au complet entre les scénarios."),
                new Variant(
                    "Chaque séance de régénération de PM obtenue par une compétence de méditation est augmentée de 1.")
            ]),
            new Competence(143, "Recueil de parchemins", "Bonus de +2 parchemins par combat.",
            [
                new Variant(
                    "L’utilisateur peut, une fois par combat et si le parchemin est de niveau 3 ou moins, l’utiliser sans le détruire."),
                new Variant(
                    "L’utilisateur peut, si le parchemin est de niveau 5 ou moins et cause un effet instantané, augmenter l’effet en question d’un point (dégâts, DR, PVT, etc.)."),
                new Variant(
                    "L’utilisateur peut détruire un parchemin et gagner son niveau multiplié par 2 en PM, consommer un parchemin de cette manière compte pour une utilisation de parchemin en combat. Si consommé hors d’un combat, un délai de 15 minutes doit être attendu avant d’en consommer un deuxième.")
            ])
        ];
        EcclesiasticT4 =
        [
            new Competence(144, "Compréhension accrue",
                "L’utilisateur peut incanter des parchemins jusqu'à 3 Tiers plus élevés que son niveau de lanceur de sort.",
                [
                    new Variant(
                        "Dans un parchemin, s’il connaît et peut incanter l’effet, il peut augmenter son tiers de pouvoir de 1."),
                    new Variant(
                        "Dans un parchemin, s’il connaît et peut incanter la forme, il peut augmenter son tiers de 1."),
                    new Variant(
                        "L’utilisateur peut ajouter un modificateur qu’il connait dans un parchemin, dans sa forme la plus simple (Tiers 1).")
                ]),
            new Competence(145, "Connaissance des sphères",
                "L'utilisateur de cette compétence possède 2 lexiques effectifs de plus quant à son niveau de lanceur de sort.",
                [
                    new Variant("L’utilisateur obtient un bonus de +5 résistance à l'Arcainum."),
                    new Variant("L’utilisateur obtient un bonus de +2 PM Max."),
                    new Variant("L’utilisateur obtient un bonus de +2 sur le Potentia de l’effet du sort.")
                ]),
            new Competence(146, "Grimoire organisé", "L’utilisateur obtient un bonus de +3 sorts actifs par scénario.",
            [
                new Variant(
                    "Permet à l'utilisateur d'échanger jusqu'à trois sorts dans ses sorts actifs par jour suite à une étude d’une heure."),
                new Variant("L’utilisateur obtient un bonus de +2 PM Max."),
                new Variant(
                    "L'utilisateur peut préparer un sort. Cela prendra 5 minutes par niveau de sort et coûte le prix en PM. Par la suite, il pourra lancer ce sort au courant de la journée sans coût de PM. L'utilisateur ne peut pas avoir plus d'un sort préparé à la fois. Afin d'utiliser le sort, il doit l'incanter.")
            ]),
            new Competence(147, "Recherchiste",
                "L'utilisateur peut, suivant une recherche d’une heure dans des livres, poser une question sur un sujet occulte à l’animation.",
                [
                    new Variant("De plus, le champ d'étude comprend aussi la religion."),
                    new Variant("De plus, le champ d'étude comprend aussi l'ingénierie."),
                    new Variant("De plus, le champ d'étude comprend aussi la science.")
                ])
        ];
        MonkT3 =
        [
            new Competence(148, "Endurance de l’Ours",
                "L’utilisateur obtient un bonus de +3 PV Max, mais perd la possibilité de porter une armure. S’il décide d’en porter une, il n’a plus ce bonus et sa variante. En retirant son armure, il récupère les PV Max, mais ils ne guérissent pas automatiquement.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par jour, décaler un effet obtenu en combat à la fin de ce dernier. Si la réactivation de l’effet rend l’utilisateur agonisant, il sera considéré comme mort."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, se donner l’effet « Enchevêtrement » pendant deux minutes. Tant que l’effet « Enchevêtrement » donné par cette compétence persiste, il diminue les dégâts reçus à 1 et devient immunisé aux effets de déplacement. L’utilisateur peut sortir de l’enchevêtrement à tout moment, mettant fin aux bénéfices de cette variante. Les coups qu'il reçoit ne dissipent pas l’effet « Enchevêtrement » engendré par cette compétence."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, ignorer les dégâts et les effets de déplacements d'une attaque.")
                ]),
            new Competence(149, "Griffe du Tigre",
                "L’utilisateur obtient un bonus de +1 dégât (actif) pour ses trois premières attaques au corps à corps lors d'un combat.",
                [
                    new Variant(
                        "L’utilisateur peut, une fois par jour, faire une attaque avec l’effet « Brise-Membre »."),
                    new Variant(
                        "L’utilisateur peut, une fois par jour, utiliser un sort avec une portée « Touché » avec son arme. Si le sort occasionne des dégâts, ils seront additionnés à ceux de l'arme. Si l'arme est parée, le sort ne se décharge pas, mais il est perdu si l’utilisateur est déconcentré. Les dégâts du sort utilisé de cette manière ont l’étiquette « actif ». Le sort utilisé est de niveau 4 maximum. Le sort reste dans l’arme pendant 30 secondes."),
                    new Variant(
                        "L’utilisateur peut, une fois par combat, toucher une cible avec une main ou son arme pour causer l’effet « Renversement ».")
                ],
                "Variante 3 : citer « Renversement »"),
            new Competence(150, "Inscriptions arcaniques",
                "L’utilisateur apprend à se servir de ses PM de manière différente. Il peut modifier son corps au travers des tatouages arcaniques. Ces derniers permettent de rendre un sort de forme « Personnelle » de manière permanente sur lui-même, ou d'en faire un activateur instantané pour les autres formes (sur les bras et les jambes obligatoirement). NOTE : l’accès à cette compétence fait perdre à l’utilisateur la capacité d’incanter des sorts supérieurs au Niveau 2. \nL’utilisateur peut tatouer un maximum de 3 niveaux de sorts sur son torse et un total de 2 niveaux de sorts sur l’ensemble de ses bras et jambes (pas 2 niveaux par membre). \nL’utilisateur peut méditer 5 minutes afin de recharger l’effet de ses tatouages. Il doit payer le coût en PM des sorts, et peut décider quels sorts recharger.\nLes tatouages sont inactifs si le moine porte de l'armure lourde.\nLes variantes indiquent les différentes façons d'appliquer des tatouages sur le corps de l'utilisateur.",
                [
                    new Variant(
                        "Scarification : Procédé douloureux et permanent. L’utilisateur devra graver les runes nécessaires dans sa peau afin de canaliser ses sorts. La procédure causera un malus de -1 PV Max par niveaux de sort inscrit pour le scénario. Par la suite, l'utilisateur guérira 1 PV Max par scénario jusqu'à guérison complète. S'il décide d’augmenter un de ses tatouages de niveau 1 à niveau 2, il peut changer la totalité du sort, mais aura tout de même le malus de -1 PV Max."),
                    new Variant(
                        "Encre : Procédé permanent et coûteux. Il faudra utiliser une ressource d'encre par niveau de sort tatoué. Il est possible de refaire ses tatouages au coût d'une ressource d'encre par niveau modifié."),
                    new Variant(
                        "Charbon : Procédé non permanent. Le tatouage dure un scénario et l’utilisateur devra utiliser une ressource de charbon par niveau de sort à chaque inscription. Même s'il obtient la quantité requise lors du scénario, il ne pourra se tatouer à nouveau qu'au scénario suivant.")
                ]),
            new Competence(151, "Vision de l’Aigle",
                "L’utilisateur peut, une fois par combat et jusqu'à la fin de celui-ci, identifier une cible et devenir immunisé à toutes ses illusions. Certaines rares habilités permettent de contrer la Vision de l'aigle. Si utilisé hors combat, sa durée est de 5 minutes, et nécessite un délai d’une heure avant d’être réutilisé.",
                [
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par combat, utiliser la compétence Presquive avec l’ajout de la variante 1."),
                    new Variant(
                        "De plus, l’utilisateur peut, une fois par jour,  éviter les dégâts et les effets d'un piège. Ne fonctionne pas sur les pièges de coffres."),
                    new Variant(
                        "L’utilisateur peut, trois fois par jour, identifier la puissance arcanique d’une cible. Celle-ci devra lui dire son maximum de PM.")
                ])
        ];
        MonkT4 =
        [
            new Competence(152, "Balance parfaite", "L'utilisateur devient immunisé à tout effet de « Renversement ».",
            [
                new Variant(
                    "Si l'utilisateur prend un coup d'un élément en particulier, il gagne une (1) résistance à son élément opposé. Feu <--> Glace, Acide <--> Foudre, Béni <--> Maudit"),
                new Variant(
                    "De plus, si l'utilisateur tombe en agonie, l’adversaire qui a donné le dernier coup reçoit les dégâts et les effets de cette touche."),
                new Variant(
                    "De plus, si l'utilisateur donne la dernière touche sur un assaillant, sa prochaine stabilisation donnera +3 PV de plus à sa cible suivant la convalescence. Après avoir donné une stabilisation, le prochain coup du Moine fera +2 dégâts (passif).")
            ]),
            new Competence(153, "Morsure du Serpent",
                "L’utilisateur peut, trois fois par combat, effectuer une attaque qui lui donnera +2 dégâts (actif).",
                [
                    new Variant("De plus, effet « Engourdissement » pendant 1 minute."),
                    new Variant(
                        "De plus,  effet « Paralysie » pendant 5 secondes. Une cible peut être affectée par cet effet une seule fois par combat."),
                    new Variant(
                        "De plus, effet « Léthargie » pendant 15 secondes. Une cible peut être affectée par cet effet une seule fois par combat.")
                ]),
            new Competence(154, "Tatouages ritualistiques",
                "L’utilisateur peut avoir un total de 5 niveaux de tatouages corporels (sur le torse) et 4 niveaux de tatouages sur ses bras et ses jambes. Les tatouages n'ont aucun effet si le Moine porte de l'armure légère. NOTE : Le moine regagne la possibilité de lancer des sorts de niveau 3. Les variantes indiquent les différentes façons d'appliquer des tatouages sur le corps de l'utilisateur.",
                [
                    new Variant(
                        "Scarification : sur les sorts à dégâts scarifiés sur sesbras et jambes, l'utilisateur peut ajouter soit un effet de « Douleur » ou un effet de « Peur » de 5 secondes comme bon lui semble. L'utilisateur doit aussi choisir une deuxième variante de la compétence Inscriptions Arcaniques."),
                    new Variant(
                        "Encre : sur tous les sorts de l'école d'Abjuration qui sont inscrits sur les tatouages corporels à l’encre, le tiers de l'effet est augmenté de 1. L'utilisateur doit aussi choisir une deuxième variante de la compétence Inscriptions Arcaniques."),
                    new Variant(
                        "Charbon : Moyennant une unité de charbon, l'utilisateur peut changer jusqu'à cinq niveaux de tatouages sur son corps en 30 minutes. L'utilisateur doit aussi choisir une deuxième variante de la compétence Inscriptions Arcaniques.")
                ],
                150),
            new Competence(155, "Serment",
                "Le moine doit sélectionner un serment qu'il devra garder. Tant qu'il garde son serment, il a un bonus de + 2 niveaux de tatouages corporels et de bras et jambes. De plus, il a un bonus de +3 PV Max et +3 PM Max. Si le serment n'est pas respecté, il perdra tous les bénéfices de cette compétence tant qu'il n'aura pas eu rédemption.",
                [
                    new Variant(
                        "Voeu de Chasteté : L'utilisateur ne peut pas entretenir de relation romantique, ou même de désirs romantiques envers quiconque. NOTE : seul un sort de « Charme » excessivement puissant OU boire un philtre d'amour peut briser ce vœu."),
                    new Variant(
                        "Voeu de Pureté : L'utilisateur ne peut pas boire de concoction alchimique ou d’alcool. Il devra aussi faire preuve d'une routine d'hygiène saine afin de garder la pureté de son corps."),
                    new Variant(
                        "Voeu de Pauvreté : L'utilisateur ne peut pas avoir de possessions matérielles sur lui, outre son bâton de marche (ne peut être un bâton de pouvoir). Il ne peut posséder d'objets magiques, de métaux précieux, de monnaie, etc.")
                ])
        ];
        ShamanT3 =
        [
            new Competence(156, "Cercle de stabilisation",
                "L’utilisateur peut, suivant une cérémonie de 5 minutes et au coût de 10 PM, stabiliser tous les agonisants dans un rayon de 20 pieds autour de lui. L’utilisateur ne peut pas se déplacer durant la cérémonie et cette dernière doit se dérouler à l’extérieur. Suite à la cérémonie, les personnes agonisantes affectées tomberont en convalescence.",
                [
                    new Variant("La nature énergise. Suite à la convalescence, les cibles gagnent +2 PV."),
                    new Variant(
                        "La nature répare. Au coût de 5 PM dépensés par l'utilisateur, suite à la convalescence, tous les bris de membres seront douloureusement réparés."),
                    new Variant("La nature apaise. Suite à la convalescence, les effets mentaux seront dissipés.")
                ]),
            new Competence(157, "Communication avec les animaux",
                "L’utilisateur peut maintenant communiquer avec les créatures animales, excluant les créatures de type insecte.",
                [
                    new Variant("Permet de communiquer avec les insectes."),
                    new Variant("Permet de communiquer avec un Féral en forme complète, même lorsque enragé."),
                    new Variant(
                        "Une fois par jour, permet d'apaiser un animal et certaines créatures magiques. Peut aussi permettre à un Féral de sortir de sa rage. Dans ce cas, cette compétence peut être utilisée sur soi-même.")
                ]),
            new Competence(158, "Communication avec les esprits",
                "L’utilisateur peut, suivant une cérémonie d'au moins 10 minutes, discuter pendant 5 minutes avec l’esprit qui répondra. Si aucun esprit n’est présent sur les lieux de la cérémonie, l'utilisateur ouvre tout de même une porte pour la communication avec un esprit répondant dans la région. Dans le cas échéant, vous devrez aller voir la Mort afin d’avoir votre discussion. Dans le cas où vous devez aller voir l’animation, vous ne pouvez utiliser cette compétence qu’une fois par jour. Si un esprit est présent sur place, vous pouvez utiliser de nouveau cette compétence.",
                [
                    new Variant(
                        "Permet, à la suite de la cérémonie, de parler avec les morts récents (de la journée). La présence du cadavre est requise."),
                    new Variant(
                        "Permet d'établir un lien avec un esprit spécifique. Le lien doit être discuté avec l'esprit en question lors d'une cérémonie initiale. Suite à l'établissement de ce lien, seul cet esprit pourra répondre aux cérémonies. Si celui-ci est indisponible, la Mort vous répondra. Un lien peut être brisé, mais il faudra une autre cérémonie. Attention, les esprits ont une bonne mémoire…"),
                    new Variant(
                        "L’utilisateur peut, une fois par scénario, utiliser cette compétence sans cérémonie pour parler à un esprit présent.")
                ],
                "Variante 3 : citer « Communication avec les esprits » en s'adressant à l'esprit visé."),
            new Competence(159, "Rêves prémonitoires",
                "L’utilisateur peut obtenir des rêves prémonitoires sur une base aléatoire (Hasard). L'animation fournit un compte-rendu du rêve.",
                [
                    new Variant(
                        "Suite à une méditation de 30 minutes ou à votre réveil d’une nuit de sommeil, vous pouvez, une fois par saison, aller demander à l'animation de vous donner un rêve prémonitoire immédiatement."),
                    new Variant(
                        "Vous avez vu ce moment décisif ! Vous possédez la compétence Presquive (sans variante). Cela n’affecte pas la progression dans les arbres de compétences."),
                    new Variant(
                        "Pendant un événement d’exploration, vous pouvez demander le résultat d'une des options, une fois par exploration.")
                ])
        ];
        ShamanT4 =
        [
            new Competence(160, "Antidote naturel", "L'utilisateur peut concocter un antidote à partir de plantes et d'éléments naturels qu'il trouvera dans son environnement. Produire un antidote naturel prendra 30 minutes de collecte en nature. L'utilisateur peut garder son antidote pendant la durée de l'événement et ne peut avoir qu'un antidote sur lui à la fois.", 
                [
                    new Variant("Si l'antidote retire l'effet négatif d'une concoction, la cible se guérit d'un 3 PV additionnels."),
                    new Variant("Si l'antidote retire l'effet négatif d'une concoction, la cible gagne une résistance à la prochaine instance d’effet néfaste de concoctions. Accessoirement, cela immunise aussi des effets secondaires de concoctions pour la prochaine heure."),
                    new Variant("Si l'antidote retire l’effet négatif d’une concoction, un effet mental affligeant la cible peut être retiré.")
                ]),
            new Competence(161, "Cérémonie", "À la conclusion d'une cérémonie, tous les participants récupèrent 5 PM. Une cérémonie de ce genre doit durer au minimum 15 minutes et compter au minimum 3 participants, excluant l'utilisateur. L'utilisateur connaît les secrets de la communication avec les esprits et sait les attirer. S'il avertit l'animation au moins 2 heures avant le début de la cérémonie, il lui est possible d'appeler un esprit spécifique avec cette compétence. NOTE : Les variantes sont des cérémonies spécifiques dont les effets ne se cumulent pas avec la compétence Cérémonie.", 
                [
                    new Variant("Cérémonie d'unification : L'utilisateur peut unifier deux âmes jusqu'à ce que la mort les sépare. La cérémonie doit durer au minimum 15 minutes et nécessite au moins 4 célébrants, excluant l'utilisateur et les deux êtres unifiés. Suite à la célébration, les deux cibles gagnent les bonus suivants : \nElles peuvent maintenant stabiliser leur partenaire gratuitement sans utiliser de compétence, en passant 5 minutes à leurs côtés. \nElles possèdent un sauf-conduit à la Mort pour la durée de l'évènement. \nSi l’un des deux mariés tombe au combat, l’autre obtient tous ses PVT. \nUn mariage doit être fait entre deux personnes consentantes, et ces personnes ne peuvent être mariées qu’à une seule personne à la fois. Donne aussi accès à la cérémonie de divorce, qui prend le consentement d’un seul des deux partis."),
                    new Variant("Cérémonie des chaînes : L'utilisateur peut se servir de cette cérémonie afin d'ancrer un esprit dans le plan matériel et le rendre physique. La cérémonie doit durer un minimum de 10 minutes et plus il y a de célébrants, plus les chances de succès sont grandes. Un Shaman peut tenter de faire cette cérémonie seul quand même ; il est à noter qu'un esprit se rendant compte de la situation peut s'en offusquer… "),
                    new Variant("Cérémonie de fidélisation : Requiert qu'une cible soit à l'agonie et ait accepté les répercussions de la cérémonie. L'utilisateur effectue une cérémonie afin de guérir la cible et celle-ci revient en vie avec un nombre de PV équivalent à son maximum de PVT. Par contre, la cible vouera une loyauté inébranlable envers l'utilisateur pendant une heure après la cérémonie. Cette cérémonie doit durer au moins 5 minutes. NOTE : Aucun autre célébrant n'est nécessaire à part l'utilisateur et la cible.")
                ]),
            new Competence(162, "Quête de vision", "Le shaman est en mesure de méditer sous l'influence de substances afin d'acquérir quelques bonus. Le Shaman sera en mesure, suivant la durée requise, de poser une question hors jeu à l’animation.", 
                [
                    new Variant("Le Shaman peut entrer dans un état second en prenant une consommation de Beuvrâhge. Le joueur doit jouer l'ivresse pendant 1 heure. Alors qu'il est ivre, l'utilisateur est immunisé aux effets de peur. Une fois l'heure terminée, il devra jouer la gueule de bois pendant 30 minutes, et sera incapable d'utiliser ses compétences de concentration."),
                    new Variant("Le Shaman peut entrer en état second en prenant une consommation d'un antidote naturel (voir Antidote naturel). Il sera incapable de combattre pendant les 30 prochaines minutes et devra jouer des hallucinations vivides et colorées. Pendant la phase d'hallucinations, l'utilisateur est immunisé à toute forme d'effet mental. Par contre, dès les 30 minutes terminées, il aura une période réfractaire où le monde semble morne et sans couleur pour un autre 30 minutes. Pendant ce délai, l'utilisateur sera incapable d'utiliser ses résistances contre les effets mentaux (à moins qu'il soit en possession d'un objet magique)."),
                    new Variant("Le Shaman peut entrer en état second en prenant une consommation de substance alchimique. Il abandonne donc l'effet de la potion afin de pouvoir aller en quête de vision. La potion doit avoir un niveau de toxicité d'au moins 30 pour être valide. Il devra jouer une forme exagérée de l'effet de la potion tant qu'il en subira la toxicité. Pendant l'heure qui suit, l'utilisateur refuse catégoriquement d’ingurgiter quelconque substance que ce soit, mais sera immunisé à toutes potions. Lorsque l'heure est terminée, il sera nauséeux pour les 30 prochaines minutes.")
                ]),
            new Competence(163, "Totem", "L’utilisateur obtient un esprit totem. Chaque esprit totem offre un sort actif de plus à son utilisateur. Par contre, ce dernier ne pourra plus avoir de « familier ». S'il avait précédemment un familier, il doit l'abandonner et rompre le lien avec celui-ci avant de choisir cette compétence.", 
                [
                    new Variant("Totem du Hibou : Permet à l'utilisateur d'ignorer l'effet d'un sort de son choix par jour. Il doit déclarer l'utilisation de son totem après avoir reçu le sort, l'effet est visible à l'œil nu, le sort semble s'éloigner de l'utilisateur."),
                    new Variant("Totem de l'Ours : Permet à l'utilisateur d'endurer plus. Bonus de +2 PV Max."),
                    new Variant("Totem du Serpent : Permet à l'utilisateur d'ajouter un effet « Paralysie » pendant 5 secondes au premier sort de toucher qu'il lance en combat.")
                ],
                "Citer le totem utilisé et son effet.")
        ];
    }
}