
using Oppgave2_FizzBuzzJazzFuzz.Configuration;

namespace Oppgave2_FizzBuzzJazzFuzz.Generator
{
    public class GenerateFizzBuzzJazzFuzzList: IGenerateFizzBuzzJazzFuzzList
    {
        private IConfig FizzBuzzConfig { get; set; }

        public string GetListValues(int num, IConfig fizzBuzzConfig)
        {
            FizzBuzzConfig = fizzBuzzConfig;
            string retVal = null;
            foreach (var item in FizzBuzzConfig.GetKeyValue())
            {
                if (num % item.Key == 0)
                {
                    retVal += item.ReplaceText;
                }
            }
            return retVal ?? num.ToString();

        }
    }
}
