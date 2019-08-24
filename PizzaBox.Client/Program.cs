using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Client
{
  public class Program
  {

    static void Main(string[] args)
    {
      // var pizza = MakeChicagoPizza();

      // var Custom_Pizza = MakeCustomPizza();

      selectPizzaOptions();

    }

    static ATruePizza selectPizzaOptions()
    {
      System.Console.Write("Please select [A] to order a specialty pizza or [B] to select a custom pizza: ");
      var response = Console.ReadLine();
      if(response == "a")
        return MakeChicagoPizza();
      else 
        return MakeCustomPizza();
    }

    static ATruePizza MakeChicagoPizza()
    {
      string confirmation = "n";

      Chicago cPizza = new Chicago();
      var chicagoPizza = cPizza.Make();

      while (confirmation == "n")
      {
        chicagoPizza.Size = new Size("Medium");
        chicagoPizza.Crust = new Crust("Deep Dish");
        chicagoPizza.Toppings = new List<Topping>();
        chicagoPizza.Toppings.Add(new Topping("Marinara Sauce"));
        chicagoPizza.Toppings.Add(new Topping("Cheese"));

        for (int i = 3; i > 0; i--)
        {
          var additionalTopping = "";
          System.Console.Write($"Please enter {i} more topping{(i == 1 ? "" : "s")}: ");
          additionalTopping = Console.ReadLine();
          chicagoPizza.Toppings.Add(new Topping(additionalTopping));
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Is this order correct?\n");
        System.Console.WriteLine($"Size ===> {chicagoPizza.Size.Name}");
        System.Console.WriteLine($"Crust ===> {chicagoPizza.Crust.Name}");
        foreach (var a in chicagoPizza.Toppings)
        {
          System.Console.WriteLine($"Topping ===> {a.Name}");
        }
        System.Console.WriteLine();
        System.Console.Write("Select [Y]es for [N]o: ");
        confirmation = Console.ReadLine();
        System.Console.WriteLine();

      }

      return chicagoPizza;
    }

    static ATruePizza MakeCustomPizza()
    {
      string confirmation = "n";

      CustomPizza custPizza = new CustomPizza();
      var CustomPizza = custPizza;

      while (confirmation == "n")
      {
        System.Console.Write("Please select your size: ");
        var custPizzaSize = Console.ReadLine();
        CustomPizza.Size = new Size(custPizzaSize);
        System.Console.Write("Please select your crust: ");
        var custPizzaCrust = Console.ReadLine();
        CustomPizza.Crust = new Crust(custPizzaCrust);
        CustomPizza.Toppings = new List<Topping>();
        CustomPizza.Toppings.Add(new Topping("Marinara Sauce"));
        CustomPizza.Toppings.Add(new Topping("Cheese"));

        for (int i = 3; i > 0; i--)
        {
          var additionalTopping = "";
          System.Console.Write($"Please enter {i} more topping{(i == 1 ? "" : "s")}: ");
          additionalTopping = Console.ReadLine();
          CustomPizza.Toppings.Add(new Topping(additionalTopping));
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Is this order correct?\n");
        System.Console.WriteLine($"Size ===> {CustomPizza.Size.Name}");
        System.Console.WriteLine($"Crust ===> {CustomPizza.Crust.Name}");
        foreach (var a in CustomPizza.Toppings)
        {
          System.Console.WriteLine($"Topping ===> {a.Name}");
        }
        System.Console.WriteLine();
        System.Console.Write("Select [Y]es for [N]o: ");
        confirmation = Console.ReadLine();
        System.Console.WriteLine();
      }

      return CustomPizza;

    }
  }
}
