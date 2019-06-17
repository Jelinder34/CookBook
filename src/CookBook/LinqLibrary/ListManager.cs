using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Recipe> LoadData()
        {
            List<Recipe> output = new List<Recipe>();

            output.Add(new Recipe { Name = "Steak with Chipotle-Lime Chimichurri", MainIngredient = "Steak", MealType = "Dinner", Time = "30", AllIngredients = new HashSet<string> { "2 cups fresh parsley leaves", "1-1/2 cups fresh cilantro leaves", "1/2 medium red onion", "1 to 2 chipotle peppers in adoba sauce", "5 garlic cloves", "1/2 cup olive oil", "1/4 cup white wine vinegar", "1 tsp grated lime zest", "1/4 cup lime juice", "3 tsp dried oregano", "1-1/4 tsp salt", "3/4 tsp pepper", "2 pounds beef flat iron steaks" }, Directions = "For chimichurri, place the first 5 ingredients in a food processor; pulse until finely chopped. Add oil, vinegar, lime zest, lime juice, oregano, 1/2 teaspoon salt and 1/4 teaspoon pepper; process until blended. Transfer to a bowl; refrigerate, covered, until serving. Sprinkle steaks with the remaining salt and pepper. Grill, covered, over medium heat 5-8 minutes on each side or until meat reaches desired doneness (for medium-rare, a thermometer should read 135°; medium, 140°; medium-well, 145°). Let stand 5 minutes before slicing. Serve with chimichurri.", Nutrition = "Per Serving: 207 calories; 14 g fat; 5.7 g carbohydrates; 15 g protein; 25 mg cholesterol; 640 mg sodium." });

            output.Add(new Recipe { Name = "Creamy Ham and Cheese Quiche", MainIngredient = "Egg", MealType = "Breakfast", Time = "75", AllIngredients = new HashSet<string> { "9-inch pie crust", "1 cup shredded cheddar cheese", "1/2 cup shredded swiss cheese", "2 tbs all-purpose flour", "1/2 cup diced cooked ham", "2 tbs honey mustard", "1-1/4 cups half and half", "5 eggs", "1/4 cup green onions", "1/4 tsp salt" }, Directions = "Preheat oven to 400 degrees F (200 degrees C). Press pie pasty into the bottom of a 9-inch pie plate. Bake pie crust in preheated oven for 5 minutes, use a fork to poke holes into the crust, and continue cooking until lightly browned, about 5 minutes more. Reduce oven heat to 350 degrees F (175 degrees C). Mix 1/2 cup Cheddar cheese, Swiss cheese, and 1 tablespoon flour in a bowl; spread over the warm pie crust. Stir ham and honey mustard together in a bowl to coat the ham completely; spoon over the cheese mixture. Mix half-and-half, eggs, green onions, 1 tablespoon flour, and salt together in bowl. Pour mixture carefully over the ham layer; top with remaining Cheddar cheese. Bake in preheated oven until set in the center, 40 to 50 minutes. Cool for 10 minutes before cutting.", Nutrition = "Per Serving: 327 calories; 23.3 g fat; 16.1 g carbohydrates; 13.7 g protein; 155 mg cholesterol; 538 mg sodium. " });

            output.Add(new Recipe { Name = "Mac-N-Cheese Pizza",  MainIngredient = "Elbow Macaroni", MealType = "Dinner", Time = "55", AllIngredients = new HashSet<string> { "Cooking Spray", "11 ounce package refrigerated pizza crust", "1/2 cups of elbow macoroni", "1/4 cup butter", "tablespoon all-purpose flour", "milk", "3/4 pound processed cheese", "1/2 cup shredded mozzarella cheese" }, Directions = "Preheat oven to 400 degrees F (200 degrees C). Spray a 10x15-inch baking sheet with cooking spray. Unroll pizza crust and place on the prepared baking pan. Bring a large pot of lightly salted water to a boil.Cook elbow macaroni in the boiling water, stirring occasionally until cooked through but firm to the bite,8 minutes.Drain. Melt butter in a large saucepan over medium heat; cook and stir flour with butter until it has a slightly toasted fragrance, about 2 minutes.Whisk in milk and simmer until thickened, whisking constantly, 2 more minutes. Stir in processed cheese cubes. Let the cheese cubes melt, stirring often, to make a smooth cheese sauce. Spread about 3 / 4 cup of cheese sauce onto the pizza crust. Stir cooked macaroni into remaining cheese sauce in the saucepan and spoon the macaroni and cheese onto the crust in an even layer.Sprinkle top of pizza with mozzarella cheese. Bake in the preheated oven until the crust is lightly browned and the mozzarella cheese is golden brown, about 15 minutes.", Nutrition = "Per Serving: 411 calories; 19.7 g fat; 39.3 g carbohydrates; 18.5 g protein; 56 mg cholesterol; 897 mg sodium." });

            return output;
        }
    }
}
