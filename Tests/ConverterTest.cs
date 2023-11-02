namespace Tests

{
    public class ConverterTest
    {
        [Fact]
        public void convertToCelciusTest()
        {
            // Arrange
            var converter = new Converter();
            var fahrenheit = 66.99;

            // Act
            var actual = converter.convertToCelcius(fahrenheit);

            // Assert
            Assert.Equal(19.44, actual);
        }

        [Fact]
        public void convertToFahrenheitTest()
        {
            // Arrange
            var converter = new Converter();
            var celcius = 19.44;

            // Act
            var actual = converter.convertToFahrenheit(celcius);

            // Assert
            Assert.Equal(66.99, actual);
        }
        [Fact]
        public void convertToRomanNumeralTest()
        {
            // Arrange
            var converter = new Converter();

            // Act 
            var actual = converter.convertToRomanNumeral(1200);

            // Assert
            Assert.Equal("MCC", actual);
        }
    }
}