using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Data Structure");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
