using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Funcionario
    {
        public string Nome;
        public Double SalarioBruto;
        public Double Imposto;

        public Double SalarioLiquido()
        {
            
            return  SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += ((porcentagem/100) * SalarioBruto) ;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); ;
        }

    }


}
