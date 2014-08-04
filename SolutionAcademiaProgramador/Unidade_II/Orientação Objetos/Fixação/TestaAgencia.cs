using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_II.Orientação_Objetos
{
    class TestaAgencia
    {
        public static void Main03(string[] args)
        {
            Agencia a1 = new Agencia();
            a1.numero = 12345;

            Agencia a2 = new Agencia();
            a2.numero = 54321;

            Console.WriteLine(a1.numero);
            Console.WriteLine(a2.numero);
            Console.ReadKey();
        }

    }
}
