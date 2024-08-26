using System;
namespace ChuyenDoiNhietDo
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;
            do
            {


                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Fahrenheit to Celsius.");
                Console.WriteLine("2. Celsius to Fahrenheit.");
                Console.WriteLine("0. Exit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your Fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("-->" + FahrenheitToCelsius(fahrenheit));
                        break;
                    case 2:
                        Console.WriteLine("Enter your Celsius");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("-->" + CelsiusToFahrenheit(celsius));
                        break;
                }

            } while (choice != 0);



        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }


    }
}

