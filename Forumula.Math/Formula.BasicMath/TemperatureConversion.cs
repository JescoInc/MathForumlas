namespace Formula.BasicMath
{
    public static class TemperatureConversion
    {
        public static float ConvertCelciusToFahrenheit(int fahrenheight)
        {
            int celcius = (fahrenheight - 32) * 5 / 9;
            return celcius;
        }

        public static float ConvertFahrenheitToCelcius(int celcius)
        {
            int fahrenheight = celcius * 9 / 5 + 32;
            return fahrenheight;
        }

        public static double ConvertCelciusToKelvin(double celcius)
        {
            double kelvin = celcius + 273.15;

            return kelvin;
        }
    }
}
