using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class Custom : APizzaMaker
  {
    public override ATruePizza Make()
    {

      ATruePizza custPizza1 = new CustomPizza();
      System.Console.Write("Select a size: ");
      var custSize = Console.ReadLine();
      var cust_Size = custPizza1.Size = new Size(custSize);
      System.Console.Write("Select a crust: ");
      var custCrust = Console.ReadLine();
      var cust_Crust = custPizza1.Crust = new Crust(custCrust);
      custPizza1.Toppings = new List<Topping>();
      custPizza1.Toppings.Add(new Topping("Tomato Sauce"));
      custPizza1.Toppings.Add(new Topping("Cheese"));
      System.Console.WriteLine("Select up to three additional toppings: ");
      var custTopping = Console.ReadLine();
      custPizza1.Toppings.Add(new Topping(custTopping));
      System.Console.WriteLine("Select up to three additional toppings: ");
      custTopping = Console.ReadLine();
      custPizza1.Toppings.Add(new Topping(custTopping));
      System.Console.WriteLine("Select up to three additional toppings: ");
      custTopping = Console.ReadLine();
      custPizza1.Toppings.Add(new Topping(custTopping));

      return custPizza1;

    }
  }
}