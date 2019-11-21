using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<RecipeResponse> recipes => context.recipes;
        public void SaveRecipe(RecipeResponse recipeResponse)
        {
            if (recipeResponse.RecipeID == 0)
            {
                context.recipes.Add(recipeResponse);
            }
            else
            {
                RecipeResponse recipeEntry = context.recipes
                    .FirstOrDefault(r => r.RecipeID == recipeResponse.RecipeID);
                if (recipeEntry != null)
                {
                    recipeEntry.FoodName = recipeResponse.FoodName;
                    recipeEntry.UserName = recipeResponse.UserName;
                    recipeEntry.Ingredients = recipeResponse.Ingredients;
                    recipeEntry.FoodRecipe = recipeResponse.FoodRecipe;
                    recipeEntry.Category = recipeResponse.Category;
                }
            }
            context.SaveChanges();
        }
        public RecipeResponse DelecteRecipe(int recipeID)
        {
            RecipeResponse recipeEntry = context.recipes
               .FirstOrDefault(r => r.RecipeID == recipeID);
            if (recipeEntry != null)
            {
                context.recipes.Remove(recipeEntry);
                context.SaveChanges();
            }
            return recipeEntry;
        }
    }
}
