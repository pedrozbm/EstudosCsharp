using System.Diagnostics;
using System.Runtime.InteropServices;

// Debugging: 
//Teclas
//• F9 - marcar/desmarcar breakpoint
//• F5 - iniciar/continuar o debug
//• F10 - executar um passo (pula função)
//• F11 - executar um passo(entra na função)
//• SHIFT + F11 - sair do método em execução
//• SHIFT + F5 - parar debug
//• Janelas
//• Watch (expressões personalizadas)
//• Autos(expressões "interessantes" detectadas pelo Visual Studio)
//• Locals(variáveis locais)


namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funções representam um processamento que possui um significado
            // Em orientação a objetos, funções em classe recebem o nome de "Metodos"

            Console.WriteLine("Digite 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine()); 
            int n3 = int.Parse(Console.ReadLine());

           double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior: "+ resultado);
        }
        static int Maior(int n1,int n2,int n3) {
                int m;

                if (n1 > n2 && n1 > n3)
                {
                    m = n1;
                }
                else if (n2 > n3 && n2 > n3)
                {
                    m = n2;
                }
                else
                {
                    m = n3;
                }
                return m;
            }

    }
}