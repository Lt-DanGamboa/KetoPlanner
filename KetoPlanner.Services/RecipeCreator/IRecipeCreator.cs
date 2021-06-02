using OpenREITS.Services.RecipeCreator;

namespace KetoPlanner.Services.RecipeCreator
{
    public interface IRecipeCreator
    {
        Command<RecipeInput> SaveRecipe { get; }
    }

}