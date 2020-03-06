using System.Collections.Generic;
using Oppgave1_FizzBuzz.Model;

namespace Oppgave1_FizzBuzz.Configuration
{
    public class FizzBuzzConfig: IFizzBuzzConfig
    {
        public List<ConfigParamModel> GetKeyValue()
        {
            return new List<ConfigParamModel>
            {    new ConfigParamModel { Key = 3, ReplaceText = "Fizz" },
                new ConfigParamModel { Key = 5, ReplaceText = "Buzz" }
            };
        }
    }
}
