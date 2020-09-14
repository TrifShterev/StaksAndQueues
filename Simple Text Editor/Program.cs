using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> lastCommand = new Stack<string>();

            string text = "";

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "1":
                        lastCommand.Push(text);
                        text += commands[1];
                        break;

                    case "2":
                        lastCommand.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(commands[1]));
                        break;

                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;

                    case "4":
                        text = lastCommand.Pop();
                        break;
                }
            }
        }
    }
}
