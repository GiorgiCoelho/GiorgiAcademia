using System;

namespace Unidade1.Logica
{
    internal class ImprimePadrao1
    {
        private static void Main03(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
            }

            Console.ReadKey(); // ou Console.ReadLine();
        }
    }
}