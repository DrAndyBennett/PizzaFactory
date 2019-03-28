using PizzaFactory.Models.Helper;

namespace PizzaFactory.Services.Helper
{
    public interface IRandomNumberService
    {
        int GetRandomNumber(Range range);
    }
}
