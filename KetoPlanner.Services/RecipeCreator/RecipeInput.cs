using System.Collections.Generic;
using KetoPlanner.Services.RecipeCreator;

namespace OpenREITS.Services.RecipeCreator
{
    public class RecipeInput
    {
        public string Description { get; set; }
        public int CountOfCarbs { get; set; }
        public int Likes { get; set; }
        public int UsingCounter { get; set; }
        public double TastyScore { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}