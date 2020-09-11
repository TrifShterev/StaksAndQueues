using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToEnqueue = input[0];
            int elementsDequeue = input[1];
            int numberToFind = input[2];

            
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> myQueue = new Queue<int>(numbers);
            for (int i = 0; i < elementsDequeue; i++)
            {
                if (myQueue.TryDequeue(out int result))
                {

                }
                else
                {
                    Console.WriteLine('0');
                    return;
                }
            }
            if (myQueue.Count > 0)
            {


                if (myQueue.Contains(numberToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(myQueue.Min());
                }
            }
            else
            {
                Console.WriteLine('0');
            }
        }
    }
}
