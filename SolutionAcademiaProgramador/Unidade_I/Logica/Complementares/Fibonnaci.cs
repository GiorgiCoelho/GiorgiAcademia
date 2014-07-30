using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.Logica.Complementares
{
    class Fibonnaci
    {
        public static void Main07(string[] args)
        {
            int a = 1;
            int b = 0;
            int c;
            Console.WriteLine("Qual número você quer ver a sequência Fibonnaci?");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero ; i++)
            {
                if (numero - i != 1)
                {
                    Console.Write(b + ",");
                }
                else
                {
                    Console.WriteLine(b);
                }
                c = a;
                a = b;
                b = c + a;                
            }
            Console.ReadKey();
        }
    }
}
