namespace PizzaFactory.Models.Pizza
{
    public class Topping
    {
        public Topping(string value)
        {
            Name = value;
            CookingTime = value.Length;
        }

        public string Name { get; }
        public int CookingTime { get; }
    }
}
