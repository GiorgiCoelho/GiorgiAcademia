using System;

namespace Unidade_I.Logica.Complementares
{
    internal class Xadrez
    {
        public static void Main09(string[] args)
        {
            int inicio;
            int fim;
            int duracao;

            Console.Write("Hora de início: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("\nFinalização: ");
            fim = int.Parse(Console.ReadLine());

            if (inicio >= fim)
            {
                duracao = (fim + 24) - inicio;
                Console.WriteLine("\nDuração: "+duracao);
            }
            else
            {
                duracao = fim - inicio;
                Console.WriteLine("\nDuração: " + duracao + " horas.");
            }
            Console.ReadLine();
        }
    }
}