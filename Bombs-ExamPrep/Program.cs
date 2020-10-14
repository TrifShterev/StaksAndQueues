using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bombs_ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffect = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bombCasing = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> bEffects = new Queue<int>(bombEffect);
            Stack<int> bCasings = new Stack<int>(bombCasing);

            int daturaBombsCount = 0;//40
            int cherryaBombsCount = 0;//60
            int smokeDecoyBombsCount = 0;//120

            bool pouchIsFull = false;
            var operations = Math.Min(bombCasing.Length, bombEffect.Length);

            for (int i = 0; i < operations; i++)
            {
                int currentBombEffect = bEffects.Peek();
                int currentBombCasing = bCasings.Peek();
                int sum = currentBombCasing + currentBombEffect;

                if(daturaBombsCount >= 3 && cherryaBombsCount >= 3 && smokeDecoyBombsCount >= 3)
                {
                    pouchIsFull = true;
                    break;
                }
                if (sum==40)
                {
                    daturaBombsCount++;
                    bEffects.Dequeue();
                    bCasings.Pop();
                }
                else if (sum==60)
                {
                    cherryaBombsCount++;
                    bEffects.Dequeue();
                    bCasings.Pop();
                }
                else if (sum==120)
                {
                    smokeDecoyBombsCount++;
                    bEffects.Dequeue();
                    bCasings.Pop();
                }
                else
                {
                    
                    while (true)
                    {
                        currentBombCasing -= 5;
                        sum = currentBombCasing + currentBombEffect;
                        if (sum==40)
                {
                    daturaBombsCount++;
                    bEffects.Dequeue();
                    bCasings.Pop();
                            break;
                }
                else if (sum==60)
                {
                    cherryaBombsCount++;
                    bEffects.Dequeue();
                    bCasings.Pop();
                            break;
                }
                else if (sum==120)
                {
                    smokeDecoyBombsCount++;
                    bEffects.Dequeue();
                    bCasings.Pop();
                            break;
                }
                    }
                }
                
            }
            if (pouchIsFull)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bEffects.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",bEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bCasings.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ",bCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            Console.WriteLine($"Cherry Bombs: {cherryaBombsCount}\nDatura Bombs: {daturaBombsCount}\nSmoke Decoy Bombs: {smokeDecoyBombsCount}");

        }
    }
}
