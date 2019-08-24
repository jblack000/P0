using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class Chicago : APizzaMaker
  {
    public override ATruePizza Make()
    {
      // ATruePizza Chicago_Pizza = new CustomPizza();
      // Chicago_Pizza.Crust = new Crust("Deep Dish");
      // Chicago_Pizza.Size = new Size("Medium");
      // Chicago_Pizza.Toppings = new List<Topping>();
      // Chicago_Pizza.Toppings.Add(new Topping("Marinara Sauce"));
      // Chicago_Pizza.Toppings.Add(new Topping("Cheese"));
      // Chicago_Pizza.Toppings.Add(new Topping("Pepperoni"));
      // Chicago_Pizza.Toppings.Add(new Topping("Sausage"));
      // return Chicago_Pizza;

      return new CustomPizza();
    }
  }
}
