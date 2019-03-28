namespace PizzaFactory.Models.Pizza
{
    public class Base
    {
        public Base(string name, double multiplier)
        {
            Name = name;
            Multiplier = multiplier;
        }

        public string Name { get; }
        public double Multiplier { get; }
    }
}
