using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Model;

namespace Oppgave2_FizzBuzzJazzFuzz.Configuration
{
    public class FizzBuzzConfig: IConfig
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
