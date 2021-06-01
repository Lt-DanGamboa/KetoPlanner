using KetoPlanner.Services.RecipeCreator;
using Xunit;

namespace KetoPlanner.Tests
{
    public class RecipeProcessingTests
    {
        [Fact(DisplayName = "Create & save a new recipe")]
        public void CreateAndSaveRecipe()
        {
            IRecipeCreator recipeCreator = new RecipeCreator();
        }
    }
}