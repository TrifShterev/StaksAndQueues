using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_minimum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var command = input[0];
                
                switch (command)
                {
                    case "1":
                        var number = int.Parse(input[1]);
                        myStack.Push(number);
                        break;
                    case "2":
                        myStack.Pop();
                        break;
                    case "3":
                        if (myStack.Count>0)
                        {
                            Console.WriteLine(myStack.Max());
                        }
                        break;
                    case "4":
                        if (myStack.Count>0)
                        {
                            Console.WriteLine(myStack.Min());
                        }
                        
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",myStack));
        }
    }
}
