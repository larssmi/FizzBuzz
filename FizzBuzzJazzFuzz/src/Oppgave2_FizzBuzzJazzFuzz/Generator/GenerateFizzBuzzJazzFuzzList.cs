
using Oppgave2_FizzBuzzJazzFuzz.Configuration;

namespace Oppgave2_FizzBuzzJazzFuzz.Generator
{
    public class GenerateFizzBuzzJazzFuzzList: IGenerateFizzBuzzJazzFuzzList
    {
        //Hva er formålet med denne?
        private IConfig FizzBuzzConfig { get; set; }

        
        //Jeg sliter litt med navngivingen her. Dette er vel ikke en typisk Getter som bare henter noe?
        //ListValues gir heller ikke mye gevinst. Klarer du å finne et bedre navn?
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
