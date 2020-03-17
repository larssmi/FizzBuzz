using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Model;

namespace Oppgave2_FizzBuzzJazzFuzz.Configuration
{
    public class FizzBuzzConfig: IConfig
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
