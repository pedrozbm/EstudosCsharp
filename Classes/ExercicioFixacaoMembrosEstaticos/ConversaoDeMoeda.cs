using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoMembrosEstaticos
{
    internal class ConversaoDeMoeda
    {
        public static double IOF = 1.06;
        public static double Cotacao;
        public static double Compra;

        public static double calculo()
        {
            return (Compra * IOF) * Cotacao; 
        }
    }
}
