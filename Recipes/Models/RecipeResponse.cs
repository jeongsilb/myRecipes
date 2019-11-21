using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class RecipeResponse
    {
        [Required(ErrorMessage = "Please enter Recipe ID")]
        [Key]
        public int RecipeID { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter food name")]
        public string FoodName { get; set; }
        [Required(ErrorMessage = "Please enter this food ingredients")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "Please enter this food recipe")]
        public string FoodRecipe { get; set; }
        [Required(ErrorMessage = "Please specify one option")]
        public int Category { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;
    }
}
