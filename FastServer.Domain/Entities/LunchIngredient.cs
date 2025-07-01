// FastServer.Domain/Entities/LunchIngredient.cs
namespace FastServer.Domain.Entities;

public class LunchIngredient
{
    public int LunchId { get; set; }
    public Lunch Lunch { get; set; }

    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }
}