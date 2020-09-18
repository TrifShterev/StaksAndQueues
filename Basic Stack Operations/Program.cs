using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int elementsToPop = input[1];
            int numberToFind = input[2];

            
           var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> playingStack = new Stack<int>(numbers);

            for (int i = 0; i < elementsToPop; i++)
            {
                playingStack.Pop();

            }
            if (playingStack.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else if (playingStack.Count>0)
            {
                Console.WriteLine(playingStack.Min());
            }
            else
            {
                Console.WriteLine('0');
            }
        }
    }
}
