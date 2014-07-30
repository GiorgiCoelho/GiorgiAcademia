using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.Logica.Complementares
{
    class Triangulo2
    { 
        public static void Main06(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int z = 1; z <= 4; z++)
                {
                    for (int c = 1; c <= z; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
