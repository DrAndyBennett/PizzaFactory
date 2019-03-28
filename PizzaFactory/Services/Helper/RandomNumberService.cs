using System;
using PizzaFactory.Models.Helper;

namespace PizzaFactory.Services.Helper
{
    public class RandomNumberService : IRandomNumberService
    {
        private Random _rnd;

        public RandomNumberService(bool seeded = false)
        {
            _rnd = seeded ? new Random(seed) : new Random();
        }

        private const int seed = 10;
        
        public int GetRandomNumber(Range range)
        {
            return _rnd.Next(range.Low, range.High);
        }

    }
}