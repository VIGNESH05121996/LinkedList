using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Data Structure");
            LinkedList list = new LinkedList();            
            list.AppendList(56);
            list.AppendList(30);
            list.AppendList(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
