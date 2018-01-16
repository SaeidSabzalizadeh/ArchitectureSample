using Architecture.SharedLibrary.DependencyInversion;
using Microsoft.Extensions.DependencyInjection;

namespace Architecture.Core.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StuffJob();
            //SharedLibrary.InterfaceSegregation.TestUseSettings.Test();

            System.Console.WriteLine();
            System.Console.ReadLine();
        }

        private static void StuffJob()
        {
            var serviceProvider = new ServiceCollection()
           .AddScoped<IHappiness, HappinessService>()
           .AddScoped<ISaddness, SaddnessService>()
           .BuildServiceProvider();

            var sadness = serviceProvider.GetService<ISaddness>();
            var happiness = serviceProvider.GetService<IHappiness>();

            var stuff = new Stuff(happiness, sadness);
            System.Console.WriteLine(stuff.DoStuffJob());
        }
    }
}
