Feature: Temperature Converter

@mytag
Scenario: Convert fahrenheit to celcius
	Given the temperature is in fahrenheit
	When the fahrenheit conversion calculation is performed
	Then the result should be in celcius

@mytag
Scenario: Convert ceclius to fahrenheit
	Given the temperature is in ceclius
	When the celcius conversion calculation is performed
	Then the result should be in fahrenheit