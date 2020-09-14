using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesInTheBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> box = new Stack<int>(clothesInTheBox);
            var rackCapacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currentOnTheRack = 0;

            while (box.Any())
            {

                var currentCloth = box.Peek();
                if (currentOnTheRack+currentCloth<rackCapacity)
                {
                    currentOnTheRack += box.Pop();

                }
                else if (currentOnTheRack + currentCloth == rackCapacity)
                {
                    currentOnTheRack += box.Pop();
                    racks++;
                    currentOnTheRack = 0;

                }
                else
                {
                    racks++;
                    currentOnTheRack = 0;
                }

            }
            Console.WriteLine(racks);

        }
    }
}
