using System;

 class Application
{
	public void Run()
	{
        List<string> recipes = Load();
        ViewDetails(recipes);
	}
     private List <string> Load ()
    {
         using (streamReader reader = new StreamReader("..//Recipes.txt"))
         {
             string line;
             while ((line = reader.ReadLine()) !=null)
             {
                 string[] recipes = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
             }
         }

    }
}
