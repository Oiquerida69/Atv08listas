using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv08listaserepetiçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("Wendell");
            nomes.Add("Mirela");
            nomes.Add("Samus");
            nomes.Add("Waluigi");
            Console.WriteLine($"O primeiro é {nomes[0]} ");
            Console.WriteLine($"O segundo é {nomes[1]} ");
            Console.WriteLine($"O terceiro é {nomes[2]} ");
            Console.WriteLine($"O quarto é {nomes[3]} ");
            Console.WriteLine("Digite o seu nome :");
            nomes.Add(Console.ReadLine());
            Console.WriteLine($"O seu nome é {nomes[4]}");


            int quantidade = nomes.Count;
            Console.WriteLine($"existem {quantidade} usuarios cadastrados!");
            nomes.Remove("Waluigi");

            Console.ReadKey();



        }
        void arrays()
        {
            string[] nomes = new string[3] { "wendell", "mirela","mario"};
            string[] usuarios = new string[3];
            int[] idades = {19,21,18 };
            usuarios[0] = "Link";
            usuarios[1] = "Samus";
            usuarios[2] = "Bayonetta";
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            Console.WriteLine(usuarios[2]);
            Console.WriteLine(usuarios[1]);
            Console.WriteLine(usuarios[0]);

            Console.ReadKey();

        }
    }
}
