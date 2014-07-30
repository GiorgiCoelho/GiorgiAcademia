using System;

namespace Unidade1.Logica
{
    internal class ImprimeNumeros
    {
        private static void Main02(string[] args)
        {
            for (int contador = 0; contador < 100; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.ReadKey(); // ou Console.ReadLine();
        }
    }
}