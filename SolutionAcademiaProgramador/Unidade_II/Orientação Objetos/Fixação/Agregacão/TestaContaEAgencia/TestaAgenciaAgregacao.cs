using System;

namespace Unidade_II.Orientação_Objetos
{
    internal class TestaAgenciaAgregacao
    {
        public static void Main03(string[] args)
        {
            Agencia a1 = new Agencia();
            a1.numero = 12345;

            Conta c1 = new Conta();
            c1.numero = 111;
            c1.saldo = 200;
            c1.limite = 500;

            c1.agencia = a1;

            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.agencia.numero);
            Console.WriteLine(c1.limite);
            Console.WriteLine(c1.saldo);

            Console.ReadKey();
        }
    }
}