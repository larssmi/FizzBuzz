namespace Oppgave2_FizzBuzzJazzFuzz.Model
{
    //Hvilken fordel har denne fremfor KeyValue?
    //Det er sikkert fornuftig å benytte et annet navn som feks KeyValue som du nevner da det sier noe om at dette feltet har en numerisk verdi
    //Mulig feltet burde het Number
    public class ConfigParamModel
    {
        public int KeyValue { get; set; }
        public string ReplaceText { get; set; }
    }
}
