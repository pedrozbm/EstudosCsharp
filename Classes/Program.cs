using System.Globalization;

namespace Classes
{
    //    Fazer um programa para ler as medidas dos lados de dois triângulos X e Y(suponha medidas
    //válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
    //    possui a maior área.
    //A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
    //seguinte(fórmula de Heron):

    //Resolvendo com Classes 
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (area > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
// Quais os beneficios de se calcular área de um traingulo por meio 
// de um MÉTODO dentroo da CLASSE Triângulo?

// Reaproveitamento de código: Nós eliminamos o código repetido (cálculo 
// das áreas dos triângulos x e y) no programa principal.

// Delegação de responsabilidades: Quem deve ser responsável por saber 
// como caluclar a área de um triângulo é o próprio triângulo. A lógica do
// cálculo da área não deve estar em outro lugar.