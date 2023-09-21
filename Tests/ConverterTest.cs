using TestSP1;

namespace Tests

{
    public class ConverterTest
    {
        private Converter converter = new Converter();
        private double fahrenHeit = 66.99;
        private double celcius = 19.44;
        private int arabicNum = 1200;


        [Fact]
        public void convertToCelciusTest()
        {
            Assert.Equal(celcius, converter.convertToCelcius(fahrenHeit));
        }

        [Fact]
        public void convertToFahrenheitTest()
        {
            Assert.Equal(fahrenHeit, converter.convertToFahrenheit(celcius));
        }
        [Fact]
        public void convertToRomanNumeralTest()
        {
            Assert.Equal("MCC", converter.convertToRomanNumeral(arabicNum));
        }
    }
}