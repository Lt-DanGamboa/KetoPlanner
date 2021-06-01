using OpenREITS.Services.RecipeCreator;

namespace KetoPlanner.Services.RecipeCreator
{
    public interface IRecipeCreator
    {
        Command<RecipeInput> SaveRecipe { get; }
    }

    public class RecipeCreator : IRecipeCreator
    {
        public Command<RecipeInput> SaveRecipe => throw new System.NotImplementedException();
    }

}