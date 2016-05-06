using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPizza
{
   public static class Pizzaria
    {
        /// <summary>
        /// place an order
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="customerPhone"></param>
        /// <param name="customerAddress"></param>
        /// <param name="typeOfOrder"></param>
        /// <returns></returns>
        public static Order PlaceOrder (string customerName, int customerPhone, string customerAddress, OrderType typeOfOrder)
        {
            var order = new Order
            {
                CustomerName = customerName,
                CustomerAddress = customerAddress,
                CustomerPhone = customerPhone,
                TypeOfOrder = typeOfOrder
            };
            return order;
            
           

        }
    }
}
