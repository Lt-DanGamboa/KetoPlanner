namespace KetoPlanner.Services.RecipeCreator
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public VolumeMeasurementType MeasurementType { get; set; }
    }
}