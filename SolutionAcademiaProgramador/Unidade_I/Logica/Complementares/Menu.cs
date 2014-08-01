using System;

namespace Unidade1.Logica.Complementares
{
    internal class Menu
    {
        public static void Main08(string[] args)
        {
            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=============================================");
                Console.WriteLine();
                Console.WriteLine("\t - MENU -");
                Console.WriteLine("1 - Padrão 1");
                Console.WriteLine("2 - Padrão 2");
                Console.WriteLine("3 - Padrão 3");
                Console.WriteLine("4 - Padrão 4");
                Console.WriteLine("5 - Padrão 5");
                Console.WriteLine("6 - Padrão 6");
                Console.WriteLine("7 - Padrão 7");
                Console.WriteLine();
                Console.Write("Qual opção você deseja? Para sair digite '0': ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        for (int contador = 0; contador < 100; contador++)
                        {
                            Console.WriteLine("Giorgi Coelho");
                        }
                        break;

                    case 2:
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        for (int contador = 0; contador < 100; contador++)
                        {
                            Console.WriteLine(contador);
                        }
                        break;

                    case 3:
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        for (int contador = 1; contador <= 100; contador++)
                        {
                            int resto = contador % 2;
                            if (resto == 1)
                            {
                                Console.WriteLine("*");
                            }
                            else
                            {
                                Console.WriteLine("**");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        for (int contador = 1; contador <= 100; contador++)
                        {
                            int resto = contador % 4;
                            if (resto == 0)
                            {
                                Console.WriteLine("PI");
                            }
                            else
                            {
                                Console.WriteLine(contador);
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int z = 1; z <= i; z++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        for (int i = 1; i <= 2; i++)
                        {
                            for (int z = 1; z <= 4; z++)
                            {
                                for (int c = 1; c <= z; c++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 7:
                        Console.WriteLine("=============================================");
                        int a = 1;
                        int b = 0;
                        int d;
                        Console.WriteLine();
                        Console.Write("Qual número você quer ver a sequência Fibonnaci? ");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < numero; i++)
                        {
                            if (numero - i != 1)
                            {
                                Console.Write(b + ",");
                            }
                            else
                            {
                                Console.WriteLine(b);
                            }
                            d = a;
                            a = b;
                            b = d + a;
                        }
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}