using System;
using System.Runtime.InteropServices;
using System.Globalization;

// Convenções

//Camel case: lastName (Parametros de métodos, variáveis dentro
//    de métodos)

//Pascal Case: LastName (namespaces, classe, properties e métodos)

//Padrão _lastName (atributos "internos" da classe)


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            float n5 = 4.5f;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            string nome = "Pedro"; //Strings são imutáveis
            object obj1 = "Alex Brown";

            // Funções para valores Mínimos e máximos
            int ni = int.MinValue;
            int nm = int.MaxValue;

            
            Console.WriteLine(ni);   
        }
    }

}