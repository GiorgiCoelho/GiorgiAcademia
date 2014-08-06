using System;

namespace Unidade_II.Orientação_Objetos
{
    internal class TestaAgencia
    {
        public static void Main03(string[] args)
        {
            Agencia a1 = new Agencia();
            a1.numero = 12345;

            Console.WriteLine(a1.numero);

            Console.ReadKey();
        }
    }
}