using System;

namespace Pesca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--Bem vindo ao programa da PESCA--");

            const double LIMITEEMQUILOS = 50;
            const double MULTA1 = 4;
            const double MULTA2 = 8;

            Console.WriteLine("Quantos quilos de peixe você pescou?");
            double quilosPescados = double.Parse(Console.ReadLine());

            double pesoExcedido = quilosPescados - LIMITEEMQUILOS;

            if (quilosPescados <= LIMITEEMQUILOS)
            {
                Console.WriteLine("O valor da multa que deve ser paga é: 0");
                Console.WriteLine("O excedente em quilos do peixe pescado é: 0");
            }
            else
            {
                if (quilosPescados < 60)
                {
                    Console.WriteLine($"O valor da multa que deve ser paga é: {pesoExcedido * MULTA1:0.00}");
                    Console.WriteLine($"O excedente em quilos do peixe pescado é: {pesoExcedido:0.000}");
                }
                else
                {
                    Console.WriteLine($"O valor da multa que deve ser paga é: {pesoExcedido * MULTA2:0.00}");
                    Console.WriteLine($"O excedente em quilos do peixe pescado é: {pesoExcedido:0.000}");
                }

            }

            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();

        }
    }
}
