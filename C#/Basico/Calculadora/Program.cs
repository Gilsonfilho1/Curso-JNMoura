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
            int numero1, numero2, soma, subtracao, divisao, multiplicacao;

            Console.WriteLine("Digite o primeiro numero:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            divisao = numero1 / numero2;
            multiplicacao = numero1 * numero2;

            Console.WriteLine($"A soma dos numeros é: {soma}");
            Console.WriteLine($"A subtração dos numeros é: {subtracao}");
            Console.WriteLine($"A divisão dos numeros é: {divisao}");
            Console.WriteLine($"A multiplicação dos numeros é: {multiplicacao}");

            Console.WriteLine("Digite enter para encerrar o programa");
            Console.ReadKey();

        }
    }
}
