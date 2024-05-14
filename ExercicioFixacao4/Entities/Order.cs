using ExercicioFixacao4.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao4.Entities
{
    internal class Order
    {
        public DateTime Momment {  get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in Items)
            {
                sum = +item.Price;
            }

            return sum;
        }
    }
}
