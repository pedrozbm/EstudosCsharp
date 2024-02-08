using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace ExercicioFixaçãoVetores
{
    //    A dona de um pensionato possui dez quartos para alugar para estudantes,
    //sendo esses quartos identificados pelos números 0 a 9.
    //Quando um estudante deseja alugar um quarto, deve-se registrar o nome
    //e email deste estudante.
    //Fazer um programa que inicie com todos os dez quartos vazios, e depois
    //leia uma quantidade N representando o número de estudantes que vão
    //alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
    //N estudantes.Para cada registro de aluguel, informar o nome e email do
    //estudante, bem como qual dos quartos ele escolheu(de 0 a 9). Suponha
    //que seja escolhido um quarto vago.Ao final, seu programa deve imprimir
    //um relatório de todas ocupações do pensionato, por ordem de quarto,
    //conforme exemplo.
    internal class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quarto = new Quarto[10];

            Console.WriteLine("Digite o número de quartos a serem alugados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o Número do quarto desejado: ");
                int quartoselect = int.Parse(Console.ReadLine());
                if (quarto[quartoselect] == null)
                {
                    Console.WriteLine("Digite o nome e o email: ");
                    string nome = Console.ReadLine();
                    string email = Console.ReadLine();
                    quarto[quartoselect] = new Quarto { Nome = nome, email = email };

                }
                else
                {
                    Console.WriteLine("Quarto já ocupado");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (quarto[i] is not null)
                {
                    Console.WriteLine("Quarto: " + i + " \n Nome: " + quarto[i].Nome + "\n Email: " + quarto[i].email);
                }
            }
        }
    }
}
