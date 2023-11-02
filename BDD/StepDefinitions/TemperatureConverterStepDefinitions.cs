using System;
using TechTalk.SpecFlow;
using TestSP1;

namespace BDD.StepDefinitions
{
    [Binding]
    public class TemperatureConverterStepDefinitions
    {
        public Converter converter = new Converter();
        public double fahrenheitInput;
        public double celciusInput;
        public double celsiusRes;
        public double fahrenheitRes;


        [Given(@"the temperature is in fahrenheit")]
        public void GivenTheTemperatureIsInFahrenheit()
        {
            fahrenheitInput = 66.99;
        }

        [When(@"the fahrenheit conversion calculation is performed")]
        public void WhenTheFahrenheitConversionCalculationIsPerformed()
        {
            celsiusRes = converter.convertToCelcius(fahrenheitInput);
        }

        [Then(@"the result should be in celcius")]
        public void ThenTheResultShouldBeInCelcius()
        {
            var celcius = 19.44;
            celsiusRes.Should().Be(celcius);
        }


        [Given(@"the temperature is in ceclius")]
        public void GivenTheTemperatureIsInCeclius()
        {
            celciusInput = 19.44;
        }
    
        [When(@"the celcius conversion calculation is performed")]
        public void WhenTheCelciusConversionCalculationIsPerformed()
        {
            fahrenheitRes = converter.convertToFahrenheit(celciusInput);
        }

        [Then(@"the result should be in fahrenheit")]
        public void ThenTheResultShouldBeInFahrenheit()
        {
            var fahrenheit = 66.99;
            fahrenheitRes.Should().Be(fahrenheit);
        }
    }
}
