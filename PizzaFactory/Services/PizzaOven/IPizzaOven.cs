using PizzaFactory.Models.Pizza;

namespace PizzaFactory.Services.PizzaOven
{
    public interface IPizzaOven
    {
        bool Cook(Pizza pizza);
    }
}
