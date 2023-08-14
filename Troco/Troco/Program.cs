using System;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float celsius, fahrenheit;


            Console.WriteLine("digite a temperatura em celsius: ");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("a temperatura em fahrenheit é: " + fahrenheit);
































            Console.ReadKey();
        }
    }
}
