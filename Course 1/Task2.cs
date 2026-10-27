namespace TemperatureToFahrenheit
{
    class Task2
    {
        static void Main()
        {
            // Ask for Fahrenheit
            Console.WriteLine("Enter temperature in Fahrenheit: ");
            float fahreinheitInput = float.Parse(Console.ReadLine());

            // Calculate
            double fahreinheitToCelcius = (5.0 / 9.0) * (fahreinheitInput - 32.0);

            // Output
            Console.WriteLine($"{fahreinheitInput} degrees Fahrenheit is equal to {fahreinheitToCelcius} degrees Celsius.");
        }
    }
}
