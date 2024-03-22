using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Bem vindo ao programa de Média");
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"Média: {media}");

            Console.ReadKey();
        }
    }
}
