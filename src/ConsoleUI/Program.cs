using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Recipe> Rep = ListManager.LoadData();

            //Rep = Rep.Where(x => x.Time < 60).ToList();
            //Rep = Rep.OrderBy(x => x.Name).ToList();
            //Rep = Rep.OrderBy(x => x.MealType).ThenByDescending(x => x.Time).ToList();
            
            foreach (var recipe in Rep)
            {
                Console.WriteLine($"{ recipe.Name } { recipe.MainIngredient } ({ recipe.MealType }): Minutes { recipe.Time }");
            }

            Console.ReadLine();
        }
    }
}
