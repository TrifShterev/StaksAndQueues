using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    queue.Enqueue(numbers[i]);
                    
                    
                }
                
            }
            Console.Write(String.Join(", ", queue));
        }
    }
}
