using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os numeros a serem formados");

            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O resultado da soma é {Soma(numero1, numero1)}");

            Console.WriteLine("Aperte Enter para finalizar");

            Console.ReadLine();

        }

        public static int Soma(int numero1, int numero2)
        {

            return numero1 + numero2;

        }

    }



}
