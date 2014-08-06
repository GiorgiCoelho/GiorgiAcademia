using System;

namespace Unidade_II.Orientação_Objetos
{
    internal class TestaContaMetodo
    {
        public static void Main04(string[] args)
        {
            //MÉTODOS
            ContaMetodo c = new ContaMetodo();
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