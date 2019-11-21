using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace Recipes.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.recipes.Any())
            {
                context.recipes.AddRange(
                    new RecipeResponse
                    {
                        UserName = "Rose",
                        FoodName = "Creamy Mushroom Soup",
                        Ingredients = "3 tablespoons canola oil, divided 1 small yellow onion, chopped 3 cloves garlic, chopped 8 ounces thinly sliced fresh cremini mushrooms (2½ cups), divided 8 ounces shiitake mushrooms, stemmed and thinly sliced (2 cups), divided 6 cups low-sodium vegetable broth 2 medium russet potatoes, peeled and chopped 2 teaspoons kosher salt ¼ cup heavy cream ¼ teaspoon freshly ground black pepper 2 tablespoons chopped fresh chives Crusty bread, for serving",
                        FoodRecipe = "Heat 1 tablespoon oil in a large, heavy-bottomed pot over medium-high. Add onion, garlic, 2 cups creminis, and 1½ cups shiitakes. Cook, stirring often, until softened, 6 to 7 minutes. Add broth, potatoes, and salt; bring to a boil. Reduce heat and simmer until potatoes are tender, 15 to 18 minutes. Stir in cream and pepper. Heat remaining 2 tablespoons oil in a large skillet over medium-high. Add remaining ½ cup each creminis and shiitakes and cook, stirring occasionally, until golden brown, 4 to 5 minutes.",
                        Category = 1
                    },
                    new RecipeResponse
                    {
                        UserName = "Kate",
                        FoodName = "Creamy Mushroom Soup",
                        Ingredients = "3 tablespoons canola oil, divided 1 small yellow onion, chopped 3 cloves garlic, chopped 8 ounces thinly sliced fresh cremini mushrooms (2½ cups), divided 8 ounces shiitake mushrooms, stemmed and thinly sliced (2 cups), divided 6 cups low-sodium vegetable broth 2 medium russet potatoes, peeled and chopped 2 teaspoons kosher salt ¼ cup heavy cream ¼ teaspoon freshly ground black pepper 2 tablespoons chopped fresh chives Crusty bread, for serving",
                        FoodRecipe = "Heat 1 tablespoon oil in a large, heavy-bottomed pot over medium-high. Add onion, garlic, 2 cups creminis, and 1½ cups shiitakes. Cook, stirring often, until softened, 6 to 7 minutes. Add broth, potatoes, and salt; bring to a boil. Reduce heat and simmer until potatoes are tender, 15 to 18 minutes. Stir in cream and pepper. Heat remaining 2 tablespoons oil in a large skillet over medium-high. Add remaining ½ cup each creminis and shiitakes and cook, stirring occasionally, until golden brown, 4 to 5 minutes.",
                        Category = 2
                    },
                    new RecipeResponse
                    {
                        UserName = "Jeongsil",
                        FoodName = "Creamy Mushroom Soup",
                        Ingredients = "3 tablespoons canola oil, divided 1 small yellow onion, chopped 3 cloves garlic, chopped 8 ounces thinly sliced fresh cremini mushrooms (2½ cups), divided 8 ounces shiitake mushrooms, stemmed and thinly sliced (2 cups), divided 6 cups low-sodium vegetable broth 2 medium russet potatoes, peeled and chopped 2 teaspoons kosher salt ¼ cup heavy cream ¼ teaspoon freshly ground black pepper 2 tablespoons chopped fresh chives Crusty bread, for serving",
                        FoodRecipe = "Heat 1 tablespoon oil in a large, heavy-bottomed pot over medium-high. Add onion, garlic, 2 cups creminis, and 1½ cups shiitakes. Cook, stirring often, until softened, 6 to 7 minutes. Add broth, potatoes, and salt; bring to a boil. Reduce heat and simmer until potatoes are tender, 15 to 18 minutes. Stir in cream and pepper. Heat remaining 2 tablespoons oil in a large skillet over medium-high. Add remaining ½ cup each creminis and shiitakes and cook, stirring occasionally, until golden brown, 4 to 5 minutes.",
                        Category = 2
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
