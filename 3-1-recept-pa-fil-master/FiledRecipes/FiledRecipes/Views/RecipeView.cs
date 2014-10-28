using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{

    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (IRecipe recipe in recipes) 
            {
                Show(recipes);
                ContinueOnKeyPressed();
            }

        }
         public void Show(IRecipe recipe)
        {//header with recipe name
            Console.Clear();
            Header = recipe.Name;
            ShowHeaderPanel();
            Console.WriteLine("Ingredienser");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine("Instruktioner");
            Console.WriteLine("------------------------------------------------------------");

            foreach (var instruction in recipe.Instructions)
            {
                Console.WriteLine(instruction);
            }


        }


   
    }
}
