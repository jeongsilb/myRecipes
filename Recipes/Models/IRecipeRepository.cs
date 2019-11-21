using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public interface IRecipeRepository
    {
        IQueryable<RecipeResponse> recipes { get; }
        void SaveRecipe(RecipeResponse recipeResponse);

        RecipeResponse DelecteRecipe(int RecipeID);
    }
}
