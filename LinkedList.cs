using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedList
    {
        internal Node head;
        public int place;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("\n" + temp.data + " ");
                temp = temp.next;
            }
        }

        internal void AddFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;
            }
            this.head = node;
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        internal void AppendList(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }

        internal void InsertAt(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                Node temp = head;
                while (position != 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }

        internal void InsertBetween(int new_data)
        {
            Node new_node = new Node(new_data);
            Node pos = head;
            int len = 0;
            while (pos != null)
            {
                len++;
                pos = pos.next;
            }
            int count = ((len % 2 == 0) ? (len / 2) : (len + 1)) / 2;
            pos = head;
            while (count-- > 1)
            {
                pos = pos.next;
            }
            new_node.next = pos.next;
            pos.next = new_node;
        }

        internal void DeleteFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("The List Is Empty");
            }
            Console.WriteLine("Deleted Node: " + this.head.data);
            this.head = this.head.next;
        }

        internal void DeleteLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("The list is empty");
            }
            if (this.head.next == null)
            {
                Console.WriteLine("Only 1 element in the list");
            }
            Node node = head;
            while (node.next.next != null)
            {
                node = node.next;
            }
            Console.Write("The deleted node is: " + node.next.data);
            node.next = null;
        }

        internal int SearchFirst(int value)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            Node temp = head;
            int position = 1;
            int count = 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Search Found at position: " + position);
                    count++;
                    break;
                }
                temp = temp.next;
                position++;
            }
            if (count == 0)
            {
                Console.WriteLine("There is no data that match the entered value in the list");
            }
            return position;
        }

        internal void InsertNewNode(int newValue, int replaceAfterValue)
        {
            this.place = SearchFirst(newValue);
            InsertAt(this.place + 1, replaceAfterValue);

        }

        internal void SearchAndDelete(int value)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    if (temp.next.data == value)
                    {
                        Console.WriteLine("Deleted the node: " + temp.next.data);
                        temp.next = temp.next.next;
                    }
                    temp = temp.next;
                }
            }

        }

        internal int SizeOf()
        {
            int count = 1;
            Node temp = this.head;
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }

    public class SortedLinkedList
    {
        internal Node head;

        internal void Add(int data)   
        {
            Node node = new Node(data);    
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        internal void Display()          
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void SortList()
        {
            Node current = head;
            Node index = null;
            int temp = 0;
            if(this.head == null)
            {
                Console.WriteLine("List Is Empty");
            }
            else
            {
                while(current != null)
                {
                    index = current.next;
                    while(index != null)
                    {
                        if(current.data > index.data)
                        {
                            temp = index.data;
                            index.data = current.data;
                            current.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
    }
}
