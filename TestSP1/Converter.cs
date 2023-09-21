namespace TestSP1
{
    public class Converter
    {
        public Converter()
        {

        }

        public double convertToCelcius(double fahrenHeit)
        {
            return Math.Round((fahrenHeit - 32) * 5 / 9, 2);
        }

        public double convertToFahrenheit(double celcius)
        {
            return Math.Round((celcius * 9 / 5) + 32, 2);
        }

        public string convertToRomanNumeral(int number)
        {
            string romanRes = string.Empty;
            string[] romanLetters = {
                "M",
                "CM",
                "D",
                "CD",
                "C",
                "XC",
                "L",
                "XL",
                "X",
                "IX",
                "V",
                "IV",
                "I"
            };
            int[] arabicNumbers = {
                1000,
                900,
                500,
                400,
                100,
                90,
                50,
                40,
                10,
                9,
                5,
                4,
                1
            };
            int i = 0;
            while(number!=0)
            {
                if (number >= arabicNumbers[i])
                {
                    number-=arabicNumbers[i];
                    romanRes += romanLetters[i];
                } else
                {
                    i++;
                }
            }
            return romanRes;
        }
    }
}