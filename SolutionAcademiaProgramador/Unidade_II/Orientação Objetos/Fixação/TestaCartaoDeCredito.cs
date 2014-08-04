using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_II.Orientação_Objetos
{
    class TestaCartaoDeCredito
    {
        public static void Main02(string[] args)
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 11223344;
            cdc1.dataDeValidade = "12/08";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 44332211;
            cdc2.dataDeValidade = "12/09";

            Console.WriteLine(cdc1.numero);
            Console.WriteLine(cdc1.dataDeValidade);
            Console.WriteLine(cdc2.numero);
            Console.WriteLine(cdc2.dataDeValidade);
            Console.ReadKey();
        }
    }
}
