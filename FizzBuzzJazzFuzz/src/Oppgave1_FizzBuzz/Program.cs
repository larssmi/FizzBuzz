using System;
using Oppgave1_FizzBuzz.ConsoleViewer;
using Oppgave1_FizzBuzz.ServiceCollections;
using Microsoft.Extensions.DependencyInjection;

namespace Oppgave1_FizzBuzz
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
