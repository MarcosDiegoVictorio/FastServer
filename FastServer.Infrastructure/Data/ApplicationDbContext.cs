using Microsoft.EntityFrameworkCore;
using FastServer.Domain.Entities;

namespace FastServer.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    //DbSet para suas entidades
    public DbSet<Lunch> Lunches { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<LunchIngredient> LunchIngredients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Configurar a chave primaria composta para LunchIngredient
        modelBuilder.Entity<LunchIngredient>()
            .HasKey(li => new { li.LunchId, li.IngredientId });

        // Configura a relação entre LunchIngredient e Lunch
        modelBuilder.Entity<LunchIngredient>()
            .HasOne(li => li.Lunch)
            .WithMany(l => l.LunchIngredients)
            .HasForeignKey(li => li.IngredientId);

        //Configura a relação entre LunchIngredient e Ingredient
        modelBuilder.Entity<LunchIngredient>()
            .HasOne(li => li.Ingredient)
            .WithMany(i => i.LunchIngredients)
            .HasForeignKey(li => li.IngredientId);

        base.OnModelCreating(modelBuilder);
    }
}

