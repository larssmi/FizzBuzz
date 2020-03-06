using Oppgave1_FizzBuzz.Configuration;

namespace Oppgave1_FizzBuzz.Generator
{
    public class GenerateFizzBuzzList: IGenerateFizzBuzzList
    {
        private readonly IFizzBuzzConfig _fizzBuzzConfig;
        public GenerateFizzBuzzList(IFizzBuzzConfig fizzBuzzConfig)
        {
            _fizzBuzzConfig = fizzBuzzConfig;
        }
      
        public string GetListValues(int num)
        {
         
            string retVal = null;
            foreach (var item in _fizzBuzzConfig.GetKeyValue())
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
