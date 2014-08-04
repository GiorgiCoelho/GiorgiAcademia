using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_II.Orientação_Objetos
{
    class TestaValoresPadrao
    {
        public static void Main05(string[] args)
        {
            Conta c = new Conta();
            Console.WriteLine(c.numero);
            Console.WriteLine(c.saldo);
            Console.WriteLine(c.limite);
            Console.ReadKey();
        }
    }
}
