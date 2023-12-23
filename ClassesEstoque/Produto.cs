using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public double Quantidade;

        public Double ValorTotalEmEstoque()
        {   
            
            return Quantidade * Preco;
        }

        public void AdicionarProdutosEstoque()
        {
            Quantidade += Quantidade;
        }
        public void RemoverProdutos()
        {
            Quantidade -= Quantidade;

        }
    }

}
