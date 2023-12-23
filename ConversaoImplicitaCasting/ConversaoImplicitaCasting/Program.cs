namespace ConversaoImplicitaCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão  implicita entre tipos é quando um conteúdo de um certo tipo pode ser naturalmente
            // atribuído para uma variável de outro tipo
            // Casting é uma conversão explicita entre tipos compatíveis

            float x = 4.5f;
            double y = x;
            // Esta é uma conversão implicita

            double a;
            float b;
            a = 5.1;
            b = (float)a;
            //Esse é um exemplo de Cast

            Console.WriteLine(b);
            //Para divisoões de números inteiros´, é importante lembrar do cast
            int n1 = 5;
            int n2 = 2;

            Console.WriteLine(n1 / n2);// Gera um resultado inteiro
            double resultado = (double) n1 / n2;
            Console.WriteLine(resultado);
        }
    }
} 