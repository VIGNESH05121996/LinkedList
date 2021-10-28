using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList list = new SortedLinkedList();         
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.WriteLine();
            list.SortList();
            Console.ReadLine();
        }
    }
}
