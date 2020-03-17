
using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Model;

namespace Oppgave2_FizzBuzzJazzFuzz.Configuration
{
    public interface IConfig
    {
        //Trenger du egentlig list, eller er det tilstrekkelig med IEnumerable?
        //Ja, i dette tilfelle så vil det nok holde fint med IEnumerable da det bare er behov for 
        //utlisting og ikke endring, sortering eller andre ting som vil påvirke innholdet. 
        IEnumerable<ConfigParamModel> GetKeyValue();
    }
}
