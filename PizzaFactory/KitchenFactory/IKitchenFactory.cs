using PizzaFactory.Services;

namespace PizzaFactory.KitchenFactory
{
    public interface IKitchenFactory
    {
        Kitchen GetKitchen();
    }
}