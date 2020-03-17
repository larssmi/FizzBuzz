using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Oppgave2_FizzBuzzJazzFuzz.Configuration;
using Oppgave2_FizzBuzzJazzFuzz.ConsoleViewer;
using Oppgave2_FizzBuzzJazzFuzz.Generator;

namespace Oppgave2_FizzBuzzJazzFuzz_Test
{
    public class JazzFuzzTests
    {
        private IGenerateFizzBuzzJazzFuzzList _generateFizzBuzzList;
        private IConfig _configJazzFuzz;

        private int RefValue { get; set; }

        [SetUp]
        public void Setup()
        {
            var servicesJazzFuzzProvider = new ServiceCollection();
            servicesJazzFuzzProvider.AddSingleton<IConfig, JazzFuzzConfig>();
            servicesJazzFuzzProvider.AddSingleton<IViewResult, ViewResult>();
            servicesJazzFuzzProvider.AddSingleton<IGenerateFizzBuzzJazzFuzzList, GenerateFizzBuzzJazzFuzzList>();
            var setupProvider = servicesJazzFuzzProvider.BuildServiceProvider();

            var config = setupProvider.GetServices<IConfig>();
            var enumerable = config as IConfig[] ?? config.ToArray();
            _configJazzFuzz = enumerable.FirstOrDefault(o => o.GetType() == typeof(JazzFuzzConfig));
            _generateFizzBuzzList = setupProvider.GetService<IGenerateFizzBuzzJazzFuzzList>();
        }

        [Test]
        //Hva er gevinsten med å slå over til delvis norsk her?
        //Dette er en liten trykkfeil og skal være TestOrdinaryValue    
        public void TestOrdinaryValue()
        {
            RefValue = 10;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configJazzFuzz);
            Assert.AreEqual("10", result);
        }

        [Test]
        public void TestJazz()
        {
            RefValue = 18;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configJazzFuzz);
            Assert.AreEqual("Jazz", result);
        }

        [Test]
        public void TestFuzz()
        {
            RefValue = 20;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configJazzFuzz);
            Assert.AreEqual("Fuzz", result);
        }

        [Test]
        public void TestJazzFuzz()
        {
            RefValue = 72;
            var result = _generateFizzBuzzList.GenerateValues(RefValue, _configJazzFuzz);
            Assert.AreEqual("JazzFuzz", result);
        }
    }
}
