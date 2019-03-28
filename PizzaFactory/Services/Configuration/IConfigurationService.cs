namespace PizzaFactory.Services.Configuration
{
    public interface IConfigurationService
    {
        int NumberOfPizzas { get; set; }
        int Interval { get; set; }
        string FileName { get; set; }
        int BaseCookingTime { get; set; }
    }
}