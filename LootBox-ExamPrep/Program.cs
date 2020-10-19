using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LootBox_ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var queueItems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stackItems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> firstBox = new Queue<int>(queueItems);
            Stack<int> secondBox = new Stack<int>(stackItems);

            List<int> myBox = new List<int>();

            while (firstBox.Any()&&secondBox.Any())
            {
                var firstBoxItem = firstBox.Peek();
                var secondBoxItem = secondBox.Peek();
                var sum = firstBoxItem + secondBoxItem;

                if (sum%2==0)
                {
                    myBox.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBoxItem);
                    secondBox.Pop();
                }
            }
            if (!firstBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (myBox.Sum()>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {myBox.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {myBox.Sum()}");
            }
        }
    }
}
