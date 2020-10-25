using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Scheduling_FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = Console.ReadLine()
               .Split(", ",StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            var threads = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int needToKill = int.Parse(Console.ReadLine());

            Stack<int> tasksStack = new Stack<int>(tasks);
            Queue<int> threadsQueue = new Queue<int>(threads);

            while (tasksStack.Any()&&threadsQueue.Any())
            {
                int threadValue = threadsQueue.Peek();
                int tasksValue = tasksStack.Peek();
                

                if (threadValue>=tasksValue)
                {
                    if (tasksValue == needToKill)
                    {
                        Console.WriteLine($"Thread with value {threadValue} killed task {needToKill}");
                        break;
                    }
                    threadsQueue.Dequeue();
                    tasksStack.Pop();
                }
                else if (threadValue<tasksValue)
                {
                    if (tasksValue == needToKill)
                    {
                        Console.WriteLine($"Thread with value {threadValue} killed task {needToKill}");
                        break;
                    }
                    threadsQueue.Dequeue();
                }

                if (tasksValue==needToKill)
                {
                    Console.WriteLine($"Thread with value {threadValue} killed task {needToKill}");
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", threadsQueue));
        }
    }
}
