// FastServer.Domain/Entities/Ingredient.cs
using System.Collections.Generic;

namespace FastServer.Domain.Entities;

public class Ingredient
{
    public int Id { get; set; }
    public string ?Name { get; set; }
    public decimal Value { get; set; }
    public ICollection<LunchIngredient> LunchIngredients { get; set; } = new List<LunchIngredient>();
}
