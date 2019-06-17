using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class Recipe
    {

        public string Name { get; set; }
        public string MainIngredient { get; set; }
        public string MealType { get; set; }
        public string Time { get; set; }
        public HashSet<string> AllIngredients { get; set; }
        public string Directions { get; set; }
        public string Nutrition { get; set; }

        public string RecipeDisName
        {
            get
            {
                return $"{ Name }{ MealType }{ MainIngredient }{ Time }";
            }
        }

    }
}
