using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Domain.Models
{
  public class Order
  {
    //public List<APizza> Pizzas { get; set; }
    public List<ATruePizza> Pizzas { get; set; }
    public decimal Price { get; set; }
    
  }
}
