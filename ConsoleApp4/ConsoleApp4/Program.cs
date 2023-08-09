using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float soma;
            float subtracao;
            float multiplicacao;
            float divisao;
            float resto;

            //Console.Write("Hello Word");

           
            
            
            Console.Write("digite o 1º numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("digite o 2º numero: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b; //estamos somando os valores das variaveis a e b

            Console.WriteLine("A soma dos valores: " + soma);

            subtracao = a - b; //estamos subtraindo os valores das variaveis a e b

            Console.WriteLine("A subtração dos valores: " + subtracao);

            multiplicacao = a * b;

            Console.WriteLine("A multiplicação das variaveis: " + multiplicacao);

            divisao = a / b;

            Console.WriteLine("A divisão dos valores: " + divisao);

            Console.ReadLine(); 
            
            Console.ReadKey();

            














        }
    }
}
