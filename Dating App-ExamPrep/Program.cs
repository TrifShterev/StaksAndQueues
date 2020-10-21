using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dating_App_ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var males = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var females = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stakOfMales = new Stack<int>(males);
            Queue<int> queueOfFemales = new Queue<int>(females);
            int matchCounter = 0;
            

            while (queueOfFemales.Any()&&stakOfMales.Any())
            {
                int male = stakOfMales.Peek();
                int female = queueOfFemales.Peek();
                if (male<=0)
                {
                    stakOfMales.Pop();
                    continue;
                }
                if (female<=0)
                {
                    queueOfFemales.Dequeue();
                    continue;
                }
                
                if (male%25==0)
                {
                    stakOfMales.Pop();
                    stakOfMales.Pop();
                    continue;
                }
                if (female%25==0)
                {
                    queueOfFemales.Dequeue();
                    queueOfFemales.Dequeue();
                    continue;
                }
                if (male==female)
                {
                    stakOfMales.Pop();
                    queueOfFemales.Dequeue();
                    matchCounter++;
                }
                else
                {
                  var currentMale=  male - 2;
                    stakOfMales.Pop();
                    stakOfMales.Push(currentMale);
                    if (queueOfFemales.Any())
                    {
                        queueOfFemales.Dequeue();
                    }
                    
                    
                }
            }
            Console.WriteLine($"Matches: {matchCounter}");
            if (!stakOfMales.Any())
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ",stakOfMales)}");
            }
            if (!queueOfFemales.Any())
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", queueOfFemales)}");
            }
        }
    }
}
