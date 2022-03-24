using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            else
                Console.WriteLine("Linked List as follows");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if(Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public void AddNodeAtStart(int First)
        {
            Node node = new Node(First);
            if(Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void DeleteFirstNode()
        {
            if(this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("\nRemove from linkedlist " + temp.data);
        }
        public bool search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if(temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
    }
}
