using System.IO;

namespace PizzaFactory.Services.Configuration
{
    public class DirectoryService : IDirectoryService
    {
        public string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}