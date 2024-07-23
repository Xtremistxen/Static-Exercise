namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This method will convert Fahrenheit to Celsius
            var fahrenheit = 101.2;
            var celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {celsius} Celsius.");
            
            //This method will convert Celsius Fahrenheit
            var celsiusInput = 75.4;
            var fahrenheitOutput = TempConverter.CelsiusToFahrenheit(celsiusInput);
            Console.WriteLine($"{celsiusInput} Celsius is equal to {fahrenheitOutput} Fahrenheit.");
        }
    }
}
