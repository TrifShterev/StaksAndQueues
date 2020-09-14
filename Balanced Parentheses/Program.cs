using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            Stack<char> parenthesesStack = new Stack<char>();

            for (int i = 0; i < symbols.Length; i++)
            {

         

                char first = symbols[i];

                if (first == '(' || first == '{' || first == '[' || !parenthesesStack.Any())
                {
                    parenthesesStack.Push(first);
                }
                else if (parenthesesStack.Any() && first == '}' && parenthesesStack.Peek() == '{')
                {
                    parenthesesStack.Pop();
                }
                else if (parenthesesStack.Any() && first == ')' && parenthesesStack.Peek() == '(')
                {
                    parenthesesStack.Pop();
                }
                else if (parenthesesStack.Any() && first == ']' && parenthesesStack.Peek() == '[')
                {
                    parenthesesStack.Pop();
                }      
            }
            if (parenthesesStack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

        }
    }
}
