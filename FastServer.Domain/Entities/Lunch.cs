// FastServer.Domain/Entities/Lunch.cs
using System.Collections.Generic;
using System.Linq;

namespace FastServer.Domain.Entities;

public class Lunch
{
    public int Id { get; set; }
    public string ?Name { get; set; }
    public decimal TotalValue { get; set; }
    public ICollection<LunchIngredient> LunchIngredients { get; set; } = new List<LunchIngredient>();

    public void CalculateTotalValue()
    {
        TotalValue = LunchIngredients != null && LunchIngredients.Any() ?
                     LunchIngredients.Sum(li => li.Ingredient?.Value ?? 0)
                     : 0;
    }
}