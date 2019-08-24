using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Location
  {
    public Address Address { get; set; }
    public Dictionary<string, int> Inventory { get; set; }
    public List<Order> Orders { get; set; }
  }
}
