using System.Runtime.ConstrainedExecution;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //       Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            //       Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
            //       pessoas

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("Average Height = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}