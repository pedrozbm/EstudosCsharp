using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks.Dataflow;
using System.Transactions;
using System.Globalization;

namespace Exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Fazer um programa para ler um número inteiro N e os dados(nome e
            //preço) de N Produtos.Armazene os N produtos em um vetor.Em
            //seguida, mostrar o preço médio dos produtos.

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0;i < n; i++)
            {
                sum += vect[i].Price;   
            }
            double avg = sum / n;
            Console.WriteLine("Average price = "+ avg.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}