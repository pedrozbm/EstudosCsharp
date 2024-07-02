using ExercicioFixacaoEnumComposicao.Entities;
using ExercicioFixacaoEnumComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoEnumComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            
            Client client = new Client(name, email, date);
            

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            Enum.TryParse < OrderStatus>("Shipped", out OrderStatus os1);
            OrderStatus os2 = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Shipped");
            Console.WriteLine(os2);

        }
    }
}
