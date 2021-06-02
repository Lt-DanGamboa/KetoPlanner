using System.Collections.Generic;
using System.Security.Principal;
using KetoPlanner.Entities;
using KetoPlanner.Services.Persistence;
using KetoPlanner.Services.RecipeCreator;
using KetoPlanner.Tests.Mocks;
using Moq;
using OpenREITS.Services.RecipeCreator;
using Xunit;

namespace KetoPlanner.Tests
{
    public class RecipeProcessingTests
    {
        [Fact(DisplayName = "Create & save a new recipe")]
        public void CreateAndSaveRecipe()
        {
            List<Ingredient> ingredients = new List<Ingredient>
            {
                new Ingredient
                {
                    Name = "Tocino",
                    Quantity = 2,
                    MeasurementType = VolumeMeasurementType.Piece
                },
                new Ingredient
                {
                    Name = "Huevo",
                    Quantity = 2,
                    MeasurementType = VolumeMeasurementType.Piece
                },
                new Ingredient
                {
                    Name = "Aceite",
                    Quantity = 1,
                    MeasurementType = VolumeMeasurementType.Teaspoon
                },
                new Ingredient
                {
                    Name = "Sal",
                    Quantity = 1,
                    MeasurementType = VolumeMeasurementType.Pint
                }
            };

            RecipeInput input = new RecipeInput
            {
                Description = "Huevos con tocino",
                CountOfCarbs = 2,
                Likes = 2,
                UsingCounter = 4,
                TastyScore = 7,
                Ingredients = ingredients
            };

            Mock<IDbContext> db = new Mock<IDbContext>();

            db.Setup(d => d.Recipe.Save(It.IsAny<Recipe>()))
                .Callback((Recipe rcp) =>
                {
                    Assert.NotNull(rcp);
                    Assert.NotNull(rcp.UserId);
                    Assert.NotNull(rcp.CountOfCarbs);
                    Assert.NotNull(rcp.Description);
                    Assert.NotNull(rcp.Ingredients);
                });
            
            
            IExtendedPrincipal user = new MockPrincipal();
            IRecipeCreator recipeCreator = new RecipeCreator(db.Object);
            recipeCreator.SaveRecipe.Invoke(user, input);
        }
    }
}