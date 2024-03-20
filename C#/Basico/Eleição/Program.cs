using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de votação");
            Console.WriteLine("Digite o código do voto:\n[1] Candidato 1\n[2] Candidato 2\n[3] Candidato 3\n[4] Candidato 4\n[5] Nulo\n[6] Branco");
            int voto = int.Parse(Console.ReadLine());
            
            if (voto == 1)
            {
                Console.WriteLine("Voto contabilizado com sucesso.");
            }
            if (voto == 2)
            {
                Console.WriteLine("Voto contabilizado com sucesso.");
            }
            if (voto == 3)
            {
                Console.WriteLine("Voto contabilizado com sucesso.");
            }
            if (voto == 4)
            {
                Console.WriteLine("Voto contabilizado com sucesso.");
            }
            /*
            if (voto == 1 || voto == 2 || voto == 3 || voto == 4)
            {
                Console.WriteLine("Voto contabilizado com sucesso.");
            }
            */
            if (voto == 5)
            {
                Console.WriteLine("Voto nulo contabilizado.");
            } 
            if (voto == 6)
            {
                Console.WriteLine("Voto em branco contabilizado");
            }
            else
            {
                Console.WriteLine("Codigo de voto invalido. ");
            }

            Console.ReadKey();
        }
    }
}
