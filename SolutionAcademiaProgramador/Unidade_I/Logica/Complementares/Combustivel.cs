using System;

namespace Unidade_I.Logica.Complementares
{
    internal class Combustivel
    {
        private static void Main(string[] args)
        {
            int litrosVendidos;
            char tipoCombustivel;
            double valorFinal;

            Console.WriteLine("Tipo do combustível: ");
            tipoCombustivel = char.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de combustível vendido: ");
            litrosVendidos = int.Parse(Console.ReadLine());

            if (tipoCombustivel == 'G')
            {
                if (litrosVendidos < 20)
                {
                    valorFinal = litrosVendidos * 3.30 - (litrosVendidos * 0.04 * 3.30);
                }
                else
                {
                    valorFinal = litrosVendidos * 3.30 - (litrosVendidos * 0.06 * 3.30);
                }

            }
            else
            {
                if (litrosVendidos < 20)
                {
                    valorFinal = litrosVendidos * 2.90 - (litrosVendidos * 0.03 * 2.90);
                }
                else
                {
                    valorFinal = litrosVendidos * 2.90 - (litrosVendidos * 0.05 * 2.90);
                } 
            }
        }
    }
}