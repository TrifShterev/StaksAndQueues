using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] rosses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> totalLilies = new Stack<int>(lilies);
            Queue<int> totalRosses = new Queue<int>(rosses);

            int wreathsCounter = 0;

            Stack<int> storedLilies = new Stack<int>();
            Queue<int> stortedRosses = new Queue<int>();

            
          var  currentLilie = totalLilies.Peek();
           var currentRosse = totalRosses.Peek();
            var sum = currentLilie + currentRosse;
            while (totalLilies.Any())
            {                              
             
                if (sum == 15)
                {
                    totalLilies.Pop();
                    totalRosses.Dequeue();
                    wreathsCounter++;

                }
                else if (sum > 15)
                {
                    currentLilie -= 2;
                    sum = currentLilie + currentRosse;
                    continue;
                }
                else if (sum < 15)
                {
                    storedLilies.Push(currentLilie);
                    totalLilies.Pop();
                    stortedRosses.Enqueue(currentRosse);
                    totalRosses.Dequeue();
                }

                if (totalLilies.Any())
                {
                    currentLilie = totalLilies.Peek();
                    currentRosse = totalRosses.Peek();
                    sum = currentLilie + currentRosse;
                }
               


            }
            if (storedLilies.Any())
            {


                currentLilie = storedLilies.Peek();
                currentRosse = stortedRosses.Peek();
                sum = currentLilie + currentRosse;
                while (storedLilies.Any())
                {



                    if (sum == 15)
                    {
                        storedLilies.Pop();
                        stortedRosses.Dequeue();
                        sum = currentLilie + currentRosse;
                        wreathsCounter++;

                    }
                    else if (sum > 15)
                    {
                        currentLilie -= 2;
                        sum = currentLilie + currentRosse;
                        continue;
                    }
                    else if (sum < 15)
                    {

                        storedLilies.Pop();

                        stortedRosses.Dequeue();
                    }
                    if (storedLilies.Any())
                    {
                        currentLilie = storedLilies.Peek();
                        currentRosse = stortedRosses.Peek();
                        sum = currentLilie + currentRosse;
                    }
                }
            }
            if (wreathsCounter>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCounter} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreathsCounter} wreaths more!");
            }
        }

       
    }
}
