using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        private static List<Product> products = new List<Product>();
        private static SortedDictionary<string, List<Order>> orders = new SortedDictionary<string, List<Order>>();

        private static void ReadProducts()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split('-');
                var existingProductIndex = products
                    .FindIndex(x => x.name == input[0]);
                if (existingProductIndex > -1)
                {
                    products[existingProductIndex].price = double.Parse(input[1]);
                }else
                {
                    var product = new Product
                    {
                        name = input[0],
                        price = double.Parse(input[1])
                    };
                    products.Add(product);
                }                
            }
        }

        private static void ReadOrders()
        {
            var input = Console.ReadLine();
            Order temp;
            while (input != "end of clients")
            {
                var splitted = input
                    .Split(new char[] { '-', ',' });
                if(products.Exists(x => x.name == splitted[1]))
                {
                    var customer = splitted[0];
                    if (!orders.ContainsKey(customer))
                    {
                        orders[customer] = new List<Order>();
                    }
                    if (orders[customer].Exists(x => x.product == splitted[1]))
                    {
                        var ord = orders[customer]
                            .Where(x => x.product == splitted[1])
                            .First();
                        ord.amount += int.Parse(splitted[2]);
                    }else
                    {
                        temp = new Order
                        {
                            product = splitted[1],
                            amount = int.Parse(splitted[2])
                        };
                        orders[customer].Add(temp);
                    }
                    
                }                
                input = Console.ReadLine();
            }
        }

        public static void PrintResult()
        {
            double total = 0d;
            foreach (var order in orders)
            {
                double bill = 0d;
                foreach (var item in order.Value)
                {
                    var productInfo = products
                    .Where(x => x.name == item.product)
                    .First();
                    bill += productInfo.price * item.amount;
                }
                Console.WriteLine($"{order.Key}");
                
                total += bill;
                order.Value.ForEach(x => Console.WriteLine($"-- {x.product} - {x.amount}"));
                Console.WriteLine($"Bill: {bill:f2}");
            }
            Console.WriteLine($"Total bill: {total:f2}");
        }

        static void Main(string[] args)
        {
            ReadProducts();
            ReadOrders();
            PrintResult();
        }
    }
}
