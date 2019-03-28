using System.Configuration;

namespace PizzaFactory.Services.Configuration
{
    public class ConfigurationService : IConfigurationService
    {
        public int NumberOfPizzas { get; set; }
        public int Interval { get; set; }
        public string FileName { get; set; }
        public int BaseCookingTime { get; set; }

        public ConfigurationService(IDirectoryService directoryService)
        {
            BaseCookingTime = GetValidConfigurationItem("BaseCookingTime") ?? 3000;
            NumberOfPizzas = GetValidConfigurationItem("NumberOfPizzas") ?? 50;
            Interval = GetValidConfigurationItem("Interval") ?? 500;

            FileName = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["ResultFileName"]) ? 
                ConfigurationManager.AppSettings["ResultFileName"] : 
                $"{directoryService.GetCurrentDirectory()}\\PizzaLog.txt";
        }

        private int? GetValidConfigurationItem(string name)
        {
            if (int.TryParse(ConfigurationManager.AppSettings[name], out var intValue))
            {
                return intValue;
            }

            return null;
        }
    }
}
