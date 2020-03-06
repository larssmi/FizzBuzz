﻿using System.Linq;
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
            var configSeviceFizzBuzz = _config.FirstOrDefault(o => o.GetType() == typeof(FizzBuzzConfig));
            var rangeListValues = Enumerable.Range(1, 100).ToList();
            rangeListValues.ForEach(x => Console.WriteLine(_generateFizzBuzzList.GetListValues(x, configSeviceFizzBuzz)));

            var configSeviceJazzFuzz = _config.FirstOrDefault(o => o.GetType() == typeof(JazzFuzzConfig));
            rangeListValues = Enumerable.Range(1, 100).Reverse().ToList();
            rangeListValues.ForEach(x => Console.WriteLine(_generateFizzBuzzList.GetListValues(x, configSeviceJazzFuzz)));
           
        }
        
    }
}
