using System;

namespace Unidade_II.Orientação_Objetos
{
    internal class TestaConta
    {
        public static void Main04(string[] args)
        {
            //ORIENTADO A OBJETOS BÁSICO
            /*
            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            Conta c2 = new Conta();
            c2.numero = 5678;
            c2.saldo = 2000;
            c2.limite = 250;

            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);
            Console.WriteLine(c1.limite);

            Console.WriteLine(c2.numero);
            Console.WriteLine(c2.saldo);
            Console.WriteLine(c2.limite);*/

            //MÉTODOS
            Conta c = new Conta();
            c.Deposita(1000);
            c.ImprimeExtrato();

            c.Saca(100);
            c.ImprimeExtrato();

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            Console.WriteLine("Saldo disponível: " + saldoDisponivel);
            Console.ReadKey();
        }
    }
}