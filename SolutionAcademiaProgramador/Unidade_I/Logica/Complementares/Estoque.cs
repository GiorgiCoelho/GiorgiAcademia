using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_I.Logica.Complementares
{
    class Estoque
    {
        static void Main12(string[] args)
        {
            int quantAtualEstoque;
            int quantMaxEstoque;
            int quantMinEstoque;
            int quantMedia;

            Console.WriteLine("QUANTIDADE ATUAL: ");
            quantAtualEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine("QUANTIDADE MÁXIMA: ");
            quantMaxEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine("QUANTIDADE MÍNIMA: ");
            quantMinEstoque = int.Parse(Console.ReadLine());

            quantMedia = (quantMaxEstoque + quantMinEstoque)/2;
            if (quantAtualEstoque >= quantMedia)
            {
                Console.WriteLine("Não efetuar compra!");
            }
            else
            {
                Console.WriteLine("Efetuar compra!");
            }
            Console.ReadKey();
        }
    }
}
