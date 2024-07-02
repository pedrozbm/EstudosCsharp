using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoEnumComposicao.Entities
{
    internal class OrderItem
    {
        public int  Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price)
        {
            this.Quantity = quantity;
            this.Price = price;
        }
        public Double SubTotal()
        {
            return Quantity*Price;
        }
    }
}
