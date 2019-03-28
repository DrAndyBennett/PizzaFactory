using PizzaFactory.Models.Pizza;
using PizzaFactory.Services.Configuration;
using PizzaFactory.Services.Helper;

namespace PizzaFactory.Services.PizzaOven
{
    class PizzaOven : IPizzaOven
    {
        private readonly IConfigurationService _configurationService;
        private readonly ILogger _logger;
        private readonly ITimer _timer;

        public PizzaOven(IConfigurationService configurationService, ILogger logger, ITimer timer)
        {
            _configurationService = configurationService;
            _logger = logger;
            _timer = timer;
        }

        public bool Cook(Pizza pizza)
        {
            if (pizza.Cooked)
            {
                // cannot cook pizza again
                _logger.Log($"Can't cook {pizza.GetDescription()} again");
                return false;
            }

            if (pizza.PizzaBase == null)
            {
                // cannot cook pizza
                _logger.Log($"Can't cook pizza there was no base");
                return false;
            }

            if (pizza.Topping == null)
            {
                // cannot cook pizza
                _logger.Log($"Can't cook {pizza.PizzaBase.Name} there was no topping");
                return false;
            }

            var duration = (int)(pizza.PizzaBase.Multiplier * _configurationService.BaseCookingTime) + 
                           (pizza.Topping.ToString().Length * 100);
            _logger.Log($"Cooking {pizza.GetDescription()} for {duration}ms");
            _timer.Delay(duration);
            _logger.Log($"Cooked {pizza.GetDescription()}");
            pizza.Cooked = true;
            return true;
        }
    }
}