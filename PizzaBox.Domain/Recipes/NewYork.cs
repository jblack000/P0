using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class NewYork : APizzaMaker
  {
    public override ATruePizza Make()
    {
      ATruePizza NewYork_Pizza = new CustomPizza();
      NewYork_Pizza.Crust = new Crust("Hand Tossed Thin Crust");
      NewYork_Pizza.Size = new Size("Large");
      NewYork_Pizza.Toppings = new List<Topping>();
      NewYork_Pizza.Toppings.Add(new Topping("Tomato Sauce"));
      NewYork_Pizza.Toppings.Add(new Topping("Cheese"));
      // NewYork_Pizza.Toppings.Add(new Topping("Pepperoni"));
      // NewYork_Pizza.Toppings.Add(new Topping("Sausage"));
      return NewYork_Pizza;

      //Components.Add(new Crust("NewYork"));
    }
  }
}
