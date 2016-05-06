using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Best Pizza");
            Console.WriteLine("1.place an order");
            Console.WriteLine("0.exit");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    break;

                case "0":
                    Console.WriteLine("good bye");
                    return;
                    

                default:
                    break;
                    
            }

            
            var order1 = Pizzaria.PlaceOrder(1, "aaa", 1234567892, "12 ,aaa ", "delivery");
            Console.WriteLine("Order Number: {0}, Customer name: {1}, Customer Phone: {2}, Customer Address: {3}, Type Of Order: {4}",
                               order1.OrderNumber, order1.CustomerName, order1.CustomerPhone, order1.CustomerAddress,  order1.TypeOfOrder);

            var order2 = Pizzaria.PlaceOrder(2, "bbb", 1234565672, "13 ,bbb ", "takeout");
            Console.WriteLine("Order Number: {0}, Customer name: {1}, Customer Phone: {2}, Customer Address: {3}, Type Of Order: {4}",
                               order2.OrderNumber, order2.CustomerName, order2.CustomerPhone, order2.CustomerAddress, order2.TypeOfOrder);
        }
    }
}
