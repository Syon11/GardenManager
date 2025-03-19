using GardenManager.Model;
using GardenManager.Model.Arcane;
using Microsoft.EntityFrameworkCore;

namespace GardenManager.Context;

public class EmergenceContext(DbContextOptions<EmergenceContext> options) : DbContext(options)
{
    public DbSet<ArcaneConfig> ArcaneConfigs { get; set; }
    public DbSet<ArcaneEffect> ArcaneEffects { get; set; }
    public DbSet<ArcaneModifier> ArcaneModifiers { get; set; }
    public DbSet<ArcaneShape> ArcaneShapes { get; set; }
    public DbSet<Word> Words { get; set; }
    public DbSet<ConfigWord> ConfigWords { get; set; }
    public DbSet<EffectWord> EffectWords { get; set; }
    public DbSet<ModifierWord> ModifierWords { get; set; }
    public DbSet<ShapeWord> ShapeWords { get; set; }
    public DbSet<PowerWord> PowerWords { get; set; }
    public DbSet<Spell> Spells { get; set; }
    public DbSet<Variant> Variants { get; set; }
    public DbSet<Competence> Competences { get; set; }
    public DbSet<RacialCompetence> RacialCompetences { get; set; }
    public DbSet<Race> Races { get; set; }
    public DbSet<Origin> Origins { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<User> Users { get; set; }
}