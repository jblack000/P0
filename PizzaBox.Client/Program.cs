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
      var pizza = MakeChicagoPizza();

      System.Console.WriteLine(pizza.Toppings);
    }

    static ATruePizza MakeChicagoPizza()
    {
      Chicago cPizza = new Chicago();
      var chicagoPizza = cPizza.Make();
      chicagoPizza.Size = new Size("Medium");
      chicagoPizza.Crust = new Crust("Deep Dish");
      chicagoPizza.Toppings = new List<Topping>();
      chicagoPizza.Toppings.Add(new Topping("Marinara Sauce"));
      chicagoPizza.Toppings.Add(new Topping("Cheese"));

      for (int i = 3; i > 0; i--)
      {
        var additionalTopping = "";
        System.Console.Write($"Please enter {i} more toppings: ");
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

      return chicagoPizza;
    }
  }
}
