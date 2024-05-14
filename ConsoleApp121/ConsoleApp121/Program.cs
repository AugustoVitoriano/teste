using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double altura;

            Console.Write("Informe o numero de pessoas: ");
            n = int.Parse(Console.ReadLine());



            double[] vect = new double[n];




            for (int i = 0; i < n; i++) 
            {
                Console.Write("Altura {0}: ",i);
                vect[i] = double.Parse(Console.ReadLine());
            }






        }
    }
}
