using ExercicioFixacaoEnumComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioFixacaoEnumComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {

        }
        public Order(OrderStatus status)
        {
            Status = status;
        }

        void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        Double Total()
        {
            return 
        }
    }
}
