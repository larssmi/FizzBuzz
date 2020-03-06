using Microsoft.Extensions.DependencyInjection;
using Oppgave1_FizzBuzz.Configuration;
using Oppgave1_FizzBuzz.ConsoleViewer;
using Oppgave1_FizzBuzz.Generator;

namespace Oppgave1_FizzBuzz.ServiceCollections
{
    public static class SetupServiceProviders
    {
        public static ServiceProvider SetupProvider()
        {
            var servicesJazzFuzzProvider = new ServiceCollection();
            servicesJazzFuzzProvider.AddSingleton<IFizzBuzzConfig, FizzBuzzConfig>();
            servicesJazzFuzzProvider.AddSingleton<IViewResult, ViewResult>();
            servicesJazzFuzzProvider.AddSingleton<IGenerateFizzBuzzList, GenerateFizzBuzzList>();
            return servicesJazzFuzzProvider.BuildServiceProvider();
        }
    }
}
