using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository repository;
        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        public ViewResult RecipeList() => View(repository.recipes);

        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AddRecipe(int recipeID) =>
           View(repository.recipes
               .FirstOrDefault(r => r.RecipeID == recipeID));
        [HttpPost]
        public IActionResult AddRecipe(RecipeResponse recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.FoodName} has been saved!";
                return RedirectToAction("RecipeList");
            }
            else
            {
                return View(recipe);
            }
        }
        public ViewResult Create() => View("AddRecipe", new RecipeResponse());

        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            RecipeResponse deletedRecipe = repository.DelecteRecipe(recipeId);

            if (deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.FoodName} was deletd!";
            }
            return RedirectToAction("RecipeList");
        }

        public ViewResult ViewRecipe(int recipeID)
        {
            return View(repository.recipes
               .FirstOrDefault(r => r.RecipeID == recipeID));
        }
        public ViewResult ReviewRecipe()
        {
            return View();
        }
    }
}
