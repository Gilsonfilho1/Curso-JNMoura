using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, soma;

            Console.WriteLine("Digite o primeiro numero:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            Console.WriteLine($"A soma dos numeros é: {soma}");
            Console.ReadKey();

        }
    }
}
