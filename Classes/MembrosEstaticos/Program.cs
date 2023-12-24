using System;
using System.Globalization;
//Membros estáticos

//Também chamados membros de classe
// - Em oposição a membros e instância
// São membros que fazem sentido independentemente de objetos.
//Não precisam de objeto para serem chamados. São chamaos a partir
//do prórpio nome da classe

//Aplicações comuns:
// - Classes utilitárias
// - Declaração de constantes

// Uma classe que possui somente membros estáticos, pode ser uma classe
//estática também. Esta classe não poderá ser instanciada.


// Exemplo de código, versão 1: Métodos na própria classe do programa

//Fazer um programa para ler um valor numérico qualquer, e daí mostrar
//quanto seria o valor de uma circunferência e do volume de uma esfera
//para um raio daquele valor. Informar também o valor de PI com duas
//casas decimais

namespace MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}