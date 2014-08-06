using System;

namespace Unidade_II.Orientação_Objetos.Complementar
{
    internal class TestaAlunoAgregacao
    {
        public static void Main(string[] args)
        {
            AlunoAgregacao estudante1 = new AlunoAgregacao();
            estudante1.nome = "Giorgi Coelho";
            estudante1.rg = "111.111.111-11";
            estudante1.dataNascimento = "1996/04/19";

            AlunoAgregacao estudante2 = new AlunoAgregacao();
            estudante2.nome = "Camila Vianna";
            estudante2.rg = "222.222.222-22";
            estudante2.dataNascimento = "1996/07/10";

            Turma t = new Turma();
            t.ensino = "Médio";
            t.periodo = "Matutino";
            t.serie = "Terceirão";
            t.sigla = "3º";

            estudante1.turma = t;

            Console.WriteLine(estudante1.turma.ensino);
            Console.WriteLine(estudante1.turma.periodo);
            Console.WriteLine(estudante1.turma.serie);
            Console.WriteLine(estudante1.turma.sigla);
            Console.WriteLine(estudante1.nome);
            Console.WriteLine(estudante1.rg);
            Console.WriteLine(estudante1.dataNascimento);

            Console.ReadKey();
        }
    }
}