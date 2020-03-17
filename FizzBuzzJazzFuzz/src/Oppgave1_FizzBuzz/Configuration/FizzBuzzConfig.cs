using System.Collections.Generic;
using Oppgave1_FizzBuzz.Model;

namespace Oppgave1_FizzBuzz.Configuration
{
    public class FizzBuzzConfig: IFizzBuzzConfig
    {
        public IEnumerable<ConfigParamModel> GetKeyValue()
        {
            return new List<ConfigParamModel>
            {    new ConfigParamModel { KeyValue = 3, ReplaceText = "Fizz" },
                new ConfigParamModel { KeyValue = 5, ReplaceText = "Buzz" }
            };
        }
    }
}
