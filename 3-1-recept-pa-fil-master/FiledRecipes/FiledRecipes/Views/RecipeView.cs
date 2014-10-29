﻿using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{

    public class RecipeView : ViewBase, IRecipeView
    {
        
         public void Show(IRecipe recipe)
        {//header with recipe name
            Console.Clear();
            Header = recipe.Name;
            ShowHeaderPanel();
            Console.WriteLine();
            Console.WriteLine("Ingredienser");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine();
            Console.WriteLine("Instruktioner");
            Console.WriteLine("------------------------------------------------------------");

            foreach (string instruction in recipe.Instructions)
            {
                Console.WriteLine(instruction);
            }


        }

         public void Show(IEnumerable<IRecipe> recipes)
         {
             foreach (IRecipe recipe in recipes)
             {
                 Show(recipe);
                 ContinueOnKeyPressed();
             }

         }

   
    }
}
