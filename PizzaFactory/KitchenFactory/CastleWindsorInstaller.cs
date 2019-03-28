using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using PizzaFactory.Database;
using PizzaFactory.Services.Configuration;
using PizzaFactory.Services.Helper;
using PizzaFactory.Services.PizzaOven;
using ConsoleLogger = Castle.Core.Logging.ConsoleLogger;
using ILogger = Castle.Core.Logging.ILogger;

namespace PizzaFactory.KitchenFactory
{
    public class CastleWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ITimer>().ImplementedBy<Timer>(),
                Component.For<IConfigurationService>().ImplementedBy<ConfigurationService>(),
                Component.For<IWriter>().ImplementedBy<FileWriter>(),
                Component.For<Services.Helper.ILogger>().ImplementedBy<Services.Helper.ConsoleLogger>(),
                Component.For<IKitchenFactory>().ImplementedBy<PizzaKitchenFactory>(),
                Component.For<IPizzaRepository>().ImplementedBy<PizzaRepository>(),
                Component.For<IPizzaOven>().ImplementedBy<PizzaOven>(),
                Component.For<IDirectoryService>().ImplementedBy<DirectoryService>(),
                Component.For<IRandomNumberService>().ImplementedBy<RandomNumberService>());
        }
    }
}