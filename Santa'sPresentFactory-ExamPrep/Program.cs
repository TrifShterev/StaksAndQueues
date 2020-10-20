using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace Santa_sPresentFactory_ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var magic = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            Stack<int> materialsStack = new Stack<int>(materials);
            Queue<int> magicQueue = new Queue<int>(magic);

            int dollsCount = 0;
            int trainCount = 0;
            int bycicleCount = 0;
            int tedyBearsCount = 0;

            while (magicQueue.Any()&&materialsStack.Any())
            {
                var currentMagic = magicQueue.Peek();
                var currentMaterial = materialsStack.Peek();
                var mix = currentMagic * currentMaterial;


                if (mix==150)
                {
                    dollsCount++;
                    magicQueue.Dequeue();
                    materialsStack.Pop();
                    continue;
                }
                else if (mix==250)
                {
                    trainCount++;
                    magicQueue.Dequeue();
                    materialsStack.Pop();
                    continue;
                }
                else if (mix==300)
                {
                    tedyBearsCount++;
                    magicQueue.Dequeue();
                    materialsStack.Pop();
                    continue;
                }
                else if (mix==400)
                {
                    bycicleCount++;
                    magicQueue.Dequeue();
                    materialsStack.Pop();
                    continue;
                }
                if (currentMaterial==0&&currentMagic==0)
                {
                    magicQueue.Dequeue();
                    materialsStack.Pop();
                    continue;
                }
                else if (currentMaterial==0)
                {
                    materialsStack.Pop();
                    continue;
                }
                else if (currentMagic==0)
                {
                    magicQueue.Dequeue();
                    continue;
                }

                if (mix < 0)
                {
                    var sum = currentMagic + currentMaterial;
                    magicQueue.Dequeue();
                    materialsStack.Pop();
                    materialsStack.Push(sum);
                }
                else if (mix > 0)
                {
                    materialsStack.Pop();
                    currentMaterial += 15;
                    materialsStack.Push(currentMaterial);
                    magicQueue.Dequeue();
                    //if (magicQueue.Any())
                    //{


                    //    currentMagic = magicQueue.Peek();
                    //    mix = currentMagic * currentMaterial;
                    //    if (mix == 150)
                    //    {
                    //        dollsCount++;
                    //        magicQueue.Dequeue();
                    //        materialsStack.Pop();
                    //        continue;
                    //    }
                    //    else if (mix == 250)
                    //    {
                    //        trainCount++;
                    //        magicQueue.Dequeue();
                    //        materialsStack.Pop();
                    //        continue;
                    //    }
                    //    else if (mix == 300)
                    //    {
                    //        tedyBearsCount++;
                    //        magicQueue.Dequeue();
                    //        materialsStack.Pop();
                    //        continue;
                    //    }
                    //    else if (mix == 400)
                    //    {
                    //        bycicleCount++;
                    //        magicQueue.Dequeue();
                    //        materialsStack.Pop();
                    //        continue;
                    //    }
                    //    if (currentMaterial == 0 && currentMagic == 0)
                    //    {
                    //        magicQueue.Dequeue();
                    //        materialsStack.Pop();
                    //        continue;
                    //    }
                    //    else if (currentMaterial == 0)
                    //    {
                    //        materialsStack.Pop();
                    //        continue;
                    //    }
                    //    else if (currentMagic == 0)
                    //    {
                    //        magicQueue.Dequeue();
                    //        continue;
                    //    }
                    //}
                }
            }
            if ((dollsCount>0&&trainCount>0)||(tedyBearsCount>0&&bycicleCount>0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materialsStack.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ",materialsStack)}");
            }
            else if (magicQueue.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicQueue)}");
            }

            if (bycicleCount>0)
            {
                Console.WriteLine($"Bicycle: {bycicleCount}");
            }
            if (dollsCount>0)
            {
                Console.WriteLine($"Doll: {dollsCount}");
            }
            if (tedyBearsCount>0)
            {
                Console.WriteLine($"Teddy bear: {tedyBearsCount}");
            }
            if (trainCount>0)
            {
                Console.WriteLine($"Wooden train: {trainCount}");
            }
        }
    }
}
