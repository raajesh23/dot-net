using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit = 97;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
            Console.ReadLine();
        }
    }
}
