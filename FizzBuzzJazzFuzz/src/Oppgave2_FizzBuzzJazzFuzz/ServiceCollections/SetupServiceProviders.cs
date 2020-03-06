using Microsoft.Extensions.DependencyInjection;
using Oppgave2_FizzBuzzJazzFuzz.Configuration;
using Oppgave2_FizzBuzzJazzFuzz.ConsoleViewer;
using Oppgave2_FizzBuzzJazzFuzz.Generator;

namespace Oppgave2_FizzBuzzJazzFuzz.ServiceCollections
{
    public static class SetupServiceProviders
    {
        public static ServiceProvider SetupProvider()
        {
            var servicesJazzFuzzProvider = new ServiceCollection();
            servicesJazzFuzzProvider.AddSingleton<IConfig, FizzBuzzConfig>();
            servicesJazzFuzzProvider.AddSingleton<IConfig, JazzFuzzConfig>();
            servicesJazzFuzzProvider.AddSingleton<IViewResult, ViewResult>();
            servicesJazzFuzzProvider.AddSingleton<IGenerateFizzBuzzJazzFuzzList, GenerateFizzBuzzJazzFuzzList>();
            return servicesJazzFuzzProvider.BuildServiceProvider();
        }
    }
}
