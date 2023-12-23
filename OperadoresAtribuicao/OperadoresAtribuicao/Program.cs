using System;

namespace OperadoresAtribuicao
{
    public class OperadoresAtribuicao{
        static void Main(string[] args)
        {
            int a = 1;

            a += 2; // Este operador Soma 2 ao valor de a
            a -= 2; //subtrai   
            a *= 2; //multiplica    
            a /= 2; // divide
            a %= 2;// Este operador retorna o resto da divisão
            Console.WriteLine(a);

            // Os operadores de atribuição tabém funcinam para concatenação de Strings
            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            //Operadores de Incremento e Decremento:

            int b = 10;
            b++;
            Console.WriteLine(b);

        }
    }


}
