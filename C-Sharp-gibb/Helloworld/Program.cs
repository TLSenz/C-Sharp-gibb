using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie Heiss ist es in Celsius: ");
            int TemperaturCelsius = Convert.ToInt32(Console.ReadLine());
            int TemperaturFahrenheit = ((TemperaturCelsius * 9) / 5) + 32;
            Console.WriteLine(TemperaturFahrenheit);

        }
    }
}
