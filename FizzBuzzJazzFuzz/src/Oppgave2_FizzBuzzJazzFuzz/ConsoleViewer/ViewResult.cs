using System.Linq;
using System;
using System.Collections.Generic;
using Oppgave2_FizzBuzzJazzFuzz.Configuration;
using Oppgave2_FizzBuzzJazzFuzz.Generator;

namespace Oppgave2_FizzBuzzJazzFuzz.ConsoleViewer
{
    public class ViewResult:IViewResult
    {
        private readonly IGenerateFizzBuzzJazzFuzzList _generateFizzBuzzList;
        private readonly IEnumerable<IConfig> _config;
        public ViewResult(IGenerateFizzBuzzJazzFuzzList generateFizzBuzzList, IEnumerable<IConfig> config)
        {
            _generateFizzBuzzList = generateFizzBuzzList;
            _config = config;
        }


        
        public void ViewResults()
        {
            //Hva er årsaken til at du ikke itererer på _config?
            
            //Jeg synes det er mer clean code som er ryddigere, letter å lese og alt er på en linje i stedet for flere kodelinjer 
            //Slipper også å loope gjennom radene i _config samt inkl. statements som if/else etc.
            //En grunn til å vurdere iterasjon er at det generelt går litt raskere, men i dette tilfelle så vil det være av liten betydning da det er små datamengder.  

            var configSeviceFizzBuzz = _config.FirstOrDefault(o => o.GetType() == typeof(FizzBuzzConfig));
            var rangeListValues = Enumerable.Range(1, 100).ToList();
            //Klarer du å skrive om dette så den er mindre utsatt for train wreck?
            //Sikkert flere muligheter her, en variant kan være denne:
            foreach (var item in rangeListValues)
            {
                var outPut = _generateFizzBuzzList.GenerateValues(item, configSeviceFizzBuzz);
                Console.WriteLine(outPut);
            }

            //rangeListValues.ForEach(x => Console.WriteLine(_generateFizzBuzzList.GetListValues(x, configSeviceFizzBuzz)));
            
            var configSeviceJazzFuzz = _config.FirstOrDefault(o => o.GetType() == typeof(JazzFuzzConfig));
            rangeListValues = Enumerable.Range(1, 100).Reverse().ToList();
            foreach (var item in rangeListValues)
            {
                var outPut = _generateFizzBuzzList.GenerateValues(item, configSeviceJazzFuzz);
                Console.WriteLine(outPut);
            }
            //rangeListValues.ForEach(x => Console.WriteLine(_generateFizzBuzzList.GetListValues(x, configSeviceJazzFuzz)));
           
        }
        
    }
}
