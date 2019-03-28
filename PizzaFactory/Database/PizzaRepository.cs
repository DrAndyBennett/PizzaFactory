using PizzaFactory.Models.Helper;
using PizzaFactory.Services.Helper;

namespace PizzaFactory.Database
{
    class PizzaRepository : IPizzaRepository
    {
        private readonly IRandomNumberService _randomNumberService;

        public PizzaRepository(IRandomNumberService randomNumberService)
        {
            _randomNumberService = randomNumberService;
        }

        private readonly Models.Pizza.Base[] _bases = {
            new Models.Pizza.Base("Deep Pan", 2),
            new Models.Pizza.Base("Stuffed Crust", 1.5),
            new Models.Pizza.Base("Thin and Crispy", 1),
        };

        private readonly Models.Pizza.Topping[] _toppings = {
            new Models.Pizza.Topping("Ham And Pineapple"),
            new Models.Pizza.Topping("Pepperoni"),
            new Models.Pizza.Topping("Vegetable"),
        };

        public Models.Pizza.Base GetBase()
        {
            return _bases[_randomNumberService.GetRandomNumber(new Range(0, _bases.Length))];
        }

        public Models.Pizza.Topping GetTopping()
        {
            return _toppings[_randomNumberService.GetRandomNumber(new Range(0, _toppings.Length))];
        }
    }
}