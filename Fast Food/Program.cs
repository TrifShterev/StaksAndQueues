using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queueOfOrders = new Queue<int>(orders);

            Console.WriteLine(queueOfOrders.Max());

            for (int i = 0; i < orders.Length; i++)

            {
                var firstElement = queueOfOrders.Peek();

                if (firstElement<=capacity)
                {
                    capacity -= queueOfOrders.Dequeue();
                }
                else
                {
                    break;
                }
                
                
            }
            if (queueOfOrders.Any())
            {
                Console.WriteLine($"Orders left: {String.Join(" ",queueOfOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
