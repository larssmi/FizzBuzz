using System.Linq;
using System;
using Oppgave1_FizzBuzz.Generator;


namespace Oppgave1_FizzBuzz.ConsoleViewer
{
    public class ViewResult:IViewResult
    {
        private readonly IGenerateFizzBuzzList _generateList;
       
        public ViewResult(IGenerateFizzBuzzList generateList)
        {
            _generateList = generateList;
        }
        public void ViewResults()
        {
             var rangeListValues = Enumerable.Range(1, 100).ToList();
            rangeListValues.ForEach(x => Console.WriteLine(_generateList.GetListValues(x)));

        }
    }
}
