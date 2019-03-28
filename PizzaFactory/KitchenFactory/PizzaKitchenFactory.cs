using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Database;
using PizzaFactory.Services;
using PizzaFactory.Services.Configuration;
using PizzaFactory.Services.Helper;
using PizzaFactory.Services.PizzaOven;

namespace PizzaFactory.KitchenFactory
{
    class PizzaKitchenFactory : IKitchenFactory
    {
        private readonly IConfigurationService _configurationService;
        private readonly ITimer _timer;
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IPizzaOven _pizzaOven;
        private readonly IWriter _writer;

        public PizzaKitchenFactory(IConfigurationService configurationService,
            IWriter writer, 
            ITimer timer, 
            IPizzaRepository pizzaRepository, 
            IPizzaOven pizzaOven)
        {
            _writer = writer;
            _configurationService = configurationService;
            _timer = timer;
            _pizzaRepository = pizzaRepository;
            _pizzaOven = pizzaOven;
        }

        public Kitchen GetKitchen()
        {
            return new PizzaKitchen(
                _configurationService,
                _writer,
                _timer,
                _pizzaRepository, 
                _pizzaOven);
        }
    }
}
