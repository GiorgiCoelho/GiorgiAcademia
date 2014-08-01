using System;

namespace Unidade_I.Logica.Complementares
{
    internal class Combustivel
    {
        private static void Main(string[] args)
        {
            double litrosVendidos;
            char tipoCombustivel;
            double valorSerPago;

            Console.WriteLine("TIPO DE COMBUSTÍVEL: G OU A");
            tipoCombustivel = char.Parse(Console.ReadLine());
            Console.WriteLine("QUANTIDADE DE LITROS VENDIDOS: ");
            litrosVendidos = double.Parse(Console.ReadLine());

            if (tipoCombustivel == 'G')
            {
                if (litrosVendidos < 20)
                {
                    valorSerPago = (litrosVendidos * 3.30) - ((litrosVendidos * 0.04) * 3.30);
                }
                else
                {
                    valorSerPago = (litrosVendidos * 3.30) - ((litrosVendidos * 0.06) * 3.30);
                }
            }
            else
            {
                if (litrosVendidos < 20)
                {
                    valorSerPago = (litrosVendidos * 2.90) - ((litrosVendidos * 0.03) * 2.90);
                }
                else
                {
                    valorSerPago = (litrosVendidos * 2.90) - ((litrosVendidos * 0.05) * 2.90);
                }
            }
            Console.WriteLine("Valor a ser pago: " + valorSerPago + " R$.");
            Console.ReadKey();
        }
    }
}