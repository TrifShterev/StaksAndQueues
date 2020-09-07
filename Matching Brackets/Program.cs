using System;
using System.Collections.Generic;
using System.Text;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol=='(')
                {
                    stack.Push(i);

                }
                else if (symbol==')')
                {
                    int indexOfBracked = stack.Pop();
                    var result = text.Substring(indexOfBracked, i - indexOfBracked + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
