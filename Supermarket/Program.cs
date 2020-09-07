using System;
using System.Collections;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            string input;

            while ((input=Console.ReadLine())!="End")
            {
                if (input=="Paid")
                {
                    while (queue.Count>0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }

                }
                else
                {
                    queue.Enqueue(input);
                }
                
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
