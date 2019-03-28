using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models.Pizza
{
    public class Pizza
    {
        public Base PizzaBase { get; }
        public Topping Topping { get; }

        public Pizza(Base pizzaBase, Topping topping)
        {
            PizzaBase = pizzaBase;
            Topping = topping;
        }

        public bool Cooked { get; set; }
        public string GetDescription() => $"{PizzaBase.Name} {Topping.Name}";
    }
}
