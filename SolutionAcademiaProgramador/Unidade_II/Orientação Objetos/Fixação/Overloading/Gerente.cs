namespace Unidade_II.Orientação_Objetos.Fixação.Overloading
{
    internal class Gerente
    {
        public string nome;
        public double salario;

        public void AumentoSalario()
        {
            this.AumentoSalario(0.1);
        }

        public void AumentoSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
    }
}