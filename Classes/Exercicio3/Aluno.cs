using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Aluno
    {
        public string Nome;
        public double n1;
        public double n2;
        public double n3;

        public double Media()
        {
            return (n1 + n2 + n3)/3;
        }
        public string Aprovado()
        {
            if (Media() >= 60)
            {
                return "Aprovado";
            }
            else
            {
                
                return "Reprovado, faltam: "+(60 - Media())+" pontos";

            }
        }
    }
    
}
