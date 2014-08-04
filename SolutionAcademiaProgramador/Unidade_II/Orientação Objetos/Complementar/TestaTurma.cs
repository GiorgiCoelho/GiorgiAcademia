using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_II.Orientação_Objetos.Complementar
{
    class TestaTurma
    {
        public static void Main(string[] args)
        {
            Turma turma1 = new Turma();
            turma1.periodo = "Matutino";
            turma1.ensino = "Médio";
            turma1.serie = "Segundo Ano";
            turma1.sigla = "2°2";

            Turma turma2   = new Turma();
            turma2.periodo = "Vespertino";
            turma2.ensino  = "Fundamental";
            turma2.serie = "Quinta Série";
            turma2.sigla =  "5ª Série";

        }
    }
}
