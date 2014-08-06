using System;

namespace Unidade_II.Orientação_Objetos.Complementar
{
    internal class FuncionarioMetodo
    {
        public string nome;
        public string cargo;
        public double salario;

        public void AumentaSalario(double valor)
        {
            this.salario += valor;
        }

        public void MostraId()
        {
            Console.WriteLine(this.nome);
            Console.WriteLine(this.cargo);
            Console.WriteLine(this.salario);
        }
    }
}