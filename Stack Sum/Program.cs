using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(input);

            string command;
            while ((command=Console.ReadLine().ToLower())!="end")
            {
                var commands = command.Split();

                switch (commands[0])
                {
                    case "add":
                        int firstNumber = int.Parse(commands[1]);
                        int secondNumber = int.Parse(commands[2]);
                        stack.Push(firstNumber);
                        stack.Push(secondNumber);
                    
                        break;
                    case "remove":
                        int numbersOut = int.Parse(commands[1]);
                        if (stack.Count>=numbersOut)
                        {
                            for (int i = 0; i < numbersOut; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
