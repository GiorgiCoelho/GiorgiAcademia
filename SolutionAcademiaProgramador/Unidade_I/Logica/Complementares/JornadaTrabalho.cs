using System;

namespace Unidade_I.Logica.Complementares
{
    internal class JornadaTrabalho
    {
        public static void Main10(string[] args)
        {
            double valorHora;
            int numHoras;
            double salarioTotal;
            double horaExtra = 0;

            Console.WriteLine("Salário por hora: ");
            valorHora = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas: ");
            numHoras = int.Parse(Console.ReadLine());

            if (numHoras > 40)
            {
                horaExtra = (numHoras - 40) * ((valorHora * 0.50) + valorHora);
            }

            salarioTotal = horaExtra + (valorHora * 40);
            Console.WriteLine("Salário Total: " + salarioTotal);
            Console.ReadKey();
        }
    }
}