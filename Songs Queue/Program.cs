using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>(songs);

            
            while (songsQueue.Any())
            {
                string input = Console.ReadLine();
                var command = input[0];

                switch (command)
                {
                    case 'P':
                      
                        songsQueue.Dequeue();                                              
                        break;

                    case 'A':
                        var song = "";
                        for (int i = 4; i < input.Length; i++)
                        {
                            song += input[i];
                           
                        }
                        if (!songsQueue.Contains(song))
                        {
                            songsQueue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case 'S':
                        Console.WriteLine(String.Join(", ",songsQueue));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
