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
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next !=null)
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
            if(temp==null)
            {
                Console.WriteLine("Linked List is empty");
                return; 
            }
            while(temp !=null)
            {
                Console.WriteLine("\n"+temp.data + " ");
                temp = temp.next;
            }
        }

        internal void AddFirst(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
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
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }

        internal void InsertAt(int position,int data)
        {
            Node node = new Node(data);
            if(position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                Node temp = head;
                while(position != 2)
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
            while(pos != null)
            {
                len++;
                pos = pos.next;
            }
            int count = ((len % 2 == 0) ? (len / 2) : (len + 1)) / 2;
            pos = head;
            while(count-- > 1)
            {
                pos = pos.next;
            }
            new_node.next = pos.next;
            pos.next = new_node;
        }

        internal void DeleteFirst()
        {
            if(this.head == null)
            {
                Console.WriteLine("The List Is Empty");
            }
            Console.WriteLine("Deleted Node: " + this.head.data);
            this.head = this.head.next;
        }
    }
}
