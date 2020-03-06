using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Model;

namespace Oppgave2_FizzBuzzJazzFuzz.Configuration
{
   public  class JazzFuzzConfig: IConfig
    {
        public List<ConfigParamModel> GetKeyValue()
        {
            return new List<ConfigParamModel>
            {
                new ConfigParamModel {Key = 9, ReplaceText = "Jazz" },
                new ConfigParamModel {Key = 4, ReplaceText = "Fuzz" }
            };
        }
    }
}
