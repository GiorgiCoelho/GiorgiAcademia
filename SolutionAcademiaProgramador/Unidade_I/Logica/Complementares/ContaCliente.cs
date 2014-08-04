using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidade1.Logica.Complementares;

namespace Unidade_I.Logica.Complementares
{
    class ContaCliente
    {
        public static void Main11(string[] args)
        {
            int numContaCliente;
            double saldo = 0;
            double debito = 0;
            double credito = 0;
            int opcao;
            char opcao2;

            Console.WriteLine("Conta cliente: ");
            numContaCliente = int.Parse(Console.ReadLine());
            Menu:
            Console.Clear();
            Console.WriteLine(" === MENU === ");
            Console.WriteLine("1. Saldo");
            Console.WriteLine("2. Débito");
            Console.WriteLine("3. Crédito");
            Console.Write("\n\nOpção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Saldo: "+ saldo);
                    if (saldo < 0)
                    {
                        Console.WriteLine("Saldo Negativo!");
                    }
                    else
                    {
                        Console.WriteLine("Saldo Positivo!");
                    }
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    opcao2 = char.Parse(Console.ReadLine());
                    if (opcao2 == 'S')
                    {
                        goto Menu;
                    }
                    break;
                case 2:
                    Console.Write("Quanto deseja retirar? ");
                    debito = double.Parse(Console.ReadLine());
                    saldo = saldo - debito;
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    opcao2 = char.Parse(Console.ReadLine());
                    if (opcao2 == 'S')
                    {
                        goto Menu;
                    }
                    break;
                case 3:
                    Console.Write("Quanto deseja depositar? ");
                    credito = double.Parse(Console.ReadLine());
                    saldo = saldo + credito;
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    opcao2 = char.Parse(Console.ReadLine());
                    if (opcao2 == 'S')
                    {
                        goto Menu;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
