
using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Model;

namespace Oppgave2_FizzBuzzJazzFuzz.Configuration
{
    public interface IConfig
    {
        //Trenger du egentlig list, eller er det tilstrekkelig med IEnumerable?
        List<ConfigParamModel> GetKeyValue();
    }
}
