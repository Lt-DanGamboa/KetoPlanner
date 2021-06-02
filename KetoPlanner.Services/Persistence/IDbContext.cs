using KetoPlanner.Entities;
using OpenREITS.Services.RecipeCreator;

namespace KetoPlanner.Services.Persistence
{
    public interface IDbContext
    {
        IRecipeRepo Recipe { get; }
    }

    public interface IRecipeRepo
    {
        void Save(Recipe recipe);
    }
}