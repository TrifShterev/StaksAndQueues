using System;
using System.Collections.Generic;
using System.Linq;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCarsCanPass = int.Parse(Console.ReadLine());
            var queueOfTheStreetLight = new Queue<string>();
            int carsPassed = 0;
            string input;
            while ((input=Console.ReadLine())!= "end")
            {
                if (input=="green")
                {

                    for (int i = 0; i < numberOfCarsCanPass; i++)
                    {
                        if (queueOfTheStreetLight.Any())
                        {
                            Console.WriteLine($"{queueOfTheStreetLight.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }
                    
                }
                else
                {
                    queueOfTheStreetLight.Enqueue(input);
                }
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
