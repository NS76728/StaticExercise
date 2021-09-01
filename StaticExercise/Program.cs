using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temperature do you want to convert?");
            string input = Console.ReadLine();

            if (input== "fahrenheit")
            {
                Console.WriteLine("What is the fahrenheit temperature you want to convert?");
                double use = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(TempConverter.FahrenheitToCelsius(use));
            }
            else if (input == "celsius")
            {
                Console.WriteLine("What is the celsius temperature you want to convert?");
                double use = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(TempConverter.CelsiusToFahrenheit(use));
            }
        }
    }
}
