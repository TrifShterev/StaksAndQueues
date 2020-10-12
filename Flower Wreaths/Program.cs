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

            int storedFlowers = 0;

            var operations = Math.Min(totalLilies.Count, totalRosses.Count);
           

            for (int i = 0; i < operations; i++)
            {
                int currentLilie = totalLilies.Peek();
                int currentRosse = totalRosses.Peek();
                int sum = currentLilie + currentRosse;
          
             
                if (sum == 15)
                {
                    totalLilies.Pop();
                    totalRosses.Dequeue();
                    wreathsCounter++;
                   


                }
                else if (sum > 15)
                {
                    while (true)
                    {
                        currentLilie -= 2;
                        if (currentLilie+currentRosse == 15)
                        {
                            wreathsCounter++;
                            totalLilies.Pop();
                            totalRosses.Dequeue();
                            break;
                        }
                        else if (currentLilie + currentRosse < 15)
                        {
                            storedFlowers += currentLilie + currentRosse;
                            totalLilies.Pop();
                            totalRosses.Dequeue();
                            break;
                        }
                    }

                }
                else if (sum < 15)
                {
                    storedFlowers += currentLilie + currentRosse;
                    totalLilies.Pop();                    
                    totalRosses.Dequeue();
                    
                    
                }
                        

            }
            if (storedFlowers>=15)
            {
                var extraWreath = storedFlowers / 15;
                wreathsCounter += extraWreath;
            }
            if (wreathsCounter>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCounter} wreaths!");
            }
            else if(wreathsCounter<5)
            {
                Console.WriteLine($"You didn't make it, you need {5-wreathsCounter} wreaths more!");
            }
        }

       
    }
}
