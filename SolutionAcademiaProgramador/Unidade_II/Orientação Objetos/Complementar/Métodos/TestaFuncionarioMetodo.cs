using System;

namespace Unidade_II.Orientação_Objetos.Complementar
{
    internal class TestaFuncionarioMetodo
    {
        public static void Main02(string[] args)
        {
            FuncionarioMetodo f1 = new FuncionarioMetodo();
            f1.nome = "Giorgi Coelho";
            f1.cargo = "Estudante";
            Console.WriteLine("Quanto deseja aumentar o salário? ");
            double aumento = double.Parse(Console.ReadLine());
            f1.AumentaSalario(aumento);
            f1.MostraId();

            Console.ReadKey();
        }
    }
}