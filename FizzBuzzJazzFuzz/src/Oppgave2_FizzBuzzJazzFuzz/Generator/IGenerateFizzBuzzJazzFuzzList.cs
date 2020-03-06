using Oppgave2_FizzBuzzJazzFuzz.Configuration;

namespace Oppgave2_FizzBuzzJazzFuzz.Generator
{
    public interface IGenerateFizzBuzzJazzFuzzList
    {
        string GetListValues(int num, IConfig fizzBuzzConfig);
    }
}
