using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Digite o valor do 1º apostador: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do 2º apostador: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do 3º apostador: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do prêmio: ");
            double valorPremio = Convert.ToDouble(Console.ReadLine());

            double totalInvestido = valor1 + valor2 + valor3;
            double premioApostador1 = (valor1 / totalInvestido) * valorPremio;
            double premioApostador2 = (valor2 / totalInvestido) * valorPremio;
            double premioApostador3 = (valor3 / totalInvestido) * valorPremio;

            Console.WriteLine($"O primeiro apostado recebe: R$ {premioApostador1:0.00}");
            Console.WriteLine($"O primeiro apostado recebe: R$ {premioApostador2:0.00}");
            Console.WriteLine($"O terceiro apostado recebe: R$ {premioApostador3:0.00}");

            Console.ReadKey();
        }
    }
}
