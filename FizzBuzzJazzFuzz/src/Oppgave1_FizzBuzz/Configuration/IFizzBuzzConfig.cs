using Oppgave1_FizzBuzz.Model;
using System.Collections.Generic;

namespace Oppgave1_FizzBuzz.Configuration
{
    public interface IFizzBuzzConfig
    {
        List<ConfigParamModel> GetKeyValue();
    }
}
