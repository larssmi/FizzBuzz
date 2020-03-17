using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Oppgave2_FizzBuzzJazzFuzz.Configuration;
using Oppgave2_FizzBuzzJazzFuzz.ConsoleViewer;
using Oppgave2_FizzBuzzJazzFuzz.Generator;

namespace Oppgave2_FizzBuzzJazzFuzz_Test
{
    public class BizzFuzzTests
    {
        private IGenerateFizzBuzzJazzFuzzList _generateFizzBuzzList;
        private IConfig _configFizzBuzz;
       
        private int RefValue { get; set; }

        [SetUp]
        public void Setup()
        {
            var servicesJazzFuzzProvider = new ServiceCollection();
            servicesJazzFuzzProvider.AddSingleton<IConfig, FizzBuzzConfig>();
            servicesJazzFuzzProvider.AddSingleton<IViewResult, ViewResult>();
            servicesJazzFuzzProvider.AddSingleton<IGenerateFizzBuzzJazzFuzzList, GenerateFizzBuzzJazzFuzzList>();
            var setupProvider = servicesJazzFuzzProvider.BuildServiceProvider();

            var config = setupProvider.GetServices<IConfig>();
            var enumerable = config as IConfig[] ?? config.ToArray();
            _configFizzBuzz = enumerable.FirstOrDefault(o => o.GetType() == typeof(FizzBuzzConfig));
            _generateFizzBuzzList = setupProvider.GetService<IGenerateFizzBuzzJazzFuzzList>();
        }

        [Test]
        public void TestOrdinaryValue()
        {
            RefValue = 1;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configFizzBuzz);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void TestFizz()
        {
            RefValue = 3;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configFizzBuzz);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void TestBuzz()
        {
            RefValue = 10;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configFizzBuzz);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void TestFizzBuzz()
        {
            RefValue = 15;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configFizzBuzz);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
