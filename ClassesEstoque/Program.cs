using System;
using System.Globalization;
using System.Security.Cryptography;

// Fazer um programa para ler os dados de um produto em estoque (nome, preço e
// quantidade no estoque). Em seguida:

//Mostrar os dados do produto (Nome, preço, quantidade no estoque, valor total
// no estoque
//Realizar uma entrada no estoque e mostrar novamente os dados do produto
// Realizar uma saída no estoque e mostrar novamente os dados do produto

namespace ClassesEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.Write("Digite o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade no estoque: ");
            p.Quantidade =int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p.Nome + ", $ " + p.Preco + ", " + p.Quantidade + " unidades, Total:" + p.ValorTotalEmEstoque());

            int quantidade;
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados Atualizados: ");

        }
    }
}