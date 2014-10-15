using System;

namespace Unidade_II.Orientação_Objetos.Fixação.Overloading
{
    internal class TestaGerente
    {
        private static void Main(string[] args)
        {
            Gerente g1 = new Gerente();
            g1.nome = "Giorgi";
            Console.WriteLine(g1.nome);
            g1.salario = 200;
            Console.WriteLine("Salário: "+g1.salario);
            Console.WriteLine("Taxa fixa de 10%");
            g1.AumentoSalario();
            Console.WriteLine("Salário: " + g1.salario);
            Console.Write("Taxa Variada: ");
            double taxa = double.Parse(Console.ReadLine());
            taxa /= 100;
            g1.AumentoSalario(taxa);
            Console.WriteLine("Salário: " +g1.salario);
            Console.ReadKey();            
        }
    }
}