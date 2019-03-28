using PizzaFactory.Database;
using PizzaFactory.Models.Pizza;
using PizzaFactory.Services.Configuration;
using PizzaFactory.Services.Helper;
using PizzaFactory.Services.PizzaOven;

namespace PizzaFactory.KitchenFactory
{
    public class PizzaKitchen : Kitchen
    {
        private readonly IConfigurationService _configurationService;
        private readonly IWriter _writer;
        private readonly ITimer _timer;
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IPizzaOven _pizzaOven;

        public PizzaKitchen(
            IConfigurationService configurationService, 
            IWriter writer,
            ITimer timer,
            IPizzaRepository pizzaRepository, 
            IPizzaOven pizzaOven)
        {
            _configurationService = configurationService;
            _writer = writer;
            _timer = timer;
            _pizzaRepository = pizzaRepository;
            _pizzaOven = pizzaOven;
        }

        public override void PrepareMeals()
        {
            for (var i = 1; i <= _configurationService.NumberOfPizzas; i++)
            {
                var pizza = new Pizza(
                    _pizzaRepository.GetBase(), 
                    _pizzaRepository.GetTopping());

                _pizzaOven.Cook(pizza);

                if (!pizza.Cooked)
                {
                    // not cooked so try again
                    i--;
                }
                else
                {
                    _writer.Write($"{i} {pizza.GetDescription()}");
                }
                _timer.Delay(_configurationService.Interval);
            }
            _writer.Flush();
        }
    }
}
