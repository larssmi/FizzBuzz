using System;
using Microsoft.Extensions.DependencyInjection;
using Oppgave2_FizzBuzzJazzFuzz.ConsoleViewer;
using Oppgave2_FizzBuzzJazzFuzz.ServiceCollections;

namespace Oppgave2_FizzBuzzJazzFuzz
{
    class Program
    {
        static void Main()
        {
            var servicesProvider = SetupServiceProviders.SetupProvider();
            var viewResult = servicesProvider.GetService<IViewResult>();
            viewResult.ViewResults();

            Console.ReadLine();
        }
    }
}
