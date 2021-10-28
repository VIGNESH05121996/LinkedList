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
            list.AppendList(70);
            list.Display();
            Console.WriteLine();
            list.InsertAt(2, 30);
            Console.WriteLine("30 Is Inserted Between 56 and 70");
            list.Display();
            Console.ReadLine();
        }
    }
}
