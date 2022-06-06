using System;

namespace Overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList();

            linkedList.AddHead(1);
            linkedList.AddHead(2);
            linkedList.AddHead(3);
            linkedList.AddHead(4);

            Console.WriteLine($"Head: {linkedList.Head.Value}");
            Console.WriteLine($"Tail: {linkedList.Tail.Value}");

            Console.WriteLine($"Next to head: {linkedList.Head.Next.Value}");
            Console.WriteLine($"Previous to tail: {linkedList.Tail.Previous.Value}");

        }
    }
}
