using System;
using System.Collections.Generic;

class StringReversal
{
    static void Main()
    {
        string str = Console.ReadLine();

        Stack<char> stack = new Stack<char>();
        foreach (var ch in str)
        {
            stack.Push(ch);
        }
        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
    }
}

