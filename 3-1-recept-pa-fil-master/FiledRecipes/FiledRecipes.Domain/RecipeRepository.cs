using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FiledRecipes.Domain
{
    /// <summary>
    /// Holder for recipes.
    /// </summary>
    public class RecipeRepository : IRecipeRepository
    {
        /// <summary>
        /// Represents the recipe section.
        /// </summary>
        private const string SectionRecipe = "[Recept]";

        /// <summary>
        /// Represents the ingredients section.
        /// </summary>
        private const string SectionIngredients = "[Ingredienser]";

        /// <summary>
        /// Represents the instructions section.
        /// </summary>
        private const string SectionInstructions = "[Instruktioner]";

        /// <summary>
        /// Occurs after changes to the underlying collection of recipes.
        /// </summary>
        public event EventHandler RecipesChangedEvent;

        /// <summary>
        /// Specifies how the next line read from the file will be interpreted.
        /// </summary>
        private enum RecipeReadStatus { Indefinite, New, Ingredient, Instruction };

        /// <summary>
        /// Collection of recipes.
        /// </summary>
        private List<IRecipe> _recipes;

        /// <summary>
        /// The fully qualified path and name of the file with recipes.
        /// </summary>
        private string _path;

        /// <summary>
        /// Indicates whether the collection of recipes has been modified since it was last saved.
        /// </summary>
        public bool IsModified { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the RecipeRepository class.
        /// </summary>
        /// <param name="path">The path and name of the file with recipes.</param>
        public RecipeRepository(string path)
        {
            // Throws an exception if the path is invalid.
            _path = Path.GetFullPath(path);

            _recipes = new List<IRecipe>();
        }

        /// <summary>
        /// Returns a collection of recipes.
        /// </summary>
        /// <returns>A IEnumerable&lt;Recipe&gt; containing all the recipes.</returns>
        public virtual IEnumerable<IRecipe> GetAll()
        {
            // Deep copy the objects to avoid privacy leaks.
            return _recipes.Select(r => (IRecipe)r.Clone());
        }

        /// <summary>
        /// Returns a recipe.
        /// </summary>
        /// <param name="index">The zero-based index of the recipe to get.</param>
        /// <returns>The recipe at the specified index.</returns>
        public virtual IRecipe GetAt(int index)
        {
            // Deep copy the object to avoid privacy leak.
            return (IRecipe)_recipes[index].Clone();
        }

        /// <summary>
        /// Deletes a recipe.
        /// </summary>
        /// <param name="recipe">The recipe to delete. The value can be null.</param>
        public virtual void Delete(IRecipe recipe)
        {
            // If it's a copy of a recipe...
            if (!_recipes.Contains(recipe))
            {
                // ...try to find the original!
                recipe = _recipes.Find(r => r.Equals(recipe));
            }
            _recipes.Remove(recipe);
            IsModified = true;
            OnRecipesChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Deletes a recipe.
        /// </summary>
        /// <param name="index">The zero-based index of the recipe to delete.</param>
        public virtual void Delete(int index)
        {
            Delete(_recipes[index]);
        }

        /// <summary>
        /// Raises the RecipesChanged event.
        /// </summary>
        /// <param name="e">The EventArgs that contains the event data.</param>
        protected virtual void OnRecipesChanged(EventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of 
            // a race condition if the last subscriber unsubscribes 
            // immediately after the null check and before the event is raised.
            EventHandler handler = RecipesChangedEvent;

            // Event will be null if there are no subscribers. 
            if (handler != null)
            {
                // Use the () operator to raise the event.
                handler(this, e);
            }
        }
        public void Load()
        {
            //create list
            List<IRecipe> recipes = new List<IRecipe>();
            //variable
            string line;
            RecipeReadStatus status = RecipeReadStatus.Indefinite;//set for unknown length
            Recipe myRecipe = null;
            try
            { //try catch phrase for exceptions?
                using (StreamReader streamReader = new StreamReader(_path)) //set up streamreader
                {
                    while ((line = streamReader.ReadLine()) != null) //Keep reading until the end
                    {
                        if (line != "") //skip to the next line if blank
                        {
                            if (line == SectionRecipe) //if new recipe
                            {
                                status = RecipeReadStatus.New;
                            }

                            else if (line == SectionIngredients) //else if new ingredient section
                            {
                                status = RecipeReadStatus.Ingredient;
                            }

                            else if (line == SectionInstructions) //else if there are instructions
                            {
                                status = RecipeReadStatus.Instruction;
                            }
                            else
                            {//trying again with if instead of switch?
                                if (status == RecipeReadStatus.New)
                                {
                                    myRecipe = new Recipe(line);
                                    recipes.Add(myRecipe); //add new recipe
                                }

                                else if (status == RecipeReadStatus.Ingredient)
                                {
                                    string[] value = line.Split(new char[] { ';' }, StringSplitOptions.None); //set up ingredients after ;

                                    if (value.Length != 3) //stop if more than 3 
                                    {
                                        throw new FileFormatException("FEL! Tre Ingrediens behövs!"); //catch if too many items 

                                    }

                                    Ingredient ingredient = new Ingredient();
                                    ingredient.Amount = value[0];
                                    ingredient.Measure = value[1];
                                    ingredient.Name = value[2];
                                    myRecipe.Add(ingredient); //set in right order and add
                                }

                                else if (status == RecipeReadStatus.Instruction)
                                {
                                    myRecipe.Add(line); //add instructions
                                }

                                else
                                {
                                    throw new FileFormatException(); //find any exceptions
                                }
                            }
                        }
                    }
                }
                recipes.TrimExcess(); //include trim excess
                _recipes = recipes.OrderBy(recipe => recipe.Name).ToList(); //order by name
                IsModified = false; // should be false
                OnRecipesChanged(EventArgs.Empty); //parameter evargempt if onrecipeschanged called
            }

            catch (FileFormatException)
            { //catch exceptions
                throw new FileFormatException();
            }
        }

        public void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(_path))
            {
                foreach (Recipe recipe in _recipes) //for each Recipe, write out info
                {
                    streamWriter.WriteLine(SectionRecipe);
                    streamWriter.WriteLine(recipe.Name);
                    streamWriter.WriteLine(SectionIngredients);

                    foreach (var ingredient in recipe.Ingredients) //format ingredients correctly
                    {
                        streamWriter.WriteLine("{0};{1};{2}", ingredient.Amount, ingredient.Measure, ingredient.Name);
                    }

                    streamWriter.WriteLine(SectionInstructions);
                    foreach (string instruction in recipe.Instructions)
                    {
                        streamWriter.WriteLine(instruction);
                    }

                }
                OnRecipesChanged(EventArgs.Empty); //EventArgs -- test passed
                IsModified = false; //modify false --test passed
            }
        }
    }
}

