using System;

namespace Unidade_II.Orientação_Objetos.Complementar
{
    internal class TestaFuncionario
    {
        public static void Main02(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "Giorgi Coelho";
            funcionario1.cargo = "Presidente";

            Funcionario funcionario2 = new Funcionario();
            funcionario2.nome = "Camila Vianna";
            funcionario2.cargo = "Vice-Presidente";

            Console.WriteLine(funcionario1.nome);
            Console.WriteLine(funcionario1.cargo);
            Console.WriteLine(funcionario2.nome);
            Console.WriteLine(funcionario2.cargo);

            Console.ReadKey();
        }
    }
}