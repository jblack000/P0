using System;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Domain.Models
{
  public class Menu
  {
    string choice = "";
    public void selectPizza()
    {
      System.Console.Write("Press 'A' to order a specialty pizza or press 'B' or order a custom pizza: ");
      choice = "";

      while (choice != "a" || choice != "b")
      {
        choice = Console.ReadLine();

        if (choice == "a")
        {
          OrderSpecialtyPizza();
        }
        else if (choice == "b")
        {
          OrderCustomPizza();
        }
        else
        {
          System.Console.Write("Please press 'A' to order a specialty pizza or press 'B' or order a custom pizza: ");
          choice = Console.ReadLine();
        }

      }
    }

    public Custom OrderCustomPizza()
    {
      Custom customPizza = new Custom();
      customPizza.Make();

      return customPizza;
    }

    private void OrderSpecialtyPizza()
    {
      throw new NotImplementedException();
    }
  }
}