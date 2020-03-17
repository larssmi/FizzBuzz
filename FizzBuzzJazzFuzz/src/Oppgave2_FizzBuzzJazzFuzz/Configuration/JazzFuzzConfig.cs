using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Model;

namespace Oppgave2_FizzBuzzJazzFuzz.Configuration
{
   public  class JazzFuzzConfig: IConfig
    {
        public IEnumerable<ConfigParamModel> GetKeyValue()
        {
            return new List<ConfigParamModel>
            {
                new ConfigParamModel {KeyValue = 9, ReplaceText = "Jazz" },
                new ConfigParamModel {KeyValue = 4, ReplaceText = "Fuzz" }
            };
        }
    }
}
