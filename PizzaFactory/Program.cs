using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using PizzaFactory.KitchenFactory;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            //container.Register(Component.For<IKitchenFactory>().ImplementedBy<PizzaKitchenFactory>());
            container.Install(FromAssembly.This());
            var factory = container.Resolve<IKitchenFactory>();
            var kitchen = factory.GetKitchen();
            kitchen.PrepareMeals();

        }
    }
}
