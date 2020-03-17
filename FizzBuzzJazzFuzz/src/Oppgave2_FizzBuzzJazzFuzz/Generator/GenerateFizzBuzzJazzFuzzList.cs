
using Oppgave2_FizzBuzzJazzFuzz.Configuration;

namespace Oppgave2_FizzBuzzJazzFuzz.Generator
{
    public class GenerateFizzBuzzJazzFuzzList: IGenerateFizzBuzzJazzFuzzList
    {
        //Hva er formålet med denne?
        //Denne kan i dette tilfelle fjernes og benytte input parameteren slik jeg har endret til

        //private IConfig FizzBuzzConfig { get; set; }

        
        //Jeg sliter litt med navngivingen her. Dette er vel ikke en typisk Getter som bare henter noe?
        //ListValues gir heller ikke mye gevinst. Klarer du å finne et bedre navn?
        // Navngiving er ikke alltid like lett, men forsøker å endre til denne
        public string GenerateValues(int num, IConfig fizzBuzzConfig)
        {
           
            string retVal = null;
            foreach (var item in fizzBuzzConfig.GetKeyValue())
            {
                if (num % item.KeyValue == 0)
                {
                    retVal += item.ReplaceText;
                }
            }
            return retVal ?? num.ToString();

        }
    }
}
