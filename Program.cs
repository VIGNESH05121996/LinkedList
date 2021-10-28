using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Data Structure");
            LinkedList list = new LinkedList();
            list.Display();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            Console.ReadLine();
        }
    }
}
