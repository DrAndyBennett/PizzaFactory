using System.IO;
using PizzaFactory.Services.Configuration;

namespace PizzaFactory.Services.Helper
{
    class FileWriter : IWriter
    {
        private readonly StreamWriter _streamWriter;

        public FileWriter(IConfigurationService configurationService)
        {
            if (File.Exists(configurationService.FileName))
            {
                File.Delete(configurationService.FileName);
            }

            FileStream fileStream = new FileStream(configurationService.FileName, FileMode.Create);
            _streamWriter = new StreamWriter(fileStream);
        }

        public void Write(string data) => _streamWriter.WriteLine(data);

        public void Flush() => _streamWriter.Flush();
    }
}