using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, C;

            Console.Write("Informe o 1º numero: ");
            N1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o 2º numero: ");
            N2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o 3º numero: ");
            N3 = double.Parse(Console.ReadLine());

            if (!(N3 > 5))
            {
                C = (N1 + N2) * N3;
                Console.WriteLine("Resultado: {0}", C);
            }
            else 
            {
                C = (N1 - N2) * N3;
                Console.WriteLine("Resultado: {0}", C);
            }
        }
    }
}
