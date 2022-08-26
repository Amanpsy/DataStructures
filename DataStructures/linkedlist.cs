using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
     class linkedlist
    {

        internal node head;

        public void Add(int data)
        {
            node Node = new node(data);
            
                if (head == null)
            {
                head = Node;
            }
                else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = Node;
            }
            Console.WriteLine("{0} added into linked list", Node.data);

        }
        public void AddFirst(int data)
        {
            node Node = new node(data);
            Node.next = head;
            head = Node;
            Console.WriteLine("{0} added into linked list", Node.data);
        }

        public void Append(int data)
        {
            Add(data);
        }

        public node Insert(int data, int position)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");

            node Node = new node(data);
            if (position == 1)
            {
                Node.next = head;
                head = Node;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node.next = head.next;
                        head.next = Node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position is out of range");
            }
            return head;
        }

        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty please add nodes");
            }
            else
            {
                int removeitem = head.data;
                head = head.next;
                Console.WriteLine("\n{0}  element is sucessfully removed from Linked list.", removeitem);
            }
        }

        public void PopLast()
        {
            node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty please add nodes");
            }
            else
            {
                if (temp.next == null)
                {
                    int data = temp.data;
                    temp = null;
                    Console.WriteLine("{0} Node is removed sucessfully", data);
                }
                //second node not equal to null
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                int lastDeletedNode = temp.next.data;
                temp.next = null;
                Console.WriteLine("{0} node is removed sucessfully", lastDeletedNode);
            }
        }

        public void Search(int data)
        {
            node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty please add nodes");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine("\n{0} node is present in Linked list\n", temp.data);
                        //break;
                        return;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("\n{0} node is not present in Linked list\n", data);
            }
        }
        public void Display ()
        {
            Console.WriteLine("\nDisplaying Nodes\n");
            node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }

            }

        }
    
