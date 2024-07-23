namespace StaticExercise;

public static class TempConverter
{
    // This method will convert Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit)
    {   //Had to google the equation not good at math
        return (fahrenheit - 32) * 5 / 9;
    }
    
    // This method will convert Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {   //This is just a reversal of the above equation
        return (celsius * 9 / 5) + 32;
    }
}