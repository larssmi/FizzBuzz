using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Oppgave1_FizzBuzz.Configuration;
using Oppgave1_FizzBuzz.ConsoleViewer;
using Oppgave1_FizzBuzz.Generator;

namespace Oppgave1_FizzBuzz_Test
{
    public class FizzBuzzTests
    {

        private IGenerateFizzBuzzList _generateFizzBuzzList;
        private int RefValue { get; set; }
        [SetUp]
        public void Setup()
        {
            var servicesJazzFuzzProvider = new ServiceCollection();
            servicesJazzFuzzProvider.AddSingleton<IFizzBuzzConfig, FizzBuzzConfig>();
            servicesJazzFuzzProvider.AddSingleton<IViewResult, ViewResult>();
            servicesJazzFuzzProvider.AddSingleton<IGenerateFizzBuzzList, GenerateFizzBuzzList>();
            var setupProvider = servicesJazzFuzzProvider.BuildServiceProvider();

            _generateFizzBuzzList = setupProvider.GetService<IGenerateFizzBuzzList>();
        }

        [Test]
        public void TestOrdinærValue()
        {
            RefValue = 1;
            var result = _generateFizzBuzzList.GenerateValues(RefValue);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void TestFizz()
        {
            RefValue = 3;
            var result = _generateFizzBuzzList.GenerateValues(RefValue);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void TestBuzz()
        {
            RefValue = 10;
            var result = _generateFizzBuzzList.GenerateValues(RefValue);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void TestFizzBuzz()
        {
            RefValue = 15;
            var result = _generateFizzBuzzList.GenerateValues(RefValue);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}