using System.Collections.Generic;

namespace KetoPlanner.Entities
{
    public class Recipe
    {
        public int UserId { get; set; }
        //public string ImageURL { get; set; }
        //public string ShareURL { get; set; }
        public string Description { get; set; }
        public int CountOfCarbs { get; set; }
        public int Likes { get; set; }
        public int UsingCounter { get; set; }
        public double TastyScore { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}