using System.Threading.Channels;
using System.Globalization;
namespace EntradaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string frase = Console.ReadLine(); //Comando que lê até a quebra de linha
            // Retorna os dados lidos na forma string
            Console.WriteLine("Você digitou: " + frase);
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            //string[] vet = Console.ReadLine().Split(' '); // a Função Split, quebra em variaveis através do parametro passado
            //string a = vet[0];
            //string b = vet[1];
            //string c = vet[2];

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //Lendo outros tipos de dados:

            int n1 = int.Parse(Console.ReadLine());//Parse converte o String recebido para um inteiro
            Console.WriteLine(n1);
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //como no brasil usamos virgula como separador de dinheiro, para usar ponto, devemos importar a culture info

            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            string sexo = vet[1];
            string idade = vet[2];

            double altura = double.Parse((string)vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}