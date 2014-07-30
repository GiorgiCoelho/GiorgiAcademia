using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.Logica.Complementares
{
    class Triangulo1
    {
        public static void Main05(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int z = 1; z <= i; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
