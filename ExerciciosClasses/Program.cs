using System.Runtime.ConstrainedExecution;

namespace ExerciciosClasses
{
    //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
    //velha.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da primeira pessoa");
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Agora digite sua idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora Digite o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade dessa pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine(pessoa1.nome + " é mais velha");
            }
            else
            {
                Console.WriteLine(pessoa2.nome+"é mais velha");
            }
        }
    }
}