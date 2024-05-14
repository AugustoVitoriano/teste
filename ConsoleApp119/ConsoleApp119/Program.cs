using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MAIOR, MEDIO, MENOR;

            Console.Write("INFORME O VALOR DE A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("INFORME O VALOR DE B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("INFORME O VALOR DE C: ");
            C = double.Parse(Console.ReadLine());
           
            if (A > B && A > C)
            {
                MAIOR = A;
                Console.WriteLine("{0} É O MAIOR", MAIOR);
                if (B > C)
                {
                    MEDIO = B;
                    Console.WriteLine("{0} É O MAIOR", MEDIO);
                    MENOR = C;                
                    Console.WriteLine("{0} É O MAIOR", MENOR);

                }
                else
                {
                    MEDIO = C;
                    Console.WriteLine("{0} É O MAIOR", MEDIO);
                    MENOR = B;
                    Console.WriteLine("{0} É O MAIOR", MENOR);
                }
            }              
            else
            {
                if (B > A && B > C)
                {
                    MAIOR = B;
                    Console.WriteLine("{0} É O MAIOR", MAIOR);


                    if (A > C)
                    {
                        MEDIO = A;
                        Console.WriteLine("{0} É O MAIOR", MEDIO);
                        MENOR = C;
                        Console.WriteLine("{0} É O MAIOR", MENOR);
                        Console.WriteLine();
                    }
                    else
                    {
                        MEDIO = C;
                        Console.WriteLine("{0} É O MEDIO", MEDIO);
                        MENOR = A;
                        Console.WriteLine("{0} É O MENOR", MENOR);
                        Console.WriteLine();
                    }
                }
                else
                {
                    if ((C > A) && (C > B))
                    {
                        MAIOR = C;
                        Console.WriteLine("{0} É O MAIOR,", MAIOR);
                        Console.WriteLine();
                        if (A > B) 
                        {
                            MEDIO = A;
                            Console.WriteLine("{0} É O MEDIO,", MEDIO);
                            MENOR = B;
                            Console.WriteLine("{0} É O MENOR,", MENOR);
                            Console.WriteLine();
                        }
                        else 
                        {
                            MEDIO = B;
                            Console.WriteLine("{0} É O MEDIO,", MEDIO);
                            MENOR = A;
                            Console.WriteLine("{0} É O MENOR,", MENOR);
                            Console.WriteLine();
                        }
                    }  
                }
            }
        }
    }
}
