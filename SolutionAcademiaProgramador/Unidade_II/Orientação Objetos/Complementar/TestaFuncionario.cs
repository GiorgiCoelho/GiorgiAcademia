using System;

namespace Unidade_II.Orientação_Objetos.Complementar
{
    internal class TestaFuncionario
    {
        public static void Main(string[] args)
        {
            /*
            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "Giorgi Coelho";
            funcionario1.cargo = "Presidente";

            Funcionario funcionario2 = new Funcionario();
            funcionario2.nome = "Camila Vianna";
            funcionario2.cargo = "Vice-Presidente";

            Console.WriteLine(funcionario1.nome);
            Console.WriteLine(funcionario1.cargo);
            Console.WriteLine(funcionario2.nome);
            Console.WriteLine(funcionario2.cargo);*/

            Funcionario f1 = new Funcionario();
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