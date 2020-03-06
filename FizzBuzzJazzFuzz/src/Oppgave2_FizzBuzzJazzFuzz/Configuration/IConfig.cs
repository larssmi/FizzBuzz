
using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Model;

namespace Oppgave2_FizzBuzzJazzFuzz.Configuration
{
    public interface IConfig
    {
        List<ConfigParamModel> GetKeyValue();
    }
}
