using System;
using System.Security.Principal;
using KetoPlanner.Entities;
using KetoPlanner.Services.Persistence;
using OpenREITS.Services.RecipeCreator;

namespace KetoPlanner.Services.RecipeCreator
{
    public class RecipeCreator : IRecipeCreator
    {
        public RecipeCreator(IDbContext db)
        {
            this.db = db;
        }
        public Command<RecipeInput> SaveRecipe => 
            Command<RecipeInput>.Wrap(SaveImp);
        
        private void SaveImp(IExtendedPrincipal user, RecipeInput input)
        {
            db.Recipe.Save(new Recipe
            {
                UserId = user.Id,
                Description = input.Description,
                CountOfCarbs = input.CountOfCarbs,
                Ingredients = input.Ingredients
            });
        }
        private readonly IDbContext db;
    }
}